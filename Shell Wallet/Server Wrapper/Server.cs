using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace RPCWrapper
{
    // C# RPC Server Wrapper by Take42
    // TODO : Shorten code
    // TODO : Add transaction hash functions
    // TODO : Add remaining functions
    // TODO : Finish network monitor
    /// <summary>
    /// RPC server wrapper that handles all wallet functions within its own thread
    /// </summary>
    public class Server
    {
        #region Variables
        #region Private and Internal
        /// <summary>
        /// Holds the wallet server process
        /// </summary>
        private static Process WalletProcess;

        /// <summary>
        /// Variables used to setup the local server connection
        /// </summary>
        private static String ServerPath, RPCPort, RPCPassword, HostAddress,
            HostPort, WalletPassword, InternalError, InternalHash;
        private static Boolean LocalServer, InternalAlive, InternalFailure, InternalTestnet;

        /// <summary>
        /// Lets the server know whether the daemon connection has been verified as running
        /// </summary>
        internal static Boolean DaemonVerified = false;
        #endregion
        #region Public
        /// <summary>
        /// Event handler that runs within the server thread when it successfully starts
        /// </summary>
        public static EventHandler OnStart;

        /// <summary>
        /// Event handler that runs within the server thread when it stops
        /// </summary>
        public static EventHandler OnStop;

        /// <summary>
        /// Event handler that runs within the server thread on each update tick, as defined by the RefreshRate variable
        /// </summary>
        public static EventHandler OnTick;

        /// <summary>
        /// Event handler that runs within the network thread when it successfully starts
        /// </summary>
        public static EventHandler OnNetworkStart;

        /// <summary>
        /// Event handler than runs within the network thread when it stops
        /// </summary>
        public static EventHandler OnNetworkStop;

        /// <summary>
        /// Event handler that runs within the network thread on each network tick, as defined by the NetworkRefreshRate variable
        /// </summary>
        public static EventHandler OnNetworkTick;

        /// <summary>
        /// Defines how often the wallet should check for updates from the server (in milliseconds)
        /// </summary>
        public static int RefreshRate = 1000;

        /// <summary>
        /// Defines how often the server should check for updates from the network (in milliseconds)
        /// </summary>
        public static int NetworkRefreshRate = 1000;

        /// <summary>
        /// Defines whether or not the server should connect as a testnet connection
        /// </summary>
        public static Boolean Testnet
        {
            get
            {
                return InternalTestnet;
            }
            set
            {
                if (value == true)
                    Console.WriteLine("Testnet mode ENABLED");
                else Console.WriteLine("Testnet mode DISABLED");
                InternalTestnet = value;
            }
        }

        /// <summary>
        /// Returns true if server is running and a wallet is open
        /// </summary>
        public static Boolean Alive
        {
            get
            {
                if (InternalAlive && WalletProcess != null && !WalletProcess.HasExited)
                    return true;
                else return false;
            }
        }

        /// <summary>
        /// Returns the last server error message, then clears it
        /// </summary>
        public static String Error
        {
            get
            {
                if (InternalError == null) InternalError = "";
                String s = InternalError;
                InternalError = "";
                return s;
            }
        }
        #endregion
        #endregion

        #region Internal Functions
        /// <summary>
        /// Throws string as error internally
        /// </summary>
        private static JObject ThrowError(String e)
        {
            JObject Err = new JObject();
            Err["message"] = e;
            Err["response"] = e;
            Err["error"] = e;
            return Err;
        }

        /// <summary>
        /// Ping a host and port to see if it is online
        /// </summary>
        /// <param name="Host">The address that is being pinged</param>
        /// <param name="Port">The port that is being pinged</param>
        /// <returns>Returns true is ping was successful</returns>
        private static Boolean Ping(String Host, int Port)
        {
            using (TcpClient tcpClient = new TcpClient())
                try
                {
                    tcpClient.Connect(Host, Port);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
        }

        /// <summary>
        /// Sends an RPC request to the server then returns result or error
        /// </summary>
        private static JObject SendRequest(String Method, JObject Params = null)
        {
            // Check if server is alive before sending
            if (!Alive)
            {
                InternalError = "Server is not running, could not send request";
                return ThrowError(InternalError);
            }

            // Create a POST request
            HttpWebRequest r = (HttpWebRequest)WebRequest.Create("http://127.0.0.1:" + RPCPort + "/json_rpc");
            r.ContentType = "application/json-rpc";
            r.Method = "POST";

            // Sign credentials
            r.Credentials = new NetworkCredential("", RPCPassword);

            // Create a JSON object
            JObject j = new JObject();

            // Add parameters
            if (Params != null) j["params"] = JObject.FromObject(Params);

            // Assign request variables
            j.Add(new JProperty("jsonrpc", "2.0"));
            j.Add(new JProperty("id", "0"));
            j.Add(new JProperty("password", RPCPassword));

            // Define request method
            j.Add(new JProperty("method", Method));

            // Serialize JObject into a string
            String s = JsonConvert.SerializeObject(j);

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
            catch (WebException e)
            {
                InternalError = "Error sending request to server: " + e.Message;
                return ThrowError(InternalError);
            }
        }

        /// <summary>
        /// Sends a request to the daemon server
        /// </summary>
        private static JObject SendDaemonRequest(String Method, JObject Params = null, String Request = "")
        {
            // Check if daemon is verified
            if (!DaemonVerified) return ThrowError("Daemon not connected");

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
                String s = JsonConvert.SerializeObject(j);

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
                    InternalError = "Error sending request to server: " + e.Message;
                    return ThrowError(InternalError);
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
                    InternalError = "Error sending request to server: " + e.Message;
                    return ThrowError(InternalError);
                }
            }
        }
        #endregion

        #region Server Functions
        /// <summary>
        /// Verifies and connects to a daemon independantly from the local RPC server
        /// </summary>
        /// <param name="Local">Whether or not the daemon is running locally (true) or through a node (false)</param>
        /// <param name="NodeHost">The address of the remote daemon node, set to null to ignore</param>
        /// <param name="NodePort">The port in which the server should try to connect to the daemon</param>
        /// <returns>Returns true if successful</returns>
        public static Boolean StartNetwork(Boolean Local = true, String NodeHost = "daemon.turtle.link", String NodePort = "11898")
        {
            // Set variables
            LocalServer = Local;
            if (!LocalServer) HostAddress = NodeHost;
            else HostAddress = "127.0.0.1";
            HostPort = NodePort;

            // Check if server is valid
            Console.WriteLine("Attempting to connect to daemon at {0}:{1}", HostAddress, HostPort);
            if (Ping(HostAddress, Convert.ToInt32(HostPort)))
            {
                // Set internal daemon connection
                Console.WriteLine("Daemon connection successful");
                DaemonVerified = true;

                // Begin new thread for updates
                Thread s = new Thread(delegate ()
                {
                    // Invoke start event
                    OnNetworkStart.Invoke(new Server(), null);

                    while (DaemonVerified)
                    {
                        // Update network
                        Network.Update();

                        // Invoke update event
                        OnNetworkTick.Invoke(new Server(), null);

                        // Sleep for the desired refresh rate
                        Thread.Sleep(NetworkRefreshRate);
                    }

                    // Invoke stop event
                    OnNetworkStop.Invoke(new Server(), null);
                })
                {
                    Name = "Network Thread"
                };
                s.Start();
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
        public static void CloseNetwork()
        {
            if (!Alive)
            {
                DaemonVerified = false;
                Network.Reset();
            }
        }

        /// <summary>
        /// Starts the RPC server thread and opens a wallet through it
        /// </summary>
        /// <param name="Path">Local system path to the walletd.exe application</param>
        /// <param name="WalletPath">Local system path to the wallet being opened</param>
        /// <param name="Password">The password for the wallet being opened</param>
        /// <param name="ServerPassword">The password to open the local RPC server with (use Server.Hash to generate a unique password hash)</param>
        /// <param name="ServerPort">The port to bind the local RPC server to</param>
        /// <param name="Local">Whether or not the daemon is running locally (true) or through a node (false)</param>
        /// <param name="NodeHost">The address of the remote daemon node, set to null to ignore</param>
        /// <param name="NodePort">The port in which the server should try to connect to the daemon</param>
        public static Boolean OpenWallet(String Path, String WalletPath, String Password, String ServerPassword = "", String ServerPort = "11911",
            Boolean Local = false, String NodeHost = "daemon.turtle.link", String NodePort = "11898")
        {
            // Check if server is already alive
            if (Alive)
            {
                InternalError = "Server already running!";
                return false;
            }

            // Assign local variables
            ServerPath = Path;
            Wallet.Password = Password;
            WalletPassword = Password;
            RPCPassword = ServerPassword;
            RPCPort = ServerPort;
            LocalServer = Local;
            if (!LocalServer) HostAddress = NodeHost;
            else HostAddress = "127.0.0.1";
            HostPort = NodePort;

            // First check if RPC server port is available
            if (Ping("127.0.0.1", Convert.ToInt32(RPCPort)))
            {
                InternalError = "Selected RPC server port is not available";
                return false;
            }

            // Second check if daemon is running
            if (!StartNetwork(LocalServer, HostAddress, HostPort))
            {
                InternalError = "Could not connect to daemon";
                return false;
            }

            // Set up a fail check

            // Create a thread to run the server in
            Thread s = new Thread(delegate ()
            {
                // Create a process for the server to run on
                using (WalletProcess = new Process())
                {

                    // Setup process start info
                    WalletProcess.StartInfo.FileName = ServerPath;
                    WalletProcess.StartInfo.UseShellExecute = false;
                    WalletProcess.StartInfo.RedirectStandardOutput = true;
                    WalletProcess.StartInfo.RedirectStandardInput = true;
                    WalletProcess.StartInfo.RedirectStandardError = true;

                    // Don't show console
                    WalletProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    WalletProcess.StartInfo.CreateNoWindow = true;

                    // Add flags according to supplied arguments
                    if (LocalServer) WalletProcess.StartInfo.Arguments = "--local";
                    else WalletProcess.StartInfo.Arguments = "--daemon-address " + HostAddress + " --daemon-port " + HostPort;
                    if (RPCPassword != "") WalletProcess.StartInfo.Arguments += " --rpc-password " + RPCPassword;
                    else WalletProcess.StartInfo.Arguments += " --rpc-legacy-security";
                    if (Testnet) WalletProcess.StartInfo.Arguments += " --testnet";
                    WalletProcess.StartInfo.Arguments += " --bind-port " + RPCPort;
                    WalletProcess.StartInfo.Arguments += " --log-level 0 --allow-local-ip";
                    WalletProcess.StartInfo.Arguments += " -w \"" + Wallet.Path + "\"";
                    if (WalletPassword != "")
                    {
                        WalletProcess.StartInfo.Arguments += " -p " + WalletPassword;
                        WalletPassword = "";
                    }

                    // Begin the process
                    Console.WriteLine("Attempting to bind local RPC server to port {0}", ServerPort);
                    InternalAlive = WalletProcess.Start();

                    // Begin listening for data
                    WalletProcess.BeginOutputReadLine();
                    WalletProcess.BeginErrorReadLine();

                    // If the server failed to start
                    if (!InternalAlive)
                    {
                        Console.WriteLine("RPC server could not be bound to selected port");
                        InternalError = "Could not start server process, check system credentials";
                        WalletProcess = null;
                        InternalFailure = true;
                        return;
                    }
                    else Console.WriteLine("RPC server successfully binded to port");

                    // Trigger server start event
                    OnStart.Invoke(new Server(), EventArgs.Empty);

                    // Main loop
                    while (Alive)
                    {
                        // Check if process as ended
                        if (WalletProcess.HasExited) break;

                        // Update wallet
                        Wallet.Update();

                        // Update network
                        Network.Update();

                        // Trigger tick event
                        OnTick.Invoke(new Server(), EventArgs.Empty);

                        // Sleep for the desired refresh rate
                        Thread.Sleep(RefreshRate);
                    }

                    // Force kill wallet process
                    if (!WalletProcess.HasExited) WalletProcess.Kill();

                    // Trigger stop event
                    OnStop.Invoke(new Server(), EventArgs.Empty);

                    // Reset wallet data
                    Wallet.Reset();
                }
            })
            {
                Name = "Server Thread"
            };
            s.Start();

            if (InternalFailure == true)
            {
                InternalFailure = false;
                return false;
            }
            else return true;
        }

        /// <summary>
        /// Creates a new wallet container file
        /// </summary>
        /// <param name="Path">Local system path to the walletd.exe application</param>
        /// <param name="WalletPath">Local system path to the wallet being created (cannot already exist)</param>
        /// <param name="Password">The password for the wallet being created</param>
        /// <returns>Returns true if successful</returns>
        public static Boolean CreateWallet(String Path, String WalletPath, String Password)
        {
            // Assign local variables
            ServerPath = Path;
            Wallet.Path = WalletPath;
            if (Password.Length > 0) Wallet.Password = Password;
            WalletPassword = Password;

            // Check if file already exists
            if (File.Exists(WalletPath)) return false;

            // Create a process object to hold server instance
            Process p = new Process();
            p.StartInfo.FileName = ServerPath;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.OutputDataReceived += (s, e) => Console.WriteLine(e.Data);
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo.CreateNoWindow = true;

            // Add flags according to supplied arguments
            p.StartInfo.Arguments = "--log-level 0 -g";
            p.StartInfo.Arguments += " -w \"" + Wallet.Path + "\"";
            if (WalletPassword != "")
            {
                p.StartInfo.Arguments += " -p " + WalletPassword;
                WalletPassword = "";
            }
            //Console.WriteLine(p.StartInfo.Arguments);

            // Run server
            p.Start();
            p.WaitForExit();

            // Check if successful
            if (File.Exists(WalletPath)) return true;
            else return false;
        }

        /// <summary>
        /// Imports keys into a new wallet container file
        /// </summary>
        /// <param name="Path">Local system path to the walletd.exe application</param>
        /// <param name="WalletPath">Local system path to the wallet being created (cannot already exist)</param>
        /// <param name="Password">The password for the wallet being created</param>
        /// <returns>Returns true if successful</returns>
        public static Boolean ImportWallet(String Path, String WalletPath, String Password, String ViewKey, String SpendKey)
        {
            // Assign local variables
            ServerPath = Path;
            Wallet.Path = WalletPath;
            if (Password.Length > 0) Wallet.Password = Password;
            WalletPassword = Password;

            // Check if file already exists
            if (File.Exists(WalletPath)) return false;

            // Create a process object to hold server instance
            Process p = new Process();
            p.StartInfo.FileName = ServerPath;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.OutputDataReceived += (s, e) => Console.WriteLine(e.Data);
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo.CreateNoWindow = true;

            // Add flags according to supplied arguments
            p.StartInfo.Arguments = "--log-level 0 -g";
            p.StartInfo.Arguments += " -w \"" + Wallet.Path +"\"";
            if (WalletPassword != "")
            {
                p.StartInfo.Arguments += " -p " + WalletPassword;
                WalletPassword = "";
            }
            p.StartInfo.Arguments += " --view-key " + ViewKey;
            p.StartInfo.Arguments += " --spend-key " + SpendKey;
            //Console.WriteLine(p.StartInfo.Arguments);

            // Run server
            p.Start();
            p.WaitForExit();

            // Check if successful
            if (File.Exists(WalletPath)) return true;
            else return false;
        }

        /// <summary>
        /// Checks to see if a password is correct by attempting to get an address from the wallet container
        /// </summary>
        /// <param name="Path">Local system path to the walletd.exe application</param>
        /// <param name="WalletPath">Local system path to the wallet being opened</param>
        /// <param name="Password">The password for the wallet being opened</param>
        /// <returns>Returns true if password is correct</returns>
        public static Boolean CheckPassword(String Path, String WalletPath, String Password)
        {
            // Assign local variables
            ServerPath = Path;
            Wallet.Path = WalletPath;
            if (Password.Length > 0) Wallet.Password = Password;
            WalletPassword = Password;

            // Check if file exists
            if (!File.Exists(WalletPath)) return false;

            // Create a process object to hold server instance
            Process p = new Process();
            p.StartInfo.FileName = ServerPath;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            String output = "";
            p.OutputDataReceived += (s, e) => output += e.Data;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo.CreateNoWindow = true;

            // Add flags according to supplied arguments
            p.StartInfo.Arguments = "--log-level 1 --rpc-legacy-security";
            p.StartInfo.Arguments += " --address";
            p.StartInfo.Arguments += " -w \"" + Wallet.Path + "\"";
            if (WalletPassword != "")
            {
                p.StartInfo.Arguments += " -p " + WalletPassword;
                WalletPassword = "";
            }
            //Console.WriteLine(p.StartInfo.Arguments);

            // Run server
            p.Start();
            p.WaitForExit();

            // Get result
            String Output = p.StandardOutput.ReadToEnd();

            // Check if successful
            if (!Output.ToLower().Contains("password")) return true;
            else return false;
        }

        /// <summary>
        /// Stops both server and network connections
        /// </summary>
        public static void Stop()
        {
            if (Alive)
            {
                Wallet.Save();
                OnStop.Invoke(new Server(), null);
            }
            if (DaemonVerified)
            {
                OnNetworkStop.Invoke(new Server(), null);
            }
            Wallet.Reset();
            Network.Reset();
            InternalAlive = false;
            DaemonVerified = false;
        }

        /// <summary>
        /// Stops both server and network connections
        /// </summary>
        public static void Exit()
        {
            Stop();
        }
        #endregion

        #region Wallet Functions
        ///<summary>
        ///Retrieves the wallet's view key
        ///Returns viewSecretKey
        ///</summary>
        public static JObject GetViewKey()
        {
            // Send request to server
            JObject result = SendRequest("getViewKey");

            // Output response
            if (result["error"] == null) return (JObject)result["result"];
            else return ThrowError(InternalError);
        }

        ///<summary>
        ///Retrieves the wallet's spend keys
        ///Returns spendSecretKey, spendpublicKey
        ///</summary>
        public static JObject GetSpendKeys(String Address)
        {
            // Send request to server
            JObject Params = new JObject();
            Params["address"] = Address;
            JObject result = SendRequest("getSpendKeys", Params);

            // Output response
            if (result["error"] == null) return (JObject)result["result"];
            else return ThrowError(InternalError);
        }

        ///<summary>
        ///Re-syncs the wallet manually
        ///Does not return any variables
        ///</summary>
        public static JObject Reset()
        {
            SendRequest("reset");
            return new JObject();
        }

        ///<summary>
        ///Saves the wallet manually
        ///Does not return any variables
        ///</summary>
        public static JObject Save()
        {
            SendRequest("save");
            return new JObject();
        }

        ///<summary>
        ///Retrieves information about the RPC wallet state
        ///Returns blockCount, knownBlockCount, lastBlockHash, peerCount
        ///</summary>
        public static JObject GetStatus()
        {
            // Send request to server
            JObject result = SendRequest("getStatus");

            // Output response
            if (result["error"] == null) return (JObject)result["result"];
            else return ThrowError(InternalError);
        }

        ///<summary>
        ///Retrieves all public addresses associated with the wallet
        ///Returns all wallet addresses
        ///</summary>
        public static JObject GetAddresses()
        {
            // Send request to server
            JObject result = SendRequest("getAddresses");

            // Output response
            if (result["error"] == null) return (JObject)result["result"];
            else return ThrowError(InternalError);
        }

        ///<summary>
        ///Creates a new address in your wallet
        ///Returns new address
        ///</summary>
        public static JObject CreateAddress()
        {
            // Send request to server
            JObject result = SendRequest("createAddress");

            // Output response
            if (result["error"] == null) return (JObject)result["result"];
            else return ThrowError(InternalError);
        }

        ///<summary>
        ///Deletes an address from your wallet
        ///Does not return any variables
        ///</summary>
        public static JObject DeleteAddress(String Address)
        {
            // Send request to server
            JObject Params = new JObject();
            Params["address"] = Address;
            SendRequest("deleteAddress", Params);
            return new JObject();
        }

        ///<summary>
        ///Retrieves wallet balance
        ///Returns balance of specified address or all addresses if blank
        ///Returns availableBalance, lockedAmount
        ///</summary>
        public static JObject GetBalance(String Address = "")
        {
            // Send request to server
            JObject result;
            if (Address != "")
            {
                JObject Params = new JObject();
                Params["address"] = Address;
                result = SendRequest("getBalance", Params);
            }
            else result = SendRequest("getBalance");

            // Output response
            if (result["error"] == null) return (JObject)result["result"];
            else return ThrowError(InternalError);
        }

        ///<summary>
        ///Retrieves a list of block hashes within a specified range
        ///Returns every blockHash within chosen range
        ///</summary>
        public static JObject GetBlockHashes(int StartingHeight, int BlockCount)
        {
            // Send request to server
            JObject Params = new JObject();
            Params["startingHeight"] = StartingHeight;
            Params["blockCount"] = BlockCount;
            JObject result = SendRequest("getBlockHashes", Params);

            // Output response
            if (result["error"] == null) return (JObject)result["result"];
            else return ThrowError(InternalError);
        }

        ///<summary>
        ///Sends a transaction to one or more addresses with the option of a payment ID
        ///Returns transactionHash
        ///</summary>
        public static JObject SendTransaction(List<String> Addresses, List<Transfer> Transfers, double Fee, int Anonymity = 6, String Extra = "",
            String PaymentID = "", int UnlockTime = 0, String ChangeAddress = "", String Mixin = "")
        {
            // Send request to server
            JObject Params = new JObject();
            Params["anonymity"] = Anonymity;
            Params["fee"] = (int)(Fee * 100);
            if (UnlockTime != 0) Params["unlockTime"] = UnlockTime;
            if (PaymentID != "") Params["paymentId"] = PaymentID;
            if (Addresses.Count > 0) Params["addresses"] = JArray.FromObject(Addresses);
            Params["transfers"] = JArray.FromObject(Transfers);
            if (ChangeAddress != "") Params["changeAddress"] = ChangeAddress;
            if (Extra != "") Params["extra"] = Extra;
            if (Mixin != "") Params["mixin"] = Mixin;
            JObject result = SendRequest("sendTransaction", Params);

            // Output response
            if (result["error"] == null)
            {
                Console.WriteLine("Send transaction hash: {0}", result["result"]["hash"]);
                return (JObject)result["result"];
            }
            else
            {
                Console.WriteLine("Error sending transaction: {0}", result["error"]["message"]);
                result["error"] = result["error"]["message"];
                return (JObject)result;
            }
        }

        /// <summary>
        /// Returns information about specified transaction data
        /// </summary>
        /// <returns></returns>
        public static JObject GetTransaction(int BlockCount, List<String> Addresses, String BlockHash = "", int FirstBlockIndes = -1, String PaymentID = "")
        {
            // Send request to server
            JObject Params = new JObject();
            Params["blockCount"] = BlockCount;
            if (BlockHash != "") Params["blockHash"] = BlockHash;
            if (FirstBlockIndes >= 0) Params["firstBlockIndex"] = FirstBlockIndes;
            if (Addresses.Count > 0) Params["addresses"] = JArray.FromObject(Addresses);
            if (PaymentID != "") Params["paymentId"] = PaymentID;
            JObject result = SendRequest("getTransaction", Params);

            // Output response
            if (result["error"] == null) return (JObject)result["result"];
            else return ThrowError(InternalError);
        }
        #endregion

        #region Network Functions
        ///<summary>
        ///Retrieves the wallet's view key
        ///Returns viewSecretKey
        ///</summary>
        public static JObject GetNetworkInfo()
        {
            return SendDaemonRequest("getinfo");
        }

        /// <summary>
        /// Retrieves the last block header on the network
        /// </summary>
        /// <returns></returns>
        public static JObject GetLastBlockHeader()
        {
            // Send request to server
            JObject result = SendDaemonRequest("getlastblockheader", new JObject());

            // Output response
            if (result["error"] == null) return (JObject)result["result"];
            else return ThrowError(InternalError);
        }

        /// <summary>
        /// Gets information about a specific block
        /// </summary>
        public static JObject GetBlockInfo(String BlockHash)
        {
            // Send request to server
            String j = "{ \"jsonrpc\":\"2.0\", \"id\":\"0\", \"method\":\"f_block_json\", " +
                "\"params\":{\"hash\":\"" + BlockHash + "\"}}";
            JObject result = SendDaemonRequest("", null, j);

            // Output response
            if (result["error"] == null) return (JObject)result["result"];
            else return ThrowError(InternalError);
        }
        #endregion

        #region Security
        /// <summary>
        /// Generates a unique password hash upon first called instance
        /// </summary>
        /// <returns>Returns a unique hash string</returns>
        public static String Hash
        {
            get
            {
                if (InternalHash == "" || InternalHash == null)
                {
                    Regex r = new Regex("[^a-zA-Z0-9 -]");
                    byte[] p = Encoding.UTF8.GetBytes(Environment.CurrentDirectory);
                    byte[] k = new Rfc2898DeriveBytes(Environment.MachineName,
                        Encoding.ASCII.GetBytes(DateTime.Now.ToString("yyyyMMddHHmmssffff"))).GetBytes(256 / 8);
                    var s = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };
                    var e = s.CreateEncryptor(k, Encoding.ASCII.GetBytes("@1B2c3D4e5F6g7H8"));
                    byte[] c;
                    using (var memoryStream = new MemoryStream())
                    using (var cryptoStream = new CryptoStream(memoryStream, e, CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(p, 0, p.Length);
                        cryptoStream.FlushFinalBlock();
                        c = memoryStream.ToArray();
                    }
                    InternalHash = Convert.ToBase64String(c);
                }
                return InternalHash;
            }
        }

        /// <summary>
        /// Safely encrypts a string using the generated server hash
        /// </summary>
        /// <param name="Input">The string to encrypt</param>
        /// <returns>Returns a uniquely generated hash of the input string</returns>
        public static string SafeEncrypt(String Input)
        {
            HashAlgorithm algorithm = new SHA256Managed();
            byte[] b = Encoding.ASCII.GetBytes(Input);
            byte[] s = Encoding.ASCII.GetBytes(Hash);
            byte[] p = new byte[b.Length + s.Length];
            for (int i = 0; i < b.Length; i++)
                p[i] = b[i];
            for (int i = 0; i < s.Length; i++)
                p[b.Length + i] = s[i];
            return Convert.ToBase64String(algorithm.ComputeHash(p));
        }
        #endregion
    }
}