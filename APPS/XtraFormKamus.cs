using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SQLite;
using Telerik.WinControls.UI;

namespace APPS
{
    public partial class XtraFormKamus : DevExpress.XtraEditors.XtraForm
    {
        #region Function SQLITE
        private SQLiteConnection sql_con;
        private SQLiteDataAdapter DB;
        private readonly DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        #endregion

        /// <summary>
        /// 1 only instance
        /// </summary>
        private static XtraFormKamus instance;

        public static XtraFormKamus GETINSTANE()
        {
            if (instance == null || instance.IsDisposed)
                instance = new XtraFormKamus();
            else
                instance.BringToFront();
            return instance;
        }

        public XtraFormKamus()
        {
            InitializeComponent();

            radMenuItemSelect.Click += new EventHandler(RadMenuItemSelect_Click);
            radMenuItemCopy.Click += new EventHandler(RadMenuItemCopy_Click);

            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
            this.dataGridViewDB.BestFitColumns(BestFitColumnMode.AllCells);
        }

        private void RadMenuItemCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox.SelectedText);
        }

        private void RadMenuItemSelect_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
            richTextBox.Focus();
        }

        #region Connection DataBase
        private void SetConnection()
        {
            try
            {
                string locationFile = Application.StartupPath + @"\data\data.db";
                //string drive_letter = Application.StartupPath;
                //drive_letter = drive_letter.Substring(0, 1) + ":\\";
                sql_con = new SQLiteConnection("Data Source=" + locationFile + ";Version=3;New=False;Compress=true;");
                //sql_con = new SQLiteConnection("Data Source=" + drive_letter + "ALTERINDO/data/data.db;Version=3;New=False;Compress=true;");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        private void LoadData()
        {
            try
            {
                SetConnection();
                sql_con.Open();
                SQLiteCommand sql_cmd = sql_con.CreateCommand();
                string CommandText = "SELECT * FROM table_Kamus";
                DB = new SQLiteDataAdapter(CommandText, sql_con);
                DS.Reset();
                DB.Fill(DS);
                DT = DS.Tables[0];
                dataGridViewDB.DataSource = DT;
                this.dataGridViewDB.Columns["id"].IsVisible = false;
                this.dataGridViewDB.Columns["title"].HeaderText = "Judul";
                this.dataGridViewDB.Columns["definisi"].IsVisible = false;

                sql_con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void XtraFormData_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void RadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DataView dv = DT.DefaultView;
                dv.RowFilter = string.Format("title like '%{0}%'", radTextBox.Text);
                dataGridViewDB.DataSource = dv.ToTable();
            }
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            LoadData();

        }

        private void RichTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                radContextMenu.Show(Cursor.Position);
            }
        }

        private void DataGridViewDB_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                radLabelDetail.Text = "Judul: " + dataGridViewDB.SelectedRows[0].Cells["title"].Value.ToString();
                richTextBox.Text = dataGridViewDB.SelectedRows[0].Cells["definisi"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}