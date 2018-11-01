using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FrmSubarticleCatalog : Form
    {
        public FrmSubarticleCatalog()
        {
            InitializeComponent();
            dgvSubarticles.Rows.Add();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlAddEdit.Visible = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlAddEdit.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Info",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                return;

        }

        private void dgvSubarticles_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

            }
            catch (Exception)
            {
            }

        }
    }
}
