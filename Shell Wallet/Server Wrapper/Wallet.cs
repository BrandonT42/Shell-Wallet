using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace RPCWrapper
{
    /// <summary>
    /// Utility class for holding static wallet variables
    /// </summary>
    public class Wallet
    {
        #region Variables
        #region Private and Internal
        private static JObject Balances = new JObject(),
            SelectedBalances = new JObject(), Status = new JObject();
        private static String InternalPassword, InternalSelectedAddress;
        internal static String Path = "";
        #endregion
        #region Public
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
        #endregion

        #region Utilities
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
            {
                SelectedAddress = Addresses[0];
                Console.WriteLine("Selected address changed to {0}", SelectedAddress);
            }

            // Update overall balance
            Balances = Server.GetBalance();

            // Update balances for selected address
            SelectedBalances = Server.GetBalance(SelectedAddress);
        }

        /// <summary>
        /// Resets all wallet variables
        /// </summary>
        public static void Reset()
        {
            Path = "";
            SelectedAddress = "";
        }

        /// <summary>
        /// Saves and closes the wallet
        /// </summary>
        public static void Save()
        {
            Server.Save();
            Console.WriteLine("Saving wallet");
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
            Console.WriteLine("Resyncing wallet");
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
}
