using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Shell_Wallet
{
    /// <summary>
    /// Used to log console data
    /// </summary>
    internal class ConsoleWriter : TextWriter
    {
        /// <summary>
        /// Holds original console writer
        /// </summary>
        private static TextWriter OriginalConsoleWriter;

        /// <summary>
        /// Creates a debug console window
        /// </summary>
        private static DebugWindow Debug;

        /// <summary>
        /// Holds the console output in a single string
        /// </summary>
        internal static String Output;

        /// <summary>
        /// Init
        /// </summary>
        internal ConsoleWriter(TextWriter OriginalWriter)
        {
            // Store original console writer
            OriginalConsoleWriter = OriginalWriter;
            
            // Create a debug console
            Debug = new DebugWindow();

            // Sow debug console
            if (Config.Debug) Debug.Show();
        }

        /// <summary>
        /// Sets default encoding
        /// </summary>
        public override Encoding Encoding
        {
            get { return Encoding.Default; }
        }

        /// <summary>
        /// Overrides the default WriteLine method to write to our log and the console
        /// </summary>
        /// <param name="value"></param>
        public override void WriteLine(string value)
        {
            // Add line to debug console
            if (Debug != null)
                Output += DateTime.Now.ToShortDateString() + " " +
                    DateTime.Now.ToLongTimeString() + " : " + value + "\r\n";
        }

        /// <summary>
        /// Flush output to log file
        /// </summary>
        internal static void FlushOutput()
        {
            // Set to original writer
            Console.SetOut(OriginalConsoleWriter);

            // Close debug console
            if (Debug != null) Debug.Close();

            // Flush log to text file
            if (Config.Log)
            {
                Console.WriteLine("Outputing console data to log file");
                String p = Path.Combine(Config.DataPath, Config.LogFile);
                if (!File.Exists(p)) File.Create(p).Dispose();
                File.WriteAllText(p, Output);
            }
        }
    }
}
