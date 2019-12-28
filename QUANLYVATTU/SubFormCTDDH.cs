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
    public partial class SubFormCTDDH : DevExpress.XtraEditors.XtraForm
    {
        public SubFormCTDDH()
        {
            InitializeComponent();
        }

        private void SubFormCTDDH_Load(object sender, EventArgs e)
        {
            
            //
            this.vattuTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.vattuTableAdapter.Fill(this.dataSetServer2.Vattu);
            this.cTDDHTableAdapter.Fill(this.dataSetServer2.CTDDH);
            this.cTDDHBindingSource.DataSource = Program.formNhanvien.getCTDatHangBDS();
            BindingSource tempDDH = Program.formNhanvien.getDatHangBDS();
            string valueMasoDDH = getDataRow(tempDDH, "MasoDDH");
            tbMasoDDH.Text = valueMasoDDH;
           // ((DataRowView)cTDDHBindingSource[cTDDHBindingSource.Position])["MasoDDH"] = this.tbMasoDDH.Text;

        }

        private void SubFormCTDDH_Shown(object sender, EventArgs e)
        {
            this.cTDDHBindingSource.AddNew();
            tbMaVT.Text = getDataRow(this.vattuBindingSource, "MAVT");
            nuSoLuong.Value = 1;
            nuDonGia.Value = 0;
        }
        private string getDataRow(BindingSource bindingSource, string column)
        {
            return ((DataRowView)bindingSource[bindingSource.Position])[column].ToString().Trim();
        }

        private void gridViewVatTu_Click(object sender, EventArgs e)
        {
            tbMaVT.Text = getDataRow(vattuBindingSource, "MAVT");
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
        private void SubFormCTDDH_FormClosing(object sender, FormClosingEventArgs e)
        {          
            Program.formMain.Enabled = true;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!checkValidate(tbMaVT, "Mã VT is not empty!")) return;
            if (nuDonGia.Value == 0)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 0!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ((DataRowView)cTDDHBindingSource[cTDDHBindingSource.Position])["MAVT"] = this.tbMaVT.Text;
            this.cTDDHBindingSource.EndEdit();
            this.cTDDHTableAdapter.Update(Program.formNhanvien.getDataSet().CTDDH);
            this.Close();
        }
    }
}