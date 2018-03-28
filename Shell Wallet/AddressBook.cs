using Newtonsoft.Json;
using RPCWrapper;
using System;
using System.ComponentModel;
using System.Data;
using System.IO;

namespace Shell_Wallet
{
    /// <summary>
    /// Holds contact information for address book
    /// </summary>
    public class Contact
    {
        #region Variables
        /// <summary>
        /// Returns contact name
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Returns contact address
        /// </summary>
        public String Address { get; set; }

        /// <summary>
        /// Returns contact payment ID
        /// </summary>
        public String PaymentID { get; set; }
        #endregion

        /// <summary>
        /// Init
        /// </summary>
        internal Contact() { }
    }

    /// <summary>
    /// Loads and saves address book
    /// </summary>
    internal class AddressBook
    {
        #region Variables
        internal static SortableBindingList<Contact> DataSource = new SortableBindingList<Contact>();
        #endregion

        /// <summary>
        /// Loads address book from file
        /// </summary>
        internal static void Load()
        {
            Console.WriteLine("Loading address book");

            // Check that the data folder exists
            if (!Directory.Exists(Config.DataPath)) Directory.CreateDirectory(Config.DataPath);
            String p = Path.Combine(Config.DataPath, Config.AddressBookFile);

            // Check that address book file exists and create it if it doesn't
            if (!File.Exists(p))
            {
                Console.WriteLine("Address book not found, creating it now");
                File.Create(p).Dispose();
                File.WriteAllText(p, "[]");
            }

            // Load information from the address book
            String s = "[]";
            using (StreamReader r = new StreamReader(p))
            {
                s = r.ReadToEnd();
            }

            // Set up our datasource
            DataSource = JsonConvert.DeserializeObject < SortableBindingList<Contact>>(s);
        }

        /// <summary>
        /// Saves address book to file
        /// </summary>
        internal static void Save()
        {
            String s = JsonConvert.SerializeObject(DataSource, Formatting.Indented);
            String p = Path.Combine(Config.DataPath, Config.AddressBookFile);
            File.WriteAllText(p, s);
        }
    }
}
