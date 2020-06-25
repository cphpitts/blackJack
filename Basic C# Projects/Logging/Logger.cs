using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{
    public class Logger
    {
        public static void LogWriter(int number)
        {
            using (StreamWriter file = new StreamWriter(@"C:\Users\cphpi\Documents\GitHub\cSharp_Projects\Basic C# Projects\Logging\Log\log.txt", true))
            {
                file.WriteLine(number);
            }
        }

        public static string LogReader()
        {
            string logFile = File.ReadAllText(@"C:\Users\cphpi\Documents\GitHub\cSharp_Projects\Basic C# Projects\Logging\Log\log.txt");
            return logFile;
        }
    }
}
