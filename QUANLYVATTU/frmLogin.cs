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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            executeLogin();
        }

        private void chiNhanhBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_DSPM.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.dS_DSPM.V_DS_PHANMANH);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void executeLogin()
        {
            if (tbUsername.Text.Trim() == "")
            {
                MessageBox.Show("Username is not empty!", "Error message", MessageBoxButtons.OK);
                tbUsername.Focus();
                return;
            }

            Program.server = cbChiNhanh.SelectedValue.ToString();
            Program.loginName = tbUsername.Text;    //Successfully send the userID to Program to push through FormMain
            Program.password = tbPassword.Text;

            Program.connectionString = "Server=" + Program.server + ";"
                                    + "database=QLVT_DATHANG;"
                                    + "User id=" + Program.loginName + ";"
                                    + "Password=" + Program.password;
            Program.connection = new SqlConnection(Program.connectionString);
            try
            {   // mở kết nối
                Program.connection.Open();

                // xác đinh group 
                string query = "EXEC SP_DANGNHAP " + Program.loginName;
                SqlCommand sqlCommand = new SqlCommand(query, Program.connection);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                dataReader.Read();
                Program.manv = int.Parse(dataReader.GetValue(0).ToString());
                //sslMANV.Text = "Mã NV: " + Program.manv;
                //sslTEN.Text = "Họ và tên: " + dataReader.GetValue(1).ToString();
                Program.group = dataReader.GetValue(2).ToString();
                //sslNHOM.Text = "Nhóm: " + Program.group;
                dataReader.Close();
                //
                Program.loginHienTai = Program.loginName;
                Program.passwordHienTai = Program.password;
                Program.formMain = new frmMain();
                Program.formMain.Activate();
                Program.formMain.Show();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Username or password incorrect " + ex.Message, "Error message", MessageBoxButtons.OK);
                tbUsername.Focus();
                return;
            }
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = (cbShow.Checked) ? false : true;
        }
    }
}