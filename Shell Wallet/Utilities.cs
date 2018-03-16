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
        /// Holds a list of all lines from the console
        /// </summary>
        private static List<string> lines = new List<string>();

        /// <summary>
        /// Holds original console writer
        /// </summary>
        private TextWriter original;

        /// <summary>
        /// Init
        /// </summary>
        /// <param name="original"></param>
        internal ConsoleWriter(TextWriter original)
        {
            // Store original console writer
            this.original = original;
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
            // Add line to log
            lines.Add(value);

            // Add line to console
            original.WriteLine(value);
        }

        /// <summary>
        /// Returns all lines written to console as a single string
        /// </summary>
        /// <returns></returns>
        internal string GetLines()
        {
            string output = "";
            foreach (string s in lines.ToArray())
            {
                output += s + "\r\n";
            }
            return output;
        }

        /// <summary>
        /// Flush output to log file
        /// </summary>
        internal void FlushOutput()
        {
            // Set to original writer
            Console.SetOut(original);
            
            /*
            // Flush log to text file
            Console.WriteLine("Flushing output to log file");
            if (!File.Exists("./Log.txt")) File.Create("./Log.txt");
            File.WriteAllText("./Log.txt", GetLines());
            */
        }
    }
}
