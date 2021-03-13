using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VsDeploymentAutomation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            Publish();
        }

        #region [Custom Private Functions]

        private bool Pull()
        {
            ProcessStartInfo gitInfo = new ProcessStartInfo();
            gitInfo.CreateNoWindow = true;
            gitInfo.RedirectStandardError = true;
            gitInfo.RedirectStandardOutput = true;
            gitInfo.UseShellExecute = false;
            gitInfo.FileName = @"C:\Program Files\Git\bin\git.exe";

            Process gitProcess = new Process();
            gitInfo.Arguments = "pull origin master"; // such as "fetch orign"
            gitInfo.WorkingDirectory = @"C:\git\public\ndate";

            gitProcess.StartInfo = gitInfo;
            gitProcess.Start();

            string stderr_str = gitProcess.StandardError.ReadToEnd();  // pick up STDERR
            string stdout_str = gitProcess.StandardOutput.ReadToEnd(); // pick up STDOUT

            //textBox1.Text = stdout_str + stderr_str;

            gitProcess.WaitForExit();
            gitProcess.Close();

            return true;
        }

        private bool Build()
        {
            ProcessStartInfo gitInfo = new ProcessStartInfo();
            gitInfo.CreateNoWindow = true;
            gitInfo.RedirectStandardError = true;
            gitInfo.RedirectStandardOutput = true;
            gitInfo.UseShellExecute = false;
            gitInfo.FileName = @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe";

            Process gitProcess = new Process();
            gitInfo.Arguments = @"C:\git\public\Fractal\Fractal\Fractal.sln"; // such as "fetch orign"
            //gitInfo.WorkingDirectory = @"C:\git\public\ndate";

            gitProcess.StartInfo = gitInfo;
            gitProcess.Start();

            string stderr_str = gitProcess.StandardError.ReadToEnd();  // pick up STDERR
            string stdout_str = gitProcess.StandardOutput.ReadToEnd(); // pick up STDOUT

            //textBox1.Text = stdout_str + stderr_str;

            gitProcess.WaitForExit();
            gitProcess.Close();

            return true;
        }

        private bool Publish()
        {
            ProcessStartInfo gitInfo = new ProcessStartInfo();
            gitInfo.CreateNoWindow = true;
            gitInfo.RedirectStandardError = true;
            gitInfo.RedirectStandardOutput = true;
            gitInfo.UseShellExecute = false;
            gitInfo.FileName = @"C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\MSBuild.exe";

            Process gitProcess = new Process();
            gitInfo.Arguments = @"C:\git\private\armadareports\ArmadaReports\ArmadaReports.Web\ArmadaReports.Web.csproj /p:DeployOnBuild=true /p:PublishProfile=armadareports"; // such as "fetch orign"
            //gitInfo.WorkingDirectory = @"C:\git\public\ndate";

            gitProcess.StartInfo = gitInfo;
            gitProcess.Start();

            //string stderr_str = gitProcess.StandardError.ReadToEnd();  // pick up STDERR
            string stdout_str = gitProcess.StandardOutput.ReadToEnd(); // pick up STDOUT

            //textBox1.Text = stdout_str;// + stderr_str;

            gitProcess.WaitForExit();
            gitProcess.Close();

            return true;
        }

        #endregion
    }
}
