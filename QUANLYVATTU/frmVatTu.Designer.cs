namespace QUANLYVATTU
{
    partial class frmVattu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVattu));
            System.Windows.Forms.Label sOLUONGTONLabel;
            System.Windows.Forms.Label dVTLabel;
            System.Windows.Forms.Label tENVTLabel;
            System.Windows.Forms.Label mAVTLabel;
            this.panelChiNhanh = new System.Windows.Forms.Panel();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnReload = new DevExpress.XtraEditors.SimpleButton();
            this.btnUndo = new DevExpress.XtraEditors.SimpleButton();
            this.btnGhi = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.dataSetServer2 = new QUANLYVATTU.DataSetServer2();
            this.vattuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vattuTableAdapter = new QUANLYVATTU.DataSetServer2TableAdapters.VattuTableAdapter();
            this.tableAdapterManager = new QUANLYVATTU.DataSetServer2TableAdapters.TableAdapterManager();
            this.vattuGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gbInfor = new System.Windows.Forms.GroupBox();
            this.sOLUONGTONNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dVTTextBox = new System.Windows.Forms.TextBox();
            this.tENVTTextBox = new System.Windows.Forms.TextBox();
            this.mAVTTextBox = new System.Windows.Forms.TextBox();
            sOLUONGTONLabel = new System.Windows.Forms.Label();
            dVTLabel = new System.Windows.Forms.Label();
            tENVTLabel = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            this.panelChiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetServer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.gbInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sOLUONGTONNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChiNhanh
            // 
            this.panelChiNhanh.Controls.Add(this.btnThoat);
            this.panelChiNhanh.Controls.Add(this.btnReload);
            this.panelChiNhanh.Controls.Add(this.btnUndo);
            this.panelChiNhanh.Controls.Add(this.btnGhi);
            this.panelChiNhanh.Controls.Add(this.btnXoa);
            this.panelChiNhanh.Controls.Add(this.btnThem);
            this.panelChiNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChiNhanh.Location = new System.Drawing.Point(0, 0);
            this.panelChiNhanh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelChiNhanh.Name = "panelChiNhanh";
            this.panelChiNhanh.Size = new System.Drawing.Size(1105, 56);
            this.panelChiNhanh.TabIndex = 6;
            // 
            // btnThoat
            // 
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(443, 13);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 32);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
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
            // dataSetServer2
            // 
            this.dataSetServer2.DataSetName = "DataSetServer2";
            this.dataSetServer2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vattuBindingSource
            // 
            this.vattuBindingSource.DataMember = "Vattu";
            this.vattuBindingSource.DataSource = this.dataSetServer2;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QUANLYVATTU.DataSetServer2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = this.vattuTableAdapter;
            // 
            // vattuGridControl
            // 
            this.vattuGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vattuGridControl.DataSource = this.vattuBindingSource;
            this.vattuGridControl.Location = new System.Drawing.Point(0, 51);
            this.vattuGridControl.MainView = this.gridView1;
            this.vattuGridControl.Name = "vattuGridControl";
            this.vattuGridControl.Size = new System.Drawing.Size(1105, 351);
            this.vattuGridControl.TabIndex = 7;
            this.vattuGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.vattuGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // gbInfor
            // 
            this.gbInfor.Controls.Add(this.sOLUONGTONNumericUpDown);
            this.gbInfor.Controls.Add(this.label1);
            this.gbInfor.Controls.Add(sOLUONGTONLabel);
            this.gbInfor.Controls.Add(dVTLabel);
            this.gbInfor.Controls.Add(this.dVTTextBox);
            this.gbInfor.Controls.Add(tENVTLabel);
            this.gbInfor.Controls.Add(this.tENVTTextBox);
            this.gbInfor.Controls.Add(mAVTLabel);
            this.gbInfor.Controls.Add(this.mAVTTextBox);
            this.gbInfor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbInfor.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfor.Location = new System.Drawing.Point(0, 398);
            this.gbInfor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbInfor.Name = "gbInfor";
            this.gbInfor.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbInfor.Size = new System.Drawing.Size(1105, 174);
            this.gbInfor.TabIndex = 8;
            this.gbInfor.TabStop = false;
            this.gbInfor.Text = "Thông tin vật tư";
            // 
            // sOLUONGTONNumericUpDown
            // 
            this.sOLUONGTONNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vattuBindingSource, "SOLUONGTON", true));
            this.sOLUONGTONNumericUpDown.Location = new System.Drawing.Point(574, 116);
            this.sOLUONGTONNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sOLUONGTONNumericUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.sOLUONGTONNumericUpDown.Name = "sOLUONGTONNumericUpDown";
            this.sOLUONGTONNumericUpDown.Size = new System.Drawing.Size(157, 23);
            this.sOLUONGTONNumericUpDown.TabIndex = 10;
            this.sOLUONGTONNumericUpDown.ThousandsSeparator = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.MinimumSize = new System.Drawing.Size(149, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 158);
            this.label1.TabIndex = 8;
            // 
            // sOLUONGTONLabel
            // 
            sOLUONGTONLabel.AutoSize = true;
            sOLUONGTONLabel.Location = new System.Drawing.Point(471, 119);
            sOLUONGTONLabel.Name = "sOLUONGTONLabel";
            sOLUONGTONLabel.Size = new System.Drawing.Size(103, 17);
            sOLUONGTONLabel.TabIndex = 6;
            sOLUONGTONLabel.Text = "Số lượng tồn:";
            // 
            // dVTLabel
            // 
            dVTLabel.AutoSize = true;
            dVTLabel.Location = new System.Drawing.Point(204, 119);
            dVTLabel.Name = "dVTLabel";
            dVTLabel.Size = new System.Drawing.Size(88, 17);
            dVTLabel.TabIndex = 4;
            dVTLabel.Text = "Đơn vị tính:";
            // 
            // dVTTextBox
            // 
            this.dVTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vattuBindingSource, "DVT", true));
            this.dVTTextBox.Location = new System.Drawing.Point(293, 115);
            this.dVTTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dVTTextBox.Name = "dVTTextBox";
            this.dVTTextBox.Size = new System.Drawing.Size(157, 23);
            this.dVTTextBox.TabIndex = 5;
            // 
            // tENVTLabel
            // 
            tENVTLabel.AutoSize = true;
            tENVTLabel.Location = new System.Drawing.Point(506, 76);
            tENVTLabel.Name = "tENVTLabel";
            tENVTLabel.Size = new System.Drawing.Size(62, 17);
            tENVTLabel.TabIndex = 2;
            tENVTLabel.Text = "Tên VT:";
            // 
            // tENVTTextBox
            // 
            this.tENVTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vattuBindingSource, "TENVT", true));
            this.tENVTTextBox.Location = new System.Drawing.Point(574, 73);
            this.tENVTTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tENVTTextBox.Name = "tENVTTextBox";
            this.tENVTTextBox.Size = new System.Drawing.Size(157, 23);
            this.tENVTTextBox.TabIndex = 3;
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(231, 73);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(56, 17);
            mAVTLabel.TabIndex = 0;
            mAVTLabel.Text = "Mã VT:";
            // 
            // mAVTTextBox
            // 
            this.mAVTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vattuBindingSource, "MAVT", true));
            this.mAVTTextBox.Location = new System.Drawing.Point(293, 70);
            this.mAVTTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mAVTTextBox.Name = "mAVTTextBox";
            this.mAVTTextBox.Size = new System.Drawing.Size(157, 23);
            this.mAVTTextBox.TabIndex = 1;
            // 
            // frmVattu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 572);
            this.Controls.Add(this.gbInfor);
            this.Controls.Add(this.vattuGridControl);
            this.Controls.Add(this.panelChiNhanh);
            this.Name = "frmVattu";
            this.Text = "frmVatTu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVatTu_Load);
            this.panelChiNhanh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetServer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.gbInfor.ResumeLayout(false);
            this.gbInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sOLUONGTONNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChiNhanh;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnReload;
        private DevExpress.XtraEditors.SimpleButton btnUndo;
        private DevExpress.XtraEditors.SimpleButton btnGhi;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DataSetServer2 dataSetServer2;
        private System.Windows.Forms.BindingSource vattuBindingSource;
        private DataSetServer2TableAdapters.VattuTableAdapter vattuTableAdapter;
        private DataSetServer2TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl vattuGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox gbInfor;
        private System.Windows.Forms.NumericUpDown sOLUONGTONNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dVTTextBox;
        private System.Windows.Forms.TextBox tENVTTextBox;
        private System.Windows.Forms.TextBox mAVTTextBox;
    }
}