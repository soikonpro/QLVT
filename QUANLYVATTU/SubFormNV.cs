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
    public partial class SubFormNV : DevExpress.XtraEditors.XtraForm
    {
        public SubFormNV()
        {
            InitializeComponent();
        }

        private void SubFormNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetServer2.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.dataSetServer2.NhanVien);
            if (Program.group == "CHINHANH" || Program.group == "USER")
            {
                cbChiNhanh.Visible = false;
                label1.Visible = false;
            }
      
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.nhanVienTableAdapter.Fill(this.dataSetServer2.NhanVien);
            this.cbChiNhanh.DataSource = Program.bindingSourceChiNhanh; //DataSource của cbChiNhanh tham chiếu đến bindingSource ở LoginForm
            cbChiNhanh.DisplayMember = "description";
            cbChiNhanh.ValueMember = "subscriber_server";
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhanVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetServer2);

        }

        private void cbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbChiNhanh.ValueMember != "")   //Xử lý trường hợp Event autorun khi vừa khởi chạy project
            {
                if (this.cbChiNhanh.SelectedValue != null && Program.server != this.cbChiNhanh.SelectedValue.ToString()) //Khi enable FormNhanVien thì value = null nên lỗi
                {
                    Program.server = this.cbChiNhanh.SelectedValue.ToString();
                    if (Program.loginHienTai != Program.remoteLogin) //Why?
                    {
                        Program.loginHienTai = Program.remoteLogin;
                        Program.passwordHienTai = Program.remotePassword;
                    }
                    else
                    {
                        Program.loginHienTai = Program.loginName;
                        Program.passwordHienTai = Program.password;
                    }
                    try
                    {
                        Program.connectionString = "Server=" + Program.server + ";"
                                        + "database=QLVT;"
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
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectionString;
                    this.nhanVienTableAdapter.Fill(this.qLVTDataSet.NhanVien);
                }
            }
        }
    }
}