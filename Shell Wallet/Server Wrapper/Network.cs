using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using Newtonsoft.Json.Linq;

namespace RPCWrapper
{
    /// <summary>
    /// Utility class for holding static network variables
    /// </summary>
    public class Network
    {
        #region Private and Internal Variables
        private static String HostAddress;
        private static int HostPort;
        private static Boolean InternalAlive;
        private static JObject Status = new JObject(), LastBlockHeader = new JObject(), LastBlock = new JObject();
        private static Thread WorkerThread;
        #endregion

        #region Public Variables
        public static Boolean Alive
        {
            get
            {
                return InternalAlive;
            }
        }

        public static ThreadedBindingList<TransactionPool> TransactionPool = new ThreadedBindingList<TransactionPool>();
        public static ThreadedBindingList<RecentBlocks> RecentBlocks = new ThreadedBindingList<RecentBlocks>();
        #endregion

        #region Event Handlers
        /// <summary>
        /// Event handler that runs within the network thread when it successfully starts
        /// </summary>
        public static EventHandler OnStart;

        /// <summary>
        /// Event handler that runs within the network thread when it stops
        /// </summary>
        public static EventHandler OnStop;

        /// <summary>
        /// Event handler that runs within the network thread on each update tick, as defined by the NetworkRefreshRate variable
        /// </summary>
        public static EventHandler OnTick;
        #endregion

        #region Network Access Functions
        /// <summary>
        /// Gets the total network block height
        /// </summary>
        public static int TransactionPoolSize
        {
            get
            {
                if (Status != null && Status["tx_pool_size"] != null)
                    return (int)Status["tx_pool_size"];
                else return 0;
            }
        }

        /// <summary>
        /// Gets the total network block height
        /// </summary>
        public static int TransactionCount
        {
            get
            {
                if (Status != null && Status["tx_count"] != null)
                    return (int)Status["tx_count"];
                else return 0;
            }
        }

        /// <summary>
        /// Gets the total network block height
        /// </summary>
        public static int BlockHeight
        {
            get
            {
                if (Status != null && Status["height"] != null)
                    return (int)Status["height"];
                else return 0;
            }
        }

        /// <summary>
        /// Gets the total network hashrate
        /// </summary>
        public static String Hashrate
        {
            get
            {
                if (Difficulty != 0 && Target != 0)
                {
                    decimal h = Difficulty / Target;
                    if (h > 1000000)
                    {
                        decimal d = h / 1000000;
                        return Math.Round(d, 2).ToString() + " MH/s";
                    }
                    else if (h > 1000)
                    {
                        decimal d = h / 1000;
                        return Math.Round(d, 2).ToString() + " kH/s";
                    }
                    else return Math.Round(h, 2).ToString() + " H/s";
                }
                else return "0 H/s";
            }
        }

        /// <summary>
        /// Gets the total network difficulty
        /// </summary>
        public static int Difficulty
        {
            get
            {
                if (Status != null && Status["difficulty"] != null)
                    return (int)Status["difficulty"];
                else return 0;
            }
        }

        /// <summary>
        /// Gets the network block target
        /// </summary>
        public static int Target
        {
            get
            {
                if (Status != null && Status["target"] != null)
                    return (int)Status["target"];
                else return 30;
            }
        }

        /// <summary>
        /// Gets the current block reward
        /// </summary>
        public static double Reward
        {
            get
            {
                if (LastBlockHeader != null && LastBlockHeader["block_header"] != null)
                    return (double)LastBlockHeader["block_header"]["reward"] / Math.Pow(10, Server.CurrencyDecimals);
                else return 0;
            }
        }

        /// <summary>
        /// Gets the last block hash
        /// </summary>
        public static String LastBlockHash
        {
            get
            {
                if (LastBlockHeader != null && LastBlockHeader["block_header"] != null)
                    return (String)LastBlockHeader["block_header"]["hash"];
                else return "";
            }
        }

        /// <summary>
        /// Gets the current circulating supply
        /// </summary>
        public static double Supply
        {
            get
            {
                if (LastBlock != null && LastBlock["block"] != null)
                {
                    return (double)LastBlock["block"]["alreadyGeneratedCoins"] / Math.Pow(10, Server.CurrencyDecimals);
                }
                else return 0;
            }
        }
        #endregion

        #region Public Utilities
        /// <summary>
        /// Updates the network information
        /// </summary>
        internal static void Update()
        {
            if (Server.NetworkMonitor)
            {
                Status = GetNetworkInfo();
                LastBlockHeader = GetLastBlockHeader();
                LastBlock = GetBlockInfo(LastBlockHash);
            }
        }

        /// <summary>
        /// Resets all network variables
        /// </summary>
        public static void Reset()
        {
            HostAddress = "127.0.0.1";
            HostPort = 11911;
            Status = new JObject();
            LastBlockHeader = new JObject();
            LastBlock = new JObject();
        }

        /// <summary>
        /// Verifies and connects to a daemon independantly from the local RPC server
        /// </summary>
        /// <param name="Local">Whether or not the daemon is running locally (true) or through a node (false)</param>
        /// <param name="DaemonPath">The address of the remote daemon node, set to null to ignore</param>
        /// <param name="DaemonPort">The port in which the server should try to connect to the daemon</param>
        /// <returns>Returns true if successful</returns>
        public static Boolean Start(String DaemonPath = "daemon.turtle.link", int DaemonPort = 11898)
        {
            // Set variables
            HostAddress = DaemonPath;
            HostPort = DaemonPort;

            // Check if server is valid
            Console.WriteLine("Attempting to connect to daemon at {0}:{1}", HostAddress, HostPort);
            if (Server.Ping(HostAddress, Convert.ToInt32(HostPort)))
            {
                // Set internal daemon connection
                Console.WriteLine("Daemon connection successful");
                InternalAlive = true;

                // Begin new thread for updates
                WorkerThread = new Thread(delegate ()
                {
                    // Invoke start event
                    if (OnStart != null)
                        OnStart.Invoke(new Network(), null);

                    while (Alive)
                    {
                        // Update network
                        Update();

                        // Invoke update event
                        if (OnTick != null)
                            OnTick.Invoke(new Network(), null);

                        // Sleep for the desired refresh rate
                        try { Thread.Sleep(Server.NetworkRefreshRate); }
                        // Hacky but works to waking a thread
                        catch (Exception) { }
                    }

                    // Invoke stop event
                    if (OnStop != null)
                        OnStop.Invoke(new Network(), null);
                })
                {
                    Name = "Network Thread"
                };
                WorkerThread.Start();
                return true;
            }
            else
            {
                Console.WriteLine("Daemon connection failed");
                return false;
            }
        }

        /// <summary>
        /// Closes the daemon connection (only if a wallet is not opened)
        /// </summary>
        public static void Stop()
        {
            InternalAlive = false;
            // Hacky wake up call
            if (WorkerThread != null && WorkerThread.IsAlive)
                WorkerThread.Interrupt();
            Reset();
        }
        #endregion

        #region Internal Utilities
        /// <summary>
        /// Sends a request to the daemon server
        /// </summary>
        internal static JObject SendRequest(String Method, JObject Params = null, String Request = "")
        {
            // Check if daemon is verified
            if (!Alive) return Server.ThrowError("Daemon not connected");

            // Not an RPC request
            if (Method != "" && Params == null)
            {
                // Send request to server
                using (WebClient client = new WebClient())
                {
                    String result = client.DownloadString("http://" + HostAddress + ":" + HostPort + "/" + Method);
                    return JObject.Parse(result);
                }
            }

            // RPC request
            else if (Method != "" && Params != null)
            {
                // Create a POST request
                HttpWebRequest r = (HttpWebRequest)WebRequest.Create("http://" + HostAddress + ":" + HostPort + "/json_rpc");
                r.ContentType = "application/json-rpc";
                r.Method = "POST";

                // Create a JSON object
                JObject j = new JObject();

                // Add parameters
                if (Params.Count > 0) j["params"] = JObject.FromObject(Params);

                // Assign request variables
                j.Add(new JProperty("jsonrpc", "2.0"));
                j.Add(new JProperty("id", "0"));

                // Define request method
                j.Add(new JProperty("method", Method));

                // Serialize JObject into a string
                String s = j.ToString();

                try
                {
                    // Send bytes to server
                    byte[] byteArray = Encoding.UTF8.GetBytes(s);
                    r.ContentLength = byteArray.Length;
                    Stream d = r.GetRequestStream();
                    d.Write(byteArray, 0, byteArray.Length);
                    d.Close();

                    // Receive reply from server
                    WebResponse webResponse = r.GetResponse();
                    StreamReader reader = new StreamReader(webResponse.GetResponseStream(), Encoding.UTF8);

                    // Get response
                    JObject response = JObject.Parse(reader.ReadToEnd());

                    // Dispose of pieces
                    reader.Dispose();
                    webResponse.Dispose();

                    // Return the server response
                    return response;
                }
                catch (Exception e)
                {
                    Server.InternalError = "Error sending request to server: " + e.Message;
                    return Server.ThrowError(Server.InternalError);
                }
            }

            // RPC request but hard data is given to send
            else
            {
                // Create a POST request
                HttpWebRequest r = (HttpWebRequest)WebRequest.Create("http://" + HostAddress + ":" + HostPort + "/json_rpc");
                r.ContentType = "application/json-rpc";
                r.Method = "POST";

                try
                {
                    // Send bytes to server
                    byte[] byteArray = Encoding.UTF8.GetBytes(Request);
                    r.ContentLength = byteArray.Length;
                    Stream d = r.GetRequestStream();
                    d.Write(byteArray, 0, byteArray.Length);
                    d.Close();

                    // Receive reply from server
                    WebResponse webResponse = r.GetResponse();
                    StreamReader reader = new StreamReader(webResponse.GetResponseStream(), Encoding.UTF8);

                    // Get response
                    JObject response = JObject.Parse(reader.ReadToEnd());

                    // DEBUG
                    //Console.WriteLine(response.ToString());

                    // Dispose of pieces
                    reader.Dispose();
                    webResponse.Dispose();

                    // Return the server response
                    return response;
                }
                catch (Exception e)
                {
                    Server.InternalError = "Error sending request to server: " + e.Message;
                    return Server.ThrowError(Server.InternalError);
                }
            }
        }
        #endregion

        #region Server Queries
        ///<summary>
        ///Retrieves the wallet's view key
        ///Returns viewSecretKey
        ///</summary>
        public static JObject GetNetworkInfo()
        {
            return SendRequest("getinfo");
        }

        /// <summary>
        /// Retrieves the last block header on the network
        /// </summary>
        /// <returns></returns>
        public static JObject GetLastBlockHeader()
        {
            // Send request to server
            JObject result = SendRequest("getlastblockheader", new JObject());

            // Output response
            if (result["error"] == null) return (JObject)result["result"];
            else return Server.ThrowError(Server.InternalError);
        }

        /// <summary>
        /// Gets information about a specific block
        /// </summary>
        public static JObject GetBlockInfo(String BlockHash)
        {
            // Send request to server
            String j = "{ \"jsonrpc\":\"2.0\", \"id\":\"0\", \"method\":\"f_block_json\", " +
                "\"params\":{\"hash\":\"" + BlockHash + "\"}}";
            JObject result = SendRequest("", null, j);

            // Output response
            if (result["error"] == null) return (JObject)result["result"];
            else return Server.ThrowError(Server.InternalError);
        }
        #endregion
    }

    /// <summary>
    /// Class for keeping track of recent blocks on the network
    /// </summary>
    public class RecentBlocks
    {
        #region Variables
        public String Height { get; set; }
        public String Date { get; set; }
        public String Size { get; set; }
        public String Hash { get; set; }
        public String Difficulty { get; set; }
        public String Transactions { get; set; }
        #endregion

        #region Init
        public RecentBlocks(String Height, String Date, String Size, String Hash, String Difficulty, String Transactions)
        {
            this.Height = Height;
            this.Date = Date;
            this.Size = Size;
            this.Hash = Hash;
            this.Difficulty = Difficulty;
            this.Transactions = Transactions;
        }
        public RecentBlocks() { }
        #endregion
    }

    /// <summary>
    /// Class for keeping track of the network's transaction pool
    /// </summary>
    public class TransactionPool
    {
        #region Variables
        public String Amount { get; set; }
        public String Fee { get; set; }
        public String Size { get; set; }
        public String Hash { get; set; }
        #endregion

        #region Init
        public TransactionPool(String Amount, String Fee, String Size, String Hash)
        {
            this.Amount = Amount;
            this.Fee = Fee;
            this.Size = Size;
            this.Hash = Hash;
        }
        public TransactionPool() { }
        #endregion
    }
}
