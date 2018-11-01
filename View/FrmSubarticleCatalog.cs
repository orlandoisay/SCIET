using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Data;

namespace View
{
    public partial class FrmSubarticleCatalog : Form
    {
        List<SubarticlePOJO> subarticlesList = new List<SubarticlePOJO>();

        public FrmSubarticleCatalog()
        {
            InitializeComponent();
            dgvSubarticles.Rows.Add();
            //updateTable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlAddEdit.Visible = true;
            btnChangeQuantity.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlAddEdit.Visible = true;
            btnChangeQuantity.Visible = false;
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

                dgvSubarticles.Rows[e.RowIndex].Selected = true;
                btnChangeQuantity.Visible = true;

            }
            catch (Exception)
            {
            }

        }

        public void updateTable()
        {

            dgvSubarticles.Rows.Clear();
            //subarticlesList = SubarticleDAO.getAllById(1);
            for (int i = 0; i < subarticlesList.Count; i++)
            {
                dgvSubarticles.Rows.Add(subarticlesList[i].IdSubarticle, subarticlesList[i].Size,
                    subarticlesList[i].Color, subarticlesList[i].Cost, subarticlesList[i].Price1,
                    subarticlesList[i].Price2, subarticlesList[i].Price3, subarticlesList[i].Price4,
                    subarticlesList[i].Quantity);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddEdit.Visible = false;
        }

        private void btnChangeQuantity_Click(object sender, EventArgs e)
        {
            new FrmModifyQuantity().ShowDialog();
        }
    }
}
