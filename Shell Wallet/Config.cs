using Newtonsoft.Json.Linq;
using System;
using System.IO;
using WalletWrapper;

namespace Shell_Wallet
{
    /// <summary>
    /// Config file helper class
    /// </summary>
    internal class Config
    {
        #region Variables
        // File names and paths
        internal const String ConfigFile = "Config.json";
        internal const String AddressBookFile = "Addresses.json";
        internal const String LogFile = "Log.log";
        internal static String CurrentDirectory = Directory.GetCurrentDirectory();
        internal static String DataPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "Shell Wallet");

        // Local server
        internal static String ServerPath = "";
        internal static String ServerPort = "11911";
        internal static String OriginalServerPassword = "";
        internal static String ServerPassword = "";

        // Daemon server
        internal static String NodeHost = "";
        internal static String NodePort = "";
        internal static bool LocalDaemon = true;

        // Security
        internal static bool GeneratePassword = true;
        internal static bool AllowBlankPasswords = false;

        // Defaults
        internal static String DefaultWalletPath = "";
        internal static String DefaultFee = "0.1";
        internal static String DefaultUnlockTime = "0";
        internal static String DefaultMixin = "6";

        // Refresh rates
        internal static int RefreshRate = 1000;
        internal static int NetworkRefreshRate = 1000;
        internal static int GUIRefreshRate = 1000;

        // Environment
        internal static bool Debug = false;
        internal static bool Testnet = false;
        internal static bool Log = false;
        #endregion

        /// <summary>
        /// Loads configuration from config file
        /// </summary>
        internal static void Load()
        {
            // Check that the data folder exists
            if (!Directory.Exists(DataPath)) Directory.CreateDirectory(DataPath);

            // Check if configuration files exists and create it if it doesn't
            Console.WriteLine("Loading configuration");
            String c = Path.Combine(DataPath, ConfigFile);
            if (!File.Exists(c))
            {
                Console.WriteLine("Config file not found, creating it now");
                File.Create(c).Dispose();
                Save();
            }

            // Load configuration from file
            using (StreamReader r = new StreamReader(c))
            {
                JObject conf = JObject.Parse(r.ReadToEnd());
                ServerPath = (String)conf["serverPath"];
                ServerPort = (String)conf["serverPort"];
                GeneratePassword = (Boolean)conf["generatePassword"];
                AllowBlankPasswords = (Boolean)conf["allowBlankPasswords"];
                OriginalServerPassword = (String)conf["serverPassword"];
                if (GeneratePassword)
                {
                    ServerPassword = Server.Hash;
                    //Console.WriteLine("Generated server password: " + Server.Hash);
                }
                else ServerPassword = (String)conf["serverPassword"];
                LocalDaemon = (Boolean)conf["localDaemon"];
                NodeHost = (String)conf["nodeAddress"];
                NodePort = (String)conf["nodePort"];
                DefaultWalletPath = (String)conf["defaultWalletPath"];
                DefaultFee = (String)conf["defaultFee"];
                DefaultMixin = (String)conf["defaultMixin"];
                RefreshRate = (int)conf["refreshRate"];
                NetworkRefreshRate = (int)conf["networkRefreshRate"];
                GUIRefreshRate = (int)conf["guiRefreshRate"];
            }
        }

        /// <summary>
        /// Saves configuration to config file
        /// </summary>
        internal static void Save()
        {
            // Create file path
            String c = Path.Combine(Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "Shell Wallet"), ConfigFile);
            JObject conf = new JObject();
            conf["serverPath"] = ServerPath;
            conf["serverPort"] = ServerPort;
            conf["serverPassword"] = OriginalServerPassword;
            conf["generatePassword"] = GeneratePassword;
            conf["allowBlankPasswords"] = AllowBlankPasswords;
            conf["localDaemon"] = LocalDaemon;
            conf["nodeAddress"] = NodeHost;
            conf["nodePort"] = NodePort;
            conf["defaultWalletPath"] = DefaultWalletPath;
            conf["defaultFee"] = DefaultFee;
            conf["defaultMixin"] = DefaultMixin;
            conf["refreshRate"] = RefreshRate;
            conf["networkRefreshRate"] = NetworkRefreshRate;
            conf["guiRefreshRate"] = GUIRefreshRate;
            File.WriteAllText(c, conf.ToString());
        }
    }
}
