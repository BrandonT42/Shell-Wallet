using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace WalletWrapper
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
        private static Process WalletProcess;
        private static String ServerPath, RPCPort, RPCPassword, HostAddress,
            HostPort, WalletPassword, InternalError, InternalHash;
        private static Boolean LocalServer, ShowConsoleWindow, InternalAlive;
        internal static Boolean CanUpdate = false;
        internal static Boolean DaemonVerified = false;
        #endregion
        #region Public
        public static EventHandler OnStart;
        public static EventHandler OnStop;
        public static EventHandler OnTick;
        public static int RefreshRate = 1000;
        public static int NetworkRefreshRate = 1000;

        /// <summary>
        /// Returns true if server is running
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
        /// Returns the last server error message
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

#if DEBUG
            // Show what we're sending
            //Console.WriteLine("Sending request type {0}\n{1}", Method, s);
#endif

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

#if DEBUG
                // Show what we're sending
                //Console.WriteLine("Sending daemon request type {0}:\r\n{1}", Method, j.ToString(Formatting.None));
#endif

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

#if DEBUG
                // Show what we're sending
                //Console.WriteLine("Sending daemon request type {0}:\r\n{1}", Method, Request);
#endif

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

        /// <summary>
        /// Initiates and runs the server process
        /// </summary>
        private static void RunWallet()
        {
            // Make sure server isn't already running
            if (Alive)
            {
                InternalError = "Server is already running, could not start";
                return;
            }

            // First check if RPC server port is available
            if (Ping("127.0.0.1", Convert.ToInt32(RPCPort)))
            {
                InternalError = "Selected RPC server port is not available";
                InternalAlive = false;
                return;
            }

            // Second check if daemon is running
            if (!DaemonVerified) StartNetwork(LocalServer, HostAddress, HostPort);
            if (!DaemonVerified)
            {
                InternalError = "Could not connect to local daemon";
                InternalAlive = false;
                return;
            }

            // Create a process for the server to run on
            WalletProcess = new Process();

            // Setup process start info
            WalletProcess.StartInfo.FileName = ServerPath;
            WalletProcess.StartInfo.UseShellExecute = false;
            WalletProcess.StartInfo.RedirectStandardOutput = true;
            WalletProcess.StartInfo.RedirectStandardInput = true;
            WalletProcess.StartInfo.RedirectStandardError = true;

            // Whether console should be displayed
            if (!ShowConsoleWindow)
            {
                WalletProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                WalletProcess.StartInfo.CreateNoWindow = true;
            }

            // Add flags according to supplied arguments
            if (LocalServer) WalletProcess.StartInfo.Arguments = "--local";
            else WalletProcess.StartInfo.Arguments = "--daemon-address " + HostAddress + " --daemon-port " + HostPort;
            if (RPCPassword != "") WalletProcess.StartInfo.Arguments += " --rpc-password " + RPCPassword;
            else WalletProcess.StartInfo.Arguments += " --rpc-legacy-security";
            WalletProcess.StartInfo.Arguments += " --bind-port " + RPCPort;
            WalletProcess.StartInfo.Arguments += " --log-level 0 --allow-local-ip";
            WalletProcess.StartInfo.Arguments += " -w \"" + Wallet.Path + "\"";
            if (WalletPassword != "")
            {
                WalletProcess.StartInfo.Arguments += " -p " + WalletPassword;
                WalletPassword = "";
            }

            // Begin the process
            InternalAlive = WalletProcess.Start();

            // Begin listening for data
            WalletProcess.BeginOutputReadLine();
            WalletProcess.BeginErrorReadLine();

            // If the server failed to start
            if (!InternalAlive)
            {
                InternalError = "Could not start server process, check system credentials";
                WalletProcess = null;
                return;
            }

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
            WalletProcess = null;

            // Reset wallet data
            Wallet.Reset();

            // Trigger stop event
            OnStop.Invoke(new Server(), EventArgs.Empty);
        }
        #endregion

        #region Server Functions
        /// <summary>
        /// Verifies a daemon connection outside of server instance
        /// </summary>
        public static Boolean StartNetwork(Boolean Local = true, String NodeHost = "daemon.turtle.link", String NodePort = "11898")
        {
            // Set variables
            LocalServer = Local;
            if (!LocalServer) HostAddress = NodeHost;
            else HostAddress = "127.0.0.1";
            HostPort = NodePort;

            // Check if server is valid
            if (Ping(HostAddress, Convert.ToInt32(HostPort)))
            {
                // Set internal daemon connection
                DaemonVerified = true;

                // Begin new thread for updates
                Thread s = new Thread(delegate ()
                {
                    while (DaemonVerified)
                    {
                        // Update network
                        Network.Update();

                        // Sleep for the desired refresh rate
                        Thread.Sleep(NetworkRefreshRate);
                    }
                });
                s.Name = "Network Thread";
                s.Start();
                return true;
            }
            else return false;
        }
        
        /// <summary>
        /// Closes the daemon connection (only if wallet isn't open)
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
        /// Starts the RPC server thread
        /// </summary>
        public static void StartWallet(String Path, String WalletPath, String Password, String ServerPassword = "", String ServerPort = "11911",
            bool Local = false, String NodeHost = "daemon.turtle.link", String NodePort = "11898", Boolean ShowWindow = false)
        {
            // Check if server is already alive
            if (Alive)
            {
                InternalError = "Server already running!";
                return;
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
            ShowConsoleWindow = ShowWindow;

            // Create a thread to run the server in
            Thread s = new Thread(RunWallet);
            s.Name = "Server Thread";
            s.Start();
        }
        
        /// <summary>
        /// Creates a new wallet container
        /// Returns true if successful
        /// </summary>
        public static bool CreateWallet(String Path, String WalletPath, String Password)
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
            if (!ShowConsoleWindow)
            {
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                p.StartInfo.CreateNoWindow = true;
            }

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
        /// Imports keys to new wallet
        /// Returns true if successful
        /// </summary>
        public static bool ImportWallet(String Path, String WalletPath, String Password, String ViewKey, String SpendKey)
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
            if (!ShowConsoleWindow)
            {
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                p.StartInfo.CreateNoWindow = true;
            }

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
        /// Checks to see if a password is correct (TODO - fix this, it's slow)
        /// </summary>
        public static bool CheckPassword(String Path, String WalletPath, String Password)
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
            if (!ShowConsoleWindow)
            {
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                p.StartInfo.CreateNoWindow = true;
            }

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
        /// Sends a flag to stop the server loop from running
        /// </summary>
        public static void Stop()
        {
            if (Alive)
            {
                Wallet.Save();
            }
            Wallet.Reset();
            InternalAlive = false;
            DaemonVerified = false;
        }

        /// <summary>
        /// Sends a flag to stop the server loop from running
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
                return (JObject)result["result"];
            }
            else
            {
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

        #region Utility and Security
        /// <summary>
        /// Generates a unique password hash upon first called instance
        /// </summary>
        public static String Hash
        {
            get
            {
                if (InternalHash == "" || InternalHash == null)
                {
                    Regex rgx = new Regex("[^a-zA-Z0-9 -]");
                    byte[] plainTextBytes = Encoding.UTF8.GetBytes(Environment.CurrentDirectory);
                    byte[] keyBytes = new Rfc2898DeriveBytes(Environment.MachineName, Encoding.ASCII.GetBytes(DateTime.Now.ToString("yyyyMMddHHmmssffff"))).GetBytes(256 / 8);
                    var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };
                    var encryptor = symmetricKey.CreateEncryptor(keyBytes, Encoding.ASCII.GetBytes("@1B2c3D4e5F6g7H8"));
                    byte[] cipherTextBytes;
                    using (var memoryStream = new MemoryStream())
                    {
                        using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                        {
                            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                            cryptoStream.FlushFinalBlock();
                            cipherTextBytes = memoryStream.ToArray();
                            cryptoStream.Close();
                        }
                        memoryStream.Close();
                    }
                    InternalHash = Convert.ToBase64String(cipherTextBytes);
                }
                return InternalHash;
            }
        }

        /// <summary>
        /// Safely encrypts a string using the generated server hash
        /// </summary>
        public static String SafeEncrypt(String s)
        {
            byte[] clearBytes = Encoding.Unicode.GetBytes(s);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(Hash, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    s = Convert.ToBase64String(ms.ToArray());
                }
            }
            return s;
        }

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
        /// Tries to ping a host and port, returns true if successful and server/port is online
        /// </summary>
        private static Boolean Ping(String Host, int Port)
        {
            TcpClient tcpClient = new TcpClient();

            try
            {
                tcpClient.Connect(Host, Port);
                tcpClient.Dispose();
                return true;
            }
            catch (Exception)
            {
                tcpClient.Dispose();
                return false;
            }
        }
        #endregion
    }

    /// <summary>
    /// Class for sending groups of transactions
    /// </summary>
    public class Transfer
    {
        #region Variables
        public String address;
        public int amount;
        #endregion

        #region Init
        public Transfer(String Address, double Amount)
        {
            this.address = Address;
            this.amount = (int)(Amount * 100);
        }
        public Transfer() { }
        #endregion
    }

    /// <summary>
    /// Utility class for holding static wallet variables
    /// </summary>
    public class Wallet
    {
        #region Variables
        public static String Path = "";
        private static String InternalPassword, InternalSelectedAddress;

        /// <summary>
        /// Gets a list of all addresses associated with the wallet
        /// </summary>
        public static List<String> Addresses = new List<string>();
        private static JObject Balances = new JObject(),
            SelectedBalances = new JObject(), Status = new JObject();

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
                    JObject result = Server.GetViewKey();
                    if (result["viewSecretKey"] != null)
                        return (String)Server.GetViewKey()["viewSecretKey"];
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
                    JObject result = Server.GetSpendKeys(SelectedAddress);
                    if (result["spendPublicKey"] != null)
                        return (String)Server.GetSpendKeys(SelectedAddress)["spendPublicKey"];
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
                    JObject result = Server.GetSpendKeys(SelectedAddress);
                    if (result["spendSecretKey"] != null)
                        return (String)Server.GetSpendKeys(SelectedAddress)["spendSecretKey"];
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

        public static String FileName
        {
            get
            {
                return System.IO.Path.GetFileNameWithoutExtension(Path);
            }
        }
        #endregion

        #region Wallet Access Functions
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
                    if (s.Length < 3) return "0." + s;
                    else return s.Insert(s.Length - 2, ".");
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
                    if (s.Length < 3) return "0." + s;
                    else return s.Insert(s.Length - 2, ".");
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
                    if (s.Length < 3) return "0." + s;
                    else return s.Insert(s.Length - 2, ".");
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
                    if (s.Length < 3) return "0." + s;
                    else return s.Insert(s.Length - 2, ".");
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
        public static String BlockCount
        {
            get
            {
                if (Status != null && Status["blockCount"] != null)
                    return (String)Status["blockCount"];
                return "0";
            }
        }

        /// <summary>
        /// Returns known/destination block count
        /// </summary>
        public static String KnownBlockCount
        {
            get
            {
                if (Status != null && Status["knownBlockCount"] != null)
                    return (String)Status["knownBlockCount"];
                return "0";
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
        #endregion

        #region Utilities
        /// <summary>
        /// Resets all wallet variables
        /// </summary>
        public static void Reset()
        {
            Path = "";
            SelectedAddress = "";
    }

        /// <summary>
        /// Saves the wallet
        /// </summary>
        public static void Save()
        {
            Server.Save();
        }

        /// <summary>
        /// Updates the wallet information
        /// </summary>
        internal static void Update()
        {
            // Update status
            Status = Server.GetStatus();

            // Update Addresses
            JObject a = Server.GetAddresses();
            if (a["error"] == null)
            {
                if (a["addresses"] != null && a["addresses"].HasValues)
                    Addresses = a["addresses"].ToObject<List<String>>();
                else Addresses = new List<string>();
            }
            else Addresses = new List<string>();

            // Update selected address
            if (SelectedAddress == "" && Addresses.Count > 0)
                SelectedAddress = Addresses[0];
            
            // Update overall balance
            Balances = Server.GetBalance();

            // Update balances for selected address
            SelectedBalances = Server.GetBalance(SelectedAddress);
        }

        /// <summary>
        /// Creates a new address within the wallet
        /// </summary>
        public static void CreateAddress()
        {
            JObject result = Server.CreateAddress();
            if (result["address"] != null) Update();
        }

        /// <summary>
        /// Deletes the selected address
        /// </summary>
        public static void DeleteSelectedAddress()
        {
            if (SelectedAddress != "" && Addresses.Count > 0)
            {
                JObject r = Server.DeleteAddress(SelectedAddress);
                Update();
            }
        }

        /// <summary>
        /// Resyncs the wallet from zero
        /// </summary>
        public static void Resync()
        {
            JObject result = Server.Reset();
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
        public TransactionPool() { }
        #endregion
    }

    /// <summary>
    /// Utility class for holding static network variables
    /// </summary>
    public class Network
    {
        #region Variables
        private static JObject Status = new JObject(), LastBlockHeader = new JObject(), LastBlock = new JObject();

        public static Boolean Alive
        {
            get
            {
                return Server.DaemonVerified;
            }
        }
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
        public static int Reward
        {
            get
            {
                if (LastBlockHeader != null && LastBlockHeader["block_header"] != null)
                    return (int)LastBlockHeader["block_header"]["reward"];
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
                    return (double)(LastBlock["block"]["alreadyGeneratedCoins"]) / 100;
                }
                else return 0;
            }
        }
        #endregion

        #region Utilities
        /// <summary>
        /// Resets all network variables
        /// </summary>
        public static void Reset()
        {

        }

        /// <summary>
        /// Updates the network information
        /// </summary>
        internal static void Update()
        {
            Status = Server.GetNetworkInfo();
            LastBlockHeader = Server.GetLastBlockHeader();
            LastBlock = Server.GetBlockInfo(LastBlockHash);
        }
        #endregion
    }
}
