namespace Ripcord.Assets.Forms
{
    partial class URLHarvester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(URLHarvester));
            this.menuButton1 = new Ripcord.Assets.Globals.MenuButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.googleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clbEngines = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.cbEnableKeywords = new System.Windows.Forms.CheckBox();
            this.txtAddBeforeLink = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numRegexGroup = new System.Windows.Forms.NumericUpDown();
            this.rbRegexGroups = new System.Windows.Forms.RadioButton();
            this.rbRegexValue = new System.Windows.Forms.RadioButton();
            this.txtQueryString = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMustNotContain = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMustContain = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRegex = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numEndPage = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numIncPage = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numStartPage = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKeywords = new System.Windows.Forms.TextBox();
            this.btnTestHarvester = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRegexGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIncPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartPage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuButton1
            // 
            this.menuButton1.Location = new System.Drawing.Point(12, 399);
            this.menuButton1.Menu = this.contextMenuStrip1;
            this.menuButton1.Name = "menuButton1";
            this.menuButton1.Size = new System.Drawing.Size(102, 25);
            this.menuButton1.TabIndex = 1;
            this.menuButton1.Text = "Actions";
            this.menuButton1.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.googleToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(114, 48);
            // 
            // googleToolStripMenuItem
            // 
            this.googleToolStripMenuItem.Name = "googleToolStripMenuItem";
            this.googleToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.googleToolStripMenuItem.Text = "Refresh";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectedToolStripMenuItem,
            this.allToolStripMenuItem});
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // selectedToolStripMenuItem
            // 
            this.selectedToolStripMenuItem.Name = "selectedToolStripMenuItem";
            this.selectedToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.selectedToolStripMenuItem.Text = "Selected";
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.allToolStripMenuItem.Text = "All";
            // 
            // clbEngines
            // 
            this.clbEngines.FormattingEnabled = true;
            this.clbEngines.Location = new System.Drawing.Point(12, 25);
            this.clbEngines.Name = "clbEngines";
            this.clbEngines.Size = new System.Drawing.Size(242, 199);
            this.clbEngines.TabIndex = 3;
            this.clbEngines.SelectedIndexChanged += new System.EventHandler(this.clbEngines_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Engines:";
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.cbEnableKeywords);
            this.gbDetails.Controls.Add(this.txtAddBeforeLink);
            this.gbDetails.Controls.Add(this.label7);
            this.gbDetails.Controls.Add(this.numRegexGroup);
            this.gbDetails.Controls.Add(this.rbRegexGroups);
            this.gbDetails.Controls.Add(this.rbRegexValue);
            this.gbDetails.Controls.Add(this.txtQueryString);
            this.gbDetails.Controls.Add(this.label10);
            this.gbDetails.Controls.Add(this.txtMustNotContain);
            this.gbDetails.Controls.Add(this.label9);
            this.gbDetails.Controls.Add(this.txtMustContain);
            this.gbDetails.Controls.Add(this.label8);
            this.gbDetails.Controls.Add(this.txtRegex);
            this.gbDetails.Controls.Add(this.label6);
            this.gbDetails.Controls.Add(this.numEndPage);
            this.gbDetails.Controls.Add(this.label5);
            this.gbDetails.Controls.Add(this.numIncPage);
            this.gbDetails.Controls.Add(this.label4);
            this.gbDetails.Controls.Add(this.numStartPage);
            this.gbDetails.Controls.Add(this.label3);
            this.gbDetails.Controls.Add(this.txtDisplayName);
            this.gbDetails.Controls.Add(this.label2);
            this.gbDetails.Enabled = false;
            this.gbDetails.Location = new System.Drawing.Point(260, 19);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(400, 374);
            this.gbDetails.TabIndex = 5;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details";
            this.gbDetails.Enter += new System.EventHandler(this.gbDetails_Enter);
            // 
            // cbEnableKeywords
            // 
            this.cbEnableKeywords.AutoSize = true;
            this.cbEnableKeywords.Location = new System.Drawing.Point(9, 344);
            this.cbEnableKeywords.Name = "cbEnableKeywords";
            this.cbEnableKeywords.Size = new System.Drawing.Size(107, 17);
            this.cbEnableKeywords.TabIndex = 23;
            this.cbEnableKeywords.Text = "Enable keywords";
            this.cbEnableKeywords.UseVisualStyleBackColor = true;
            // 
            // txtAddBeforeLink
            // 
            this.txtAddBeforeLink.Location = new System.Drawing.Point(9, 314);
            this.txtAddBeforeLink.Name = "txtAddBeforeLink";
            this.txtAddBeforeLink.Size = new System.Drawing.Size(382, 20);
            this.txtAddBeforeLink.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Add before link:";
            // 
            // numRegexGroup
            // 
            this.numRegexGroup.Location = new System.Drawing.Point(172, 181);
            this.numRegexGroup.Name = "numRegexGroup";
            this.numRegexGroup.Size = new System.Drawing.Size(63, 20);
            this.numRegexGroup.TabIndex = 20;
            this.numRegexGroup.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rbRegexGroups
            // 
            this.rbRegexGroups.AutoSize = true;
            this.rbRegexGroups.Location = new System.Drawing.Point(67, 181);
            this.rbRegexGroups.Name = "rbRegexGroups";
            this.rbRegexGroups.Size = new System.Drawing.Size(99, 17);
            this.rbRegexGroups.TabIndex = 19;
            this.rbRegexGroups.Text = "Value by group:";
            this.rbRegexGroups.UseVisualStyleBackColor = true;
            // 
            // rbRegexValue
            // 
            this.rbRegexValue.AutoSize = true;
            this.rbRegexValue.Checked = true;
            this.rbRegexValue.Location = new System.Drawing.Point(9, 181);
            this.rbRegexValue.Name = "rbRegexValue";
            this.rbRegexValue.Size = new System.Drawing.Size(52, 17);
            this.rbRegexValue.TabIndex = 18;
            this.rbRegexValue.TabStop = true;
            this.rbRegexValue.Text = "Value";
            this.rbRegexValue.UseVisualStyleBackColor = true;
            // 
            // txtQueryString
            // 
            this.txtQueryString.Location = new System.Drawing.Point(9, 81);
            this.txtQueryString.Name = "txtQueryString";
            this.txtQueryString.Size = new System.Drawing.Size(382, 20);
            this.txtQueryString.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Query string:";
            // 
            // txtMustNotContain
            // 
            this.txtMustNotContain.Location = new System.Drawing.Point(9, 269);
            this.txtMustNotContain.Name = "txtMustNotContain";
            this.txtMustNotContain.Size = new System.Drawing.Size(382, 20);
            this.txtMustNotContain.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Must not be in link:";
            // 
            // txtMustContain
            // 
            this.txtMustContain.Location = new System.Drawing.Point(9, 225);
            this.txtMustContain.Name = "txtMustContain";
            this.txtMustContain.Size = new System.Drawing.Size(382, 20);
            this.txtMustContain.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Must be in link:";
            // 
            // txtRegex
            // 
            this.txtRegex.Location = new System.Drawing.Point(9, 155);
            this.txtRegex.Name = "txtRegex";
            this.txtRegex.Size = new System.Drawing.Size(382, 20);
            this.txtRegex.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Regex:";
            // 
            // numEndPage
            // 
            this.numEndPage.Location = new System.Drawing.Point(344, 113);
            this.numEndPage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numEndPage.Name = "numEndPage";
            this.numEndPage.Size = new System.Drawing.Size(50, 20);
            this.numEndPage.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Page end:";
            // 
            // numIncPage
            // 
            this.numIncPage.Location = new System.Drawing.Point(208, 113);
            this.numIncPage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numIncPage.Name = "numIncPage";
            this.numIncPage.Size = new System.Drawing.Size(50, 20);
            this.numIncPage.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Page inc:";
            // 
            // numStartPage
            // 
            this.numStartPage.Location = new System.Drawing.Point(73, 113);
            this.numStartPage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numStartPage.Name = "numStartPage";
            this.numStartPage.Size = new System.Drawing.Size(50, 20);
            this.numStartPage.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Page start:";
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(9, 36);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(382, 20);
            this.txtDisplayName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Display name:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(585, 399);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(260, 399);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(341, 399);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(179, 399);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Keywords";
            // 
            // txtKeywords
            // 
            this.txtKeywords.Location = new System.Drawing.Point(12, 247);
            this.txtKeywords.Multiline = true;
            this.txtKeywords.Name = "txtKeywords";
            this.txtKeywords.Size = new System.Drawing.Size(242, 146);
            this.txtKeywords.TabIndex = 11;
            this.txtKeywords.Text = "Daily Free SSL Proxies";
            // 
            // btnTestHarvester
            // 
            this.btnTestHarvester.Location = new System.Drawing.Point(422, 399);
            this.btnTestHarvester.Name = "btnTestHarvester";
            this.btnTestHarvester.Size = new System.Drawing.Size(96, 23);
            this.btnTestHarvester.TabIndex = 12;
            this.btnTestHarvester.Text = "Test Harvester";
            this.btnTestHarvester.UseVisualStyleBackColor = true;
            this.btnTestHarvester.Click += new System.EventHandler(this.btnTestHarvester_Click);
            // 
            // URLHarvester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 434);
            this.Controls.Add(this.btnTestHarvester);
            this.Controls.Add(this.txtKeywords);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clbEngines);
            this.Controls.Add(this.menuButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "URLHarvester";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "URL Harvester";
            this.Load += new System.EventHandler(this.URLHarvester_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRegexGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIncPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Globals.MenuButton menuButton1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem googleToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox clbEngines;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numEndPage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numIncPage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numStartPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMustContain;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRegex;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtMustNotContain;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQueryString;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtKeywords;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numRegexGroup;
        private System.Windows.Forms.RadioButton rbRegexGroups;
        private System.Windows.Forms.RadioButton rbRegexValue;
        private System.Windows.Forms.TextBox txtAddBeforeLink;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTestHarvester;
        private System.Windows.Forms.CheckBox cbEnableKeywords;
    }
}