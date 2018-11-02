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
    public partial class FrmArticleCatalog : Form
    {
        List<ArticlePOJO> articlesList = new List<ArticlePOJO>();
        ArticlePOJO selectedItem;
        int index;

        public FrmArticleCatalog()
        {
            InitializeComponent();
            //dgvArticles.Rows.Add();
            updateTable();
            isEmpty();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlDetails.Visible = false;
            pnlAddEdit.Visible = true;
            pnlAddEdit.Location = new Point(pnlDetails.Location.X, pnlDetails.Location.Y);

            cleanPanelAddEdit();
            btnSave.Text = "Guardar";
            spnIdArticle.Enabled = true;

            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlDetails.Visible = false;
            pnlAddEdit.Visible = true;
            pnlAddEdit.Location = new Point(pnlDetails.Location.X, pnlDetails.Location.Y);

            cleanPanelAddEdit();
            spnIdArticle.Value = selectedItem.IdArticle;
            txtNameArticle.Text = selectedItem.Name;
            txtaDescriptionAddEdit.Text = selectedItem.Description;
            btnSave.Text = "Cambiar";
            spnIdArticle.Enabled = false;

            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Info",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                return;


            SubarticleDAO.deleteByIdArticle(selectedItem.IdArticle);
            ArticleDAO.deleteById(selectedItem.IdArticle);
            updateTable();
            cleanPanelAddEdit();
            pnlAddEdit.Visible = false;
            pnlDetails.Visible = false;

            isEmpty();

        }

        private void dgvArticles_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                index = e.RowIndex;
                dgvArticles.Rows[index].Selected = true;
                pnlDetails.Visible = true;
                pnlAddEdit.Visible = false;

                selectedItem = ArticleDAO.getOneById(int.Parse(dgvArticles.Rows[index].Cells[0].Value + ""));

                fillDetails(selectedItem, index);
            }
            catch (Exception)
            {
            }

        }

        private void btnShowSubarticles_Click(object sender, EventArgs e)
        {
            new FrmSubarticleCatalog(selectedItem.IdArticle).ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (btnSave.Text == "Guardar")
            {
                if (((spnIdArticle.Value) + "") == "" || txtNameArticle.Text == "")
                {
                    MessageBox.Show("Clave y nombre son campos obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (ArticleDAO.getOneById(int.Parse((spnIdArticle.Value) + "")) != null)
                {
                    MessageBox.Show("Clave duplicada, pruebe con otra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult dr = MessageBox.Show("¿Está seguro que desea guardar el producto?", "Info",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                    return;

                ArticlePOJO newArticle = new ArticlePOJO();
                newArticle.IdArticle = int.Parse(spnIdArticle.Text);
                newArticle.Name = txtNameArticle.Text;
                newArticle.Description = txtaDescriptionAddEdit.Text;
                newArticle.Image = null;
                ArticleDAO.insertArticle(newArticle);
                updateTable();

                cleanPanelAddEdit();
                pnlAddEdit.Visible = false;

                if (articlesList.Count == 1)
                {
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                }

            }
            else
            {

                DialogResult dr = MessageBox.Show("¿Está seguro que desea cambiar el producto?", "Info",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                    return;

                ArticlePOJO newArticle = new ArticlePOJO();
                newArticle.IdArticle = int.Parse((spnIdArticle.Value) + "");
                newArticle.Name = txtNameArticle.Text;
                newArticle.Description = txtaDescriptionAddEdit.Text;
                newArticle.Image = null;
                ArticleDAO.updateArticle(newArticle);
                updateTable();

                cleanPanelAddEdit();
                pnlAddEdit.Visible = false;

            }

            pnlDetails.Visible = true;
            selectedItem = articlesList[0];
            index = 0;
            fillDetails(selectedItem, index);
            dgvArticles.Rows[index].Selected = true;

            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cleanPanelAddEdit();
            pnlAddEdit.Visible = false;
            fillDetails(selectedItem, index);
            pnlDetails.Visible = true;

            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
        }

        public void updateTable()
        {

            dgvArticles.Rows.Clear();
            articlesList = ArticleDAO.getAll();
            int quantity;

            for (int i = 0; i < articlesList.Count; i++)
            {

                quantity = ArticleDAO.getTotalQuantity(articlesList[i].IdArticle);

                dgvArticles.Rows.Add(articlesList[i].IdArticle, articlesList[i].Name, quantity);
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            filterResults(txtSearch.Text.ToLower());
        }

        // Método de búsqueda
        public void filterResults(string parameter)
        {
            dgvArticles.Rows.Clear();
            for (int i = 0; i < articlesList.Count; i++)
            {
                if (rbtnNameArticle.Checked == true)
                {

                    if (articlesList[i].Name.ToLower().Contains(parameter) == true)
                    {
                        dgvArticles.Rows.Add(articlesList[i].IdArticle, articlesList[i].Name, "");
                    }

                }
                else if (rbtnIdArticle.Checked == true)
                {

                    if ((articlesList[i].IdArticle + "").Contains(parameter) == true)
                    {
                        dgvArticles.Rows.Add(articlesList[i].IdArticle, articlesList[i].Name, "");
                    }

                }

            }
        }

        public void cleanPanelAddEdit()
        {
            spnIdArticle.Value = 1;
            txtNameArticle.Text = "";
            txtaDescriptionAddEdit.Text = "";
        }

        public void fillDetails(ArticlePOJO article, int index)
        {
            lblIdArticle.Text = "Clave: " + article.IdArticle;
            lblNameArticle.Text = article.Name;
            txtaDescriptionDetails.Text = article.Description;
            lblQuantityArticle.Text = "Existencia: " + dgvArticles.Rows[index].Cells[2].Value;
        }

        public bool isEmpty()
        {

            if (articlesList.Count == 0)
            {
                MessageBox.Show("No existen productos para mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                cleanPanelAddEdit();
                pnlAddEdit.Visible = false;
                pnlDetails.Visible = false;

                return true;
            }

            pnlDetails.Visible = true;
            selectedItem = articlesList[0];
            index = 0;
            fillDetails(selectedItem, index);
            dgvArticles.Rows[index].Selected = true;
            return false;

        }

    }
}
