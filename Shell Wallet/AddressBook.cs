using Newtonsoft.Json;
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
        internal static BindingList<Contact> DataSource = new BindingList<Contact>();
        #endregion

        /// <summary>
        /// Loads address book from file
        /// </summary>
        internal static void Load()
        {
            String s = "[]";
            String p = Path.Combine(Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "Shell Wallet"), Config.AddressBookFile);
            using (StreamReader r = new StreamReader(p))
            {
                s = r.ReadToEnd();
                r.Dispose();
            }
            DataSource = JsonConvert.DeserializeObject<BindingList<Contact>>(s);
        }

        /// <summary>
        /// Saves address book to file
        /// </summary>
        internal static void Save()
        {
            String s = JsonConvert.SerializeObject(DataSource);
            String p = Path.Combine(Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "Shell Wallet"), Config.AddressBookFile);
            File.WriteAllText(p, s);
        }
    }
}
