namespace QUANLYVATTU
{
    partial class SubFormCTDDH
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
            System.Windows.Forms.Label mAVTLabel1;
            System.Windows.Forms.Label dONGIALabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label masoDDHLabel;
            this.tbMaVT = new System.Windows.Forms.TextBox();
            this.nuDonGia = new System.Windows.Forms.NumericUpDown();
            this.nuSoLuong = new System.Windows.Forms.NumericUpDown();
            this.gcVatTu = new DevExpress.XtraGrid.GridControl();
            this.vattuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetServer2 = new QUANLYVATTU.DataSetServer2();
            this.gridViewVatTu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnOK = new System.Windows.Forms.Button();
            this.tbMasoDDH = new System.Windows.Forms.TextBox();
            this.vattuTableAdapter = new QUANLYVATTU.DataSetServer2TableAdapters.VattuTableAdapter();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new QUANLYVATTU.DataSetServer2TableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new QUANLYVATTU.DataSetServer2TableAdapters.TableAdapterManager();
            this.cTDDHTableAdapter = new QUANLYVATTU.DataSetServer2TableAdapters.CTDDHTableAdapter();
            this.datHangTableAdapter = new QUANLYVATTU.DataSetServer2TableAdapters.DatHangTableAdapter();
            this.datHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTDDHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            mAVTLabel1 = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            masoDDHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nuDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetServer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mAVTLabel1
            // 
            mAVTLabel1.AutoSize = true;
            mAVTLabel1.Location = new System.Drawing.Point(151, 80);
            mAVTLabel1.Name = "mAVTLabel1";
            mAVTLabel1.Size = new System.Drawing.Size(50, 17);
            mAVTLabel1.TabIndex = 22;
            mAVTLabel1.Text = "Mã VT:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(141, 162);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(60, 17);
            dONGIALabel.TabIndex = 18;
            dONGIALabel.Text = "Đơn giá:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(136, 121);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(68, 17);
            sOLUONGLabel.TabIndex = 17;
            sOLUONGLabel.Text = "Số lượng:";
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(124, 34);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(81, 17);
            masoDDHLabel.TabIndex = 15;
            masoDDHLabel.Text = "Mã số DDH:";
            // 
            // tbMaVT
            // 
            this.tbMaVT.Enabled = false;
            this.tbMaVT.Location = new System.Drawing.Point(207, 77);
            this.tbMaVT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMaVT.Name = "tbMaVT";
            this.tbMaVT.Size = new System.Drawing.Size(224, 23);
            this.tbMaVT.TabIndex = 24;
            // 
            // nuDonGia
            // 
            this.nuDonGia.DecimalPlaces = 2;
            this.nuDonGia.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nuDonGia.Location = new System.Drawing.Point(207, 161);
            this.nuDonGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nuDonGia.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nuDonGia.Name = "nuDonGia";
            this.nuDonGia.Size = new System.Drawing.Size(225, 23);
            this.nuDonGia.TabIndex = 23;
            this.nuDonGia.ThousandsSeparator = true;
            // 
            // nuSoLuong
            // 
            this.nuSoLuong.Location = new System.Drawing.Point(207, 119);
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
            this.nuSoLuong.Size = new System.Drawing.Size(225, 23);
            this.nuSoLuong.TabIndex = 21;
            this.nuSoLuong.ThousandsSeparator = true;
            this.nuSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gcVatTu
            // 
            this.gcVatTu.DataSource = this.vattuBindingSource;
            this.gcVatTu.Dock = System.Windows.Forms.DockStyle.Right;
            this.gcVatTu.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcVatTu.Location = new System.Drawing.Point(476, 0);
            this.gcVatTu.MainView = this.gridViewVatTu;
            this.gcVatTu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcVatTu.Name = "gcVatTu";
            this.gcVatTu.Size = new System.Drawing.Size(463, 287);
            this.gcVatTu.TabIndex = 19;
            this.gcVatTu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewVatTu});
            // 
            // vattuBindingSource
            // 
            this.vattuBindingSource.DataMember = "Vattu";
            this.vattuBindingSource.DataSource = this.dataSetServer2;
            // 
            // dataSetServer2
            // 
            this.dataSetServer2.DataSetName = "DataSetServer2";
            this.dataSetServer2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewVatTu
            // 
            this.gridViewVatTu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDVT,
            this.colSOLUONGTON});
            this.gridViewVatTu.GridControl = this.gcVatTu;
            this.gridViewVatTu.Name = "gridViewVatTu";
            this.gridViewVatTu.Click += new System.EventHandler(this.gridViewVatTu_Click);
            // 
            // colMAVT
            // 
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 25;
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 0;
            this.colMAVT.Width = 94;
            // 
            // colTENVT
            // 
            this.colTENVT.FieldName = "TENVT";
            this.colTENVT.MinWidth = 25;
            this.colTENVT.Name = "colTENVT";
            this.colTENVT.Visible = true;
            this.colTENVT.VisibleIndex = 1;
            this.colTENVT.Width = 94;
            // 
            // colDVT
            // 
            this.colDVT.FieldName = "DVT";
            this.colDVT.MinWidth = 25;
            this.colDVT.Name = "colDVT";
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 2;
            this.colDVT.Width = 94;
            // 
            // colSOLUONGTON
            // 
            this.colSOLUONGTON.FieldName = "SOLUONGTON";
            this.colSOLUONGTON.MinWidth = 25;
            this.colSOLUONGTON.Name = "colSOLUONGTON";
            this.colSOLUONGTON.Visible = true;
            this.colSOLUONGTON.VisibleIndex = 3;
            this.colSOLUONGTON.Width = 94;
            // 
            // btnOK
            // 
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Location = new System.Drawing.Point(328, 204);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(105, 31);
            this.btnOK.TabIndex = 20;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tbMasoDDH
            // 
            this.tbMasoDDH.Enabled = false;
            this.tbMasoDDH.Location = new System.Drawing.Point(207, 32);
            this.tbMasoDDH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMasoDDH.Name = "tbMasoDDH";
            this.tbMasoDDH.Size = new System.Drawing.Size(224, 23);
            this.tbMasoDDH.TabIndex = 16;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.datHangTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QUANLYVATTU.DataSetServer2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = this.vattuTableAdapter;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // datHangBindingSource
            // 
            this.datHangBindingSource.DataMember = "DatHang";
            this.datHangBindingSource.DataSource = this.dataSetServer2;
            // 
            // cTDDHBindingSource
            // 
            this.cTDDHBindingSource.DataMember = "CTDDH";
            this.cTDDHBindingSource.DataSource = this.dataSetServer2;
            // 
            // SubFormCTDDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 287);
            this.Controls.Add(this.tbMaVT);
            this.Controls.Add(mAVTLabel1);
            this.Controls.Add(this.nuDonGia);
            this.Controls.Add(this.nuSoLuong);
            this.Controls.Add(this.gcVatTu);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(dONGIALabel);
            this.Controls.Add(sOLUONGLabel);
            this.Controls.Add(masoDDHLabel);
            this.Controls.Add(this.tbMasoDDH);
            this.Name = "SubFormCTDDH";
            this.Text = "SubFormCTDDH";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubFormCTDDH_FormClosing);
            this.Load += new System.EventHandler(this.SubFormCTDDH_Load);
            this.Shown += new System.EventHandler(this.SubFormCTDDH_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.nuDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetServer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMaVT;
        private System.Windows.Forms.NumericUpDown nuDonGia;
        private System.Windows.Forms.NumericUpDown nuSoLuong;
        private DevExpress.XtraGrid.GridControl gcVatTu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewVatTu;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox tbMasoDDH;
        private DataSetServer2 dataSetServer2;
        private System.Windows.Forms.BindingSource vattuBindingSource;
        private DataSetServer2TableAdapters.VattuTableAdapter vattuTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGTON;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private DataSetServer2TableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private DataSetServer2TableAdapters.TableAdapterManager tableAdapterManager;
        private DataSetServer2TableAdapters.DatHangTableAdapter datHangTableAdapter;
        private System.Windows.Forms.BindingSource datHangBindingSource;
        private DataSetServer2TableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private System.Windows.Forms.BindingSource cTDDHBindingSource;
    }
}