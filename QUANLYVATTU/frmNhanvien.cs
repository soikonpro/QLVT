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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Menu;
using DevExpress.Utils.Menu;

namespace QUANLYVATTU
{
    public partial class frmNhanvien : DevExpress.XtraEditors.XtraForm
    {
        private int position;
        private string maCN = "";
        public frmNhanvien()
        {
            InitializeComponent();

        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhanVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetServer2);

        }

        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetServer2.CTPX' table. You can move, or remove it, as needed.
            this.cTPXTableAdapter.Fill(this.dataSetServer2.CTPX);
            // TODO: This line of code loads data into the 'dataSetServer2.PhieuXuat' table. You can move, or remove it, as needed.
            this.phieuXuatTableAdapter.Fill(this.dataSetServer2.PhieuXuat);
            // TODO: This line of code loads data into the 'dataSetServer2.CTPN' table. You can move, or remove it, as needed.
            this.cTPNTableAdapter.Fill(this.dataSetServer2.CTPN);
            // TODO: This line of code loads data into the 'dataSetServer2.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Fill(this.dataSetServer2.PhieuNhap);
            gbInfor.Height = 270;
            gbDatHang.Height = 270;
            gbPhieuNhap.Height = 270;
            gbPhieuXuat.Height = 270;
            this.v_DS_PHANMANHTableAdapter.Fill(this.dS_DSPM.V_DS_PHANMANH);
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.datHangTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connectionString;
           
            this.cTDDHTableAdapter.Fill(this.dataSetServer2.CTDDH);
            this.datHangTableAdapter.Fill(this.dataSetServer2.DatHang);          
            this.nhanVienTableAdapter.Fill(this.dataSetServer2.NhanVien);
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
            maCN = (((DataRowView)nhanVienBindingSource[0])["MACN"].ToString());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            position = nhanVienBindingSource.Position;
            this.nhanVienBindingSource.AddNew();
            mANVNumericUpDown.Value = newMANV();
            lUONGNumericUpDown.Value = 4000000;
            mACNTextBox.Text = maCN;
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
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectionString;
                    // TODO: This line of code loads data into the 'dataSetServer2.NhanVien' table. You can move, or remove it, as needed.
                    this.nhanVienTableAdapter.Fill(this.dataSetServer2.NhanVien);
                }
            }
        }
        public static int newMANV()
        {
            string query = "SELECT * FROM DS_MANV1";
            SqlCommand sqlCommand = new SqlCommand(query, Program.connection);
            SqlDataReader dataReader = null;
            List<int> list = new List<int>();
            try
            {
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    list.Add(dataReader.GetInt32(0));
                }
                dataReader.Close();

                for (int i = 1; i <= list[list.Count - 1]; i++)
                {
                    if (list.BinarySearch(i) < 0) return i; //Tìm thấy số âm tức số đó chưa tồn tại. Nhận số đó là ID mới
                }
                return list[(list.Count - 1)] + 1;    //Nếu duyệt từ bé đến lớn trong dãy không có MANV mới sẽ +1 lên
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm Mã Nhân Viên mới! \n" + ex.Message, "Notification", MessageBoxButtons.OK);
                dataReader.Close();
            }
            return -1;  //Không tìm thấy trả -1 đánh dấu Dừng chương trình
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            this.nhanVienBindingSource.EndEdit();
            this.nhanVienTableAdapter.Update(this.dataSetServer2.NhanVien);
            nhanVienBindingSource.Position = position;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            nhanVienBindingSource.RemoveCurrent();
            this.nhanVienTableAdapter.Update(this.dataSetServer2.NhanVien);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectionString;
            // TODO: This line of code loads data into the 'dataSetServer2.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.dataSetServer2.NhanVien);
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            nhanVienBindingSource.CancelEdit();
            nhanVienBindingSource.Position = position;
        }

        private void gbInfor_Enter(object sender, EventArgs e)
        {

        }

        private void btnPNH_Click(object sender, EventArgs e)
        {
            this.gbPhieuNhap.Visible = true;
            this.gbInfor.Visible = false;
            this.gbDatHang.Visible = false;
            this.gbPhieuXuat.Visible = false;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.gbPhieuNhap.Visible = false;
            this.gbInfor.Visible = true;
            this.gbDatHang.Visible = false;
            this.gbPhieuXuat.Visible = false;
        }

        private void btnDH_Click(object sender, EventArgs e)
        {
            this.gbPhieuNhap.Visible = false;
            this.gbInfor.Visible = false;
            this.gbDatHang.Visible = true;
            this.gbPhieuXuat.Visible = false;

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {

        }

        private void btnPXu_Click(object sender, EventArgs e)
        {
            this.gbPhieuNhap.Visible = false;
            this.gbInfor.Visible = false;
            this.gbDatHang.Visible = false;
            this.gbPhieuXuat.Visible = true;
        }

       

        private void gridViewDDH_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            int maNVLapDDH = 0;
            if (this.gridViewDDH.GetRowCellValue(this.fKDatHangNhanVienBindingSource.Position, "MANV") != null)
            {
                maNVLapDDH = int.Parse(this.gridViewDDH.GetRowCellValue(this.fKDatHangNhanVienBindingSource.Position, "MANV").ToString().Trim());
            }
            if (e.MenuType == GridMenuType.Row)
            {
                GridViewMenu menu = e.Menu;
                DXMenuItem menuAddDDH = createMenuItem("Thêm DDH");
                menuAddDDH.Click += new EventHandler(menuAddDDH_Click);
                menu.Items.Add(menuAddDDH);

                if (maNVLapDDH == Program.manv)
                {
                    DXMenuItem menuAddCTDDH = createMenuItem("Thêm chi tiết DDH");
                    DXMenuItem menuAddPN = createMenuItem("Thêm Phiếu Nhập");
                    menuAddCTDDH.Click += new EventHandler(menuAddChiTietDDH_Click);
                    menuAddPN.Click += new EventHandler(menuAddPN_Click);
                    menu.Items.Add(menuAddCTDDH);
                    menu.Items.Add(menuAddPN);
                }
            }
        }
        private void menuAddDDH_Click(object sender, EventArgs e)   //MenuItem của PopupMenu
        {
            Program.SubFormDDH = new SubFormDDH();
            Program.SubFormDDH.Show();
           // Program.formMain.Enabled = false;
            nhanVienBindingSource.Position = nhanVienBindingSource.Find("MANV", Program.manv);
        }
        private void menuAddPN_Click(object sender, EventArgs e)   //MenuItem của PopupMenu
        {

            if (this.fKPhieuNhapDatHangBindingSource.Count > 0)
            {
                MessageBox.Show("Đơn đặt hàng này đã được lập Phiếu Nhập!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Program.SubFormPN = new SubFormPN();
            Program.SubFormPN.Show();
            Program.formMain.Enabled = false;
        }
        private void menuAddChiTietDDH_Click(object sender, EventArgs e)//MenuItem của PopupMenu
        {
            Program.SubFormCTDDH = new SubFormCTDDH();
            Program.SubFormCTDDH.Show();
            Program.formMain.Enabled = false;
        }
        private DXMenuItem createMenuItem(string caption)
        {
            DXMenuItem menuItem = new DXMenuItem();
           // menuItem.Image = image;
            menuItem.Caption = caption;
            return menuItem;
        }

        private void gridViewCTPN_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            int maNVLapDDH = 0;
            if (this.gridViewDDH.GetRowCellValue(this.fKDatHangNhanVienBindingSource.Position, "MANV") != null)
            {
                maNVLapDDH = int.Parse(this.gridViewDDH.GetRowCellValue(this.fKDatHangNhanVienBindingSource.Position, "MANV").ToString().Trim());
            }
            if (e.MenuType == GridMenuType.Row && maNVLapDDH == Program.manv)
            {
                GridViewMenu menu = e.Menu;
                DXMenuItem menuAddCTPN = createMenuItem("Thêm chi tiết Phiếu Nhập");
                menuAddCTPN.Click += new EventHandler(menuAddCTPN_Click);
                menu.Items.Add(menuAddCTPN);
            }
        }
        private void menuAddCTPN_Click(object sender, EventArgs e)
        {
            if (this.fKCTDDHDatHangBindingSource.Count == 0)
            {
                MessageBox.Show("Đơn Đặt hàng của Phiếu Nhập này chưa có Chi Tiết Đơn Đặt Hàng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (this.fKCTDDHDatHangBindingSource.Count == this.fKCTPNPhieuNhapBindingSource.Count)
            {
                MessageBox.Show("Đơn đặt hàng này đã lập đủ Chi Tiết Phiếu Nhập!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Program.SubFormCTPN = new SubFormCTPN();
            Program.SubFormCTPN.Show();
            Program.formMain.Enabled = false;
        }

        private void gridViewPhieuXuat_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            int maNVLapPX = 0;
            if (gridViewPhieuXuat.GetRowCellValue(this.fKPXNhanVienBindingSource.Position, "MANV") != null)
            {
                maNVLapPX = int.Parse(gridViewPhieuXuat.GetRowCellValue(this.fKPXNhanVienBindingSource.Position, "MANV").ToString().Trim());
            }
            if (e.MenuType == GridMenuType.Row)
            {
                GridViewMenu menu = e.Menu;
                DXMenuItem menuAddPX = createMenuItem("Thêm Phiếu Xuất");
                menuAddPX.Click += new EventHandler(menuAddPX_Click);
                menu.Items.Add(menuAddPX);

                if (maNVLapPX == Program.manv)
                {
                    DXMenuItem menuAddCTPX = createMenuItem("Thêm chi tiết Phiếu Xuất");
                    menuAddCTPX.Click += new EventHandler(menuAddCTPX_Click);
                    menu.Items.Add(menuAddCTPX);
                }
            }
        }
        private void menuAddPX_Click(object sender, EventArgs e)
        {
            Program.SubFormPX = new SubFormPX();
            Program.SubFormPX.Show();
            Program.formMain.Enabled = false;
            nhanVienBindingSource.Position = nhanVienBindingSource.Find("MANV", Program.manv);
        }
        private void menuAddCTPX_Click(object sender, EventArgs e)
        {
            Program.SubFormCTPX = new SubFormCTPX();
            Program.SubFormCTPX.Show();
            Program.formMain.Enabled = false;
        }

        private void gridViewCTPX_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            int maNVLapPX = 0;
            if (this.gridViewPhieuXuat.GetRowCellValue(this.fKPXNhanVienBindingSource.Position, "MANV") != null)
            {
                maNVLapPX = int.Parse(this.gridViewPhieuXuat.GetRowCellValue(this.fKPXNhanVienBindingSource.Position, "MANV").ToString().Trim());
            }
            if (e.MenuType == GridMenuType.Row && maNVLapPX == Program.manv)
            {
                GridViewMenu menu = e.Menu;
                DXMenuItem menuAddCTPX = createMenuItem("Thêm chi tiết Phiếu Xuất");
                menuAddCTPX.Click += new EventHandler(menuAddCTPX_Click);
                menu.Items.Add(menuAddCTPX);
            }
        }
        public BindingSource getDatHangBDS()
        {
            return this.fKDatHangNhanVienBindingSource;
        }
        public DataSetServer2 getDataSet()
        {
            return this.dataSetServer2;
        }
        public BindingSource getCTDatHangBDS()
        {
            return this.fKCTDDHDatHangBindingSource;
        }
        public BindingSource getPhieuNhap()
        {
            return this.fKPhieuNhapDatHangBindingSource;
        }
        public BindingSource getCTPhieuNhapBDS()
        {
            return this.fKCTPNPhieuNhapBindingSource;
        }
        public BindingSource getPhieuNhapBDS()
        {
            return this.fKPhieuNhapDatHangBindingSource;
        }
    }
}