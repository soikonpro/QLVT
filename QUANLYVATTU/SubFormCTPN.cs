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
    public partial class SubFormCTPN : DevExpress.XtraEditors.XtraForm
    {
        public SubFormCTPN()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhanVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetServer2);

        }

        private void SubFormCTPN_Load(object sender, EventArgs e)
        {
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.cTPNTableAdapter.Connection.ConnectionString = Program.connectionString;

            this.cTDDHTableAdapter.Fill(this.dataSetServer2.CTDDH);
            this.cTPNTableAdapter.Fill(this.dataSetServer2.CTPN);

            this.cTDDHBindingSource.DataSource = Program.formNhanvien.getCTDatHangBDS();
            this.cTPNBindingSource.DataSource = Program.formNhanvien.getCTPhieuNhapBDS();

        }

        private void SubFormCTPN_Shown(object sender, EventArgs e)
        {
            this.cTPNBindingSource.AddNew();
            BindingSource tempPN = Program.formNhanvien.getPhieuNhapBDS();
            if (tempPN.Position != -1 && cTDDHBindingSource.Position != -1)
            {
                tbMaPN.Text = ((DataRowView)tempPN[tempPN.Position])["MAPN"].ToString().Trim();
                tbMaVT.Text = ((DataRowView)cTDDHBindingSource[cTDDHBindingSource.Position])["MAVT"].ToString().Trim();
                nuSoLuong.Maximum = int.Parse(this.gridView1.GetRowCellValue(cTDDHBindingSource.Position, "SOLUONG").ToString().Trim());
                nuSoLuong.Value = nuSoLuong.Minimum;
                nuDonGia.Value = 0;
            }
        }
        private void SubFormCTPN_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.formMain.Enabled = true;
        }
        private void gvCTDDH_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (cTDDHBindingSource.Position != -1) //Trường hợp không có dữ liệu
            {
                tbMaVT.Text = gridView1.GetRowCellValue(cTDDHBindingSource.Position, "MAVT").ToString().Trim();
                nuSoLuong.Maximum = int.Parse(gridView1.GetRowCellValue(cTDDHBindingSource.Position, "SOLUONG").ToString().Trim());
            }
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
            if (!checkValidate(tbMaPN, "Mã Phiếu Nhập is not empty!")) return;
            if (!checkValidate(tbMaVT, "Mã VT is not empty!")) return;
        }
    }
}