using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Kripto
{
    internal class Openssl
    {
        public static string ExecuteOpenSSLCommand(string command, bool redirectStandardOutput,
            bool useShellExecute, bool createNoWindow)
        {
            string gitBashPath = @"C:\Program Files\Git\bin\bash.exe";

            // Argumenti za pokretanje git-bash terminala i izvršavanje komande
            string arguments = $"--login -i -c \"{command}\"";

            // Konfiguracija ProcessStartInfo objekta
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = gitBashPath,
                Arguments = arguments,
                RedirectStandardOutput = redirectStandardOutput,
                UseShellExecute = useShellExecute,
                CreateNoWindow = createNoWindow,
                WorkingDirectory = ".\\Certificates"
            };

            string output = string.Empty;
            // Kreiranje i pokretanje procesa
            using (Process process = new Process { StartInfo = startInfo })
            {
                process.Start();

                // Čitanje i ispis rezultata
                if (redirectStandardOutput)
                    output = process.StandardOutput.ReadToEnd();
                Console.WriteLine(output);

                process.WaitForExit();
            }
            return output;
        }

        public static string ExecuteCommand(string command, bool redirectStandardOutput,
            bool useShellExecute, bool createNoWindow)
        {
            //Output of the function, it can be an empty string or an output of a command, based on how user specifies
            string cmdPath = "C:\\Windows\\System32\\cmd.exe";
            string arguments = $"/c \"{command}\"";
            string output = string.Empty;
            //Creating our process and asigning its attributes
            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = cmdPath,
                    Arguments = command,
                    RedirectStandardOutput = redirectStandardOutput,
                    UseShellExecute = useShellExecute,
                    CreateNoWindow = createNoWindow,
                    WorkingDirectory = ".\\Certificates"
                }
            };
            //Starting the process
            process.Start();
            if (redirectStandardOutput)
                output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            return output;
        }


    }
}
