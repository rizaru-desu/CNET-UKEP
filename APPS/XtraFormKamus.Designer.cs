namespace APPS
{
    partial class XtraFormKamus
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormKamus));
            this.radContextMenu = new Telerik.WinControls.UI.RadContextMenu(this.components);
            this.radMenuItemCopy = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItemSelect = new Telerik.WinControls.UI.RadMenuItem();
            this.dataGridViewDB = new Telerik.WinControls.UI.RadGridView();
            this.radLabelDetail = new Telerik.WinControls.UI.RadLabel();
            this.radTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDB.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // radContextMenu
            // 
            this.radContextMenu.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItemCopy,
            this.radMenuItemSelect});
            // 
            // radMenuItemCopy
            // 
            this.radMenuItemCopy.Image = global::APPS.Properties.Resources.copy_32x32;
            this.radMenuItemCopy.Name = "radMenuItemCopy";
            this.radMenuItemCopy.Text = "Copy";
            // 
            // radMenuItemSelect
            // 
            this.radMenuItemSelect.Image = global::APPS.Properties.Resources.selecttool_32x32;
            this.radMenuItemSelect.Name = "radMenuItemSelect";
            this.radMenuItemSelect.Text = "Select All";
            // 
            // dataGridViewDB
            // 
            this.dataGridViewDB.EnableCustomFiltering = true;
            this.dataGridViewDB.Location = new System.Drawing.Point(317, 12);
            // 
            // 
            // 
            this.dataGridViewDB.MasterTemplate.AllowAddNewRow = false;
            this.dataGridViewDB.MasterTemplate.AllowDeleteRow = false;
            this.dataGridViewDB.MasterTemplate.AllowEditRow = false;
            this.dataGridViewDB.MasterTemplate.AllowRowResize = false;
            this.dataGridViewDB.MasterTemplate.BottomPinnedRowsMode = Telerik.WinControls.UI.GridViewBottomPinnedRowsMode.Fixed;
            this.dataGridViewDB.MasterTemplate.EnableCustomFiltering = true;
            this.dataGridViewDB.MasterTemplate.EnableGrouping = false;
            this.dataGridViewDB.MasterTemplate.ShowFilteringRow = false;
            this.dataGridViewDB.MasterTemplate.ShowRowHeaderColumn = false;
            this.dataGridViewDB.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dataGridViewDB.Name = "dataGridViewDB";
            this.dataGridViewDB.ReadOnly = true;
            this.dataGridViewDB.ShowGroupPanel = false;
            this.dataGridViewDB.Size = new System.Drawing.Size(249, 406);
            this.dataGridViewDB.TabIndex = 14;
            this.dataGridViewDB.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.DataGridViewDB_CellClick);
            // 
            // radLabelDetail
            // 
            this.radLabelDetail.AutoSize = false;
            this.radLabelDetail.Location = new System.Drawing.Point(12, 12);
            this.radLabelDetail.Name = "radLabelDetail";
            this.radLabelDetail.Size = new System.Drawing.Size(287, 35);
            this.radLabelDetail.TabIndex = 15;
            this.radLabelDetail.Text = "Title";
            // 
            // radTextBox
            // 
            this.radTextBox.Location = new System.Drawing.Point(12, 398);
            this.radTextBox.Name = "radTextBox";
            this.radTextBox.Size = new System.Drawing.Size(222, 20);
            this.radTextBox.TabIndex = 16;
            this.radTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RadTextBox_KeyPress);
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(240, 399);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(57, 18);
            this.radButton1.TabIndex = 17;
            this.radButton1.Text = "Refresh";
            this.radButton1.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(12, 53);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(287, 339);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";
            this.richTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RichTextBox_MouseDown);
            // 
            // XtraFormKamus
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 430);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radTextBox);
            this.Controls.Add(this.radLabelDetail);
            this.Controls.Add(this.dataGridViewDB);
            this.Controls.Add(this.richTextBox);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XtraFormKamus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kamus Kesehatan";
            this.Load += new System.EventHandler(this.XtraFormData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDB.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadContextMenu radContextMenu;
        private Telerik.WinControls.UI.RadMenuItem radMenuItemCopy;
        private Telerik.WinControls.UI.RadMenuItem radMenuItemSelect;
        private Telerik.WinControls.UI.RadGridView dataGridViewDB;
        private Telerik.WinControls.UI.RadLabel radLabelDetail;
        private Telerik.WinControls.UI.RadTextBox radTextBox;
        private Telerik.WinControls.UI.RadButton radButton1;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}