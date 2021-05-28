namespace APPS
{
    partial class XtraFormEbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormEbook));
            this.stackPanel3 = new DevExpress.Utils.Layout.StackPanel();
            this.radTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.btn_Refresh = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.radLabelDetail = new Telerik.WinControls.UI.RadLabel();
            this.dataGridViewDB = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel3)).BeginInit();
            this.stackPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDB.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // stackPanel3
            // 
            this.stackPanel3.Controls.Add(this.radTextBox);
            this.stackPanel3.Controls.Add(this.btn_Refresh);
            this.stackPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stackPanel3.Location = new System.Drawing.Point(0, 421);
            this.stackPanel3.Name = "stackPanel3";
            this.stackPanel3.Size = new System.Drawing.Size(500, 35);
            this.stackPanel3.TabIndex = 10;
            // 
            // radTextBox
            // 
            this.radTextBox.Location = new System.Drawing.Point(3, 7);
            this.radTextBox.Name = "radTextBox";
            this.radTextBox.Size = new System.Drawing.Size(411, 20);
            this.radTextBox.TabIndex = 0;
            this.radTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RadTextBox_KeyPress);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(420, 6);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(61, 23);
            this.btn_Refresh.TabIndex = 1;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // pictureEdit
            // 
            this.pictureEdit.Location = new System.Drawing.Point(42, 12);
            this.pictureEdit.Name = "pictureEdit";
            this.pictureEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.pictureEdit.Properties.ReadOnly = true;
            this.pictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit.Size = new System.Drawing.Size(150, 216);
            this.pictureEdit.TabIndex = 11;
            // 
            // radLabelDetail
            // 
            this.radLabelDetail.AutoSize = false;
            this.radLabelDetail.Location = new System.Drawing.Point(12, 235);
            this.radLabelDetail.Name = "radLabelDetail";
            this.radLabelDetail.Size = new System.Drawing.Size(210, 167);
            this.radLabelDetail.TabIndex = 12;
            this.radLabelDetail.Text = "Detail";
            // 
            // dataGridViewDB
            // 
            this.dataGridViewDB.EnableCustomFiltering = true;
            this.dataGridViewDB.Location = new System.Drawing.Point(228, 12);
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
            this.dataGridViewDB.Size = new System.Drawing.Size(253, 390);
            this.dataGridViewDB.TabIndex = 13;
            this.dataGridViewDB.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.DataGridViewDB_CellClick);
            this.dataGridViewDB.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.DataGridViewDB_CellDoubleClick);
            // 
            // XtraFormEbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 456);
            this.Controls.Add(this.dataGridViewDB);
            this.Controls.Add(this.radLabelDetail);
            this.Controls.Add(this.pictureEdit);
            this.Controls.Add(this.stackPanel3);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XtraFormEbook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perpustakaan Digital";
            this.Load += new System.EventHandler(this.XtraFormData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel3)).EndInit();
            this.stackPanel3.ResumeLayout(false);
            this.stackPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDB.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.Layout.StackPanel stackPanel3;
        private Telerik.WinControls.UI.RadTextBox radTextBox;
        private DevExpress.XtraEditors.SimpleButton btn_Refresh;
        private DevExpress.XtraEditors.PictureEdit pictureEdit;
        private Telerik.WinControls.UI.RadLabel radLabelDetail;
        private Telerik.WinControls.UI.RadGridView dataGridViewDB;
    }
}