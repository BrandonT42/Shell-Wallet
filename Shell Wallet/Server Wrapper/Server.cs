using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

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
        #region Private and Internal Variables
        private static String InternalHash;
        internal static String InternalError;
        #endregion

        #region Public Variables and Event Handlers
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
        public static Boolean Testnet = false;

        /// <summary>
        /// Defines how many decimal places are in the currency
        /// </summary>
        public static int CurrencyDecimals = 2;

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

        #region Internal Utilities
        /// <summary>
        /// Throws string as error internally
        /// </summary>
        internal static JObject ThrowError(String e)
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
        internal static Boolean Ping(String Host, int Port)
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
        #endregion

        #region Public Utilities
        /// <summary>
        /// Stops both server and network connections
        /// </summary>
        public static void Stop()
        {
            Mobile.Stop();
            Wallet.Stop();
            Network.Stop();
        }

        /// <summary>
        /// Stops both server and network connections
        /// </summary>
        public static void Exit()
        {
            Stop();
        }

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

        /// <summary>
        /// Encodes an escape string for shell arguments
        /// Credit to ZedPea on this one
        /// </summary>
        internal static String EncodeString(String Input)
        {
            string result = "";
            bool enclosedInApo, wasApo;
            string subResult;
            enclosedInApo = Input.LastIndexOfAny(
                new char[] { ' ', '\t', '|', '@', '^', '<', '>', '&' }) >= 0;
            wasApo = enclosedInApo;
            subResult = "";
            for (int i = Input.Length - 1; i >= 0; i--)
            {
                switch (Input[i])
                {
                    case '"':
                        subResult = @"\""" + subResult;
                        wasApo = true;
                        break;
                    case '\\':
                        subResult = (wasApo ? @"\\" : @"\") + subResult;
                        break;
                    default:
                        subResult = Input[i] + subResult;
                        wasApo = false;
                        break;
                }
            }
            result += (result.Length > 0 ? " " : "")
                + (enclosedInApo ? "\"" + subResult + "\"" : subResult);
            return result;
        }
        #endregion
    }
}