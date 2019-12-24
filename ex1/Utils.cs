using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace ex1
{
    public class Utils
    {
        public static void Process()
        {
            // Introduce some delay
            Thread.Sleep(1000);
        }

        public static void Log(string str, List<string> logs)
        {
            // Simple log into terminal. For more complex application, log4net may be used
            Debug.WriteLine(str);
            logs?.Add(str);
        }
    }
}
