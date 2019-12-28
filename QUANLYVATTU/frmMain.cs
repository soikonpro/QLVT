using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QUANLYVATTU
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private Form CheckExists(Type ftype) // TRÁNH MỞ QUÁ NHIỀU LẦN 
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
          

        }
        private void btnNhanvien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(frmNhanvien));
            if (form != null) form.Activate();
            else
            {
                Program.formNhanvien = new frmNhanvien();
                Program.formNhanvien.MdiParent = this;
                Program.formNhanvien.Show();
            }
        }

        private void btnVatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(frmVattu));
            if (form != null) form.Activate();
            else
            {
                Program.formVattu = new frmVattu();
                Program.formVattu.MdiParent = this;
                Program.formVattu.Show();
            }
            }

        private void btnKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(frmKho));
            if (form != null) form.Activate();
            else
            {
                Program.formKho = new frmKho();
                Program.formKho.MdiParent = this;
                Program.formKho.Show();
            }
        }

        private void btnInDSNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.connection = new SqlConnection(Program.connectionString);
            // mở kết nối
            Program.connection.Open();
            // xác đinh group 
            string query = "SELECT * FROM DBO.NhanVien";
            SqlCommand sqlCommand = new SqlCommand(query, Program.connection);
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Program.connection.Close();
            XtraReportNV xtraReportNv = new XtraReportNV();
            xtraReportNv.DataSource = dt;
            xtraReportNv.CreateDocument();
            this.documentViewer1.DocumentSource = xtraReportNv;
            this.documentViewer1.Visible = true;
        }

        private void btnTaoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(frmTaoTaiKhoan));
            if (form != null) form.Activate();
            else
            {
                Program.frmTaoTaiKhoan = new frmTaoTaiKhoan();
                Program.frmTaoTaiKhoan.MdiParent = this;
                Program.frmTaoTaiKhoan.Show();
            }
        }
    }
}
