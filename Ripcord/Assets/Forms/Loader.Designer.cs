namespace Ripcord.Assets.Forms
{
    partial class Loader
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loader));
        	this.pbIcon = new System.Windows.Forms.PictureBox();
        	this.lblHeader = new System.Windows.Forms.Label();
        	this.lblSlogan = new System.Windows.Forms.Label();
        	this.pbProgress = new System.Windows.Forms.ProgressBar();
        	this.txtProgress = new System.Windows.Forms.TextBox();
        	this.lblLoader = new System.Windows.Forms.Label();
        	this.btnOK = new System.Windows.Forms.Button();
        	((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// pbIcon
        	// 
        	this.pbIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbIcon.BackgroundImage")));
        	this.pbIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        	this.pbIcon.Location = new System.Drawing.Point(61, 36);
        	this.pbIcon.Name = "pbIcon";
        	this.pbIcon.Size = new System.Drawing.Size(64, 64);
        	this.pbIcon.TabIndex = 0;
        	this.pbIcon.TabStop = false;
        	// 
        	// lblHeader
        	// 
        	this.lblHeader.AutoSize = true;
        	this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold);
        	this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(171)))), ((int)(((byte)(24)))));
        	this.lblHeader.Location = new System.Drawing.Point(151, 40);
        	this.lblHeader.Name = "lblHeader";
        	this.lblHeader.Size = new System.Drawing.Size(164, 54);
        	this.lblHeader.TabIndex = 1;
        	this.lblHeader.Text = "Ripcord";
        	// 
        	// lblSlogan
        	// 
        	this.lblSlogan.AutoSize = true;
        	this.lblSlogan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblSlogan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(201)))), ((int)(((byte)(0)))));
        	this.lblSlogan.Location = new System.Drawing.Point(203, 83);
        	this.lblSlogan.Name = "lblSlogan";
        	this.lblSlogan.Size = new System.Drawing.Size(170, 20);
        	this.lblSlogan.TabIndex = 2;
        	this.lblSlogan.Text = "Proxy Management Tool";
        	// 
        	// pbProgress
        	// 
        	this.pbProgress.Location = new System.Drawing.Point(61, 118);
        	this.pbProgress.Maximum = 5;
        	this.pbProgress.Name = "pbProgress";
        	this.pbProgress.Size = new System.Drawing.Size(330, 12);
        	this.pbProgress.TabIndex = 0;
        	// 
        	// txtProgress
        	// 
        	this.txtProgress.BackColor = System.Drawing.Color.White;
        	this.txtProgress.Cursor = System.Windows.Forms.Cursors.Arrow;
        	this.txtProgress.Location = new System.Drawing.Point(61, 153);
        	this.txtProgress.Multiline = true;
        	this.txtProgress.Name = "txtProgress";
        	this.txtProgress.ReadOnly = true;
        	this.txtProgress.Size = new System.Drawing.Size(330, 202);
        	this.txtProgress.TabIndex = 4;
        	// 
        	// lblLoader
        	// 
        	this.lblLoader.AutoSize = true;
        	this.lblLoader.Location = new System.Drawing.Point(58, 135);
        	this.lblLoader.Name = "lblLoader";
        	this.lblLoader.Size = new System.Drawing.Size(82, 13);
        	this.lblLoader.TabIndex = 5;
        	this.lblLoader.Text = "Checking files...";
        	// 
        	// btnOK
        	// 
        	this.btnOK.Location = new System.Drawing.Point(308, 361);
        	this.btnOK.Name = "btnOK";
        	this.btnOK.Size = new System.Drawing.Size(83, 29);
        	this.btnOK.TabIndex = 1;
        	this.btnOK.Text = "OK";
        	this.btnOK.UseVisualStyleBackColor = true;
        	this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
        	// 
        	// Loader
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(449, 427);
        	this.Controls.Add(this.btnOK);
        	this.Controls.Add(this.lblLoader);
        	this.Controls.Add(this.txtProgress);
        	this.Controls.Add(this.pbProgress);
        	this.Controls.Add(this.lblSlogan);
        	this.Controls.Add(this.lblHeader);
        	this.Controls.Add(this.pbIcon);
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.Name = "Loader";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Ripcord Loader";
        	((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.TextBox txtProgress;
        private System.Windows.Forms.Label lblLoader;
        private System.Windows.Forms.Button btnOK;
    }
}