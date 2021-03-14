using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VsDeploymentAutomation.Library.Interfaces;

namespace VsDeploymentAutomation.Library.Manager
{
    public class MsBuildManager : IMsBuildManager
    {
        private string _exe;

        public MsBuildManager(string exe)
        {
            _exe = exe;
        }
        public bool Build(string arguments, out string output, out string error)
        {
            output = error = string.Empty;

            try
            {
                ProcessStartInfo gitInfo = new ProcessStartInfo();
                gitInfo.CreateNoWindow = true;
                gitInfo.RedirectStandardError = true;
                gitInfo.RedirectStandardOutput = true;
                gitInfo.UseShellExecute = false;
                gitInfo.FileName = _exe;

                Process gitProcess = new Process();
                gitInfo.Arguments = arguments; 

                gitProcess.StartInfo = gitInfo;
                gitProcess.Start();

                //error = gitProcess.StandardError.ReadToEnd();  // pick up STDERR
                output = gitProcess.StandardOutput.ReadToEnd(); // pick up STDOUT

                gitProcess.WaitForExit();
                gitProcess.Close();

                return true;
            }
            catch (Exception exception)
            {
                error = exception.Message;
                return false;
            }
        }

        public bool Publish(string arguments, out string output, out string error)
        {
            output = error = string.Empty;

            try
            {
                ProcessStartInfo gitInfo = new ProcessStartInfo();
                gitInfo.CreateNoWindow = true;
                gitInfo.RedirectStandardError = true;
                gitInfo.RedirectStandardOutput = true;
                gitInfo.UseShellExecute = false;
                gitInfo.FileName = _exe;

                Process gitProcess = new Process();
                gitInfo.Arguments = arguments;

                gitProcess.StartInfo = gitInfo;
                gitProcess.Start();

                output = gitProcess.StandardOutput.ReadToEnd(); // pick up STDOUT

                gitProcess.WaitForExit();
                gitProcess.Close();

                return true;
            }
            catch (Exception exception)
            {
                error = exception.Message;
                return false;
            }
        }
    }
}
