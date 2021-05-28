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
    public partial class XtraFormFlow : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormFlow()
        {
            InitializeComponent();
        }

        private static XtraFormFlow instance;

        public static XtraFormFlow GETINSTANE()
        {
            if (instance == null || instance.IsDisposed)
                instance = new XtraFormFlow();
            else
                instance.BringToFront();
            return instance;
        }
    }
}