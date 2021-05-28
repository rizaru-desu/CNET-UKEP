namespace APPS
{
    partial class XtraFormFlash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormFlash));
            this.axShockwaveFlash = new AxShockwaveFlashObjects.AxShockwaveFlash();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash)).BeginInit();
            this.SuspendLayout();
            // 
            // axShockwaveFlash
            // 
            this.axShockwaveFlash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axShockwaveFlash.Enabled = true;
            this.axShockwaveFlash.Location = new System.Drawing.Point(0, 0);
            this.axShockwaveFlash.Name = "axShockwaveFlash";
            this.axShockwaveFlash.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlash.OcxState")));
            this.axShockwaveFlash.Size = new System.Drawing.Size(934, 583);
            this.axShockwaveFlash.TabIndex = 0;
            // 
            // XtraFormFlash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 583);
            this.Controls.Add(this.axShockwaveFlash);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XtraFormFlash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Content";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.XtraFormFlash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveFlash;
    }
}