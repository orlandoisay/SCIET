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
            updateTable();
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
            
            SubarticlePOJO pro1 = new SubarticlePOJO(10001, "M", "Negro", 50, 75, 70, 65, 60, 10, 1000);
            SubarticlePOJO pro2 = new SubarticlePOJO(10002, "LS", "Rosa", 50, 75, 70, 65, 60, 10, 1000);
            SubarticlePOJO pro3 = new SubarticlePOJO(10003, "XL", "Verde", 50, 75, 70, 65, 60, 10, 1000);
            SubarticlePOJO pro4 = new SubarticlePOJO(10004, "X", "Negro", 50, 75, 70, 65, 60, 10, 1000);
            SubarticlePOJO pro5 = new SubarticlePOJO(10005, "M", "Rojo", 50, 75, 70, 65, 60, 10, 1000);
            subarticlesList.Add(pro1);
            subarticlesList.Add(pro2);
            subarticlesList.Add(pro3);
            subarticlesList.Add(pro4);
            subarticlesList.Add(pro5);

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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            filterResults(txtSearch.Text);
        }

        // Método de búsqueda
        public void filterResults(string parameter)
        {
            dgvSubarticles.Rows.Clear();
            for (int i = 0; i < subarticlesList.Count; i++)
            {
                
                    if ((subarticlesList[i].IdSubarticle + "").Contains(parameter) == true)
                    {
                        dgvSubarticles.Rows.Add(subarticlesList[i].IdSubarticle, subarticlesList[i].Size,
                        subarticlesList[i].Color, subarticlesList[i].Cost, subarticlesList[i].Price1,
                        subarticlesList[i].Price2, subarticlesList[i].Price3, subarticlesList[i].Price4,
                        subarticlesList[i].Quantity);
                    }

            }
        }
    }
}
