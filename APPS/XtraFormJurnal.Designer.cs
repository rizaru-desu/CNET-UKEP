namespace APPS
{
    partial class XtraFormJurnal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormJurnal));
            this.stackPanel3 = new DevExpress.Utils.Layout.StackPanel();
            this.radTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.btn_Refresh = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridViewDB = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel3)).BeginInit();
            this.stackPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDB.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // stackPanel3
            // 
            this.stackPanel3.Controls.Add(this.radTextBox);
            this.stackPanel3.Controls.Add(this.btn_Refresh);
            this.stackPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stackPanel3.Location = new System.Drawing.Point(0, 427);
            this.stackPanel3.Name = "stackPanel3";
            this.stackPanel3.Size = new System.Drawing.Size(345, 35);
            this.stackPanel3.TabIndex = 11;
            // 
            // radTextBox
            // 
            this.radTextBox.Location = new System.Drawing.Point(3, 7);
            this.radTextBox.Name = "radTextBox";
            this.radTextBox.Size = new System.Drawing.Size(268, 20);
            this.radTextBox.TabIndex = 0;
            this.radTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RadTextBox_KeyPress);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(277, 6);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(61, 23);
            this.btn_Refresh.TabIndex = 1;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // dataGridViewDB
            // 
            this.dataGridViewDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDB.EnableCustomFiltering = true;
            this.dataGridViewDB.Location = new System.Drawing.Point(0, 0);
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
            this.dataGridViewDB.Size = new System.Drawing.Size(345, 427);
            this.dataGridViewDB.TabIndex = 14;
            this.dataGridViewDB.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.DataGridViewDB_CellDoubleClick);
            // 
            // XtraFormJurnal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 462);
            this.Controls.Add(this.dataGridViewDB);
            this.Controls.Add(this.stackPanel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XtraFormJurnal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Jurnal";
            this.Load += new System.EventHandler(this.XtraFormData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel3)).EndInit();
            this.stackPanel3.ResumeLayout(false);
            this.stackPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDB.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.StackPanel stackPanel3;
        private Telerik.WinControls.UI.RadTextBox radTextBox;
        private DevExpress.XtraEditors.SimpleButton btn_Refresh;
        private Telerik.WinControls.UI.RadGridView dataGridViewDB;
    }
}