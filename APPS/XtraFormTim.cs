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

namespace APPS
{
    public partial class XtraFormTim : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormTim()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 1 only instance
        /// </summary>
        private static XtraFormTim instance;

        public static XtraFormTim GETINSTANE()
        {
            if (instance == null || instance.IsDisposed)
                instance = new XtraFormTim();
            else
                instance.BringToFront();
            return instance;
        }
    }
}