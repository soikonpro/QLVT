namespace QUANLYVATTU
{
    partial class frmKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKho));
            System.Windows.Forms.Label tENKHOLabel1;
            System.Windows.Forms.Label dIACHILabel1;
            System.Windows.Forms.Label mACNLabel1;
            System.Windows.Forms.Label mAKHOLabel1;
            this.panelChiNhanh = new System.Windows.Forms.Panel();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnReload = new DevExpress.XtraEditors.SimpleButton();
            this.btnUndo = new DevExpress.XtraEditors.SimpleButton();
            this.btnGhi = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.cbChiNhanh = new System.Windows.Forms.ComboBox();
            this.lbChiNhanh = new System.Windows.Forms.Label();
            this.dataSetServer2 = new QUANLYVATTU.DataSetServer2();
            this.khoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoTableAdapter = new QUANLYVATTU.DataSetServer2TableAdapters.KhoTableAdapter();
            this.tableAdapterManager = new QUANLYVATTU.DataSetServer2TableAdapters.TableAdapterManager();
            this.khoGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gbInfor = new System.Windows.Forms.GroupBox();
            this.tENKHOTextBox = new System.Windows.Forms.TextBox();
            this.dIACHITextBox = new System.Windows.Forms.TextBox();
            this.mACNTextBox = new System.Windows.Forms.TextBox();
            this.mAKHOTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dS_DSPM = new QUANLYVATTU.DS_DSPM();
            this.v_DS_PHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DS_PHANMANHTableAdapter = new QUANLYVATTU.DS_DSPMTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager1 = new QUANLYVATTU.DS_DSPMTableAdapters.TableAdapterManager();
            tENKHOLabel1 = new System.Windows.Forms.Label();
            dIACHILabel1 = new System.Windows.Forms.Label();
            mACNLabel1 = new System.Windows.Forms.Label();
            mAKHOLabel1 = new System.Windows.Forms.Label();
            this.panelChiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetServer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.gbInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).BeginInit();
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
            this.panelChiNhanh.Controls.Add(this.cbChiNhanh);
            this.panelChiNhanh.Controls.Add(this.lbChiNhanh);
            this.panelChiNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChiNhanh.Location = new System.Drawing.Point(0, 0);
            this.panelChiNhanh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelChiNhanh.Name = "panelChiNhanh";
            this.panelChiNhanh.Size = new System.Drawing.Size(1146, 56);
            this.panelChiNhanh.TabIndex = 6;
            // 
            // btnThoat
            // 
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(443, 12);
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
            // cbChiNhanh
            // 
            this.cbChiNhanh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbChiNhanh.DataSource = this.v_DS_PHANMANHBindingSource;
            this.cbChiNhanh.DisplayMember = "TENCN";
            this.cbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChiNhanh.FormattingEnabled = true;
            this.cbChiNhanh.Location = new System.Drawing.Point(933, 13);
            this.cbChiNhanh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbChiNhanh.Name = "cbChiNhanh";
            this.cbChiNhanh.Size = new System.Drawing.Size(201, 24);
            this.cbChiNhanh.TabIndex = 1;
            this.cbChiNhanh.ValueMember = "TENSERVER";
            this.cbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbChiNhanh_SelectedIndexChanged);
            // 
            // lbChiNhanh
            // 
            this.lbChiNhanh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbChiNhanh.AutoSize = true;
            this.lbChiNhanh.Location = new System.Drawing.Point(862, 17);
            this.lbChiNhanh.Name = "lbChiNhanh";
            this.lbChiNhanh.Size = new System.Drawing.Size(70, 17);
            this.lbChiNhanh.TabIndex = 0;
            this.lbChiNhanh.Text = "Chi nhánh";
            // 
            // dataSetServer2
            // 
            this.dataSetServer2.DataSetName = "DataSetServer2";
            this.dataSetServer2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khoBindingSource
            // 
            this.khoBindingSource.DataMember = "Kho";
            this.khoBindingSource.DataSource = this.dataSetServer2;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = this.khoTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QUANLYVATTU.DataSetServer2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // khoGridControl
            // 
            this.khoGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.khoGridControl.DataSource = this.khoBindingSource;
            this.khoGridControl.Location = new System.Drawing.Point(-3, 63);
            this.khoGridControl.MainView = this.gridView1;
            this.khoGridControl.Name = "khoGridControl";
            this.khoGridControl.Size = new System.Drawing.Size(1146, 331);
            this.khoGridControl.TabIndex = 7;
            this.khoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.khoGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // gbInfor
            // 
            this.gbInfor.Controls.Add(tENKHOLabel1);
            this.gbInfor.Controls.Add(this.tENKHOTextBox);
            this.gbInfor.Controls.Add(dIACHILabel1);
            this.gbInfor.Controls.Add(this.dIACHITextBox);
            this.gbInfor.Controls.Add(mACNLabel1);
            this.gbInfor.Controls.Add(this.mACNTextBox);
            this.gbInfor.Controls.Add(mAKHOLabel1);
            this.gbInfor.Controls.Add(this.mAKHOTextBox);
            this.gbInfor.Controls.Add(this.label2);
            this.gbInfor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbInfor.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfor.Location = new System.Drawing.Point(0, 413);
            this.gbInfor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbInfor.Name = "gbInfor";
            this.gbInfor.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbInfor.Size = new System.Drawing.Size(1146, 147);
            this.gbInfor.TabIndex = 8;
            this.gbInfor.TabStop = false;
            this.gbInfor.Text = "Thông tin kho";
            // 
            // tENKHOLabel1
            // 
            tENKHOLabel1.AutoSize = true;
            tENKHOLabel1.Location = new System.Drawing.Point(485, 50);
            tENKHOLabel1.Name = "tENKHOLabel1";
            tENKHOLabel1.Size = new System.Drawing.Size(71, 17);
            tENKHOLabel1.TabIndex = 15;
            tENKHOLabel1.Text = "Tên Kho:";
            // 
            // tENKHOTextBox
            // 
            this.tENKHOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khoBindingSource, "TENKHO", true));
            this.tENKHOTextBox.Location = new System.Drawing.Point(562, 46);
            this.tENKHOTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tENKHOTextBox.Name = "tENKHOTextBox";
            this.tENKHOTextBox.Size = new System.Drawing.Size(226, 23);
            this.tENKHOTextBox.TabIndex = 14;
            // 
            // dIACHILabel1
            // 
            dIACHILabel1.AutoSize = true;
            dIACHILabel1.Location = new System.Drawing.Point(494, 84);
            dIACHILabel1.Name = "dIACHILabel1";
            dIACHILabel1.Size = new System.Drawing.Size(58, 17);
            dIACHILabel1.TabIndex = 13;
            dIACHILabel1.Text = "Địa chỉ:";
            // 
            // dIACHITextBox
            // 
            this.dIACHITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khoBindingSource, "DIACHI", true));
            this.dIACHITextBox.Location = new System.Drawing.Point(562, 81);
            this.dIACHITextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dIACHITextBox.Name = "dIACHITextBox";
            this.dIACHITextBox.Size = new System.Drawing.Size(226, 23);
            this.dIACHITextBox.TabIndex = 16;
            // 
            // mACNLabel1
            // 
            mACNLabel1.AutoSize = true;
            mACNLabel1.Location = new System.Drawing.Point(273, 85);
            mACNLabel1.Name = "mACNLabel1";
            mACNLabel1.Size = new System.Drawing.Size(58, 17);
            mACNLabel1.TabIndex = 11;
            mACNLabel1.Text = "Mã CN:";
            // 
            // mACNTextBox
            // 
            this.mACNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khoBindingSource, "MACN", true));
            this.mACNTextBox.Enabled = false;
            this.mACNTextBox.Location = new System.Drawing.Point(340, 81);
            this.mACNTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mACNTextBox.Name = "mACNTextBox";
            this.mACNTextBox.Size = new System.Drawing.Size(135, 23);
            this.mACNTextBox.TabIndex = 12;
            // 
            // mAKHOLabel1
            // 
            mAKHOLabel1.AutoSize = true;
            mAKHOLabel1.Location = new System.Drawing.Point(268, 52);
            mAKHOLabel1.Name = "mAKHOLabel1";
            mAKHOLabel1.Size = new System.Drawing.Size(65, 17);
            mAKHOLabel1.TabIndex = 9;
            mAKHOLabel1.Text = "Mã Kho:";
            // 
            // mAKHOTextBox
            // 
            this.mAKHOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khoBindingSource, "MAKHO", true));
            this.mAKHOTextBox.Location = new System.Drawing.Point(340, 47);
            this.mAKHOTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mAKHOTextBox.Name = "mAKHOTextBox";
            this.mAKHOTextBox.Size = new System.Drawing.Size(135, 23);
            this.mAKHOTextBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 21);
            this.label2.MinimumSize = new System.Drawing.Size(149, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 158);
            this.label2.TabIndex = 8;
            // 
            // dS_DSPM
            // 
            this.dS_DSPM.DataSetName = "DS_DSPM";
            this.dS_DSPM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DS_PHANMANHBindingSource
            // 
            this.v_DS_PHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.v_DS_PHANMANHBindingSource.DataSource = this.dS_DSPM;
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
            // frmKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 560);
            this.Controls.Add(this.gbInfor);
            this.Controls.Add(this.khoGridControl);
            this.Controls.Add(this.panelChiNhanh);
            this.Name = "frmKho";
            this.Text = "frmKho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKho_Load);
            this.panelChiNhanh.ResumeLayout(false);
            this.panelChiNhanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetServer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.gbInfor.ResumeLayout(false);
            this.gbInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DSPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).EndInit();
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
        private System.Windows.Forms.ComboBox cbChiNhanh;
        private System.Windows.Forms.Label lbChiNhanh;
        private DataSetServer2 dataSetServer2;
        private System.Windows.Forms.BindingSource khoBindingSource;
        private DataSetServer2TableAdapters.KhoTableAdapter khoTableAdapter;
        private DataSetServer2TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl khoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox gbInfor;
        private System.Windows.Forms.TextBox tENKHOTextBox;
        private System.Windows.Forms.TextBox dIACHITextBox;
        private System.Windows.Forms.TextBox mACNTextBox;
        private System.Windows.Forms.TextBox mAKHOTextBox;
        private System.Windows.Forms.Label label2;
        private DS_DSPM dS_DSPM;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource;
        private DS_DSPMTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private DS_DSPMTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}