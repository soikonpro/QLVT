namespace QUANLYVATTU
{
    partial class SubFormDDH
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
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label nhaCCLabel;
            System.Windows.Forms.Label masoDDHLabel;
            this.tbMaKho = new System.Windows.Forms.TextBox();
            this.tbNCC = new System.Windows.Forms.TextBox();
            this.tbMaDDH = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.gcKho = new DevExpress.XtraGrid.GridControl();
            this.khoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetServer2 = new QUANLYVATTU.DataSetServer2();
            this.gridViewKho = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.khoTableAdapter = new QUANLYVATTU.DataSetServer2TableAdapters.KhoTableAdapter();
            this.datHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datHangTableAdapter = new QUANLYVATTU.DataSetServer2TableAdapters.DatHangTableAdapter();
            this.tableAdapterManager = new QUANLYVATTU.DataSetServer2TableAdapters.TableAdapterManager();
            mAKHOLabel = new System.Windows.Forms.Label();
            nhaCCLabel = new System.Windows.Forms.Label();
            masoDDHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gcKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetServer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(71, 144);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(58, 17);
            mAKHOLabel.TabIndex = 24;
            mAKHOLabel.Text = "Mã Kho:";
            // 
            // nhaCCLabel
            // 
            nhaCCLabel.AutoSize = true;
            nhaCCLabel.Location = new System.Drawing.Point(36, 89);
            nhaCCLabel.Name = "nhaCCLabel";
            nhaCCLabel.Size = new System.Drawing.Size(98, 17);
            nhaCCLabel.TabIndex = 21;
            nhaCCLabel.Text = "Nhà cung cấp:";
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(68, 33);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(63, 17);
            masoDDHLabel.TabIndex = 20;
            masoDDHLabel.Text = "Mã DDH:";
            // 
            // tbMaKho
            // 
            this.tbMaKho.Enabled = false;
            this.tbMaKho.Location = new System.Drawing.Point(140, 141);
            this.tbMaKho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMaKho.Name = "tbMaKho";
            this.tbMaKho.Size = new System.Drawing.Size(215, 23);
            this.tbMaKho.TabIndex = 25;
            // 
            // tbNCC
            // 
            this.tbNCC.Location = new System.Drawing.Point(140, 86);
            this.tbNCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNCC.Name = "tbNCC";
            this.tbNCC.Size = new System.Drawing.Size(215, 23);
            this.tbNCC.TabIndex = 23;
            // 
            // tbMaDDH
            // 
            this.tbMaDDH.Location = new System.Drawing.Point(140, 31);
            this.tbMaDDH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMaDDH.Name = "tbMaDDH";
            this.tbMaDDH.Size = new System.Drawing.Size(215, 23);
            this.tbMaDDH.TabIndex = 22;
            // 
            // btnOk
            // 
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.Location = new System.Drawing.Point(251, 191);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(105, 31);
            this.btnOk.TabIndex = 19;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // gcKho
            // 
            this.gcKho.DataSource = this.khoBindingSource;
            this.gcKho.Dock = System.Windows.Forms.DockStyle.Right;
            this.gcKho.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcKho.Location = new System.Drawing.Point(407, 0);
            this.gcKho.MainView = this.gridViewKho;
            this.gcKho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcKho.Name = "gcKho";
            this.gcKho.Size = new System.Drawing.Size(463, 264);
            this.gcKho.TabIndex = 18;
            this.gcKho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewKho});
            this.gcKho.Load += new System.EventHandler(this.SubFormDDH_Shown);
            this.gcKho.Click += new System.EventHandler(this.gcKho_Click);
            // 
            // khoBindingSource
            // 
            this.khoBindingSource.DataMember = "Kho";
            this.khoBindingSource.DataSource = this.dataSetServer2;
            // 
            // dataSetServer2
            // 
            this.dataSetServer2.DataSetName = "DataSetServer2";
            this.dataSetServer2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewKho
            // 
            this.gridViewKho.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKHO,
            this.colTENKHO,
            this.colDIACHI,
            this.colMACN});
            this.gridViewKho.GridControl = this.gcKho;
            this.gridViewKho.Name = "gridViewKho";
            // 
            // colMAKHO
            // 
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.MinWidth = 25;
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 2;
            this.colMAKHO.Width = 94;
            // 
            // colTENKHO
            // 
            this.colTENKHO.FieldName = "TENKHO";
            this.colTENKHO.MinWidth = 25;
            this.colTENKHO.Name = "colTENKHO";
            this.colTENKHO.Visible = true;
            this.colTENKHO.VisibleIndex = 3;
            this.colTENKHO.Width = 94;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 0;
            this.colDIACHI.Width = 94;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 25;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 1;
            this.colMACN.Width = 94;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // datHangBindingSource
            // 
            this.datHangBindingSource.DataMember = "DatHang";
            this.datHangBindingSource.DataSource = this.dataSetServer2;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.datHangTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = this.khoTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QUANLYVATTU.DataSetServer2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // SubFormDDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 264);
            this.Controls.Add(mAKHOLabel);
            this.Controls.Add(this.tbMaKho);
            this.Controls.Add(nhaCCLabel);
            this.Controls.Add(this.tbNCC);
            this.Controls.Add(masoDDHLabel);
            this.Controls.Add(this.tbMaDDH);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gcKho);
            this.Name = "SubFormDDH";
            this.Text = "SubFormCTDDH";
            this.Load += new System.EventHandler(this.SubFormDDH_Load);
            this.Shown += new System.EventHandler(this.SubFormDDH_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gcKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetServer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMaKho;
        private System.Windows.Forms.TextBox tbNCC;
        private System.Windows.Forms.TextBox tbMaDDH;
        private System.Windows.Forms.Button btnOk;
        private DevExpress.XtraGrid.GridControl gcKho;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewKho;
        private DataSetServer2 dataSetServer2;
        private System.Windows.Forms.BindingSource khoBindingSource;
        private DataSetServer2TableAdapters.KhoTableAdapter khoTableAdapter;
        private System.Windows.Forms.BindingSource datHangBindingSource;
        private DataSetServer2TableAdapters.DatHangTableAdapter datHangTableAdapter;
        private DataSetServer2TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
    }
}