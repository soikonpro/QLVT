namespace QUANLYVATTU
{
    partial class SubFormPX
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
            System.Windows.Forms.Label mAPXLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label hOTENKHLabel;
            this.tbMaPX = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.khoGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tbMaKho = new System.Windows.Forms.TextBox();
            this.tbKhachHang = new System.Windows.Forms.TextBox();
            mAPXLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            hOTENKHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.khoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPXLabel
            // 
            mAPXLabel.AutoSize = true;
            mAPXLabel.Location = new System.Drawing.Point(52, 64);
            mAPXLabel.Name = "mAPXLabel";
            mAPXLabel.Size = new System.Drawing.Size(99, 17);
            mAPXLabel.TabIndex = 14;
            mAPXLabel.Text = "Mã Phiếu Xuất:";
            // 
            // tbMaPX
            // 
            this.tbMaPX.Location = new System.Drawing.Point(151, 60);
            this.tbMaPX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMaPX.Name = "tbMaPX";
            this.tbMaPX.Size = new System.Drawing.Size(207, 23);
            this.tbMaPX.TabIndex = 16;
            // 
            // btnOK
            // 
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Location = new System.Drawing.Point(254, 199);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(105, 31);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // khoGridControl
            // 
            this.khoGridControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.khoGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.khoGridControl.Location = new System.Drawing.Point(439, 0);
            this.khoGridControl.MainView = this.gridView1;
            this.khoGridControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.khoGridControl.Name = "khoGridControl";
            this.khoGridControl.Size = new System.Drawing.Size(472, 265);
            this.khoGridControl.TabIndex = 12;
            this.khoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.khoGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(90, 150);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(58, 17);
            mAKHOLabel.TabIndex = 11;
            mAKHOLabel.Text = "Mã Kho:";
            // 
            // tbMaKho
            // 
            this.tbMaKho.Enabled = false;
            this.tbMaKho.Location = new System.Drawing.Point(151, 146);
            this.tbMaKho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMaKho.Name = "tbMaKho";
            this.tbMaKho.Size = new System.Drawing.Size(207, 23);
            this.tbMaKho.TabIndex = 13;
            // 
            // hOTENKHLabel
            // 
            hOTENKHLabel.AutoSize = true;
            hOTENKHLabel.Location = new System.Drawing.Point(24, 107);
            hOTENKHLabel.Name = "hOTENKHLabel";
            hOTENKHLabel.Size = new System.Drawing.Size(132, 17);
            hOTENKHLabel.TabIndex = 9;
            hOTENKHLabel.Text = "Họ tên Khách Hàng:";
            // 
            // tbKhachHang
            // 
            this.tbKhachHang.Location = new System.Drawing.Point(151, 103);
            this.tbKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbKhachHang.Name = "tbKhachHang";
            this.tbKhachHang.Size = new System.Drawing.Size(207, 23);
            this.tbKhachHang.TabIndex = 10;
            // 
            // SubFormPX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 265);
            this.Controls.Add(mAPXLabel);
            this.Controls.Add(this.tbMaPX);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.khoGridControl);
            this.Controls.Add(mAKHOLabel);
            this.Controls.Add(this.tbMaKho);
            this.Controls.Add(hOTENKHLabel);
            this.Controls.Add(this.tbKhachHang);
            this.Name = "SubFormPX";
            this.Text = "SubFormPX";
            ((System.ComponentModel.ISupportInitialize)(this.khoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMaPX;
        private System.Windows.Forms.Button btnOK;
        private DevExpress.XtraGrid.GridControl khoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TextBox tbMaKho;
        private System.Windows.Forms.TextBox tbKhachHang;
    }
}