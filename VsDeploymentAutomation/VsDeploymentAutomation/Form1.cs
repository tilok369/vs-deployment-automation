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
        private List<CheckBox> _countryCheckBoxes;

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

            _countryCheckBoxes = new List<CheckBox> { inCheckBox, phCheckBox, ghCheckBox, ngCheckBox, tzCheckBox,
                ugCheckBox, rwCheckBox, zmCheckBox, slCheckBox, lkCheckBox, mmCheckBox, keCheckBox, pkCheckBox };
        }

        #endregion

        #region [Events]

        private void runButton_Click(object sender, EventArgs e)
        {
            var thread = new Thread(new ThreadStart(Run));
            thread.Start();
        }

        private void logTextBox_TextChanged(object sender, EventArgs e)
        {
            logTextBox.SelectionStart = logTextBox.Text.Length;
            logTextBox.ScrollToCaret();
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

            foreach (var checkBox in _countryCheckBoxes)
            {
                if (checkBox.Checked)
                    PublishProcess(checkBox.Name.Replace("CheckBox", "").ToUpper());
            }

            Log("Process Completed");
        }

        private void PublishProcess(string countryCode)
        {
            Log("Project publish is in progress for " + countryCode + "..");
            if (!Publish(app.AppSettings["msbuild:" + countryCode + ":publishprofile"]))
            {
                Log("Publish project exited with error, process terminated for " + countryCode);
                return;
            }
            Log("Project publish completed for " + countryCode);
            LogEnd();
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

        private bool Publish(string publishProfile)
        {
            var output = string.Empty;
            var error = string.Empty;
            var result = _msBuildManager.Publish(@"" + app.AppSettings["msbuild:projectpath"] + @" /p:DeployOnBuild=true /p:PublishProfile=" + publishProfile,
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
            logTextBox.Text += Environment.NewLine + ">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>" 
                + Environment.NewLine;
        }

        #endregion
    }
}
