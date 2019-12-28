namespace QUANLYVATTU
{
    partial class SubFormCTPX
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
            System.Windows.Forms.Label dONGIALabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label mAPXLabel;
            this.btnOK = new System.Windows.Forms.Button();
            this.vattuGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nuDonGia = new System.Windows.Forms.NumericUpDown();
            this.nuSoLuong = new System.Windows.Forms.NumericUpDown();
            this.tbMaVT = new System.Windows.Forms.TextBox();
            this.tbMaPX = new System.Windows.Forms.TextBox();
            dONGIALabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            mAPXLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vattuGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Location = new System.Drawing.Point(230, 201);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(105, 31);
            this.btnOK.TabIndex = 19;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // vattuGridControl
            // 
            this.vattuGridControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.vattuGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.vattuGridControl.Location = new System.Drawing.Point(386, 0);
            this.vattuGridControl.MainView = this.gridView1;
            this.vattuGridControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.vattuGridControl.Name = "vattuGridControl";
            this.vattuGridControl.Size = new System.Drawing.Size(476, 265);
            this.vattuGridControl.TabIndex = 17;
            this.vattuGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.vattuGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(71, 160);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(60, 17);
            dONGIALabel.TabIndex = 16;
            dONGIALabel.Text = "Đơn giá:";
            // 
            // nuDonGia
            // 
            this.nuDonGia.DecimalPlaces = 2;
            this.nuDonGia.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nuDonGia.Location = new System.Drawing.Point(134, 158);
            this.nuDonGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nuDonGia.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nuDonGia.Name = "nuDonGia";
            this.nuDonGia.Size = new System.Drawing.Size(201, 23);
            this.nuDonGia.TabIndex = 18;
            this.nuDonGia.ThousandsSeparator = true;
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(65, 117);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(68, 17);
            sOLUONGLabel.TabIndex = 14;
            sOLUONGLabel.Text = "Số lượng:";
            // 
            // nuSoLuong
            // 
            this.nuSoLuong.Location = new System.Drawing.Point(134, 114);
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
            this.nuSoLuong.Size = new System.Drawing.Size(201, 23);
            this.nuSoLuong.TabIndex = 15;
            this.nuSoLuong.ThousandsSeparator = true;
            this.nuSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(80, 75);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(50, 17);
            mAVTLabel.TabIndex = 12;
            mAVTLabel.Text = "Mã VT:";
            // 
            // tbMaVT
            // 
            this.tbMaVT.Enabled = false;
            this.tbMaVT.Location = new System.Drawing.Point(134, 71);
            this.tbMaVT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMaVT.Name = "tbMaVT";
            this.tbMaVT.Size = new System.Drawing.Size(200, 23);
            this.tbMaVT.TabIndex = 13;
            // 
            // mAPXLabel
            // 
            mAPXLabel.AutoSize = true;
            mAPXLabel.Location = new System.Drawing.Point(35, 32);
            mAPXLabel.Name = "mAPXLabel";
            mAPXLabel.Size = new System.Drawing.Size(99, 17);
            mAPXLabel.TabIndex = 10;
            mAPXLabel.Text = "Mã Phiếu Xuất:";
            // 
            // tbMaPX
            // 
            this.tbMaPX.Enabled = false;
            this.tbMaPX.Location = new System.Drawing.Point(134, 28);
            this.tbMaPX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMaPX.Name = "tbMaPX";
            this.tbMaPX.Size = new System.Drawing.Size(200, 23);
            this.tbMaPX.TabIndex = 11;
            // 
            // SubFormCTPX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 265);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.vattuGridControl);
            this.Controls.Add(dONGIALabel);
            this.Controls.Add(this.nuDonGia);
            this.Controls.Add(sOLUONGLabel);
            this.Controls.Add(this.nuSoLuong);
            this.Controls.Add(mAVTLabel);
            this.Controls.Add(this.tbMaVT);
            this.Controls.Add(mAPXLabel);
            this.Controls.Add(this.tbMaPX);
            this.Name = "SubFormCTPX";
            this.Text = "SubFormCTPX";
            ((System.ComponentModel.ISupportInitialize)(this.vattuGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private DevExpress.XtraGrid.GridControl vattuGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.NumericUpDown nuDonGia;
        private System.Windows.Forms.NumericUpDown nuSoLuong;
        private System.Windows.Forms.TextBox tbMaVT;
        private System.Windows.Forms.TextBox tbMaPX;
    }
}