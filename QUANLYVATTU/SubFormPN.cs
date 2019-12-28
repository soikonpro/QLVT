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
    public partial class SubFormPN : DevExpress.XtraEditors.XtraForm
    {
        public SubFormPN()
        {
            InitializeComponent();
        }

        private void SubFormPN_Load(object sender, EventArgs e)
        {

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.phieuNhapTableAdapter.Fill(this.dataSetServer2.PhieuNhap);
            this.phieuNhapBindingSource.DataSource = Program.formNhanvien.getPhieuNhap();
        }

        private void phieuNhapBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phieuNhapBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetServer2);

        }

        private void SubFormPN_Shown(object sender, EventArgs e)
        {
            this.phieuNhapBindingSource.AddNew();
            BindingSource tempDDH = Program.formNhanvien.getDatHangBDS();
            tbMaSoDDH.Text = ((DataRowView)tempDDH[tempDDH.Position])["MasoDDH"].ToString().Trim();
            ((DataRowView)phieuNhapBindingSource[phieuNhapBindingSource.Position])["MANV"] = Program.manv;
            ((DataRowView)phieuNhapBindingSource[phieuNhapBindingSource.Position])["NGAY"] = DateTime.Today;
        }
     
        private bool checkValidate(TextBox tb, string str)
        {
            if (tb.Text.Trim().Equals(""))
            {
                MessageBox.Show(str, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb.Focus();
                return false;
            }
            return true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
           
            try
            {
                ((DataRowView)phieuNhapBindingSource[phieuNhapBindingSource.Position])["MAPN"] = this.tbMaPN.Text;
                this.phieuNhapBindingSource.EndEdit();
                this.phieuNhapTableAdapter.Update(Program.formNhanvien.getDataSet().PhieuNhap);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SubFormPN_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.formMain.Enabled = true;
        }
    }
}