namespace Ripcord.Assets.Forms
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.gbCommon = new System.Windows.Forms.GroupBox();
            this.cbDisableListview = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numRetries = new System.Windows.Forms.NumericUpDown();
            this.lblRetries = new System.Windows.Forms.Label();
            this.numTimeout = new System.Windows.Forms.NumericUpDown();
            this.lblTimeout = new System.Windows.Forms.Label();
            this.numThreads = new System.Windows.Forms.NumericUpDown();
            this.lblThreads = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.btnGetIP = new System.Windows.Forms.Button();
            this.btnConfigure = new System.Windows.Forms.Button();
            this.gbCommon.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRetries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThreads)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCommon
            // 
            this.gbCommon.Controls.Add(this.cbDisableListview);
            this.gbCommon.Location = new System.Drawing.Point(12, 52);
            this.gbCommon.Name = "gbCommon";
            this.gbCommon.Size = new System.Drawing.Size(445, 46);
            this.gbCommon.TabIndex = 0;
            this.gbCommon.TabStop = false;
            this.gbCommon.Text = "Common";
            // 
            // cbDisableListview
            // 
            this.cbDisableListview.AutoSize = true;
            this.cbDisableListview.Checked = true;
            this.cbDisableListview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDisableListview.Location = new System.Drawing.Point(15, 19);
            this.cbDisableListview.Name = "cbDisableListview";
            this.cbDisableListview.Size = new System.Drawing.Size(98, 17);
            this.cbDisableListview.TabIndex = 2;
            this.cbDisableListview.Tag = "Reduces memory overload considerably.";
            this.cbDisableListview.Text = "Disable listview";
            this.cbDisableListview.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numRetries);
            this.groupBox1.Controls.Add(this.lblRetries);
            this.groupBox1.Controls.Add(this.numTimeout);
            this.groupBox1.Controls.Add(this.lblTimeout);
            this.groupBox1.Controls.Add(this.numThreads);
            this.groupBox1.Controls.Add(this.lblThreads);
            this.groupBox1.Location = new System.Drawing.Point(12, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 54);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thread Control";
            // 
            // numRetries
            // 
            this.numRetries.Location = new System.Drawing.Point(356, 20);
            this.numRetries.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numRetries.Name = "numRetries";
            this.numRetries.Size = new System.Drawing.Size(75, 20);
            this.numRetries.TabIndex = 8;
            this.numRetries.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numRetries.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblRetries
            // 
            this.lblRetries.AutoSize = true;
            this.lblRetries.Location = new System.Drawing.Point(308, 23);
            this.lblRetries.Name = "lblRetries";
            this.lblRetries.Size = new System.Drawing.Size(40, 13);
            this.lblRetries.TabIndex = 7;
            this.lblRetries.Text = "Retries";
            // 
            // numTimeout
            // 
            this.numTimeout.Location = new System.Drawing.Point(210, 20);
            this.numTimeout.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTimeout.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTimeout.Name = "numTimeout";
            this.numTimeout.Size = new System.Drawing.Size(75, 20);
            this.numTimeout.TabIndex = 6;
            this.numTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numTimeout.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // lblTimeout
            // 
            this.lblTimeout.AutoSize = true;
            this.lblTimeout.Location = new System.Drawing.Point(159, 23);
            this.lblTimeout.Name = "lblTimeout";
            this.lblTimeout.Size = new System.Drawing.Size(45, 13);
            this.lblTimeout.TabIndex = 5;
            this.lblTimeout.Text = "Timeout";
            // 
            // numThreads
            // 
            this.numThreads.Location = new System.Drawing.Point(64, 20);
            this.numThreads.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numThreads.Name = "numThreads";
            this.numThreads.Size = new System.Drawing.Size(75, 20);
            this.numThreads.TabIndex = 3;
            this.numThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numThreads.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblThreads
            // 
            this.lblThreads.AutoSize = true;
            this.lblThreads.Location = new System.Drawing.Point(12, 23);
            this.lblThreads.Name = "lblThreads";
            this.lblThreads.Size = new System.Drawing.Size(46, 13);
            this.lblThreads.TabIndex = 2;
            this.lblThreads.Text = "Threads";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "This IP Address";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(12, 25);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(364, 20);
            this.txtIPAddress.TabIndex = 3;
            // 
            // btnGetIP
            // 
            this.btnGetIP.Location = new System.Drawing.Point(382, 23);
            this.btnGetIP.Name = "btnGetIP";
            this.btnGetIP.Size = new System.Drawing.Size(75, 23);
            this.btnGetIP.TabIndex = 4;
            this.btnGetIP.Text = "Grab";
            this.btnGetIP.UseVisualStyleBackColor = true;
            this.btnGetIP.Click += new System.EventHandler(this.btnGetIP_Click);
            // 
            // btnConfigure
            // 
            this.btnConfigure.Location = new System.Drawing.Point(368, 164);
            this.btnConfigure.Name = "btnConfigure";
            this.btnConfigure.Size = new System.Drawing.Size(89, 26);
            this.btnConfigure.TabIndex = 5;
            this.btnConfigure.Text = "Configure";
            this.btnConfigure.UseVisualStyleBackColor = true;
            this.btnConfigure.Click += new System.EventHandler(this.btnConfigure_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 200);
            this.Controls.Add(this.btnConfigure);
            this.Controls.Add(this.btnGetIP);
            this.Controls.Add(this.txtIPAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbCommon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.gbCommon.ResumeLayout(false);
            this.gbCommon.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRetries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThreads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCommon;
        private System.Windows.Forms.CheckBox cbDisableListview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numRetries;
        private System.Windows.Forms.Label lblRetries;
        private System.Windows.Forms.NumericUpDown numTimeout;
        private System.Windows.Forms.Label lblTimeout;
        private System.Windows.Forms.NumericUpDown numThreads;
        private System.Windows.Forms.Label lblThreads;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.Button btnGetIP;
        private System.Windows.Forms.Button btnConfigure;
    }
}