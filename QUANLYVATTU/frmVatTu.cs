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

namespace QUANLYVATTU
{
    public partial class frmVattu : DevExpress.XtraEditors.XtraForm
    {
        private int position;
        public frmVattu()
        {
            InitializeComponent();
        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vattuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetServer2);

        }

        private void frmVatTu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetServer2.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Fill(this.dataSetServer2.Vattu);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            position = vattuBindingSource.Position;
            this.vattuBindingSource.AddNew();
            sOLUONGTONNumericUpDown.Value = 0;
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            this.vattuBindingSource.EndEdit();
            this.vattuTableAdapter.Update(this.dataSetServer2.Vattu);
            vattuBindingSource.Position = position;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            vattuBindingSource.RemoveCurrent();
            this.vattuTableAdapter.Update(this.dataSetServer2.Vattu);
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            vattuBindingSource.CancelEdit();
            vattuBindingSource.Position = position;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            this.vattuTableAdapter.Fill(this.dataSetServer2.Vattu);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}