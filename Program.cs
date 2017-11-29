using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace sdrtrunk_launcher
{
    class Program
    {
        static void Main(string[] args)
        {
            // Verify the windows batch file exists in the directory we are in
            if (File.Exists("run_sdrtrunk_windows.bat")) {
                // Create a new process to launch the batch file
                Process sdrtrunk = new Process();
                // We don't want to use windows shell
                sdrtrunk.StartInfo.UseShellExecute = false;
                // We want to hide to batch file window
                sdrtrunk.StartInfo.CreateNoWindow = true;
                // The batch file name (default)
                sdrtrunk.StartInfo.FileName = "run_sdrtrunk_windows.bat";
                // Run the batch file to start sdrtrunk
                sdrtrunk.Start();
            } else {
                System.Environment.Exit(1);
            }
        }
    }
}
