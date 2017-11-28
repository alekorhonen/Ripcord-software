namespace Ripcord.Assets.Forms
{
    partial class Checkers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checkers));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setActiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCheckerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCheckerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJudgeURL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblJudgeStatus = new System.Windows.Forms.Label();
            this.btnTestJudge = new System.Windows.Forms.Button();
            this.gbSSLCheck = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSSLUrl = new System.Windows.Forms.TextBox();
            this.txtSSLKeyword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGeolocation = new System.Windows.Forms.TextBox();
            this.gbGeoRegex = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGeoCountry = new System.Windows.Forms.TextBox();
            this.txtGeoRegion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGeoCity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSSL = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1.SuspendLayout();
            this.gbSettings.SuspendLayout();
            this.gbSSLCheck.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbGeoRegex.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setActiveToolStripMenuItem,
            this.editCheckerToolStripMenuItem,
            this.newCheckerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(143, 70);
            // 
            // setActiveToolStripMenuItem
            // 
            this.setActiveToolStripMenuItem.Name = "setActiveToolStripMenuItem";
            this.setActiveToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.setActiveToolStripMenuItem.Text = "Set active";
            // 
            // editCheckerToolStripMenuItem
            // 
            this.editCheckerToolStripMenuItem.Name = "editCheckerToolStripMenuItem";
            this.editCheckerToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.editCheckerToolStripMenuItem.Text = "Edit checker";
            // 
            // newCheckerToolStripMenuItem
            // 
            this.newCheckerToolStripMenuItem.Name = "newCheckerToolStripMenuItem";
            this.newCheckerToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.newCheckerToolStripMenuItem.Text = "New checker";
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.groupBox1);
            this.gbSettings.Controls.Add(this.gbSSLCheck);
            this.gbSettings.Controls.Add(this.btnTestJudge);
            this.gbSettings.Controls.Add(this.lblJudgeStatus);
            this.gbSettings.Controls.Add(this.label2);
            this.gbSettings.Controls.Add(this.txtJudgeURL);
            this.gbSettings.Controls.Add(this.label1);
            this.gbSettings.Location = new System.Drawing.Point(12, 12);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(427, 396);
            this.gbSettings.TabIndex = 2;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Checker";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Judge URL:";
            // 
            // txtJudgeURL
            // 
            this.txtJudgeURL.Location = new System.Drawing.Point(99, 28);
            this.txtJudgeURL.Name = "txtJudgeURL";
            this.txtJudgeURL.Size = new System.Drawing.Size(304, 20);
            this.txtJudgeURL.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Judge status:";
            // 
            // lblJudgeStatus
            // 
            this.lblJudgeStatus.AutoSize = true;
            this.lblJudgeStatus.ForeColor = System.Drawing.Color.Red;
            this.lblJudgeStatus.Location = new System.Drawing.Point(96, 63);
            this.lblJudgeStatus.Name = "lblJudgeStatus";
            this.lblJudgeStatus.Size = new System.Drawing.Size(56, 13);
            this.lblJudgeStatus.TabIndex = 3;
            this.lblJudgeStatus.Text = "Not tested";
            // 
            // btnTestJudge
            // 
            this.btnTestJudge.Location = new System.Drawing.Point(328, 58);
            this.btnTestJudge.Name = "btnTestJudge";
            this.btnTestJudge.Size = new System.Drawing.Size(75, 23);
            this.btnTestJudge.TabIndex = 4;
            this.btnTestJudge.Text = "Check";
            this.btnTestJudge.UseVisualStyleBackColor = true;
            this.btnTestJudge.Click += new System.EventHandler(this.btnTestJudge_Click);
            // 
            // gbSSLCheck
            // 
            this.gbSSLCheck.Controls.Add(this.cbSSL);
            this.gbSSLCheck.Controls.Add(this.txtSSLKeyword);
            this.gbSSLCheck.Controls.Add(this.label4);
            this.gbSSLCheck.Controls.Add(this.txtSSLUrl);
            this.gbSSLCheck.Controls.Add(this.label3);
            this.gbSSLCheck.Location = new System.Drawing.Point(26, 99);
            this.gbSSLCheck.Name = "gbSSLCheck";
            this.gbSSLCheck.Size = new System.Drawing.Size(377, 93);
            this.gbSSLCheck.TabIndex = 5;
            this.gbSSLCheck.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "URL:";
            // 
            // txtSSLUrl
            // 
            this.txtSSLUrl.Location = new System.Drawing.Point(82, 25);
            this.txtSSLUrl.Name = "txtSSLUrl";
            this.txtSSLUrl.Size = new System.Drawing.Size(280, 20);
            this.txtSSLUrl.TabIndex = 7;
            // 
            // txtSSLKeyword
            // 
            this.txtSSLKeyword.Location = new System.Drawing.Point(82, 55);
            this.txtSSLKeyword.Name = "txtSSLKeyword";
            this.txtSSLKeyword.Size = new System.Drawing.Size(280, 20);
            this.txtSSLKeyword.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Keyword:";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(115, 417);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(83, 27);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(252, 417);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 27);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbGeoRegex);
            this.groupBox1.Controls.Add(this.txtGeolocation);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(26, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 173);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Geolocation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "URL:";
            // 
            // txtGeolocation
            // 
            this.txtGeolocation.Location = new System.Drawing.Point(82, 23);
            this.txtGeolocation.Name = "txtGeolocation";
            this.txtGeolocation.Size = new System.Drawing.Size(280, 20);
            this.txtGeolocation.TabIndex = 8;
            // 
            // gbGeoRegex
            // 
            this.gbGeoRegex.Controls.Add(this.txtGeoCity);
            this.gbGeoRegex.Controls.Add(this.label8);
            this.gbGeoRegex.Controls.Add(this.txtGeoRegion);
            this.gbGeoRegex.Controls.Add(this.label7);
            this.gbGeoRegex.Controls.Add(this.txtGeoCountry);
            this.gbGeoRegex.Controls.Add(this.label6);
            this.gbGeoRegex.Location = new System.Drawing.Point(14, 49);
            this.gbGeoRegex.Name = "gbGeoRegex";
            this.gbGeoRegex.Size = new System.Drawing.Size(349, 111);
            this.gbGeoRegex.TabIndex = 9;
            this.gbGeoRegex.TabStop = false;
            this.gbGeoRegex.Text = "Regex settings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Country:";
            // 
            // txtGeoCountry
            // 
            this.txtGeoCountry.Location = new System.Drawing.Point(68, 24);
            this.txtGeoCountry.Name = "txtGeoCountry";
            this.txtGeoCountry.Size = new System.Drawing.Size(260, 20);
            this.txtGeoCountry.TabIndex = 9;
            // 
            // txtGeoRegion
            // 
            this.txtGeoRegion.Location = new System.Drawing.Point(68, 50);
            this.txtGeoRegion.Name = "txtGeoRegion";
            this.txtGeoRegion.Size = new System.Drawing.Size(260, 20);
            this.txtGeoRegion.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Region:";
            // 
            // txtGeoCity
            // 
            this.txtGeoCity.Location = new System.Drawing.Point(68, 76);
            this.txtGeoCity.Name = "txtGeoCity";
            this.txtGeoCity.Size = new System.Drawing.Size(260, 20);
            this.txtGeoCity.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "City:";
            // 
            // cbSSL
            // 
            this.cbSSL.AutoSize = true;
            this.cbSSL.Location = new System.Drawing.Point(9, 0);
            this.cbSSL.Name = "cbSSL";
            this.cbSSL.Size = new System.Drawing.Size(80, 17);
            this.cbSSL.TabIndex = 7;
            this.cbSSL.Text = "SSL Check";
            this.cbSSL.UseVisualStyleBackColor = true;
            // 
            // Checkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 456);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.gbSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Checkers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Checker settings";
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.gbSSLCheck.ResumeLayout(false);
            this.gbSSLCheck.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbGeoRegex.ResumeLayout(false);
            this.gbGeoRegex.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setActiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCheckerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCheckerToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.GroupBox gbSSLCheck;
        private System.Windows.Forms.TextBox txtSSLKeyword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSSLUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTestJudge;
        private System.Windows.Forms.Label lblJudgeStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJudgeURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbGeoRegex;
        private System.Windows.Forms.TextBox txtGeoCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGeoRegion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGeoCountry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGeolocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbSSL;
    }
}