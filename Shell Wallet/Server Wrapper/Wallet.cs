using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using Newtonsoft.Json.Linq;

namespace RPCWrapper
{
    /// <summary>
    /// Utility class for holding static wallet variables
    /// </summary>
    public class Wallet
    {
        #region Private and Internal Variables
        private static String ServerPath, RPCPort, RPCPassword, HostAddress, HostPort, WalletPassword;
        private static Boolean LocalServer, InternalAlive, InternalFailure;
        private static Process WalletProcess;
        private static JObject Balances = new JObject(), SelectedBalances = new JObject(), Status = new JObject();
        private static String InternalPassword, InternalSelectedAddress;
        private static int LastBlockCount = 0;
        private static Boolean UpdatingTransactions = false;

        internal static String Path = "";
        #endregion

        #region Public Variables
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
        /// Gets a list of all addresses associated with the wallet
        /// </summary>
        public static List<String> Addresses = new List<string>();

        /// <summary>
        /// Returns the selected address or the first address in the wallet
        /// </summary>
        public static String SelectedAddress
        {
            get
            {
                if (InternalSelectedAddress == "" || InternalSelectedAddress == null)
                    InternalSelectedAddress = Wallet.Address;
                return InternalSelectedAddress;
            }
            set
            {
                InternalSelectedAddress = value;
            }
        }

        /// <summary>
        /// Returns the private view key
        /// </summary>
        public static String ViewKey
        {
            get
            {
                if (SelectedAddress != "")
                {
                    JObject result = GetViewKey();
                    if (result["viewSecretKey"] != null)
                        return (String)result["viewSecretKey"];
                    else return "";
                }
                else return "";
            }
        }

        /// <summary>
        /// Returns the public spend key for the selected address
        /// </summary>
        public static String PublicSpendKey
        {
            get
            {
                if (SelectedAddress != "")
                {
                    JObject result = GetSpendKeys(SelectedAddress);
                    if (result["spendPublicKey"] != null)
                        return (String)result["spendPublicKey"];
                    else return "";
                }
                else return "";
            }
        }

        /// <summary>
        /// Returns the private spend key for the selected address
        /// </summary>
        public static String PrivateSpendKey
        {
            get
            {
                if (SelectedAddress != "")
                {
                    JObject result = GetSpendKeys(SelectedAddress);
                    if (result["spendSecretKey"] != null)
                        return (String)result["spendSecretKey"];
                    else return "";
                }
                else return "";
            }
        }

        /// <summary>
        /// Returns encrypted wallet password
        /// </summary>
        public static String Password
        {
            get
            {
                if (InternalPassword == null) InternalPassword = "";
                return InternalPassword;
            }
            set
            {
                InternalPassword = Server.SafeEncrypt(value);
            }
        }

        /// <summary>
        /// Returns the file name of the wallet, without extensions
        /// </summary>
        public static String FileName
        {
            get
            {
                return System.IO.Path.GetFileNameWithoutExtension(Path);
            }
        }
        
        /// <summary>
        /// Returns total balance in correct decimal format
        /// </summary>
        /// <returns></returns>
        public static String Balance
        {
            get
            {
                if (Balances != null && Balances["availableBalance"] != null)
                {
                    String s = (String)Balances["availableBalance"];
                    if (s.Length < Server.CurrencyDecimals + 1) return "0." + s;
                    else return s.Insert(s.Length - Server.CurrencyDecimals, ".");
                }
                else return "0";
            }
        }

        /// <summary>
        /// Returns total locked balance in correct decimal format
        /// </summary>
        public static String LockedBalance
        {
            get
            {
                if (Balances != null && Balances["lockedAmount"] != null)
                {
                    String s = (String)Balances["lockedAmount"];
                    if (s.Length < Server.CurrencyDecimals + 1) return "0." + s;
                    else return s.Insert(s.Length - Server.CurrencyDecimals, ".");
                }
                else return "0";
            }
        }

        /// <summary>
        /// Returns selected addess balance in correct decimal format
        /// </summary>
        /// <returns></returns>
        public static String SelectedBalance
        {
            get
            {
                if (SelectedBalances != null && SelectedBalances["availableBalance"] != null)
                {
                    String s = (String)SelectedBalances["availableBalance"];
                    if (s == null) return "0";
                    if (s.Length < Server.CurrencyDecimals + 1) return "0." + s;
                    else return s.Insert(s.Length - Server.CurrencyDecimals, ".");
                }
                else return "0";
            }
        }

        /// <summary>
        /// Returns selected address locked balance in correct decimal format
        /// </summary>
        public static String SelectedLockedBalance
        {
            get
            {
                if (SelectedBalances != null && SelectedBalances["lockedAmount"] != null)
                {
                    String s = (String)SelectedBalances["lockedAmount"];
                    if (s == null) return "0";
                    if (s.Length < Server.CurrencyDecimals + 1) return "0." + s;
                    else return s.Insert(s.Length - Server.CurrencyDecimals, ".");
                }
                else return "0";
            }
        }

        /// <summary>
        /// Returns the first address in wallet
        /// </summary>
        public static String Address
        {
            get
            {
                if (Addresses != null && Addresses.Count > 0)
                    return Addresses[0];
                else return "";
            }
        }

        /// <summary>
        /// Returns current block count
        /// </summary>
        public static int BlockCount
        {
            get
            {
                if (Status != null && Status["blockCount"] != null)
                {
                    if ((int)Status["blockCount"] < LastBlockCount)
                        LastBlockCount = 0;
                    return (int)Status["blockCount"];
                }
                return 0;
            }
        }

        /// <summary>
        /// Returns known/destination block count
        /// </summary>
        public static int KnownBlockCount
        {
            get
            {
                if (Status != null && Status["knownBlockCount"] != null)
                    return (int)Status["knownBlockCount"];
                return 0;
            }
        }

        /// <summary>
        /// Returns last block hash
        /// </summary>
        public static String LastBlockHash
        {
            get
            {
                if (Status != null && Status["lastBlockHash"] != null)
                    return (String)Status["lastBlockHash"];
                return "0";
            }
        }

        /// <summary>
        /// Returns connected peer count
        /// </summary>
        public static String PeerCount
        {
            get
            {
                if (Status != null && Status["peerCount"] != null)
                    return (String)Status["peerCount"];
                return "0";
            }
        }

        /// <summary>
        /// Transaction history
        /// </summary>
        public static ThreadedBindingList<Transaction> Transactions = new ThreadedBindingList<Transaction>();
        #endregion

        #region Event Handlers
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
        #endregion

        #region Public Utilities
        /// <summary>
        /// Resets all wallet variables
        /// </summary>
        public static void Reset()
        {
            Path = "";
            SelectedAddress = "";
            LastBlockCount = 0;
        }

        /// <summary>
        /// Saves and closes the wallet
        /// </summary>
        public static void Save()
        {
            SendRequest("save");
            Console.WriteLine("Saving wallet");
        }

        /// <summary>
        /// Creates a new address within the wallet
        /// </summary>
        public static void CreateAddress()
        {
            JObject result = CreateNewAddress();
            if (result["address"] != null) Update();
        }

        /// <summary>
        /// Deletes the selected address
        /// </summary>
        public static void DeleteSelectedAddress()
        {
            if (SelectedAddress != "" && Addresses.Count > 0)
            {
                JObject r = DeleteAddress(SelectedAddress);
                Update();
            }
        }

        /// <summary>
        /// Resyncs the wallet from zero
        /// </summary>
        public static void Resync()
        {
            SendRequest("reset");
            Console.WriteLine("Resyncing wallet");
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
        public static Boolean Open(String Path, String WalletPath, String Password, String ServerPassword = "", String ServerPort = "11911",
            Boolean Local = false, String NodeHost = "daemon.turtle.link", String NodePort = "11898")
        {
            // Check if server is already alive
            if (Alive)
            {
                Server.InternalError = "Server already running!";
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
            if (Server.Ping("127.0.0.1", Convert.ToInt32(RPCPort)))
            {
                Server.InternalError = "Selected RPC server port is not available";
                return false;
            }

            // Second check if daemon is running
            if (!Network.Start(LocalServer, HostAddress, HostPort))
            {
                Server.InternalError = "Could not connect to daemon";
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
                    if (Server.Testnet) WalletProcess.StartInfo.Arguments += " --testnet";
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
                    if (!Alive)
                    {
                        Console.WriteLine("RPC server could not be bound to selected port");
                        Server.InternalError = "Could not start server process, check system credentials";
                        WalletProcess = null;
                        InternalFailure = true;
                        return;
                    }
                    else Console.WriteLine("RPC server successfully binded to port");

                    // Trigger server start event
                    if (OnStart != null)
                        OnStart.Invoke(new Wallet(), EventArgs.Empty);
                    

                    // Main loop
                    while (Alive)
                    {
                        // Check if process as ended
                        if (WalletProcess.HasExited) break;

                        // Update wallet
                        Update();

                        // Update network
                        Network.Update();

                        // Trigger tick event
                        if (OnTick != null)
                            OnTick.Invoke(new Wallet(), EventArgs.Empty);

                        // Sleep for the desired refresh rate
                        Thread.Sleep(Server.RefreshRate);
                    }

                    // Force kill wallet process
                    if (!WalletProcess.HasExited) WalletProcess.Kill();

                    // Trigger stop event
                    if (OnStop != null)
                        OnStop.Invoke(new Wallet(), EventArgs.Empty);

                    // Reset wallet data
                    Reset();
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
        public static Boolean Create(String Path, String WalletPath, String Password)
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
        public static Boolean Import(String Path, String WalletPath, String Password, String ViewKey, String SpendKey)
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

            Console.WriteLine("Checking wallet password");

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
        /// Sends a transaction
        /// </summary>
        public static JObject Send(List<String> Addresses, List<Transfer> Transfers, double Fee, int Anonymity = 6, String Extra = "",
            String PaymentID = "", int UnlockTime = 0, String ChangeAddress = "", String Mixin = "")
        {
            return SendTransaction(Addresses, Transfers, Fee, Anonymity, Extra, PaymentID, UnlockTime, ChangeAddress, Mixin);
        }

        /// <summary>
        /// Saves and stops the wallet thread and the network thread
        /// </summary>
        public static void Stop()
        {
            Save();
            InternalAlive = false;
            Reset();
        }
        #endregion

        #region Internal Utilities
        /// <summary>
        /// Sends an RPC request to the server then returns result or error
        /// </summary>
        private static JObject SendRequest(String Method, JObject Params = null)
        {
            // Check if server is alive before sending
            if (!Alive)
            {
                Server.InternalError = "Server is not running, could not send request";
                return Server.ThrowError(Server.InternalError);
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
            catch (WebException e)
            {
                Server.InternalError = "Error sending request to server: " + e.Message;
                return Server.ThrowError(Server.InternalError);
            }
        }

        /// <summary>
        /// Updates the wallet information
        /// </summary>
        internal static void Update()
        {
            // Update status
            Status = GetStatus();

            // Update Addresses
            JObject a = GetAddresses();
            if (a["error"] == null)
            {
                if (a["addresses"] != null && a["addresses"].HasValues)
                    Addresses = a["addresses"].ToObject<List<String>>();
                else Addresses = new List<string>();
            }
            else Addresses = new List<string>();

            // Update selected address
            if (SelectedAddress == "" && Addresses.Count > 0)
            {
                SelectedAddress = Addresses[0];
                Console.WriteLine("Selected address changed to {0}", SelectedAddress);
            }

            // Update overall balance
            Balances = GetBalance();

            // Update balances for selected address
            SelectedBalances = GetBalance(SelectedAddress);

            // Check if block height has changed
            if (BlockCount > LastBlockCount && !UpdatingTransactions)
            {
                UpdatingTransactions = true;
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    Console.WriteLine("Updating transaction log from block {0} ({1} blocks)", LastBlockCount, BlockCount - LastBlockCount);
                    JObject T = GetTransactions(new List<string>(), BlockCount - LastBlockCount, LastBlockCount);
                    if (T["items"] != null && T["items"].HasValues)
                    {
                        JArray items = (JArray)T["items"];
                        for (int i = 0; i < items.Count; i++)
                        {
                            // Cycle through transactions
                            JArray transactions = (JArray)items[i]["transactions"];
                            for (int y = 0; y < transactions.Count; y++)
                            {
                                // Get transfers
                                JArray t = (JArray)transactions[y]["transfers"];
                                List<Transfer> transfers = new List<Transfer>();
                                for (int o = 0; o < t.Count; o++)
                                {
                                    Transfer f = new Transfer((String)t[o]["address"], (double)t[o]["amount"]);
                                    transfers.Add(f);
                                }

                                // Log transaction information
                                Transaction x = new Transaction((String)transactions[y]["blockIndex"],
                                    (String)transactions[y]["transactionHash"],
                                    (String)transactions[y]["state"], (int)transactions[y]["timestamp"],
                                    (int)transactions[y]["unlockTime"], (int)transactions[y]["amount"],
                                    (int)transactions[y]["fee"], (String)transactions[y]["extra"],
                                    (String)transactions[y]["paymentId"], transfers);

                                // Insert at top of list
                                Transactions.Insert(0, x);
                            }
                        }
                    }

                    // Reset last block count
                    LastBlockCount = BlockCount;

                    // Reset update check
                    UpdatingTransactions = false;
                }).Start();
            }
        }
        #endregion
        
        #region Server Queries
        ///<summary>
        ///Retrieves the wallet's view key
        ///Returns viewSecretKey
        ///</summary>
        private static JObject GetViewKey()
        {
            // Send request to server
            JObject result = SendRequest("getViewKey");

            // Output response
            if (result["error"] == null) return (JObject)result["result"];
            else return Server.ThrowError(Server.InternalError);
        }

        ///<summary>
        ///Retrieves the wallet's spend keys
        ///Returns spendSecretKey, spendpublicKey
        ///</summary>
        private static JObject GetSpendKeys(String Address)
        {
            // Send request to server
            JObject Params = new JObject();
            Params["address"] = Address;
            JObject result = SendRequest("getSpendKeys", Params);

            // Output response
            if (result["error"] == null) return (JObject)result["result"];
            else return Server.ThrowError(Server.InternalError);
        }

        ///<summary>
        ///Retrieves information about the RPC wallet state
        ///Returns blockCount, knownBlockCount, lastBlockHash, peerCount
        ///</summary>
        private static JObject GetStatus()
        {
            // Send request to server
            JObject result = SendRequest("getStatus");

            // Output response
            if (result["error"] == null) return (JObject)result["result"];
            else return Server.ThrowError(Server.InternalError);
        }

        ///<summary>
        ///Retrieves all public addresses associated with the wallet
        ///Returns all wallet addresses
        ///</summary>
        private static JObject GetAddresses()
        {
            // Send request to server
            JObject result = SendRequest("getAddresses");

            // Output response
            if (result["error"] == null) return (JObject)result["result"];
            else return Server.ThrowError(Server.InternalError);
        }

        ///<summary>
        ///Creates a new address in your wallet
        ///Returns new address
        ///</summary>
        private static JObject CreateNewAddress()
        {
            // Send request to server
            JObject result = SendRequest("createAddress");

            // Output response
            if (result["error"] == null) return (JObject)result["result"];
            else return Server.ThrowError(Server.InternalError);
        }

        ///<summary>
        ///Deletes an address from your wallet
        ///Does not return any variables
        ///</summary>
        private static JObject DeleteAddress(String Address)
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
        private static JObject GetBalance(String Address = "")
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
            else return Server.ThrowError(Server.InternalError);
        }

        ///<summary>
        ///Retrieves a list of block hashes within a specified range
        ///Returns every blockHash within chosen range
        ///</summary>
        private static JObject GetBlockHashes(int StartingHeight, int BlockCount)
        {
            // Send request to server
            JObject Params = new JObject();
            Params["startingHeight"] = StartingHeight;
            Params["blockCount"] = BlockCount;
            JObject result = SendRequest("getBlockHashes", Params);

            // Output response
            if (result["error"] == null) return (JObject)result["result"];
            else return Server.ThrowError(Server.InternalError);
        }

        ///<summary>
        ///Sends a transaction to one or more addresses with the option of a payment ID
        ///Returns transactionHash
        ///</summary>
        private static JObject SendTransaction(List<String> Addresses, List<Transfer> Transfers, double Fee,
            int Anonymity = 6, String Extra = "", String PaymentID = "", int UnlockTime = 0,
            String ChangeAddress = "", String Mixin = "")
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
        private static JObject GetTransactions(List<String> Addresses, int BlockCount, int FirstBlockIndex = -1,
            String BlockHash = "", String PaymentID = "")
        {
            // Send request to server
            JObject Params = new JObject();
            Params["blockCount"] = BlockCount;
            if (BlockHash != "") Params["blockHash"] = BlockHash;
            if (FirstBlockIndex > -1) Params["firstBlockIndex"] = FirstBlockIndex;
            if (Addresses.Count > 0) Params["addresses"] = JArray.FromObject(Addresses);
            if (PaymentID != "") Params["paymentId"] = PaymentID;
            JObject result = SendRequest("getTransactions", Params);

            // Output response
            if (result["error"] == null) return (JObject)result["result"];
            else return Server.ThrowError(Server.InternalError);
        }
        #endregion
    }

    public class Transaction
    {
        public String Type { get; set; }
        public String Hash { get; set; }
        public String State { get; set; }
        public String TimeStamp { get; set; }
        public int UnlockTime { get; set; }
        public double Amount { get; set; }
        public double Fee { get; set; }
        public String Extra { get; set; }
        public String PaymentID { get; set; }
        public String BlockIndex;
        public List<Transfer> Transfers;

        public Transaction(String BlockIndex, String Hash, String State, int TimeStamp, int UnlockTime, int Amount,
            int Fee, String Extra, String PaymentID, List<Transfer> Transfers)
        {
            this.BlockIndex = BlockIndex;
            this.Hash = Hash;
            this.State = State;
            this.TimeStamp = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(TimeStamp)
                .ToLocalTime().ToString("MM/dd/yyyy - HH:mm");
            this.UnlockTime = UnlockTime;
            this.Amount = Amount / Math.Pow(10, Server.CurrencyDecimals);
            this.Fee = Fee / Math.Pow(10, Server.CurrencyDecimals);
            this.PaymentID = PaymentID;
            this.Transfers = Transfers;
            this.Extra = Extra;

            if (this.Amount > 0)
                this.Type = "IN";
            else this.Type = "OUT";
        }
        public Transaction() { }
    }

    /// <summary>
    /// Class for sending groups of transactions
    /// </summary>
    public class Transfer
    {
        #region Variables
        public String Address { get; set; }
        public int Amount;
        public String ConvertedAmount
        {
            get
            {
                double x = Amount / Math.Pow(10, Server.CurrencyDecimals);
                return x.ToString();
            }
        }
        #endregion

        #region Init
        public Transfer(String Address, double Amount)
        {
            this.Address = Address;
            this.Amount = (int)(Amount * 100);
        }
        public Transfer() { }
        #endregion
    }
}
