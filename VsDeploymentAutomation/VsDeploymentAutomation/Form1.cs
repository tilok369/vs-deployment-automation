using System;
using System.Collections.Generic;
using System.ComponentModel;
using app = System.Configuration.ConfigurationManager;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VsDeploymentAutomation.Library.Interfaces;
using VsDeploymentAutomation.Library.Manager;
using System.Threading;

namespace VsDeploymentAutomation
{
    public partial class MainForm : Form
    {
        private IGitCommandManager _gitCommandManager;
        private IMsBuildManager _msBuildManager;

        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        #region [Init]

        private void Init()
        {
            _gitCommandManager = new GitCommandManager(@"" + app.AppSettings["git:exepath"], @"" + app.AppSettings["git:workingdirectory"]);
            _msBuildManager = new MsBuildManager(@"" + app.AppSettings["msbuild:exepath"]);

            projectLabel.Text = app.AppSettings["project"];
            gitBranchLabel.Text = app.AppSettings["git:branch"];
            environmentLabel.Text = app.AppSettings["environment"];
        }

        #endregion

        #region [Events]

        private void runButton_Click(object sender, EventArgs e)
        {
            var thread = new Thread(new ThreadStart(Run));
            thread.Start();
        }

        #endregion

        #region [Custom Private Functions]

        private void Run()
        {
            if (gitPullCheckBox.Checked)
            {
                Log("Git pull is in progress..");
                if (!Pull()) 
                {
                    Log("Git pull exited with error, process terminated");
                    return;
                }
                Log("Git pull completed");
                LogEnd();
            }
            if (buildCheckBox.Checked)
            {
                Log("Project build is in progress..");
                if (!Build())
                {
                    Log("Build project exited with error, process terminated");
                    return;
                }
                Log("Project build completed");
                LogEnd();
            }
        }

        private bool Pull()
        {
            var output = string.Empty;
            var error = string.Empty;
            var result = _gitCommandManager.Pull("pull origin " + app.AppSettings["git:branch"], out output, out error);
            Log(result ? output : error);
            return result;
        }

        private bool Build()
        {
            var output = string.Empty;
            var error = string.Empty;
            var result = _msBuildManager.Build(@"" + app.AppSettings["msbuild:solutionpath"], out output, out error);
            Log(result ? output : error);
            return result;
        }

        private bool Publish()
        {
            var output = string.Empty;
            var error = string.Empty;
            var result = _msBuildManager.Publish(@"" + app.AppSettings["msbuild:projectpath"] + @" /p:DeployOnBuild=true /p:PublishProfile=" + app.AppSettings["msbuild:publishprofile"],
                out output, out error);
            Log(result ? output : error);
            return result;
        }

        private void Log(string message)
        {
            logTextBox.Text += Environment.NewLine + message;
        }

        private void LogEnd()
        {
            logTextBox.Text += Environment.NewLine + "------------------------------------------------------" 
                + Environment.NewLine;
        }

        #endregion
    }
}
