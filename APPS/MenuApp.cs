using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;

namespace APPS
{
    public partial class MenuApp : Form
    {
        public static string path = "";
        public static string tittleForm = "";
        public static string tabledata = "";

        public MenuApp()
        {
            InitializeComponent();

            radMenuUkom1.Click += new EventHandler(RadMenuUkom1_Click);
            radMenuUkom2.Click += new EventHandler(RadMenuUkom2_Click);
            radMenuUkom3.Click += new EventHandler(RadMenuUkom3_Click);

            radMenuTips1.Click += new EventHandler(RadMenuTips1_Click);
            radMenuTips2.Click += new EventHandler(RadMenuTips2_Click);
            radMenuTips3.Click += new EventHandler(RadMenuTips3_Click);
            radMenuTips4.Click += new EventHandler(RadMenuTips4_Click);

            radMenuWeb1.Click += new EventHandler(RadMenuWeb1_Click);
            radMenuIG2.Click += new EventHandler(RadMenuIG2_Click);
            radMenuYT3.Click += new EventHandler(RadMenuYT3_Click);
        }


        #region INFO SYSTEM
        [DllImport("kernel32.dll")]

        private static extern long GetVolumeInformation(
            string PathName,
            StringBuilder VolumeNameBuffer,
            UInt32 VolumeNameSize,
            ref UInt32 VolumeSerialNumber,
            ref UInt32 MaximumComponentLength,
            ref UInt32 FileSystemFlags,
            StringBuilder FileSystemNameBuffer,
            UInt32 FileSystemNameSize);

        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        static extern int SetProcessWorkingSetSize(IntPtr process, int minimumWorkingSetSize, int maximumWorkingSetSize);
        #endregion

        #region Connection DataBase
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        //private SQLiteDataAdapter DB;
        private readonly DataSet DS = new DataSet();
        private readonly DataTable DT = new DataTable();
        #endregion

        #region String
        readonly string hash = "R1Z@RU&D1PP4";

        //Get from Database
        string getVolume = "";
        string getSerial = "";

        //Output From MD5
        string outVolume = "";
        string outSerial = "";

        //Output Disk Information
        string IVolume = "";
        string ISerial = "";
        string IFileS = "";
        string IFlags = "";
        #endregion

        #region MD5
        private void TextDecryt()
        {
            byte[] data1 = Convert.FromBase64String(getVolume);
            byte[] data2 = Convert.FromBase64String(getSerial);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform tranform = tripDes.CreateDecryptor();
                    byte[] results1 = tranform.TransformFinalBlock(data1, 0, data1.Length);
                    byte[] results2 = tranform.TransformFinalBlock(data2, 0, data2.Length);
                    outVolume = UTF8Encoding.UTF8.GetString(results1);
                    outSerial = UTF8Encoding.UTF8.GetString(results2);
                }
            }
        }
        #endregion

        #region Get HIWD
        private void GetInfo()
        {
            string drive_letter = System.IO.Directory.GetCurrentDirectory();
            drive_letter = drive_letter.Substring(0, 1) + ":\\";
            uint serial_number = 0;
            uint max_component_length = 0;
            StringBuilder sb_volume_name = new StringBuilder(256);
            UInt32 file_system_flags = new UInt32();
            StringBuilder sb_file_system_name = new StringBuilder(256);

            if (GetVolumeInformation(drive_letter, sb_volume_name,
                (UInt32)sb_volume_name.Capacity, ref serial_number,
                ref max_component_length, ref file_system_flags,
                sb_file_system_name,
                (UInt32)sb_file_system_name.Capacity) == 0)
            {
                MessageBox.Show(this, "Kesalahan mendapatkan informasi volume" + Environment.NewLine + "Disk tidak ditemukan", "PEMBERITAHUAN", MessageBoxButtons.OK);
            }
            else
            {
                IVolume = sb_volume_name.ToString();
                ISerial = serial_number.ToString();
                IFileS = sb_file_system_name.ToString();
                IFlags = "&&H" + file_system_flags.ToString("x");
            }
        }
        #endregion

        #region Load DataBase
        private void loadDB()
        {

            string drive_letter = Directory.GetCurrentDirectory();
            drive_letter = drive_letter.Substring(0, 1) + ":\\";
            string[] files = Directory.GetFiles(drive_letter, "server.db", SearchOption.AllDirectories);
            foreach (string s in files)
            {
                sql_con = new SQLiteConnection("Data Source=" + s + ";Version=3;New=False;Compress=true;");
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();

                SQLiteDataReader dr;
                sql_cmd.CommandText = "SELECT * FROM USB_DEVICE";
                dr = sql_cmd.ExecuteReader();
                while (dr.Read())
                {
                    getVolume = dr["VolumeName"].ToString();
                    getSerial = dr["SerialNumber"].ToString();
                }
                dr.Close();
                dr.Dispose();
            }
        }
        #endregion

        void RadMenuWeb1_Click(object sender, EventArgs e)
        {

            Process.Start("http://sahabatalter.com/");
        }

        void RadMenuIG2_Click(object sender, EventArgs e)
        {

            Process.Start("https://www.instagram.com/alter.indonesia/?hl=id");
        }

        void RadMenuYT3_Click(object sender, EventArgs e)
        {

            Process.Start("https://www.youtube.com/channel/UCM9hWNlML85TMnOWkhhkgsA");
        }

        //================ Context Menu Ukom ====================//
        private void RadMenuUkom1_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(100);
                }
                path = "Ukom1.dll.swf";
                XtraFormFlash c = XtraFormFlash.GETINSTANE();
                c.Show();
                splashScreenManager1.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RadMenuUkom2_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(100);
                }
                path = "Ukom2.dll.swf";
                XtraFormFlash c = XtraFormFlash.GETINSTANE();
                c.Show();
                splashScreenManager1.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RadMenuUkom3_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(100);
                }
                path = "Ukom3.dll.swf";
                XtraFormFlash c = XtraFormFlash.GETINSTANE();
                c.Show();
                splashScreenManager1.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RadMenuTips1_Click(object sender, EventArgs e)
        {
            try
            {
                //Shell Word
                Process.Start(Application.StartupPath + @"/component/tips/tips-1.mp4");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RadMenuTips2_Click(object sender, EventArgs e)
        {
            try
            {
                //Shell Word
                Process.Start(Application.StartupPath + @"/component/tips/tips-2.mp4");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RadMenuTips3_Click(object sender, EventArgs e)
        {
            try
            {
                //Shell Word
                Process.Start(Application.StartupPath + @"/component/tips/tips-3.mp4");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RadMenuTips4_Click(object sender, EventArgs e)
        {
            try
            {
                //Shell Word
                Process.Start(Application.StartupPath + @"/component/tips/tips-4.mp4");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //================ Closing aplicatioon ====================//

        private void Btn_image_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //================ Minimize aplicatioon ====================//

        private void Btn_image_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //================ Move aplicatioon ====================//

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Menu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void PictureBoxUkom_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                radContextUji.Show(Cursor.Position);
            }
        }

        private void ToolStripOffi_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                radContextOfficial.Show(Cursor.Position);
            }
        }

        private void PictureBoxTips_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                radContextTrick.Show(Cursor.Position);
            }
        }

        private void MenuApp_Load(object sender, EventArgs e)
        {
            Thread.Sleep(8000);

            try
            {
                GetInfo();
                loadDB();
                TextDecryt();
                //Matching Drive Information = Data Server
                if (IVolume == outVolume && ISerial == outSerial)
                {
                    this.BringToFront();
                }
                else
                {
                    if (RadMessageBox.Show("Error", "Notifikasi", MessageBoxButtons.OK, "Cek label Flashdik:" + Environment.NewLine + "1. Klik kanan pada flashdisk ALTER" + Environment.NewLine + "2. Klik Kanan rename, Ketik ALTERINDO setelah itu tekan enter"+ Environment.NewLine + Environment.NewLine + "Atau Gunakan FD dari ALTER!") == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
            }
            catch (Exception ex)
            {
                if (MessageBox.Show(ex.Message + Environment.NewLine + "Hubungi IT Support Alter", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void ToolStripTim_Click(object sender, EventArgs e)
        {
            XtraFormTim tim = XtraFormTim.GETINSTANE();
            tim.Show();
        }

        private void ToolStripWork_Click(object sender, EventArgs e)
        {
            XtraFormFlow flow = XtraFormFlow.GETINSTANE();
            flow.Show();
        }

        private void PictureBoxKamus_Click(object sender, EventArgs e)
        {
            XtraFormKamus xfk = XtraFormKamus.GETINSTANE();
            xfk.Show();
        }

        private void PictureBoxJurnal_Click(object sender, EventArgs e)
        {
            XtraFormJurnal xfd = XtraFormJurnal.GETINSTANE();
            xfd.Show();
        }

        private void PictureBoxForm_Click(object sender, EventArgs e)
        {
        }

        private void PictureBoxEbook_Click(object sender, EventArgs e)
        {
            tabledata = "SELECT * FROM table_ebook";
            XtraFormEbook xfd = XtraFormEbook.GETINSTANE();
            xfd.Show();
        }

        private void PictureBoxObat_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(100);
                }
                path = "Obat.dll.swf";
                XtraFormFlash c = XtraFormFlash.GETINSTANE();
                c.Show();
                splashScreenManager1.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PictureBoxVid_Click(object sender, EventArgs e)
        {
            XtraFormSOP xfd = XtraFormSOP.GETINSTANE();
            xfd.Show();
        }

        private void ToolStripHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("IT Support : +62 813-8788-4041" + Environment.NewLine + "Customer Service: +62 877-8078-7979");
        }
    }
}
