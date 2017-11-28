namespace Ripcord.Assets.Forms
{
    partial class SourceAnalyzer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SourceAnalyzer));
            this.lvSources = new System.Windows.Forms.ListView();
            this.cSource = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cResponseTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cProxiesGathered = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSaveSources = new System.Windows.Forms.Button();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.btnDeleteEmpty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvSources
            // 
            this.lvSources.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cSource,
            this.cResponseTime,
            this.cProxiesGathered});
            this.lvSources.FullRowSelect = true;
            this.lvSources.Location = new System.Drawing.Point(12, 12);
            this.lvSources.Name = "lvSources";
            this.lvSources.Size = new System.Drawing.Size(657, 320);
            this.lvSources.TabIndex = 0;
            this.lvSources.UseCompatibleStateImageBehavior = false;
            this.lvSources.View = System.Windows.Forms.View.Details;
            // 
            // cSource
            // 
            this.cSource.Text = "Source";
            this.cSource.Width = 457;
            // 
            // cResponseTime
            // 
            this.cResponseTime.Text = "Response (ms)";
            this.cResponseTime.Width = 88;
            // 
            // cProxiesGathered
            // 
            this.cProxiesGathered.Text = "Total proxies";
            this.cProxiesGathered.Width = 83;
            // 
            // btnSaveSources
            // 
            this.btnSaveSources.Location = new System.Drawing.Point(12, 338);
            this.btnSaveSources.Name = "btnSaveSources";
            this.btnSaveSources.Size = new System.Drawing.Size(102, 29);
            this.btnSaveSources.TabIndex = 1;
            this.btnSaveSources.Text = "Save sources";
            this.btnSaveSources.UseVisualStyleBackColor = true;
            this.btnSaveSources.Click += new System.EventHandler(this.btnSaveSources_Click);
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Location = new System.Drawing.Point(120, 338);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(102, 29);
            this.btnDeleteSelected.TabIndex = 2;
            this.btnDeleteSelected.Text = "Delete selected";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // btnDeleteEmpty
            // 
            this.btnDeleteEmpty.Location = new System.Drawing.Point(228, 338);
            this.btnDeleteEmpty.Name = "btnDeleteEmpty";
            this.btnDeleteEmpty.Size = new System.Drawing.Size(102, 29);
            this.btnDeleteEmpty.TabIndex = 3;
            this.btnDeleteEmpty.Text = "Delete empty";
            this.btnDeleteEmpty.UseVisualStyleBackColor = true;
            this.btnDeleteEmpty.Click += new System.EventHandler(this.btnDeleteEmpty_Click);
            // 
            // SourceAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 379);
            this.Controls.Add(this.btnDeleteEmpty);
            this.Controls.Add(this.btnDeleteSelected);
            this.Controls.Add(this.btnSaveSources);
            this.Controls.Add(this.lvSources);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SourceAnalyzer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Source Analyzer";
            this.Load += new System.EventHandler(this.SourceAnalyzer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvSources;
        private System.Windows.Forms.ColumnHeader cSource;
        private System.Windows.Forms.ColumnHeader cResponseTime;
        private System.Windows.Forms.ColumnHeader cProxiesGathered;
        private System.Windows.Forms.Button btnSaveSources;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.Button btnDeleteEmpty;
    }
}