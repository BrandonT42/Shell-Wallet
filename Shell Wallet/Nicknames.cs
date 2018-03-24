using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shell_Wallet
{
    class Nicknames
    {
        internal static Dictionary<String, String> Addresses = new Dictionary<string, string>();

        internal static void Load()
        {
            Console.WriteLine("Loading nicknames");
            String c = Path.Combine(Config.DataPath, Config.NicknamesFile);
            if (!File.Exists(c))
            {
                Console.WriteLine("Nicknames file not found, creating it now");
                File.Create(c).Dispose();
                Save();
            }

            try
            {
                JArray j = JArray.Parse(File.ReadAllText(c));
                foreach (JObject o in j)
                    Addresses.Add((String)o["Address"], (String)o["Nickname"]);
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to parse nicknames file");
            }
        }

        internal static void Save()
        {
            JArray j = new JArray();
            foreach (KeyValuePair<string, string> x in Addresses)
            {
                JObject o = new JObject();
                o["Address"] = x.Key;
                o["Nickname"] = x.Value;
                j.Add(o);
            }
            File.WriteAllText(Path.Combine(Config.DataPath, Config.NicknamesFile), j.ToString());
        }

        internal static void Add(String Address, String Nickname)
        {
            if (!Addresses.ContainsKey(Address)) Addresses.Add(Address, Nickname);
            else
            {
                Addresses[Address] = Nickname;
            }
            Save();
        }

        internal static String Get(String Address)
        {
            if (!Addresses.ContainsKey(Address)) return "-";
            else return Addresses[Address];
        }
    }
}
