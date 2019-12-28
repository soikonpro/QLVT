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
using System.Data.SqlClient;

namespace QUANLYVATTU
{
    public partial class frmKho : DevExpress.XtraEditors.XtraForm
    {
        private string maCN = "";
        private int position;
        public frmKho()
        {
            InitializeComponent();
        }

        private void khoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.khoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetServer2);

        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_DSPM.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.dS_DSPM.V_DS_PHANMANH);
            // TODO: This line of code loads data into the 'dataSetServer2.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Fill(this.dataSetServer2.Kho);
            if (Program.group.Equals("CONGTY"))
            {
                this.cbChiNhanh.Visible = true;
                this.lbChiNhanh.Visible = true;
            }
            else
            {
                this.cbChiNhanh.Visible = false;
                this.lbChiNhanh.Visible = false;
            }
            maCN = (((DataRowView)khoBindingSource[0])["MACN"].ToString());
        }

        private void cbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbChiNhanh.ValueMember != "")
            {
                if (this.cbChiNhanh.SelectedValue != null && Program.server != this.cbChiNhanh.SelectedValue.ToString())
                {
                    Program.server = cbChiNhanh.SelectedValue.ToString();
                    try
                    {
                        Program.connectionString = "Server=" + Program.server + ";"
                                        + "database=QLVT_DATHANG;"
                                        + "User id=" + Program.loginHienTai + ";"
                                        + "Password=" + Program.passwordHienTai;
                        Program.connection = new SqlConnection(Program.connectionString);
                        Program.connection.Open();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kết nối Server thất bại! " + ex.Message, "Notification", MessageBoxButtons.OK);
                        return;
                    }
                    this.khoTableAdapter.Connection.ConnectionString = Program.connectionString;
                    // TODO: This line of code loads data into the 'dataSetServer2.NhanVien' table. You can move, or remove it, as needed.
                    this.khoTableAdapter.Fill(this.dataSetServer2.Kho);
                }
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            position = khoBindingSource.Position;
            this.khoBindingSource.AddNew();
            mACNTextBox.Text = maCN;
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            this.khoBindingSource.EndEdit();
            this.khoTableAdapter.Update(this.dataSetServer2.Kho);
            khoBindingSource.Position = position;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            khoBindingSource.RemoveCurrent();
            this.khoTableAdapter.Update(this.dataSetServer2.Kho);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            this.khoTableAdapter.Fill(this.dataSetServer2.Kho);
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            khoBindingSource.CancelEdit();
            khoBindingSource.Position = position;
        }
    }
}