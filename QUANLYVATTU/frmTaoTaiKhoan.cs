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

namespace QUANLYVATTU
{
    public partial class frmTaoTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            if (Program.group == "CONGTY")
            {
                rdChiNhanh.Enabled = rdUser.Enabled = false;
            }
            else if (Program.group == "CHINHANH")
            {
                rdCongTy.Enabled = false;
            }
        }
    }
}