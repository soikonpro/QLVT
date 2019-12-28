namespace QUANLYVATTU
{
    partial class SubFormPN
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
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label mAPNLabel;
            this.btnOK = new System.Windows.Forms.Button();
            this.tbMaSoDDH = new System.Windows.Forms.TextBox();
            this.tbMaPN = new System.Windows.Forms.TextBox();
            this.dataSetServer2 = new QUANLYVATTU.DataSetServer2();
            this.phieuNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new QUANLYVATTU.DataSetServer2TableAdapters.PhieuNhapTableAdapter();
            this.tableAdapterManager = new QUANLYVATTU.DataSetServer2TableAdapters.TableAdapterManager();
            masoDDHLabel = new System.Windows.Forms.Label();
            mAPNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetServer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(64, 89);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(81, 17);
            masoDDHLabel.TabIndex = 10;
            masoDDHLabel.Text = "Mã số DDH:";
            // 
            // mAPNLabel
            // 
            mAPNLabel.AutoSize = true;
            mAPNLabel.Location = new System.Drawing.Point(42, 38);
            mAPNLabel.Name = "mAPNLabel";
            mAPNLabel.Size = new System.Drawing.Size(103, 17);
            mAPNLabel.TabIndex = 8;
            mAPNLabel.Text = "Mã Phiếu Nhập:";
            // 
            // btnOK
            // 
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Location = new System.Drawing.Point(253, 137);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(105, 31);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tbMaSoDDH
            // 
            this.tbMaSoDDH.Enabled = false;
            this.tbMaSoDDH.Location = new System.Drawing.Point(151, 84);
            this.tbMaSoDDH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMaSoDDH.Name = "tbMaSoDDH";
            this.tbMaSoDDH.Size = new System.Drawing.Size(206, 23);
            this.tbMaSoDDH.TabIndex = 11;
            // 
            // tbMaPN
            // 
            this.tbMaPN.Location = new System.Drawing.Point(151, 32);
            this.tbMaPN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMaPN.Name = "tbMaPN";
            this.tbMaPN.Size = new System.Drawing.Size(206, 23);
            this.tbMaPN.TabIndex = 9;
            // 
            // dataSetServer2
            // 
            this.dataSetServer2.DataSetName = "DataSetServer2";
            this.dataSetServer2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phieuNhapBindingSource
            // 
            this.phieuNhapBindingSource.DataMember = "PhieuNhap";
            this.phieuNhapBindingSource.DataSource = this.dataSetServer2;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PhieuNhapTableAdapter = this.phieuNhapTableAdapter;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QUANLYVATTU.DataSetServer2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // SubFormPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 190);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(masoDDHLabel);
            this.Controls.Add(this.tbMaSoDDH);
            this.Controls.Add(mAPNLabel);
            this.Controls.Add(this.tbMaPN);
            this.Name = "SubFormPN";
            this.Text = "SubFormPN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubFormPN_FormClosing);
            this.Load += new System.EventHandler(this.SubFormPN_Load);
            this.Shown += new System.EventHandler(this.SubFormPN_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetServer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox tbMaSoDDH;
        private System.Windows.Forms.TextBox tbMaPN;
        private DataSetServer2 dataSetServer2;
        private System.Windows.Forms.BindingSource phieuNhapBindingSource;
        private DataSetServer2TableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private DataSetServer2TableAdapters.TableAdapterManager tableAdapterManager;
    }
}