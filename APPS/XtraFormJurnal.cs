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
using Telerik.WinControls.UI;
using System.Data.SQLite;

namespace APPS
{
    public partial class XtraFormJurnal : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormJurnal()
        {
            InitializeComponent();
            this.dataGridViewDB.BestFitColumns(BestFitColumnMode.AllCells);
        }

        /// <summary>
        /// 1 only instance
        /// </summary>
        private static XtraFormJurnal instance;

        public static XtraFormJurnal GETINSTANE()
        {
            if (instance == null || instance.IsDisposed)
                instance = new XtraFormJurnal();
            else
                instance.BringToFront();
            return instance;
        }

        #region Function SQLITE
        private SQLiteConnection sql_con;
        private SQLiteDataAdapter DB;
        private readonly DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        #endregion

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
                string CommandText = "SELECT * FROM table_jurnal";
                DB = new SQLiteDataAdapter(CommandText, sql_con);
                DS.Reset();
                DB.Fill(DS);
                DT = DS.Tables[0];
                dataGridViewDB.DataSource = DT;
                this.dataGridViewDB.Columns["id"].HeaderText = "No";
                this.dataGridViewDB.Columns["title"].HeaderText = "Judul";
                this.dataGridViewDB.Columns["path"].IsVisible = false;


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

        private void DataGridViewDB_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                //Shell Word
                System.Diagnostics.Process.Start(Application.StartupPath + @"\component\" + dataGridViewDB.SelectedRows[0].Cells["path"].Value.ToString());
                this.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}