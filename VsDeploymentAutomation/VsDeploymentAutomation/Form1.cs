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
using System.IO;

namespace VsDeploymentAutomation
{
    public partial class MainForm : Form
    {
        private IGitCommandManager _gitCommandManager;
        private IMsBuildManager _msBuildManager;
        private List<CheckBox> _countryCheckBoxes;
        private int _step = 0;
        private string _root;
        private string _log;

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

            _root = Application.StartupPath;
            _log = _root + "\\log_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".log";
        }

        #endregion

        #region [Events]

        private void runButton_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            progressBar.Visible = true;
            _step = CalculateProgressBarProgressStep();
            progressBar.Value += _step;
            var thread = new Thread(new ThreadStart(Run));
            thread.Start();
        }

        private void logTextBox_TextChanged(object sender, EventArgs e)
        {
            logTextBox.SelectionStart = logTextBox.Text.Length;
            logTextBox.ScrollToCaret();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Reset();
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
                    progressBar.Visible = false;
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
                    progressBar.Visible = false;
                    return;
                }
                Log("Project build completed");
                LogEnd();
            }

            foreach (var checkBox in _countryCheckBoxes)
            {
                if (checkBox.Checked)
                {
                    if (!replaceConfigCheckBox.Checked)
                        CopyWebConfig(app.AppSettings["msbuild:" + checkBox.Name.Replace("CheckBox", "").ToUpper() + ":publishpath"] + "\\Web.config",
                            _root + "\\Web.config");
                    PublishProcess(checkBox.Name.Replace("CheckBox", "").ToUpper());
                    if (!replaceConfigCheckBox.Checked)
                        CopyWebConfig(_root + "\\Web.config",
                            app.AppSettings["msbuild:" + checkBox.Name.Replace("CheckBox", "").ToUpper() + ":publishpath"] + "\\Web.config");
                }
            }

            Log("Process Completed");
            progressBar.Value = 100;
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

        private void Reset()
        {
            progressBar.Visible = false;
            progressBar.Value = 0;
            gitPullCheckBox.Checked = buildCheckBox.Checked = logCheckBox.Checked = true;
            replaceConfigCheckBox.Checked = false;
            logTextBox.Text = string.Empty;
            _countryCheckBoxes.ForEach(c => { c.Checked = false; });
        }

        private void Log(string message)
        {
            logTextBox.Text += Environment.NewLine + message;
            if (logCheckBox.Checked) File.AppendAllText(_log, Environment.NewLine + message);
            progressBar.Value = (progressBar.Value + _step) < 100 ? (progressBar.Value + _step) : 100;
        }

        private void LogEnd()
        {
            logTextBox.Text += Environment.NewLine + ">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>" 
                + Environment.NewLine;
            if (logCheckBox.Checked) File.AppendAllText(_log, Environment.NewLine + ">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>"
                + Environment.NewLine);
        }

        private int CalculateProgressBarProgressStep()
        {
            var n = 0;
            n += (gitPullCheckBox.Checked ? 1 : 0);
            n += (buildCheckBox.Checked ? 1 : 0);

            foreach(var checkBox in _countryCheckBoxes)
                n += (checkBox.Checked ? 1 : 0);

            return n;
        }

        private void CopyWebConfig(string source, string destination)
        {
            if(File.Exists(source))
                File.Copy(source, destination, true);
        }

        #endregion
    }
}
