using Newtonsoft.Json.Linq;
using System;
using System.IO;
using RPCWrapper;

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
        internal const String PasswordRegex = "[^x21-x7ExA2-xA7xBF-xFF~!#$%&*()\\-+{}|,./]";
        internal static String CurrentDirectory = Directory.GetCurrentDirectory();
        internal static String DataPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "Shell Wallet");

        // Wallet server
        internal static String ServerPath = "";
        internal static int ServerPort = 11911;
        internal static String OriginalServerPassword = "";
        internal static String ServerPassword = "";
        internal static bool GeneratePassword = true;

        // Remote RPC Server
        internal static String RemotePath = "127.0.0.1";
        internal static int RemotePort = 12345;
        internal static String RemotePassword = "";
        internal static Boolean RemoteReminder = true;

        // Daemon server
        internal static String NodeHost = "";
        internal static int NodePort = 11898;
        internal static bool LocalDaemon = true;
        internal static bool NetworkMonitor = true;

        // Security
        internal static bool AllowBlankPasswords = false;
        internal static bool PasswordConfirmation = false;

        // Defaults
        internal static String DefaultWalletPath = "";
        internal static String DefaultFee = "0.1";
        internal static String DefaultUnlockTime = "0";
        internal static String DefaultMixin = "6";

        // Refresh rates
        internal static int RefreshRate = 5000; // 5 seconds
        internal static int NetworkRefreshRate = 20000; // 10 seconds
        internal static int GUIRefreshRate = 100; // 100 milliseconds

        // Environment
        internal static bool Debug = false;
        internal static bool Testnet = false;
        internal static bool Log = false;

        //Mobile
        internal static String MobilePort = "11999";
        internal static String MobilePassword = "";
        internal static bool EnableMobile = false;
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
                if (!String.IsNullOrEmpty((String)conf["serverPath"])) ServerPath = (String)conf["serverPath"];
                if (!String.IsNullOrEmpty((String)conf["serverPort"])) ServerPort = (int)conf["serverPort"];
                if (!String.IsNullOrEmpty((String)conf["serverPassword"]))
                {
                    OriginalServerPassword = (String)conf["serverPassword"];
                    if (GeneratePassword)
                        ServerPassword = Server.Hash;
                    else ServerPassword = (String)conf["serverPassword"];
                }
                if (!String.IsNullOrEmpty((String)conf["generatePassword"])) GeneratePassword = (Boolean)conf["generatePassword"];
                if (!String.IsNullOrEmpty((String)conf["remoteServer"])) RemotePath = (String)conf["remoteServer"];
                if (!String.IsNullOrEmpty((String)conf["remotePort"])) RemotePort = (int)conf["remotePort"];
                if (!String.IsNullOrEmpty((String)conf["remotePassword"])) RemotePassword = (String)conf["remotePassword"];
                if (!String.IsNullOrEmpty((String)conf["remoteReminder"])) RemoteReminder = (Boolean)conf["remoteReminder"];
                if (!String.IsNullOrEmpty((String)conf["localDaemon"])) LocalDaemon = (Boolean)conf["localDaemon"];
                if (!String.IsNullOrEmpty((String)conf["nodeAddress"])) NodeHost = (String)conf["nodeAddress"];
                if (!String.IsNullOrEmpty((String)conf["nodePort"])) NodePort = (int)conf["nodePort"];
                if (!String.IsNullOrEmpty((String)conf["networkMonitoring"])) NetworkMonitor = (Boolean)conf["networkMonitoring"];
                if (!String.IsNullOrEmpty((String)conf["enableMobile"])) EnableMobile = (Boolean)conf["enableMobile"];
                if (!String.IsNullOrEmpty((String)conf["mobilePort"])) MobilePort = (String)conf["mobilePort"];
                if (!String.IsNullOrEmpty((String)conf["mobilePassword"])) MobilePassword = (String)conf["mobilePassword"];
                if (!String.IsNullOrEmpty((String)conf["allowBlankPasswords"])) AllowBlankPasswords = (Boolean)conf["allowBlankPasswords"];
                if (!String.IsNullOrEmpty((String)conf["passwordConfirmation"])) PasswordConfirmation = (Boolean)conf["passwordConfirmation"];
                if (!String.IsNullOrEmpty((String)conf["defaultWalletPath"])) DefaultWalletPath = (String)conf["defaultWalletPath"];
                if (!String.IsNullOrEmpty((String)conf["defaultFee"])) DefaultFee = (String)conf["defaultFee"];
                if (!String.IsNullOrEmpty((String)conf["defaultMixin"])) DefaultMixin = (String)conf["defaultMixin"];
                if (!String.IsNullOrEmpty((String)conf["walletRefreshRate"])) RefreshRate = (int)conf["walletRefreshRate"];
                if (!String.IsNullOrEmpty((String)conf["networkRefreshRate"])) NetworkRefreshRate = (int)conf["networkRefreshRate"];
                if (!String.IsNullOrEmpty((String)conf["guiRefreshRate"])) GUIRefreshRate = (int)conf["guiRefreshRate"];
            }

            // Save file in case some values were not found
            Save();
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
            conf["remoteServer"] = RemotePath;
            conf["remotePort"] = RemotePort;
            conf["remotePassword"] = RemotePassword;
            conf["remoteReminder"] = RemoteReminder;
            conf["localDaemon"] = LocalDaemon;
            conf["nodeAddress"] = NodeHost;
            conf["nodePort"] = NodePort;
            conf["networkMonitoring"] = NetworkMonitor;
            conf["enableMobile"] = EnableMobile;
            conf["mobilePassword"] = MobilePassword;
            conf["mobilePort"] = MobilePort;
            conf["allowBlankPasswords"] = AllowBlankPasswords;
            conf["passwordConfirmation"] = PasswordConfirmation;
            conf["defaultWalletPath"] = DefaultWalletPath;
            conf["defaultFee"] = DefaultFee;
            conf["defaultMixin"] = DefaultMixin;
            conf["walletRefreshRate"] = RefreshRate;
            conf["networkRefreshRate"] = NetworkRefreshRate;
            conf["guiRefreshRate"] = GUIRefreshRate;
            File.WriteAllText(c, conf.ToString());
        }
    }
}
