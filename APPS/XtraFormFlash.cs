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
using System.IO;

namespace APPS
{
    public partial class XtraFormFlash : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormFlash()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 1 only instance
        /// </summary>
        private static XtraFormFlash instance;

        public static XtraFormFlash GETINSTANE()
        {
            if (instance == null || instance.IsDisposed)
                instance = new XtraFormFlash();
            else
                instance.BringToFront();
            return instance;
        }

        #region Flash Player
        private void InitFlashMovie(byte[] swfFile)
        {
            using (MemoryStream stm = new MemoryStream())
            {
                using (BinaryWriter writer = new BinaryWriter(stm))
                {
                    /* Write length of stream for AxHost.State */
                    writer.Write(8 + swfFile.Length);
                    /* Write Flash magic 'fUfU' */
                    writer.Write(0x55665566);
                    /* Length of swf file */
                    writer.Write(swfFile.Length);
                    writer.Write(swfFile);
                    stm.Seek(0, SeekOrigin.Begin);
                    /* 1 == IPeristStreamInit */
                    axShockwaveFlash.OcxState = new AxHost.State(stm, 1, true, null);
                }
            }
        }

        #endregion

        private void XtraFormFlash_Load(object sender, EventArgs e)
        {
            byte[] Key = CryptoFlash.StringToByteArray(")p'?e4GP");
            byte[] IV = CryptoFlash.StringToByteArray(")p'?e4GP");
            //MessageBox.Show(DES_Class.ByteArrayToString(Key) + "+" + DES_Class.ByteArrayToString(IV));
            try
            {
                string dataswf = MenuApp.path;
                string openFile = Application.StartupPath + @"\component\" + Path.GetFileNameWithoutExtension(dataswf);

                if (File.Exists(openFile))
                {
                    byte[] str = CryptoFlash.DecryptFileAndReturnStream(openFile, Key, IV);
                    InitFlashMovie(str);
                }
                else
                {
                    MessageBox.Show(this, "File terhapus/Terganti namanya", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message + Environment.NewLine
                    + "Data belum terpoteksi");
            }
            this.WindowState = FormWindowState.Maximized;
        }
    }
}