using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4
{
    class IteratingObjects
    {
        private void ForLoop()
        {
            for (int counter = 1; counter < 11; counter++)
            {
                Console.WriteLine("Action repeated {0} times", counter);
            }
        }

        private void ForEachLoop()
        {
            // Requires a using System.Diagnostics directive
            Process[] processList = Process.GetProcesses();
            foreach (Process process in processList)
            {
                Console.WriteLine("Process name {0}, process ID {1}",
                    process.ProcessName, process.Id);
            }

        }
    }
}
