﻿namespace VsDeploymentAutomation
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buildCheckBox = new System.Windows.Forms.CheckBox();
            this.gitPullCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gitComboBox = new System.Windows.Forms.ComboBox();
            this.comboItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.envComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.projectLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pkCheckBox = new System.Windows.Forms.CheckBox();
            this.keCheckBox = new System.Windows.Forms.CheckBox();
            this.mmCheckBox = new System.Windows.Forms.CheckBox();
            this.lkCheckBox = new System.Windows.Forms.CheckBox();
            this.slCheckBox = new System.Windows.Forms.CheckBox();
            this.zmCheckBox = new System.Windows.Forms.CheckBox();
            this.rwCheckBox = new System.Windows.Forms.CheckBox();
            this.ugCheckBox = new System.Windows.Forms.CheckBox();
            this.tzCheckBox = new System.Windows.Forms.CheckBox();
            this.ngCheckBox = new System.Windows.Forms.CheckBox();
            this.ghCheckBox = new System.Windows.Forms.CheckBox();
            this.phCheckBox = new System.Windows.Forms.CheckBox();
            this.inCheckBox = new System.Windows.Forms.CheckBox();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.runButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.logCheckBox = new System.Windows.Forms.CheckBox();
            this.replaceConfigCheckBox = new System.Windows.Forms.CheckBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tabCheckBox = new System.Windows.Forms.CheckBox();
            this.webCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboItemBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buildCheckBox);
            this.groupBox1.Controls.Add(this.gitPullCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(9, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(136, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pre-deployment Tasks";
            // 
            // buildCheckBox
            // 
            this.buildCheckBox.AutoSize = true;
            this.buildCheckBox.Checked = true;
            this.buildCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.buildCheckBox.Location = new System.Drawing.Point(13, 52);
            this.buildCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buildCheckBox.Name = "buildCheckBox";
            this.buildCheckBox.Size = new System.Drawing.Size(85, 17);
            this.buildCheckBox.TabIndex = 1;
            this.buildCheckBox.Text = "Build Project";
            this.buildCheckBox.UseVisualStyleBackColor = true;
            // 
            // gitPullCheckBox
            // 
            this.gitPullCheckBox.AutoSize = true;
            this.gitPullCheckBox.Checked = true;
            this.gitPullCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gitPullCheckBox.Location = new System.Drawing.Point(15, 23);
            this.gitPullCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gitPullCheckBox.Name = "gitPullCheckBox";
            this.gitPullCheckBox.Size = new System.Drawing.Size(59, 17);
            this.gitPullCheckBox.TabIndex = 0;
            this.gitPullCheckBox.Text = "Git Pull";
            this.gitPullCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gitComboBox);
            this.groupBox2.Controls.Add(this.envComboBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.projectLabel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(467, 19);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(518, 81);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Configuration";
            // 
            // gitComboBox
            // 
            this.gitComboBox.DataSource = this.comboItemBindingSource;
            this.gitComboBox.DisplayMember = "Id";
            this.gitComboBox.FormattingEnabled = true;
            this.gitComboBox.Location = new System.Drawing.Point(205, 36);
            this.gitComboBox.Name = "gitComboBox";
            this.gitComboBox.Size = new System.Drawing.Size(111, 21);
            this.gitComboBox.TabIndex = 7;
            this.gitComboBox.ValueMember = "Value";
            // 
            // comboItemBindingSource
            // 
            this.comboItemBindingSource.DataSource = typeof(VsDeploymentAutomation.Models.ComboItem);
            // 
            // envComboBox
            // 
            this.envComboBox.DataSource = this.comboItemBindingSource;
            this.envComboBox.DisplayMember = "Id";
            this.envComboBox.FormattingEnabled = true;
            this.envComboBox.Location = new System.Drawing.Point(392, 36);
            this.envComboBox.Name = "envComboBox";
            this.envComboBox.Size = new System.Drawing.Size(121, 21);
            this.envComboBox.TabIndex = 6;
            this.envComboBox.ValueMember = "Value";
            this.envComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Environment";
            // 
            // projectLabel
            // 
            this.projectLabel.AutoSize = true;
            this.projectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectLabel.Location = new System.Drawing.Point(56, 36);
            this.projectLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.projectLabel.Name = "projectLabel";
            this.projectLabel.Size = new System.Drawing.Size(83, 15);
            this.projectLabel.TabIndex = 3;
            this.projectLabel.Text = "AMBS (ALL)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Project";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Git Branch";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pkCheckBox);
            this.groupBox3.Controls.Add(this.keCheckBox);
            this.groupBox3.Controls.Add(this.mmCheckBox);
            this.groupBox3.Controls.Add(this.lkCheckBox);
            this.groupBox3.Controls.Add(this.slCheckBox);
            this.groupBox3.Controls.Add(this.zmCheckBox);
            this.groupBox3.Controls.Add(this.rwCheckBox);
            this.groupBox3.Controls.Add(this.ugCheckBox);
            this.groupBox3.Controls.Add(this.tzCheckBox);
            this.groupBox3.Controls.Add(this.ngCheckBox);
            this.groupBox3.Controls.Add(this.ghCheckBox);
            this.groupBox3.Controls.Add(this.phCheckBox);
            this.groupBox3.Controls.Add(this.inCheckBox);
            this.groupBox3.Location = new System.Drawing.Point(9, 105);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Size = new System.Drawing.Size(292, 371);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Deployment Entities";
            // 
            // pkCheckBox
            // 
            this.pkCheckBox.AutoSize = true;
            this.pkCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkCheckBox.ForeColor = System.Drawing.Color.Blue;
            this.pkCheckBox.Location = new System.Drawing.Point(142, 146);
            this.pkCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pkCheckBox.Name = "pkCheckBox";
            this.pkCheckBox.Size = new System.Drawing.Size(83, 19);
            this.pkCheckBox.TabIndex = 13;
            this.pkCheckBox.Text = "PAKISTAN";
            this.pkCheckBox.UseVisualStyleBackColor = true;
            // 
            // keCheckBox
            // 
            this.keCheckBox.AutoSize = true;
            this.keCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keCheckBox.ForeColor = System.Drawing.Color.Blue;
            this.keCheckBox.Location = new System.Drawing.Point(142, 110);
            this.keCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.keCheckBox.Name = "keCheckBox";
            this.keCheckBox.Size = new System.Drawing.Size(65, 19);
            this.keCheckBox.TabIndex = 12;
            this.keCheckBox.Text = "KENYA";
            this.keCheckBox.UseVisualStyleBackColor = true;
            // 
            // mmCheckBox
            // 
            this.mmCheckBox.AutoSize = true;
            this.mmCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmCheckBox.ForeColor = System.Drawing.Color.Blue;
            this.mmCheckBox.Location = new System.Drawing.Point(142, 75);
            this.mmCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mmCheckBox.Name = "mmCheckBox";
            this.mmCheckBox.Size = new System.Drawing.Size(87, 19);
            this.mmCheckBox.TabIndex = 11;
            this.mmCheckBox.Text = "MYANMAR";
            this.mmCheckBox.UseVisualStyleBackColor = true;
            // 
            // lkCheckBox
            // 
            this.lkCheckBox.AutoSize = true;
            this.lkCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkCheckBox.ForeColor = System.Drawing.Color.Blue;
            this.lkCheckBox.Location = new System.Drawing.Point(142, 40);
            this.lkCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lkCheckBox.Name = "lkCheckBox";
            this.lkCheckBox.Size = new System.Drawing.Size(87, 19);
            this.lkCheckBox.TabIndex = 10;
            this.lkCheckBox.Text = "SRI LANKA";
            this.lkCheckBox.UseVisualStyleBackColor = true;
            // 
            // slCheckBox
            // 
            this.slCheckBox.AutoSize = true;
            this.slCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slCheckBox.ForeColor = System.Drawing.Color.Blue;
            this.slCheckBox.Location = new System.Drawing.Point(23, 322);
            this.slCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.slCheckBox.Name = "slCheckBox";
            this.slCheckBox.Size = new System.Drawing.Size(106, 19);
            this.slCheckBox.TabIndex = 9;
            this.slCheckBox.Text = "SIERRA LEON";
            this.slCheckBox.UseVisualStyleBackColor = true;
            // 
            // zmCheckBox
            // 
            this.zmCheckBox.AutoSize = true;
            this.zmCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zmCheckBox.ForeColor = System.Drawing.Color.Blue;
            this.zmCheckBox.Location = new System.Drawing.Point(23, 287);
            this.zmCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.zmCheckBox.Name = "zmCheckBox";
            this.zmCheckBox.Size = new System.Drawing.Size(69, 19);
            this.zmCheckBox.TabIndex = 8;
            this.zmCheckBox.Text = "ZAMBIA";
            this.zmCheckBox.UseVisualStyleBackColor = true;
            // 
            // rwCheckBox
            // 
            this.rwCheckBox.AutoSize = true;
            this.rwCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rwCheckBox.ForeColor = System.Drawing.Color.Blue;
            this.rwCheckBox.Location = new System.Drawing.Point(23, 253);
            this.rwCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rwCheckBox.Name = "rwCheckBox";
            this.rwCheckBox.Size = new System.Drawing.Size(78, 19);
            this.rwCheckBox.TabIndex = 7;
            this.rwCheckBox.Text = "RWANDA";
            this.rwCheckBox.UseVisualStyleBackColor = true;
            // 
            // ugCheckBox
            // 
            this.ugCheckBox.AutoSize = true;
            this.ugCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ugCheckBox.ForeColor = System.Drawing.Color.Blue;
            this.ugCheckBox.Location = new System.Drawing.Point(23, 216);
            this.ugCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ugCheckBox.Name = "ugCheckBox";
            this.ugCheckBox.Size = new System.Drawing.Size(76, 19);
            this.ugCheckBox.TabIndex = 6;
            this.ugCheckBox.Text = "UGANDA";
            this.ugCheckBox.UseVisualStyleBackColor = true;
            // 
            // tzCheckBox
            // 
            this.tzCheckBox.AutoSize = true;
            this.tzCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tzCheckBox.ForeColor = System.Drawing.Color.Blue;
            this.tzCheckBox.Location = new System.Drawing.Point(23, 181);
            this.tzCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tzCheckBox.Name = "tzCheckBox";
            this.tzCheckBox.Size = new System.Drawing.Size(82, 19);
            this.tzCheckBox.TabIndex = 5;
            this.tzCheckBox.Text = "TANZANIA";
            this.tzCheckBox.UseVisualStyleBackColor = true;
            // 
            // ngCheckBox
            // 
            this.ngCheckBox.AutoSize = true;
            this.ngCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngCheckBox.ForeColor = System.Drawing.Color.Blue;
            this.ngCheckBox.Location = new System.Drawing.Point(23, 146);
            this.ngCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ngCheckBox.Name = "ngCheckBox";
            this.ngCheckBox.Size = new System.Drawing.Size(74, 19);
            this.ngCheckBox.TabIndex = 4;
            this.ngCheckBox.Text = "NIGERIA";
            this.ngCheckBox.UseVisualStyleBackColor = true;
            // 
            // ghCheckBox
            // 
            this.ghCheckBox.AutoSize = true;
            this.ghCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ghCheckBox.ForeColor = System.Drawing.Color.Blue;
            this.ghCheckBox.Location = new System.Drawing.Point(23, 110);
            this.ghCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ghCheckBox.Name = "ghCheckBox";
            this.ghCheckBox.Size = new System.Drawing.Size(67, 19);
            this.ghCheckBox.TabIndex = 3;
            this.ghCheckBox.Text = "GHANA";
            this.ghCheckBox.UseVisualStyleBackColor = true;
            // 
            // phCheckBox
            // 
            this.phCheckBox.AutoSize = true;
            this.phCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phCheckBox.ForeColor = System.Drawing.Color.Blue;
            this.phCheckBox.Location = new System.Drawing.Point(23, 75);
            this.phCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.phCheckBox.Name = "phCheckBox";
            this.phCheckBox.Size = new System.Drawing.Size(100, 19);
            this.phCheckBox.TabIndex = 2;
            this.phCheckBox.Text = "PHILIPPINES";
            this.phCheckBox.UseVisualStyleBackColor = true;
            // 
            // inCheckBox
            // 
            this.inCheckBox.AutoSize = true;
            this.inCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inCheckBox.ForeColor = System.Drawing.Color.Blue;
            this.inCheckBox.Location = new System.Drawing.Point(23, 40);
            this.inCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.inCheckBox.Name = "inCheckBox";
            this.inCheckBox.Size = new System.Drawing.Size(57, 19);
            this.inCheckBox.TabIndex = 1;
            this.inCheckBox.Text = "INDIA";
            this.inCheckBox.UseVisualStyleBackColor = true;
            // 
            // logTextBox
            // 
            this.logTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logTextBox.ForeColor = System.Drawing.Color.Teal;
            this.logTextBox.Location = new System.Drawing.Point(334, 111);
            this.logTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox.Size = new System.Drawing.Size(651, 365);
            this.logTextBox.TabIndex = 3;
            this.logTextBox.TextChanged += new System.EventHandler(this.logTextBox_TextChanged);
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(201, 491);
            this.runButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(100, 30);
            this.runButton.TabIndex = 4;
            this.runButton.Text = "RUN";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.logCheckBox);
            this.groupBox4.Controls.Add(this.replaceConfigCheckBox);
            this.groupBox4.Location = new System.Drawing.Point(156, 19);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Size = new System.Drawing.Size(141, 81);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Post-deployment Tasks";
            // 
            // logCheckBox
            // 
            this.logCheckBox.AutoSize = true;
            this.logCheckBox.Checked = true;
            this.logCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.logCheckBox.Location = new System.Drawing.Point(15, 52);
            this.logCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.logCheckBox.Name = "logCheckBox";
            this.logCheckBox.Size = new System.Drawing.Size(44, 17);
            this.logCheckBox.TabIndex = 3;
            this.logCheckBox.Text = "Log";
            this.logCheckBox.UseVisualStyleBackColor = true;
            // 
            // replaceConfigCheckBox
            // 
            this.replaceConfigCheckBox.AutoSize = true;
            this.replaceConfigCheckBox.Location = new System.Drawing.Point(15, 25);
            this.replaceConfigCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.replaceConfigCheckBox.Name = "replaceConfigCheckBox";
            this.replaceConfigCheckBox.Size = new System.Drawing.Size(125, 17);
            this.replaceConfigCheckBox.TabIndex = 2;
            this.replaceConfigCheckBox.Text = "Replace Web Config";
            this.replaceConfigCheckBox.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(87, 491);
            this.resetButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(100, 30);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(323, 491);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(547, 25);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 7;
            this.progressBar.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tabCheckBox);
            this.groupBox5.Controls.Add(this.webCheckBox);
            this.groupBox5.Location = new System.Drawing.Point(312, 19);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox5.Size = new System.Drawing.Size(141, 81);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Applications";
            // 
            // tabCheckBox
            // 
            this.tabCheckBox.AutoSize = true;
            this.tabCheckBox.Checked = true;
            this.tabCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tabCheckBox.Location = new System.Drawing.Point(15, 52);
            this.tabCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabCheckBox.Name = "tabCheckBox";
            this.tabCheckBox.Size = new System.Drawing.Size(45, 17);
            this.tabCheckBox.TabIndex = 3;
            this.tabCheckBox.Text = "Tab";
            this.tabCheckBox.UseVisualStyleBackColor = true;
            this.tabCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // webCheckBox
            // 
            this.webCheckBox.AutoSize = true;
            this.webCheckBox.Location = new System.Drawing.Point(15, 25);
            this.webCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.webCheckBox.Name = "webCheckBox";
            this.webCheckBox.Size = new System.Drawing.Size(49, 17);
            this.webCheckBox.TabIndex = 2;
            this.webCheckBox.Text = "Web";
            this.webCheckBox.UseVisualStyleBackColor = true;
            this.webCheckBox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 550);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AMBS Deployment Automation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboItemBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox buildCheckBox;
        private System.Windows.Forms.CheckBox gitPullCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label projectLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox pkCheckBox;
        private System.Windows.Forms.CheckBox keCheckBox;
        private System.Windows.Forms.CheckBox mmCheckBox;
        private System.Windows.Forms.CheckBox lkCheckBox;
        private System.Windows.Forms.CheckBox slCheckBox;
        private System.Windows.Forms.CheckBox zmCheckBox;
        private System.Windows.Forms.CheckBox rwCheckBox;
        private System.Windows.Forms.CheckBox ugCheckBox;
        private System.Windows.Forms.CheckBox tzCheckBox;
        private System.Windows.Forms.CheckBox ngCheckBox;
        private System.Windows.Forms.CheckBox ghCheckBox;
        private System.Windows.Forms.CheckBox phCheckBox;
        private System.Windows.Forms.CheckBox inCheckBox;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox replaceConfigCheckBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.CheckBox logCheckBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox tabCheckBox;
        private System.Windows.Forms.CheckBox webCheckBox;
        private System.Windows.Forms.ComboBox envComboBox;
        private System.Windows.Forms.BindingSource comboItemBindingSource;
        private System.Windows.Forms.ComboBox gitComboBox;
    }
}

