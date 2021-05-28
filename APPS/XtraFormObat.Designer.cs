namespace APPS
{
    partial class XtraFormObat
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.dataGridViewDB = new Telerik.WinControls.UI.RadGridView();
            this.pictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.stackPanel3 = new DevExpress.Utils.Layout.StackPanel();
            this.radTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.btn_Refresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDB.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel3)).BeginInit();
            this.stackPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(370, 43);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(465, 504);
            this.webBrowser1.TabIndex = 0;
            // 
            // dataGridViewDB
            // 
            this.dataGridViewDB.EnableCustomFiltering = true;
            this.dataGridViewDB.Location = new System.Drawing.Point(12, 228);
            // 
            // 
            // 
            this.dataGridViewDB.MasterTemplate.AllowAddNewRow = false;
            this.dataGridViewDB.MasterTemplate.AllowDeleteRow = false;
            this.dataGridViewDB.MasterTemplate.AllowEditRow = false;
            this.dataGridViewDB.MasterTemplate.AllowRowResize = false;
            this.dataGridViewDB.MasterTemplate.EnableCustomFiltering = true;
            this.dataGridViewDB.MasterTemplate.EnableGrouping = false;
            this.dataGridViewDB.MasterTemplate.ShowFilteringRow = false;
            this.dataGridViewDB.MasterTemplate.ShowRowHeaderColumn = false;
            this.dataGridViewDB.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dataGridViewDB.Name = "dataGridViewDB";
            this.dataGridViewDB.ReadOnly = true;
            this.dataGridViewDB.ShowGroupPanel = false;
            this.dataGridViewDB.Size = new System.Drawing.Size(352, 319);
            this.dataGridViewDB.TabIndex = 16;
            // 
            // pictureEdit
            // 
            this.pictureEdit.Location = new System.Drawing.Point(81, 6);
            this.pictureEdit.Name = "pictureEdit";
            this.pictureEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.pictureEdit.Properties.ReadOnly = true;
            this.pictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit.Size = new System.Drawing.Size(215, 215);
            this.pictureEdit.TabIndex = 15;
            // 
            // stackPanel3
            // 
            this.stackPanel3.Controls.Add(this.radTextBox);
            this.stackPanel3.Controls.Add(this.btn_Refresh);
            this.stackPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stackPanel3.Location = new System.Drawing.Point(0, 553);
            this.stackPanel3.Name = "stackPanel3";
            this.stackPanel3.Size = new System.Drawing.Size(847, 35);
            this.stackPanel3.TabIndex = 14;
            // 
            // radTextBox
            // 
            this.radTextBox.Location = new System.Drawing.Point(3, 7);
            this.radTextBox.Name = "radTextBox";
            this.radTextBox.Size = new System.Drawing.Size(411, 20);
            this.radTextBox.TabIndex = 0;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(420, 6);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(61, 23);
            this.btn_Refresh.TabIndex = 1;
            this.btn_Refresh.Text = "Refresh";
            // 
            // XtraFormObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 588);
            this.Controls.Add(this.dataGridViewDB);
            this.Controls.Add(this.pictureEdit);
            this.Controls.Add(this.stackPanel3);
            this.Controls.Add(this.webBrowser1);
            this.Name = "XtraFormObat";
            this.Text = "XtraFormObat";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDB.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel3)).EndInit();
            this.stackPanel3.ResumeLayout(false);
            this.stackPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private Telerik.WinControls.UI.RadGridView dataGridViewDB;
        private DevExpress.XtraEditors.PictureEdit pictureEdit;
        private DevExpress.Utils.Layout.StackPanel stackPanel3;
        private Telerik.WinControls.UI.RadTextBox radTextBox;
        private DevExpress.XtraEditors.SimpleButton btn_Refresh;
    }
}