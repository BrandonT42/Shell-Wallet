using System;
using Newtonsoft.Json.Linq;

namespace RPCWrapper
{
    /// <summary>
    /// Utility class for holding static network variables
    /// </summary>
    public class Network
    {
        #region Variables
        #region Private and Internal
        private static JObject Status = new JObject(), LastBlockHeader = new JObject(), LastBlock = new JObject();
        #endregion
        #region Public
        public static Boolean Alive
        {
            get
            {
                return Server.DaemonVerified;
            }
        }
        #endregion
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

        #region Utilities
        /// <summary>
        /// Updates the network information
        /// </summary>
        internal static void Update()
        {
            Status = Server.GetNetworkInfo();
            LastBlockHeader = Server.GetLastBlockHeader();
            LastBlock = Server.GetBlockInfo(LastBlockHash);
        }

        /// <summary>
        /// Resets all network variables
        /// </summary>
        public static void Reset()
        {

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
