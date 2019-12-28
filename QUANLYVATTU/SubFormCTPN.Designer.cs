namespace QUANLYVATTU
{
    partial class SubFormCTPN
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
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label mAPNLabel;
            this.nuSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.nuDonGia = new System.Windows.Forms.NumericUpDown();
            this.tbMaVT = new System.Windows.Forms.TextBox();
            this.tbMaPN = new System.Windows.Forms.TextBox();
            this.dataSetServer2 = new QUANLYVATTU.DataSetServer2();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new QUANLYVATTU.DataSetServer2TableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new QUANLYVATTU.DataSetServer2TableAdapters.TableAdapterManager();
            this.datHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datHangTableAdapter = new QUANLYVATTU.DataSetServer2TableAdapters.DatHangTableAdapter();
            this.fKDatHangNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTDDHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTDDHTableAdapter = new QUANLYVATTU.DataSetServer2TableAdapters.CTDDHTableAdapter();
            this.cTDDHGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fKCTDDHDatHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cTPNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTPNTableAdapter = new QUANLYVATTU.DataSetServer2TableAdapters.CTPNTableAdapter();
            this.phieuNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new QUANLYVATTU.DataSetServer2TableAdapters.PhieuNhapTableAdapter();
            this.fKPhieuNhapDatHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKCTPNPhieuNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            mAPNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nuSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetServer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDatHangNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCTDDHDatHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPhieuNhapDatHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCTPNPhieuNhapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(73, 117);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(68, 17);
            sOLUONGLabel.TabIndex = 17;
            sOLUONGLabel.Text = "Số lượng:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(79, 162);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(60, 17);
            dONGIALabel.TabIndex = 15;
            dONGIALabel.Text = "Đơn giá:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(88, 73);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(50, 17);
            mAVTLabel.TabIndex = 13;
            mAVTLabel.Text = "Mã VT:";
            // 
            // mAPNLabel
            // 
            mAPNLabel.AutoSize = true;
            mAPNLabel.Location = new System.Drawing.Point(39, 27);
            mAPNLabel.Name = "mAPNLabel";
            mAPNLabel.Size = new System.Drawing.Size(103, 17);
            mAPNLabel.TabIndex = 11;
            mAPNLabel.Text = "Mã Phiếu Nhập:";
            // 
            // nuSoLuong
            // 
            this.nuSoLuong.Location = new System.Drawing.Point(142, 114);
            this.nuSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nuSoLuong.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nuSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuSoLuong.Name = "nuSoLuong";
            this.nuSoLuong.Size = new System.Drawing.Size(189, 23);
            this.nuSoLuong.TabIndex = 20;
            this.nuSoLuong.ThousandsSeparator = true;
            this.nuSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnOK
            // 
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Location = new System.Drawing.Point(226, 204);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(105, 31);
            this.btnOK.TabIndex = 19;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // nuDonGia
            // 
            this.nuDonGia.DecimalPlaces = 2;
            this.nuDonGia.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nuDonGia.Location = new System.Drawing.Point(142, 160);
            this.nuDonGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nuDonGia.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nuDonGia.Name = "nuDonGia";
            this.nuDonGia.Size = new System.Drawing.Size(189, 23);
            this.nuDonGia.TabIndex = 16;
            this.nuDonGia.ThousandsSeparator = true;
            // 
            // tbMaVT
            // 
            this.tbMaVT.Enabled = false;
            this.tbMaVT.Location = new System.Drawing.Point(142, 69);
            this.tbMaVT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMaVT.Name = "tbMaVT";
            this.tbMaVT.Size = new System.Drawing.Size(188, 23);
            this.tbMaVT.TabIndex = 14;
            // 
            // tbMaPN
            // 
            this.tbMaPN.Enabled = false;
            this.tbMaPN.Location = new System.Drawing.Point(142, 23);
            this.tbMaPN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMaPN.Name = "tbMaPN";
            this.tbMaPN.Size = new System.Drawing.Size(188, 23);
            this.tbMaPN.TabIndex = 12;
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
            this.tableAdapterManager.CTDDHTableAdapter = this.cTDDHTableAdapter;
            this.tableAdapterManager.CTPNTableAdapter = this.cTPNTableAdapter;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.datHangTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.PhieuNhapTableAdapter = this.phieuNhapTableAdapter;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QUANLYVATTU.DataSetServer2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // datHangBindingSource
            // 
            this.datHangBindingSource.DataSource = this.fKDatHangNhanVienBindingSource;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // fKDatHangNhanVienBindingSource
            // 
            this.fKDatHangNhanVienBindingSource.DataMember = "FK_DatHang_NhanVien";
            this.fKDatHangNhanVienBindingSource.DataSource = this.nhanVienBindingSource;
            // 
            // cTDDHBindingSource
            // 
            this.cTDDHBindingSource.DataSource = this.fKCTDDHDatHangBindingSource;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // cTDDHGridControl
            // 
            this.cTDDHGridControl.DataSource = this.cTDDHBindingSource;
            this.cTDDHGridControl.Location = new System.Drawing.Point(363, 0);
            this.cTDDHGridControl.MainView = this.gridView1;
            this.cTDDHGridControl.Name = "cTDDHGridControl";
            this.cTDDHGridControl.Size = new System.Drawing.Size(439, 266);
            this.cTDDHGridControl.TabIndex = 20;
            this.cTDDHGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gridView1.GridControl = this.cTDDHGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvCTDDH_RowClick);
            // 
            // fKCTDDHDatHangBindingSource
            // 
            this.fKCTDDHDatHangBindingSource.DataMember = "FK_CTDDH_DatHang";
            this.fKCTDDHDatHangBindingSource.DataSource = this.fKDatHangNhanVienBindingSource;
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
            // cTPNBindingSource
            // 
            this.cTPNBindingSource.DataSource = this.fKCTPNPhieuNhapBindingSource;
            // 
            // cTPNTableAdapter
            // 
            this.cTPNTableAdapter.ClearBeforeFill = true;
            // 
            // phieuNhapBindingSource
            // 
            this.phieuNhapBindingSource.DataSource = this.fKPhieuNhapDatHangBindingSource;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // fKPhieuNhapDatHangBindingSource
            // 
            this.fKPhieuNhapDatHangBindingSource.DataMember = "FK_PhieuNhap_DatHang";
            this.fKPhieuNhapDatHangBindingSource.DataSource = this.fKDatHangNhanVienBindingSource;
            // 
            // fKCTPNPhieuNhapBindingSource
            // 
            this.fKCTPNPhieuNhapBindingSource.DataMember = "FK_CTPN_PhieuNhap";
            this.fKCTPNPhieuNhapBindingSource.DataSource = this.phieuNhapBindingSource;
            // 
            // SubFormCTPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 266);
            this.Controls.Add(this.cTDDHGridControl);
            this.Controls.Add(sOLUONGLabel);
            this.Controls.Add(this.nuSoLuong);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(dONGIALabel);
            this.Controls.Add(this.nuDonGia);
            this.Controls.Add(mAVTLabel);
            this.Controls.Add(this.tbMaVT);
            this.Controls.Add(mAPNLabel);
            this.Controls.Add(this.tbMaPN);
            this.Name = "SubFormCTPN";
            this.Text = "SubFormCTPN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubFormCTPN_FormClosing);
            this.Load += new System.EventHandler(this.SubFormCTPN_Load);
            this.Shown += new System.EventHandler(this.SubFormCTPN_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.nuSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetServer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDatHangNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCTDDHDatHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPhieuNhapDatHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCTPNPhieuNhapBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nuSoLuong;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.NumericUpDown nuDonGia;
        private System.Windows.Forms.TextBox tbMaVT;
        private System.Windows.Forms.TextBox tbMaPN;
        private DataSetServer2 dataSetServer2;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private DataSetServer2TableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private DataSetServer2TableAdapters.TableAdapterManager tableAdapterManager;
        private DataSetServer2TableAdapters.DatHangTableAdapter datHangTableAdapter;
        private System.Windows.Forms.BindingSource datHangBindingSource;
        private System.Windows.Forms.BindingSource fKDatHangNhanVienBindingSource;
        private DataSetServer2TableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private System.Windows.Forms.BindingSource cTDDHBindingSource;
        private DataSetServer2TableAdapters.CTPNTableAdapter cTPNTableAdapter;
        private System.Windows.Forms.BindingSource fKCTDDHDatHangBindingSource;
        private DevExpress.XtraGrid.GridControl cTDDHGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private System.Windows.Forms.BindingSource cTPNBindingSource;
        private DataSetServer2TableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private System.Windows.Forms.BindingSource fKCTPNPhieuNhapBindingSource;
        private System.Windows.Forms.BindingSource phieuNhapBindingSource;
        private System.Windows.Forms.BindingSource fKPhieuNhapDatHangBindingSource;
    }
}