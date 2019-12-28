namespace QUANLYVATTU
{
    partial class frmNhanvien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label lUONGLabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label mANVLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanvien));
            this.dataSetServer2 = new QUANLYVATTU.DataSetServer2();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new QUANLYVATTU.DataSetServer2TableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new QUANLYVATTU.DataSetServer2TableAdapters.TableAdapterManager();
            this.nhanVienGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewNhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelChiNhanh = new System.Windows.Forms.Panel();
            this.btnInfo = new DevExpress.XtraEditors.SimpleButton();
            this.btnPXu = new DevExpress.XtraEditors.SimpleButton();
            this.btnPNH = new DevExpress.XtraEditors.SimpleButton();
            this.btnDH = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.btnReload = new DevExpress.XtraEditors.SimpleButton();
            this.btnUndo = new DevExpress.XtraEditors.SimpleButton();
            this.btnGhi = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.cbChiNhanh = new System.Windows.Forms.ComboBox();
            this.v_DS_PHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_DSPM = new QUANLYVATTU.DS_DSPM();
            this.lbChiNhanh = new System.Windows.Forms.Label();
            this.gbInfor = new System.Windows.Forms.GroupBox();
            this.mANVNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lUONGNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nGAYSINHDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.trangThaiXoaCheckBox = new System.Windows.Forms.CheckBox();
            this.lbInfor = new System.Windows.Forms.Label();
            this.mACNTextBox = new System.Windows.Forms.TextBox();
            this.dIACHITextBox = new System.Windows.Forms.TextBox();
            this.tENTextBox = new System.Windows.Forms.TextBox();
            this.hOTextBox = new System.Windows.Forms.TextBox();
            this.fKCTDDHDatHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKDatHangNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DS_PHANMANHTableAdapter = new QUANLYVATTU.DS_DSPMTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager1 = new QUANLYVATTU.DS_DSPMTableAdapters.TableAdapterManager();
            this.datHangTableAdapter = new QUANLYVATTU.DataSetServer2TableAdapters.DatHangTableAdapter();
            this.cTDDHTableAdapter = new QUANLYVATTU.DataSetServer2TableAdapters.CTDDHTableAdapter();
            this.gbDatHang = new System.Windows.Forms.GroupBox();
            this.gcCTDDH = new DevExpress.XtraGrid.GridControl();
            this.gridViewCTDDH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.gcDDH = new DevExpress.XtraGrid.GridControl();
            this.gridViewDDH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbPhieuNhap = new System.Windows.Forms.GroupBox();
            this.gcCTPN = new DevExpress.XtraGrid.GridControl();
            this.fKCTPNPhieuNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKPhieuNhapDatHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPhieuNhap = new DevExpress.XtraGrid.GridControl();
            this.gridViewCTPN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasoDDH2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDatHangByPN = new DevExpress.XtraGrid.GridControl();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaCC1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.phieuNhapTableAdapter = new QUANLYVATTU.DataSetServer2TableAdapters.PhieuNhapTableAdapter();
            this.cTPNTableAdapter = new QUANLYVATTU.DataSetServer2TableAdapters.CTPNTableAdapter();
            this.gbPhieuXuat = new System.Windows.Forms.GroupBox();
            this.gcCTPX = new DevExpress.XtraGrid.GridControl();
            this.fKCTPXPXBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKPXNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewCTPX = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPX1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPhieuXuat = new DevExpress.XtraGrid.GridControl();
            this.gridViewPhieuXuat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.phieuXuatTableAdapter = new QUANLYVATTU.DataSetServer2TableAdapters.PhieuXuatTableAdapter();
            this.cTPXTableAdapter = new QUANLYVATTU.DataSetServer2TableAdapters.CTPXTableAdapter();
            mACNLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            lUONGLabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetServer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNhanVien)).BeginInit();
            this.panelChiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPM)).BeginInit();
            this.gbInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mANVNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUONGNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYSINHDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYSINHDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCTDDHDatHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDatHangNhanVienBindingSource)).BeginInit();
            this.gbDatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDDH)).BeginInit();
            this.gbPhieuNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCTPNPhieuNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPhieuNhapDatHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatHangByPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            this.gbPhieuXuat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCTPXPXBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPXNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPhieuXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            mACNLabel.Location = new System.Drawing.Point(207, 159);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(52, 17);
            mACNLabel.TabIndex = 12;
            mACNLabel.Text = "Mã CN:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dIACHILabel.Location = new System.Drawing.Point(205, 116);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(53, 17);
            dIACHILabel.TabIndex = 10;
            dIACHILabel.Text = "Địa chỉ:";
            // 
            // lUONGLabel
            // 
            lUONGLabel.AutoSize = true;
            lUONGLabel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            lUONGLabel.Location = new System.Drawing.Point(563, 79);
            lUONGLabel.Name = "lUONGLabel";
            lUONGLabel.Size = new System.Drawing.Size(53, 17);
            lUONGLabel.TabIndex = 8;
            lUONGLabel.Text = "Lương:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            nGAYSINHLabel.Location = new System.Drawing.Point(188, 82);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(73, 17);
            nGAYSINHLabel.TabIndex = 6;
            nGAYSINHLabel.Text = "Ngày sinh:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            tENLabel.Location = new System.Drawing.Point(582, 44);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(36, 17);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "Tên:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            hOLabel.Location = new System.Drawing.Point(407, 44);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(30, 17);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "Họ:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            mANVLabel.Location = new System.Drawing.Point(207, 44);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(51, 17);
            mANVLabel.TabIndex = 0;
            mANVLabel.Text = "Mã NV:";
            // 
            // dataSetServer2
            // 
            this.dataSetServer2.DataSetName = "DataSetServer2";
            this.dataSetServer2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.dataSetServer2;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QUANLYVATTU.DataSetServer2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // nhanVienGridControl
            // 
            this.nhanVienGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nhanVienGridControl.DataSource = this.nhanVienBindingSource;
            this.nhanVienGridControl.Location = new System.Drawing.Point(0, 63);
            this.nhanVienGridControl.MainView = this.gridViewNhanVien;
            this.nhanVienGridControl.Name = "nhanVienGridControl";
            this.nhanVienGridControl.Size = new System.Drawing.Size(1326, 340);
            this.nhanVienGridControl.TabIndex = 1;
            this.nhanVienGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNhanVien});
            // 
            // gridViewNhanVien
            // 
            this.gridViewNhanVien.GridControl = this.nhanVienGridControl;
            this.gridViewNhanVien.Name = "gridViewNhanVien";
            // 
            // panelChiNhanh
            // 
            this.panelChiNhanh.Controls.Add(this.btnInfo);
            this.panelChiNhanh.Controls.Add(this.btnPXu);
            this.panelChiNhanh.Controls.Add(this.btnPNH);
            this.panelChiNhanh.Controls.Add(this.btnDH);
            this.panelChiNhanh.Controls.Add(this.btnThoat);
            this.panelChiNhanh.Controls.Add(this.simpleButton6);
            this.panelChiNhanh.Controls.Add(this.btnReload);
            this.panelChiNhanh.Controls.Add(this.btnUndo);
            this.panelChiNhanh.Controls.Add(this.btnGhi);
            this.panelChiNhanh.Controls.Add(this.btnXoa);
            this.panelChiNhanh.Controls.Add(this.btnThem);
            this.panelChiNhanh.Controls.Add(this.cbChiNhanh);
            this.panelChiNhanh.Controls.Add(this.lbChiNhanh);
            this.panelChiNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChiNhanh.Location = new System.Drawing.Point(0, 0);
            this.panelChiNhanh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelChiNhanh.Name = "panelChiNhanh";
            this.panelChiNhanh.Size = new System.Drawing.Size(1326, 56);
            this.panelChiNhanh.TabIndex = 5;
            // 
            // btnInfo
            // 
            this.btnInfo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.ImageOptions.Image")));
            this.btnInfo.Location = new System.Drawing.Point(850, 13);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 32);
            this.btnInfo.TabIndex = 12;
            this.btnInfo.Text = "Info";
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnPXu
            // 
            this.btnPXu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPXu.ImageOptions.Image")));
            this.btnPXu.Location = new System.Drawing.Point(769, 13);
            this.btnPXu.Name = "btnPXu";
            this.btnPXu.Size = new System.Drawing.Size(75, 32);
            this.btnPXu.TabIndex = 11;
            this.btnPXu.Text = "PX";
            this.btnPXu.Click += new System.EventHandler(this.btnPXu_Click);
            // 
            // btnPNH
            // 
            this.btnPNH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPNH.ImageOptions.Image")));
            this.btnPNH.Location = new System.Drawing.Point(688, 13);
            this.btnPNH.Name = "btnPNH";
            this.btnPNH.Size = new System.Drawing.Size(75, 32);
            this.btnPNH.TabIndex = 10;
            this.btnPNH.Text = "PN";
            this.btnPNH.Click += new System.EventHandler(this.btnPNH_Click);
            // 
            // btnDH
            // 
            this.btnDH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDH.ImageOptions.Image")));
            this.btnDH.Location = new System.Drawing.Point(608, 13);
            this.btnDH.Name = "btnDH";
            this.btnDH.Size = new System.Drawing.Size(74, 32);
            this.btnDH.TabIndex = 9;
            this.btnDH.Text = "DDH";
            this.btnDH.Click += new System.EventHandler(this.btnDH_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(956, 12);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 32);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // simpleButton6
            // 
            this.simpleButton6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton6.ImageOptions.Image")));
            this.simpleButton6.Location = new System.Drawing.Point(444, 13);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(158, 32);
            this.simpleButton6.TabIndex = 7;
            this.simpleButton6.Text = "Chuyển chi nhánh";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // btnReload
            // 
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.Location = new System.Drawing.Point(357, 12);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(80, 33);
            this.btnReload.TabIndex = 6;
            this.btnReload.Text = "Reload";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.Image")));
            this.btnUndo.Location = new System.Drawing.Point(271, 12);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(80, 32);
            this.btnUndo.TabIndex = 5;
            this.btnUndo.Text = "Undo";
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.Location = new System.Drawing.Point(184, 12);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(80, 32);
            this.btnGhi.TabIndex = 4;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(98, 12);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 32);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(12, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 32);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbChiNhanh
            // 
            this.cbChiNhanh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbChiNhanh.DataSource = this.v_DS_PHANMANHBindingSource;
            this.cbChiNhanh.DisplayMember = "TENCN";
            this.cbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChiNhanh.FormattingEnabled = true;
            this.cbChiNhanh.Location = new System.Drawing.Point(1113, 13);
            this.cbChiNhanh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbChiNhanh.Name = "cbChiNhanh";
            this.cbChiNhanh.Size = new System.Drawing.Size(201, 24);
            this.cbChiNhanh.TabIndex = 1;
            this.cbChiNhanh.ValueMember = "TENSERVER";
            this.cbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbChiNhanh_SelectedIndexChanged);
            // 
            // v_DS_PHANMANHBindingSource
            // 
            this.v_DS_PHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.v_DS_PHANMANHBindingSource.DataSource = this.dS_DSPM;
            // 
            // dS_DSPM
            // 
            this.dS_DSPM.DataSetName = "DS_DSPM";
            this.dS_DSPM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbChiNhanh
            // 
            this.lbChiNhanh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbChiNhanh.AutoSize = true;
            this.lbChiNhanh.Location = new System.Drawing.Point(1042, 17);
            this.lbChiNhanh.Name = "lbChiNhanh";
            this.lbChiNhanh.Size = new System.Drawing.Size(70, 17);
            this.lbChiNhanh.TabIndex = 0;
            this.lbChiNhanh.Text = "Chi nhánh";
            // 
            // gbInfor
            // 
            this.gbInfor.Controls.Add(this.mANVNumericUpDown);
            this.gbInfor.Controls.Add(this.lUONGNumericUpDown);
            this.gbInfor.Controls.Add(this.nGAYSINHDateEdit);
            this.gbInfor.Controls.Add(this.trangThaiXoaCheckBox);
            this.gbInfor.Controls.Add(this.lbInfor);
            this.gbInfor.Controls.Add(mACNLabel);
            this.gbInfor.Controls.Add(this.mACNTextBox);
            this.gbInfor.Controls.Add(dIACHILabel);
            this.gbInfor.Controls.Add(this.dIACHITextBox);
            this.gbInfor.Controls.Add(lUONGLabel);
            this.gbInfor.Controls.Add(nGAYSINHLabel);
            this.gbInfor.Controls.Add(tENLabel);
            this.gbInfor.Controls.Add(this.tENTextBox);
            this.gbInfor.Controls.Add(hOLabel);
            this.gbInfor.Controls.Add(this.hOTextBox);
            this.gbInfor.Controls.Add(mANVLabel);
            this.gbInfor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbInfor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbInfor.Location = new System.Drawing.Point(0, 576);
            this.gbInfor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbInfor.Name = "gbInfor";
            this.gbInfor.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbInfor.Size = new System.Drawing.Size(1326, 49);
            this.gbInfor.TabIndex = 12;
            this.gbInfor.TabStop = false;
            this.gbInfor.Text = "Thông tin Nhân Viên";
            this.gbInfor.Enter += new System.EventHandler(this.gbInfor_Enter);
            // 
            // mANVNumericUpDown
            // 
            this.mANVNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.nhanVienBindingSource, "MANV", true));
            this.mANVNumericUpDown.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.mANVNumericUpDown.Location = new System.Drawing.Point(260, 40);
            this.mANVNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mANVNumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.mANVNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mANVNumericUpDown.Name = "mANVNumericUpDown";
            this.mANVNumericUpDown.Size = new System.Drawing.Size(128, 24);
            this.mANVNumericUpDown.TabIndex = 1;
            this.mANVNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lUONGNumericUpDown
            // 
            this.lUONGNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.nhanVienBindingSource, "LUONG", true));
            this.lUONGNumericUpDown.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lUONGNumericUpDown.Location = new System.Drawing.Point(623, 74);
            this.lUONGNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lUONGNumericUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.lUONGNumericUpDown.Minimum = new decimal(new int[] {
            4000000,
            0,
            0,
            0});
            this.lUONGNumericUpDown.Name = "lUONGNumericUpDown";
            this.lUONGNumericUpDown.Size = new System.Drawing.Size(149, 24);
            this.lUONGNumericUpDown.TabIndex = 5;
            this.lUONGNumericUpDown.ThousandsSeparator = true;
            this.lUONGNumericUpDown.Value = new decimal(new int[] {
            4000000,
            0,
            0,
            0});
            // 
            // nGAYSINHDateEdit
            // 
            this.nGAYSINHDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "NGAYSINH", true));
            this.nGAYSINHDateEdit.EditValue = new System.DateTime(2019, 11, 14, 0, 0, 0, 0);
            this.nGAYSINHDateEdit.Location = new System.Drawing.Point(260, 77);
            this.nGAYSINHDateEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nGAYSINHDateEdit.Name = "nGAYSINHDateEdit";
            this.nGAYSINHDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYSINHDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYSINHDateEdit.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.nGAYSINHDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.nGAYSINHDateEdit.Size = new System.Drawing.Size(233, 22);
            this.nGAYSINHDateEdit.TabIndex = 4;
            // 
            // trangThaiXoaCheckBox
            // 
            this.trangThaiXoaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.nhanVienBindingSource, "TrangThaiXoa", true));
            this.trangThaiXoaCheckBox.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.trangThaiXoaCheckBox.Location = new System.Drawing.Point(655, 149);
            this.trangThaiXoaCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trangThaiXoaCheckBox.Name = "trangThaiXoaCheckBox";
            this.trangThaiXoaCheckBox.Size = new System.Drawing.Size(121, 30);
            this.trangThaiXoaCheckBox.TabIndex = 18;
            this.trangThaiXoaCheckBox.Text = "Trạng thái xóa";
            this.trangThaiXoaCheckBox.UseVisualStyleBackColor = true;
            // 
            // lbInfor
            // 
            this.lbInfor.AutoSize = true;
            this.lbInfor.Location = new System.Drawing.Point(37, 27);
            this.lbInfor.MinimumSize = new System.Drawing.Size(149, 158);
            this.lbInfor.Name = "lbInfor";
            this.lbInfor.Size = new System.Drawing.Size(149, 158);
            this.lbInfor.TabIndex = 17;
            // 
            // mACNTextBox
            // 
            this.mACNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "MACN", true));
            this.mACNTextBox.Enabled = false;
            this.mACNTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.mACNTextBox.Location = new System.Drawing.Point(260, 155);
            this.mACNTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mACNTextBox.Name = "mACNTextBox";
            this.mACNTextBox.Size = new System.Drawing.Size(116, 24);
            this.mACNTextBox.TabIndex = 13;
            // 
            // dIACHITextBox
            // 
            this.dIACHITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "DIACHI", true));
            this.dIACHITextBox.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.dIACHITextBox.Location = new System.Drawing.Point(260, 112);
            this.dIACHITextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dIACHITextBox.Name = "dIACHITextBox";
            this.dIACHITextBox.Size = new System.Drawing.Size(511, 24);
            this.dIACHITextBox.TabIndex = 6;
            // 
            // tENTextBox
            // 
            this.tENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "TEN", true));
            this.tENTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tENTextBox.Location = new System.Drawing.Point(623, 40);
            this.tENTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tENTextBox.Name = "tENTextBox";
            this.tENTextBox.Size = new System.Drawing.Size(149, 24);
            this.tENTextBox.TabIndex = 3;
            // 
            // hOTextBox
            // 
            this.hOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "HO", true));
            this.hOTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.hOTextBox.Location = new System.Drawing.Point(444, 40);
            this.hOTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hOTextBox.Name = "hOTextBox";
            this.hOTextBox.Size = new System.Drawing.Size(116, 24);
            this.hOTextBox.TabIndex = 2;
            // 
            // fKCTDDHDatHangBindingSource
            // 
            this.fKCTDDHDatHangBindingSource.DataMember = "FK_CTDDH_DatHang";
            this.fKCTDDHDatHangBindingSource.DataSource = this.fKDatHangNhanVienBindingSource;
            // 
            // fKDatHangNhanVienBindingSource
            // 
            this.fKDatHangNhanVienBindingSource.DataMember = "FK_DatHang_NhanVien";
            this.fKDatHangNhanVienBindingSource.DataSource = this.nhanVienBindingSource;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = QUANLYVATTU.DS_DSPMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // gbDatHang
            // 
            this.gbDatHang.Controls.Add(this.gcCTDDH);
            this.gbDatHang.Controls.Add(this.gridSplitContainer1);
            this.gbDatHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbDatHang.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbDatHang.Location = new System.Drawing.Point(0, 460);
            this.gbDatHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDatHang.Name = "gbDatHang";
            this.gbDatHang.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDatHang.Size = new System.Drawing.Size(1326, 116);
            this.gbDatHang.TabIndex = 27;
            this.gbDatHang.TabStop = false;
            this.gbDatHang.Text = "Danh sách Đơn Đặt Hàng";
            this.gbDatHang.Visible = false;
            // 
            // gcCTDDH
            // 
            this.gcCTDDH.DataSource = this.fKCTDDHDatHangBindingSource;
            this.gcCTDDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCTDDH.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcCTDDH.Location = new System.Drawing.Point(679, 21);
            this.gcCTDDH.MainView = this.gridViewCTDDH;
            this.gcCTDDH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcCTDDH.Name = "gcCTDDH";
            this.gcCTDDH.Size = new System.Drawing.Size(644, 91);
            this.gcCTDDH.TabIndex = 1;
            this.gcCTDDH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCTDDH});
            // 
            // gridViewCTDDH
            // 
            this.gridViewCTDDH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH1,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gridViewCTDDH.GridControl = this.gcCTDDH;
            this.gridViewCTDDH.Name = "gridViewCTDDH";
            // 
            // colMasoDDH1
            // 
            this.colMasoDDH1.FieldName = "MasoDDH";
            this.colMasoDDH1.MinWidth = 25;
            this.colMasoDDH1.Name = "colMasoDDH1";
            this.colMasoDDH1.Visible = true;
            this.colMasoDDH1.VisibleIndex = 0;
            this.colMasoDDH1.Width = 94;
            // 
            // colMAVT
            // 
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 25;
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 1;
            this.colMAVT.Width = 94;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.MinWidth = 25;
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            this.colSOLUONG.Width = 94;
            // 
            // colDONGIA
            // 
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.MinWidth = 25;
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            this.colDONGIA.Width = 94;
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridSplitContainer1.Grid = this.gcDDH;
            this.gridSplitContainer1.Location = new System.Drawing.Point(3, 21);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Panel1.Controls.Add(this.gcDDH);
            this.gridSplitContainer1.Size = new System.Drawing.Size(676, 91);
            this.gridSplitContainer1.TabIndex = 2;
            // 
            // gcDDH
            // 
            this.gcDDH.DataSource = this.fKDatHangNhanVienBindingSource;
            this.gcDDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDDH.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcDDH.Location = new System.Drawing.Point(0, 0);
            this.gcDDH.MainView = this.gridViewDDH;
            this.gcDDH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcDDH.Name = "gcDDH";
            this.gcDDH.Size = new System.Drawing.Size(676, 91);
            this.gcDDH.TabIndex = 0;
            this.gcDDH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDDH});
            // 
            // gridViewDDH
            // 
            this.gridViewDDH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH,
            this.colNGAY,
            this.colNhaCC,
            this.colMANV});
            this.gridViewDDH.GridControl = this.gcDDH;
            this.gridViewDDH.Name = "gridViewDDH";
            this.gridViewDDH.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridViewDDH_PopupMenuShowing);
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.MinWidth = 25;
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 0;
            this.colMasoDDH.Width = 94;
            // 
            // colNGAY
            // 
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.MinWidth = 25;
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            this.colNGAY.Width = 94;
            // 
            // colNhaCC
            // 
            this.colNhaCC.FieldName = "NhaCC";
            this.colNhaCC.MinWidth = 25;
            this.colNhaCC.Name = "colNhaCC";
            this.colNhaCC.Visible = true;
            this.colNhaCC.VisibleIndex = 2;
            this.colNhaCC.Width = 94;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            this.colMANV.Width = 94;
            // 
            // gbPhieuNhap
            // 
            this.gbPhieuNhap.Controls.Add(this.gcCTPN);
            this.gbPhieuNhap.Controls.Add(this.gcPhieuNhap);
            this.gbPhieuNhap.Controls.Add(this.gcDatHangByPN);
            this.gbPhieuNhap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbPhieuNhap.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbPhieuNhap.Location = new System.Drawing.Point(0, 410);
            this.gbPhieuNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbPhieuNhap.Name = "gbPhieuNhap";
            this.gbPhieuNhap.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbPhieuNhap.Size = new System.Drawing.Size(1326, 50);
            this.gbPhieuNhap.TabIndex = 28;
            this.gbPhieuNhap.TabStop = false;
            this.gbPhieuNhap.Text = "Danh sách Phiếu Nhập";
            this.gbPhieuNhap.Visible = false;
            // 
            // gcCTPN
            // 
            this.gcCTPN.DataSource = this.fKCTPNPhieuNhapBindingSource;
            this.gcCTPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCTPN.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcCTPN.Location = new System.Drawing.Point(1088, 21);
            this.gcCTPN.MainView = this.gridView4;
            this.gcCTPN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcCTPN.Name = "gcCTPN";
            this.gcCTPN.Size = new System.Drawing.Size(235, 25);
            this.gcCTPN.TabIndex = 3;
            this.gcCTPN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // fKCTPNPhieuNhapBindingSource
            // 
            this.fKCTPNPhieuNhapBindingSource.DataMember = "FK_CTPN_PhieuNhap";
            this.fKCTPNPhieuNhapBindingSource.DataSource = this.fKPhieuNhapDatHangBindingSource;
            // 
            // fKPhieuNhapDatHangBindingSource
            // 
            this.fKPhieuNhapDatHangBindingSource.DataMember = "FK_PhieuNhap_DatHang";
            this.fKPhieuNhapDatHangBindingSource.DataSource = this.fKDatHangNhanVienBindingSource;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN1,
            this.colMAVT1,
            this.colSOLUONG1,
            this.colDONGIA1});
            this.gridView4.GridControl = this.gcCTPN;
            this.gridView4.Name = "gridView4";
            // 
            // colMAPN1
            // 
            this.colMAPN1.FieldName = "MAPN";
            this.colMAPN1.MinWidth = 25;
            this.colMAPN1.Name = "colMAPN1";
            this.colMAPN1.Visible = true;
            this.colMAPN1.VisibleIndex = 0;
            this.colMAPN1.Width = 94;
            // 
            // colMAVT1
            // 
            this.colMAVT1.FieldName = "MAVT";
            this.colMAVT1.MinWidth = 25;
            this.colMAVT1.Name = "colMAVT1";
            this.colMAVT1.Visible = true;
            this.colMAVT1.VisibleIndex = 1;
            this.colMAVT1.Width = 94;
            // 
            // colSOLUONG1
            // 
            this.colSOLUONG1.FieldName = "SOLUONG";
            this.colSOLUONG1.MinWidth = 25;
            this.colSOLUONG1.Name = "colSOLUONG1";
            this.colSOLUONG1.Visible = true;
            this.colSOLUONG1.VisibleIndex = 2;
            this.colSOLUONG1.Width = 94;
            // 
            // colDONGIA1
            // 
            this.colDONGIA1.FieldName = "DONGIA";
            this.colDONGIA1.MinWidth = 25;
            this.colDONGIA1.Name = "colDONGIA1";
            this.colDONGIA1.Visible = true;
            this.colDONGIA1.VisibleIndex = 3;
            this.colDONGIA1.Width = 94;
            // 
            // gcPhieuNhap
            // 
            this.gcPhieuNhap.DataSource = this.fKPhieuNhapDatHangBindingSource;
            this.gcPhieuNhap.Dock = System.Windows.Forms.DockStyle.Left;
            this.gcPhieuNhap.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcPhieuNhap.Location = new System.Drawing.Point(362, 21);
            this.gcPhieuNhap.MainView = this.gridViewCTPN;
            this.gcPhieuNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcPhieuNhap.Name = "gcPhieuNhap";
            this.gcPhieuNhap.Size = new System.Drawing.Size(726, 25);
            this.gcPhieuNhap.TabIndex = 3;
            this.gcPhieuNhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCTPN});
            // 
            // gridViewCTPN
            // 
            this.gridViewCTPN.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN,
            this.colNGAY1,
            this.colMasoDDH2,
            this.colMANV1});
            this.gridViewCTPN.GridControl = this.gcPhieuNhap;
            this.gridViewCTPN.Name = "gridViewCTPN";
            this.gridViewCTPN.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridViewCTPN_PopupMenuShowing);
            // 
            // colMAPN
            // 
            this.colMAPN.FieldName = "MAPN";
            this.colMAPN.MinWidth = 25;
            this.colMAPN.Name = "colMAPN";
            this.colMAPN.Visible = true;
            this.colMAPN.VisibleIndex = 0;
            this.colMAPN.Width = 94;
            // 
            // colNGAY1
            // 
            this.colNGAY1.FieldName = "NGAY";
            this.colNGAY1.MinWidth = 25;
            this.colNGAY1.Name = "colNGAY1";
            this.colNGAY1.Visible = true;
            this.colNGAY1.VisibleIndex = 1;
            this.colNGAY1.Width = 94;
            // 
            // colMasoDDH2
            // 
            this.colMasoDDH2.FieldName = "MasoDDH";
            this.colMasoDDH2.MinWidth = 25;
            this.colMasoDDH2.Name = "colMasoDDH2";
            this.colMasoDDH2.Visible = true;
            this.colMasoDDH2.VisibleIndex = 2;
            this.colMasoDDH2.Width = 94;
            // 
            // colMANV1
            // 
            this.colMANV1.FieldName = "MANV";
            this.colMANV1.MinWidth = 25;
            this.colMANV1.Name = "colMANV1";
            this.colMANV1.Visible = true;
            this.colMANV1.VisibleIndex = 3;
            this.colMANV1.Width = 94;
            // 
            // gcDatHangByPN
            // 
            this.gcDatHangByPN.DataSource = this.fKDatHangNhanVienBindingSource;
            this.gcDatHangByPN.Dock = System.Windows.Forms.DockStyle.Left;
            this.gcDatHangByPN.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcDatHangByPN.Location = new System.Drawing.Point(3, 21);
            this.gcDatHangByPN.MainView = this.gridView6;
            this.gcDatHangByPN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcDatHangByPN.Name = "gcDatHangByPN";
            this.gcDatHangByPN.Size = new System.Drawing.Size(359, 25);
            this.gcDatHangByPN.TabIndex = 3;
            this.gcDatHangByPN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView6});
            // 
            // gridView6
            // 
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH3,
            this.colNGAY2,
            this.colNhaCC1,
            this.colMANV2});
            this.gridView6.GridControl = this.gcDatHangByPN;
            this.gridView6.Name = "gridView6";
            // 
            // colMasoDDH3
            // 
            this.colMasoDDH3.FieldName = "MasoDDH";
            this.colMasoDDH3.MinWidth = 25;
            this.colMasoDDH3.Name = "colMasoDDH3";
            this.colMasoDDH3.Visible = true;
            this.colMasoDDH3.VisibleIndex = 0;
            this.colMasoDDH3.Width = 94;
            // 
            // colNGAY2
            // 
            this.colNGAY2.FieldName = "NGAY";
            this.colNGAY2.MinWidth = 25;
            this.colNGAY2.Name = "colNGAY2";
            this.colNGAY2.Visible = true;
            this.colNGAY2.VisibleIndex = 1;
            this.colNGAY2.Width = 94;
            // 
            // colNhaCC1
            // 
            this.colNhaCC1.FieldName = "NhaCC";
            this.colNhaCC1.MinWidth = 25;
            this.colNhaCC1.Name = "colNhaCC1";
            this.colNhaCC1.Visible = true;
            this.colNhaCC1.VisibleIndex = 2;
            this.colNhaCC1.Width = 94;
            // 
            // colMANV2
            // 
            this.colMANV2.FieldName = "MANV";
            this.colMANV2.MinWidth = 25;
            this.colMANV2.Name = "colMANV2";
            this.colMANV2.Visible = true;
            this.colMANV2.VisibleIndex = 3;
            this.colMANV2.Width = 94;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // cTPNTableAdapter
            // 
            this.cTPNTableAdapter.ClearBeforeFill = true;
            // 
            // gbPhieuXuat
            // 
            this.gbPhieuXuat.Controls.Add(this.gcCTPX);
            this.gbPhieuXuat.Controls.Add(this.gcPhieuXuat);
            this.gbPhieuXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbPhieuXuat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbPhieuXuat.Location = new System.Drawing.Point(0, 239);
            this.gbPhieuXuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbPhieuXuat.Name = "gbPhieuXuat";
            this.gbPhieuXuat.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbPhieuXuat.Size = new System.Drawing.Size(1326, 171);
            this.gbPhieuXuat.TabIndex = 29;
            this.gbPhieuXuat.TabStop = false;
            this.gbPhieuXuat.Text = "Danh sách Phiếu Xuất";
            this.gbPhieuXuat.Visible = false;
            // 
            // gcCTPX
            // 
            this.gcCTPX.DataSource = this.fKCTPXPXBindingSource;
            this.gcCTPX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCTPX.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcCTPX.Location = new System.Drawing.Point(883, 21);
            this.gcCTPX.MainView = this.gridViewCTPX;
            this.gcCTPX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcCTPX.Name = "gcCTPX";
            this.gcCTPX.Size = new System.Drawing.Size(440, 146);
            this.gcCTPX.TabIndex = 1;
            this.gcCTPX.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCTPX});
            // 
            // fKCTPXPXBindingSource
            // 
            this.fKCTPXPXBindingSource.DataMember = "FK_CTPX_PX";
            this.fKCTPXPXBindingSource.DataSource = this.fKPXNhanVienBindingSource;
            // 
            // fKPXNhanVienBindingSource
            // 
            this.fKPXNhanVienBindingSource.DataMember = "FK_PX_NhanVien";
            this.fKPXNhanVienBindingSource.DataSource = this.nhanVienBindingSource;
            // 
            // gridViewCTPX
            // 
            this.gridViewCTPX.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPX1,
            this.colMAVT2,
            this.colSOLUONG2,
            this.colDONGIA2});
            this.gridViewCTPX.GridControl = this.gcCTPX;
            this.gridViewCTPX.Name = "gridViewCTPX";
            this.gridViewCTPX.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridViewCTPX_PopupMenuShowing);
            // 
            // colMAPX1
            // 
            this.colMAPX1.FieldName = "MAPX";
            this.colMAPX1.MinWidth = 25;
            this.colMAPX1.Name = "colMAPX1";
            this.colMAPX1.Visible = true;
            this.colMAPX1.VisibleIndex = 0;
            this.colMAPX1.Width = 94;
            // 
            // colMAVT2
            // 
            this.colMAVT2.FieldName = "MAVT";
            this.colMAVT2.MinWidth = 25;
            this.colMAVT2.Name = "colMAVT2";
            this.colMAVT2.Visible = true;
            this.colMAVT2.VisibleIndex = 1;
            this.colMAVT2.Width = 94;
            // 
            // colSOLUONG2
            // 
            this.colSOLUONG2.FieldName = "SOLUONG";
            this.colSOLUONG2.MinWidth = 25;
            this.colSOLUONG2.Name = "colSOLUONG2";
            this.colSOLUONG2.Visible = true;
            this.colSOLUONG2.VisibleIndex = 2;
            this.colSOLUONG2.Width = 94;
            // 
            // colDONGIA2
            // 
            this.colDONGIA2.FieldName = "DONGIA";
            this.colDONGIA2.MinWidth = 25;
            this.colDONGIA2.Name = "colDONGIA2";
            this.colDONGIA2.Visible = true;
            this.colDONGIA2.VisibleIndex = 3;
            this.colDONGIA2.Width = 94;
            // 
            // gcPhieuXuat
            // 
            this.gcPhieuXuat.DataSource = this.fKPXNhanVienBindingSource;
            this.gcPhieuXuat.Dock = System.Windows.Forms.DockStyle.Left;
            this.gcPhieuXuat.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcPhieuXuat.Location = new System.Drawing.Point(3, 21);
            this.gcPhieuXuat.MainView = this.gridViewPhieuXuat;
            this.gcPhieuXuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcPhieuXuat.Name = "gcPhieuXuat";
            this.gcPhieuXuat.Size = new System.Drawing.Size(880, 146);
            this.gcPhieuXuat.TabIndex = 0;
            this.gcPhieuXuat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPhieuXuat});
            // 
            // gridViewPhieuXuat
            // 
            this.gridViewPhieuXuat.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPX,
            this.colNGAY3,
            this.colHOTENKH,
            this.colMANV3});
            this.gridViewPhieuXuat.GridControl = this.gcPhieuXuat;
            this.gridViewPhieuXuat.Name = "gridViewPhieuXuat";
            this.gridViewPhieuXuat.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridViewPhieuXuat_PopupMenuShowing);
            // 
            // colMAPX
            // 
            this.colMAPX.FieldName = "MAPX";
            this.colMAPX.MinWidth = 25;
            this.colMAPX.Name = "colMAPX";
            this.colMAPX.Visible = true;
            this.colMAPX.VisibleIndex = 0;
            this.colMAPX.Width = 94;
            // 
            // colNGAY3
            // 
            this.colNGAY3.FieldName = "NGAY";
            this.colNGAY3.MinWidth = 25;
            this.colNGAY3.Name = "colNGAY3";
            this.colNGAY3.Visible = true;
            this.colNGAY3.VisibleIndex = 1;
            this.colNGAY3.Width = 94;
            // 
            // colHOTENKH
            // 
            this.colHOTENKH.FieldName = "HOTENKH";
            this.colHOTENKH.MinWidth = 25;
            this.colHOTENKH.Name = "colHOTENKH";
            this.colHOTENKH.Visible = true;
            this.colHOTENKH.VisibleIndex = 2;
            this.colHOTENKH.Width = 94;
            // 
            // colMANV3
            // 
            this.colMANV3.FieldName = "MANV";
            this.colMANV3.MinWidth = 25;
            this.colMANV3.Name = "colMANV3";
            this.colMANV3.Visible = true;
            this.colMANV3.VisibleIndex = 3;
            this.colMANV3.Width = 94;
            // 
            // phieuXuatTableAdapter
            // 
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // cTPXTableAdapter
            // 
            this.cTPXTableAdapter.ClearBeforeFill = true;
            // 
            // frmNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 625);
            this.Controls.Add(this.gbPhieuXuat);
            this.Controls.Add(this.gbPhieuNhap);
            this.Controls.Add(this.gbDatHang);
            this.Controls.Add(this.gbInfor);
            this.Controls.Add(this.panelChiNhanh);
            this.Controls.Add(this.nhanVienGridControl);
            this.Name = "frmNhanvien";
            this.Text = "frmNhanvien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetServer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNhanVien)).EndInit();
            this.panelChiNhanh.ResumeLayout(false);
            this.panelChiNhanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPM)).EndInit();
            this.gbInfor.ResumeLayout(false);
            this.gbInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mANVNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUONGNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYSINHDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYSINHDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCTDDHDatHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDatHangNhanVienBindingSource)).EndInit();
            this.gbDatHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDDH)).EndInit();
            this.gbPhieuNhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCTPNPhieuNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPhieuNhapDatHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatHangByPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            this.gbPhieuXuat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCTPXPXBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPXNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPhieuXuat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSetServer2 dataSetServer2;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private DataSetServer2TableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private DataSetServer2TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl nhanVienGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNhanVien;
        private System.Windows.Forms.Panel panelChiNhanh;
        private System.Windows.Forms.ComboBox cbChiNhanh;
        private System.Windows.Forms.Label lbChiNhanh;
        private DevExpress.XtraEditors.SimpleButton btnGhi;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnUndo;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton btnReload;
        private System.Windows.Forms.GroupBox gbInfor;
        private System.Windows.Forms.NumericUpDown mANVNumericUpDown;
        private System.Windows.Forms.NumericUpDown lUONGNumericUpDown;
        private DevExpress.XtraEditors.DateEdit nGAYSINHDateEdit;
        private System.Windows.Forms.CheckBox trangThaiXoaCheckBox;
        private System.Windows.Forms.TextBox mACNTextBox;
        private System.Windows.Forms.TextBox dIACHITextBox;
        private System.Windows.Forms.TextBox tENTextBox;
        private System.Windows.Forms.TextBox hOTextBox;
        private DS_DSPM dS_DSPM;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource;
        private DS_DSPMTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private DS_DSPMTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Label lbInfor;
        private DevExpress.XtraEditors.SimpleButton btnPXu;
        private DevExpress.XtraEditors.SimpleButton btnPNH;
        private DevExpress.XtraEditors.SimpleButton btnDH;
        private DevExpress.XtraEditors.SimpleButton btnInfo;
        private System.Windows.Forms.BindingSource fKDatHangNhanVienBindingSource;
        private DataSetServer2TableAdapters.DatHangTableAdapter datHangTableAdapter;
        private System.Windows.Forms.BindingSource fKCTDDHDatHangBindingSource;
        private DataSetServer2TableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private System.Windows.Forms.GroupBox gbDatHang;
        private DevExpress.XtraGrid.GridControl gcCTDDH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCTDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraGrid.GridControl gcDDH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaCC;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private System.Windows.Forms.GroupBox gbPhieuNhap;
        private DevExpress.XtraGrid.GridControl gcCTPN;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.GridControl gcPhieuNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCTPN;
        private DevExpress.XtraGrid.GridControl gcDatHangByPN;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DataSetServer2TableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY1;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH2;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV1;
        private DataSetServer2TableAdapters.CTPNTableAdapter cTPNTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG1;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA1;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH3;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY2;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaCC1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV2;
        private System.Windows.Forms.BindingSource fKCTPNPhieuNhapBindingSource;
        private System.Windows.Forms.BindingSource fKPhieuNhapDatHangBindingSource;
        private System.Windows.Forms.GroupBox gbPhieuXuat;
        private DevExpress.XtraGrid.GridControl gcCTPX;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCTPX;
        private DevExpress.XtraGrid.GridControl gcPhieuXuat;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPhieuXuat;
        private System.Windows.Forms.BindingSource fKPXNhanVienBindingSource;
        private DataSetServer2TableAdapters.PhieuXuatTableAdapter phieuXuatTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPX;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY3;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV3;
        private System.Windows.Forms.BindingSource fKCTPXPXBindingSource;
        private DataSetServer2TableAdapters.CTPXTableAdapter cTPXTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPX1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT2;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG2;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA2;
    }
}