using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace RPCWrapper
{
    class Mobile
    {
        #region Variables
        #region Private and Internal
        private static Boolean InternalAlive = false;
        private static String InternalPassword = "", Port = "11999";

        internal static String Password
        {
            get
            {
                return InternalPassword;
            }
            set
            {
                InternalPassword = Server.SafeEncrypt(value);
            }
        }
        #endregion

        #region Public
        public static Boolean Alive
        {
            get
            {
                return InternalAlive;
            }
        }
        #endregion
        #endregion

        #region Utilities
        private static void ProcessRequests(object obj)
        {
            // Grab client
            var client = (TcpClient)obj;

            // Create a network stream to handle data
            NetworkStream stream = client.GetStream();

            // Wait for data to become available
            while (Alive)
            {
                while (!stream.DataAvailable)
                    if (!Alive) return;

                // Get received bytes
                Byte[] bytes = new Byte[client.Available];
                stream.Read(bytes, 0, bytes.Length);

                // Convert received bytes into a string
                String data = Encoding.UTF8.GetString(bytes);

                // Convert string into a JObject
                JObject j = JObject.Parse(data);

                // Create a response
                String response = "";

                // Check packet password
                if (j["password"] != null && Server.SafeEncrypt((String)j["password"]) == Wallet.Password)
                {
                    // TODO - Add more command listeners here
                    if (j["method"] != null && (String)j["method"] == "balance")
                        response = Wallet.Balance;
                }

                // Create a response
                Byte[] responsebytes = Encoding.UTF8.GetBytes(response);
                stream.Write(responsebytes, 0, responsebytes.Length);
            }
        }

        private static JObject CreateResponse(String Out, JObject AltOut = null)
        {
            JObject j = new JObject();
            if (Out != null && Out != "") j["response"] = Out;
            else if (AltOut != null) j["response"] = AltOut;
            return j;
        }

        internal static void Reset()
        {
            InternalPassword = "";
        }

        public static bool Start(String Port, String Password)
        {
            // Make sure server is alive
            if (!Wallet.Alive)
            {
                Server.InternalError = "No wallet opened";
                return false;
            }

            // Make sure mobile server hasn't already been started
            if (Alive)
            {
                Server.InternalError = "Mobile server is already running";
                return false;
            }

            // Set variables
            Mobile.Password = Password;
            Mobile.Port = Port;

            // Check to make sure port is open
            if (Server.Ping("127.0.0.1", Convert.ToInt32(Mobile.Port)))
            {
                Server.InternalError = "Port not available for mobile connection";
                return false;
            }

            // Start listening on a new thread
            Thread t = new Thread(delegate ()
            {
                // Create a TCP server to wait for requests
                TcpListener server = new TcpListener(IPAddress.Any, Convert.ToInt32(Mobile.Port));
                server.Start();
                
                Console.WriteLine("Mobile server has been started on port {0}", Mobile.Port);
                InternalAlive = true;

                // Wait for a client to connect
                TcpClient client = null;
                while (Alive)
                {
                    client = server.AcceptTcpClient();
                    ThreadPool.QueueUserWorkItem(ProcessRequests, client);
                }
            })
            {
                Name = "Mobile Thread"
            };
            t.Start();
            return true;
        }

        public static void Stop()
        {
            InternalAlive = false;
            Reset();
        }
        #endregion
    }
}
