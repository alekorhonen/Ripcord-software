namespace Ripcord.Assets.Forms
{
    partial class Judge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Judge));
            this.srcJudge = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // srcJudge
            // 
            this.srcJudge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.srcJudge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.srcJudge.Location = new System.Drawing.Point(0, 0);
            this.srcJudge.Name = "srcJudge";
            this.srcJudge.ReadOnly = true;
            this.srcJudge.Size = new System.Drawing.Size(378, 240);
            this.srcJudge.TabIndex = 0;
            this.srcJudge.Text = "";
            // 
            // Judge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 240);
            this.Controls.Add(this.srcJudge);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Judge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Judge -";
            this.Load += new System.EventHandler(this.Judge_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox srcJudge;
    }
}