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
        SubarticlePOJO selectedItem;
        int selectedIdArticle;

        public FrmSubarticleCatalog(int idArticle)
        {
            InitializeComponent();
            selectedIdArticle = idArticle;
            updateTable();
            if (isEmpty() == false) {
                btnChangeQuantity.Visible = true;
            }
            lblIdArticle.Text = "Clave: "+idArticle;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cleanPanelAddEdit();
            pnlAddEdit.Visible = true;
            btnChangeQuantity.Visible = false;
            lblQuantity.Visible = true;
            spnQuantity.Visible = true;
            spnIdSubarticle.Enabled = true;
            btnSave.Text = "Guardar";

            btnsShowHide(false, true, false);
            if (subarticlesList.Count == 0)
            {
                btnEdit.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cleanPanelAddEdit();
            pnlAddEdit.Visible = true;
            btnChangeQuantity.Visible = false;
            string[] words = selectedItem.IdSubarticle.Split('_');
            spnIdSubarticle.Value = int.Parse(words[1]);
            cbxSize.SelectedItem = selectedItem.Size;
            txtColor.Text = selectedItem.Color;
            spnQuantity.Value = selectedItem.Quantity;
            spnPrice1.Value = decimal.Parse((selectedItem.Price1) + "");
            spnPrice2.Value = decimal.Parse((selectedItem.Price2) + "");
            spnPrice3.Value = decimal.Parse((selectedItem.Price3) + "");
            spnPrice4.Value = decimal.Parse((selectedItem.Price4) + "");
            spnCost.Value = decimal.Parse((selectedItem.Cost) + "");
            lblQuantity.Visible = false;
            spnQuantity.Visible = false;
            spnIdSubarticle.Enabled = false;
            btnSave.Text = "Cambiar";

            btnsShowHide(true, false, false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Info",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                return;

            SubarticleDAO.deleteByIdSubarticle(selectedItem.IdSubarticle);
            updateTable();
            cleanPanelAddEdit();
            pnlAddEdit.Visible = false;

            isEmpty();

        }

        private void dgvSubarticles_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int index = e.RowIndex;
                dgvSubarticles.Rows[index].Selected = true;
                btnChangeQuantity.Visible = true;
                pnlAddEdit.Visible = false;
                selectedItem = SubarticleDAO.getOneById(dgvSubarticles.Rows[index].Cells[0].Value + "");
                btnsShowHide(true, true, true);
            }
            catch (Exception)
            {
            }

        }

        public void updateTable()
        {

            dgvSubarticles.Rows.Clear();
            subarticlesList = SubarticleDAO.getAllById(selectedIdArticle);

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

            if (subarticlesList.Count != 0)
            {
                btnChangeQuantity.Visible = true;
                btnsShowHide(true, true, true);
            }
            else
            {
                btnsShowHide(true, false, false);
            }

        }

        private void btnChangeQuantity_Click(object sender, EventArgs e)
        {
            new FrmModifyQuantity(selectedItem.IdSubarticle).ShowDialog();
            updateTable();
            selectedItem = subarticlesList[0];
            dgvSubarticles.Rows[0].Selected = true;
        }

        public void cleanPanelAddEdit()
        {
            spnIdSubarticle.Value = 1;
            cbxSize.SelectedValue = 2;
            txtColor.Text = "";
            spnQuantity.Value = 0;
            spnPrice1.Value = 0;
            spnPrice2.Value = 0;
            spnPrice3.Value = 0;
            spnPrice4.Value = 0;
            spnCost.Value = 0;
        }

        public bool isEmpty()
        {

            if (subarticlesList.Count == 0)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnChangeQuantity.Visible = false;
                cleanPanelAddEdit();
                pnlAddEdit.Visible = false;

                return true;
            }

            selectedItem = subarticlesList[0];
            dgvSubarticles.Rows[0].Selected = true;

            return false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Guardar")
            {
                if (txtColor.Text == "" || cbxSize.SelectedValue == "")
                {
                    MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (SubarticleDAO.getOneById(selectedIdArticle + "_" + spnIdSubarticle.Value) != null)
                {
                    MessageBox.Show("Clave duplicada, pruebe con otra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult dr = MessageBox.Show("¿Está seguro que desea guardar el subproducto?", "Info",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                    return;

                SubarticlePOJO newSubarticle = new SubarticlePOJO();
                newSubarticle.IdSubarticle = selectedIdArticle + "_" + spnIdSubarticle.Value;
                newSubarticle.Size = cbxSize.SelectedItem + "";
                newSubarticle.Color = txtColor.Text;
                newSubarticle.Cost = double.Parse(spnCost.Value + "");
                newSubarticle.Price1 = double.Parse(spnPrice1.Value + "");
                newSubarticle.Price2 = double.Parse(spnPrice2.Value + "");
                newSubarticle.Price3 = double.Parse(spnPrice3.Value + "");
                newSubarticle.Price4 = double.Parse(spnPrice4.Value + "");
                newSubarticle.Quantity = int.Parse(spnQuantity.Value + "");
                newSubarticle.IdArticle = selectedIdArticle;
                SubarticleDAO.insertSubarticle(newSubarticle);
                updateTable();

                cleanPanelAddEdit();
                pnlAddEdit.Visible = false;
            }
            else
            {

                DialogResult dr = MessageBox.Show("¿Está seguro que desea cambiar el subproducto?", "Info",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                    return;

                SubarticlePOJO newSubarticle = new SubarticlePOJO();
                newSubarticle.IdSubarticle = selectedIdArticle + "_" + spnIdSubarticle.Value;
                newSubarticle.Size = cbxSize.SelectedItem + "";
                newSubarticle.Color = txtColor.Text;
                newSubarticle.Cost = double.Parse(spnCost.Value + "");
                newSubarticle.Price1 = double.Parse(spnPrice1.Value + "");
                newSubarticle.Price2 = double.Parse(spnPrice2.Value + "");
                newSubarticle.Price3 = double.Parse(spnPrice3.Value + "");
                newSubarticle.Price4 = double.Parse(spnPrice4.Value + "");
                newSubarticle.Quantity = int.Parse(spnQuantity.Value + "");
                newSubarticle.IdArticle = selectedIdArticle;
                SubarticleDAO.updateSubarticle(newSubarticle, selectedItem.IdSubarticle);
                updateTable();

                cleanPanelAddEdit();
                pnlAddEdit.Visible = false;

            }

            selectedItem = subarticlesList[0];
            dgvSubarticles.Rows[0].Selected = true;
            btnChangeQuantity.Visible = true;
            btnsShowHide(true, true, true);
        }

        public void btnsShowHide(bool action1, bool action2, bool action3)
        {
            btnAdd.Enabled = action1;
            btnEdit.Enabled = action2;
            btnDelete.Enabled = action3;
        }
    }
}
