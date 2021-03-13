namespace VsDeploymentAutomation
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gitPullCheckBox = new System.Windows.Forms.CheckBox();
            this.buildCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gitBranchLabel = new System.Windows.Forms.Label();
            this.projectLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.environmentLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.inCheckBox = new System.Windows.Forms.CheckBox();
            this.phCheckBox = new System.Windows.Forms.CheckBox();
            this.ghCheckBox = new System.Windows.Forms.CheckBox();
            this.ugCheckBox = new System.Windows.Forms.CheckBox();
            this.tzCheckBox = new System.Windows.Forms.CheckBox();
            this.ngCheckBox = new System.Windows.Forms.CheckBox();
            this.slCheckBox = new System.Windows.Forms.CheckBox();
            this.zmCheckBox = new System.Windows.Forms.CheckBox();
            this.rwCheckBox = new System.Windows.Forms.CheckBox();
            this.keCheckBox = new System.Windows.Forms.CheckBox();
            this.mmCheckBox = new System.Windows.Forms.CheckBox();
            this.lkCheckBox = new System.Windows.Forms.CheckBox();
            this.pkCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buildCheckBox);
            this.groupBox1.Controls.Add(this.gitPullCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pre-deployment Tasks";
            // 
            // gitPullCheckBox
            // 
            this.gitPullCheckBox.AutoSize = true;
            this.gitPullCheckBox.Location = new System.Drawing.Point(31, 41);
            this.gitPullCheckBox.Name = "gitPullCheckBox";
            this.gitPullCheckBox.Size = new System.Drawing.Size(75, 21);
            this.gitPullCheckBox.TabIndex = 0;
            this.gitPullCheckBox.Text = "Git Pull";
            this.gitPullCheckBox.UseVisualStyleBackColor = true;
            // 
            // buildCheckBox
            // 
            this.buildCheckBox.AutoSize = true;
            this.buildCheckBox.Location = new System.Drawing.Point(155, 41);
            this.buildCheckBox.Name = "buildCheckBox";
            this.buildCheckBox.Size = new System.Drawing.Size(109, 21);
            this.buildCheckBox.TabIndex = 1;
            this.buildCheckBox.Text = "Build Project";
            this.buildCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.environmentLabel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.projectLabel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.gitBranchLabel);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(430, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(730, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Configuration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Git Branch";
            // 
            // gitBranchLabel
            // 
            this.gitBranchLabel.AutoSize = true;
            this.gitBranchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gitBranchLabel.Location = new System.Drawing.Point(303, 40);
            this.gitBranchLabel.Name = "gitBranchLabel";
            this.gitBranchLabel.Size = new System.Drawing.Size(69, 18);
            this.gitBranchLabel.TabIndex = 1;
            this.gitBranchLabel.Text = "Develop";
            // 
            // projectLabel
            // 
            this.projectLabel.AutoSize = true;
            this.projectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectLabel.Location = new System.Drawing.Point(83, 40);
            this.projectLabel.Name = "projectLabel";
            this.projectLabel.Size = new System.Drawing.Size(99, 18);
            this.projectLabel.TabIndex = 3;
            this.projectLabel.Text = "AMBS (ALL)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Project";
            // 
            // environmentLabel
            // 
            this.environmentLabel.AutoSize = true;
            this.environmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.environmentLabel.Location = new System.Drawing.Point(516, 38);
            this.environmentLabel.Name = "environmentLabel";
            this.environmentLabel.Size = new System.Drawing.Size(106, 18);
            this.environmentLabel.TabIndex = 5;
            this.environmentLabel.Text = "Development";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Environment";
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
            this.groupBox3.Location = new System.Drawing.Point(12, 129);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(389, 457);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Deployment Entities";
            // 
            // inCheckBox
            // 
            this.inCheckBox.AutoSize = true;
            this.inCheckBox.Location = new System.Drawing.Point(31, 50);
            this.inCheckBox.Name = "inCheckBox";
            this.inCheckBox.Size = new System.Drawing.Size(65, 21);
            this.inCheckBox.TabIndex = 1;
            this.inCheckBox.Text = "INDIA";
            this.inCheckBox.UseVisualStyleBackColor = true;
            // 
            // phCheckBox
            // 
            this.phCheckBox.AutoSize = true;
            this.phCheckBox.Location = new System.Drawing.Point(31, 92);
            this.phCheckBox.Name = "phCheckBox";
            this.phCheckBox.Size = new System.Drawing.Size(112, 21);
            this.phCheckBox.TabIndex = 2;
            this.phCheckBox.Text = "PHILIPPINES";
            this.phCheckBox.UseVisualStyleBackColor = true;
            // 
            // ghCheckBox
            // 
            this.ghCheckBox.AutoSize = true;
            this.ghCheckBox.Location = new System.Drawing.Point(31, 136);
            this.ghCheckBox.Name = "ghCheckBox";
            this.ghCheckBox.Size = new System.Drawing.Size(79, 21);
            this.ghCheckBox.TabIndex = 3;
            this.ghCheckBox.Text = "GHANA";
            this.ghCheckBox.UseVisualStyleBackColor = true;
            // 
            // ugCheckBox
            // 
            this.ugCheckBox.AutoSize = true;
            this.ugCheckBox.Location = new System.Drawing.Point(31, 266);
            this.ugCheckBox.Name = "ugCheckBox";
            this.ugCheckBox.Size = new System.Drawing.Size(89, 21);
            this.ugCheckBox.TabIndex = 6;
            this.ugCheckBox.Text = "UGANDA";
            this.ugCheckBox.UseVisualStyleBackColor = true;
            // 
            // tzCheckBox
            // 
            this.tzCheckBox.AutoSize = true;
            this.tzCheckBox.Location = new System.Drawing.Point(31, 222);
            this.tzCheckBox.Name = "tzCheckBox";
            this.tzCheckBox.Size = new System.Drawing.Size(98, 21);
            this.tzCheckBox.TabIndex = 5;
            this.tzCheckBox.Text = "TANZANIA";
            this.tzCheckBox.UseVisualStyleBackColor = true;
            // 
            // ngCheckBox
            // 
            this.ngCheckBox.AutoSize = true;
            this.ngCheckBox.Location = new System.Drawing.Point(31, 180);
            this.ngCheckBox.Name = "ngCheckBox";
            this.ngCheckBox.Size = new System.Drawing.Size(85, 21);
            this.ngCheckBox.TabIndex = 4;
            this.ngCheckBox.Text = "NIGERIA";
            this.ngCheckBox.UseVisualStyleBackColor = true;
            // 
            // slCheckBox
            // 
            this.slCheckBox.AutoSize = true;
            this.slCheckBox.Location = new System.Drawing.Point(31, 397);
            this.slCheckBox.Name = "slCheckBox";
            this.slCheckBox.Size = new System.Drawing.Size(122, 21);
            this.slCheckBox.TabIndex = 9;
            this.slCheckBox.Text = "SIERRA LEON";
            this.slCheckBox.UseVisualStyleBackColor = true;
            // 
            // zmCheckBox
            // 
            this.zmCheckBox.AutoSize = true;
            this.zmCheckBox.Location = new System.Drawing.Point(31, 353);
            this.zmCheckBox.Name = "zmCheckBox";
            this.zmCheckBox.Size = new System.Drawing.Size(80, 21);
            this.zmCheckBox.TabIndex = 8;
            this.zmCheckBox.Text = "ZAMBIA";
            this.zmCheckBox.UseVisualStyleBackColor = true;
            // 
            // rwCheckBox
            // 
            this.rwCheckBox.AutoSize = true;
            this.rwCheckBox.Location = new System.Drawing.Point(31, 311);
            this.rwCheckBox.Name = "rwCheckBox";
            this.rwCheckBox.Size = new System.Drawing.Size(91, 21);
            this.rwCheckBox.TabIndex = 7;
            this.rwCheckBox.Text = "RWANDA";
            this.rwCheckBox.UseVisualStyleBackColor = true;
            // 
            // keCheckBox
            // 
            this.keCheckBox.AutoSize = true;
            this.keCheckBox.Location = new System.Drawing.Point(189, 136);
            this.keCheckBox.Name = "keCheckBox";
            this.keCheckBox.Size = new System.Drawing.Size(76, 21);
            this.keCheckBox.TabIndex = 12;
            this.keCheckBox.Text = "KENYA";
            this.keCheckBox.UseVisualStyleBackColor = true;
            // 
            // mmCheckBox
            // 
            this.mmCheckBox.AutoSize = true;
            this.mmCheckBox.Location = new System.Drawing.Point(189, 92);
            this.mmCheckBox.Name = "mmCheckBox";
            this.mmCheckBox.Size = new System.Drawing.Size(99, 21);
            this.mmCheckBox.TabIndex = 11;
            this.mmCheckBox.Text = "MYANMAR";
            this.mmCheckBox.UseVisualStyleBackColor = true;
            // 
            // lkCheckBox
            // 
            this.lkCheckBox.AutoSize = true;
            this.lkCheckBox.Location = new System.Drawing.Point(189, 50);
            this.lkCheckBox.Name = "lkCheckBox";
            this.lkCheckBox.Size = new System.Drawing.Size(101, 21);
            this.lkCheckBox.TabIndex = 10;
            this.lkCheckBox.Text = "SRI LANKA";
            this.lkCheckBox.UseVisualStyleBackColor = true;
            // 
            // pkCheckBox
            // 
            this.pkCheckBox.AutoSize = true;
            this.pkCheckBox.Location = new System.Drawing.Point(189, 180);
            this.pkCheckBox.Name = "pkCheckBox";
            this.pkCheckBox.Size = new System.Drawing.Size(97, 21);
            this.pkCheckBox.TabIndex = 13;
            this.pkCheckBox.Text = "PAKISTAN";
            this.pkCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 713);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AMBS Deployment Automation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox buildCheckBox;
        private System.Windows.Forms.CheckBox gitPullCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label projectLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label gitBranchLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label environmentLabel;
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
    }
}

