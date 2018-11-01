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
        int selectedItem;

        public FrmArticleCatalog()
        {
            InitializeComponent();
            //dgvArticles.Rows.Add();
            updateTable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlDetails.Visible = false;
            pnlAddEdit.Visible = true;
            pnlAddEdit.Location = new Point(pnlDetails.Location.X, pnlDetails.Location.Y);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlDetails.Visible = false;
            pnlAddEdit.Visible = true;
            pnlAddEdit.Location = new Point(pnlDetails.Location.X, pnlDetails.Location.Y);

            txtIdArticle.Text = articlesList[selectedItem].IdArticle + "";
            txtNameArticle.Text = articlesList[selectedItem].Name;
            txtaDescriptionAddEdit.Text = articlesList[selectedItem].Description;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Info",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                return;

        }

        private void dgvArticles_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                dgvArticles.Rows[e.RowIndex].Selected = true;
                pnlDetails.Visible = true;
                pnlAddEdit.Visible = false;

                selectedItem = e.RowIndex;

                lblIdArticle.Text = "Clave: "+articlesList[selectedItem].IdArticle;
                lblNameArticle.Text = articlesList[selectedItem].Name;
                txtaDescriptionDetails.Text = articlesList[selectedItem].Description;
                
            }
            catch (Exception)
            {
            }
            
        }

        private void btnShowSubarticles_Click(object sender, EventArgs e)
        {
            new FrmSubarticleCatalog().ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddEdit.Visible = false;
        }

        public void updateTable()
        {

            dgvArticles.Rows.Clear();
            //articlesList = ArticleDAO.getAll();
            // Prueba:
            ArticlePOJO pro1 = new ArticlePOJO(1000,"Blusa","Bonita","D:");
            ArticlePOJO pro2 = new ArticlePOJO(1001, "Pantalon", "ni idea", "C:");
            ArticlePOJO pro3 = new ArticlePOJO(1002, "Botas", "Maso", "E:");
            ArticlePOJO pro4 = new ArticlePOJO(1003, "Bufanda", "Calientita", "F:");
            ArticlePOJO pro5 = new ArticlePOJO(1004, "Bolsa", "Grande", "G:");
            articlesList.Add(pro1);
            articlesList.Add(pro2);
            articlesList.Add(pro3);
            articlesList.Add(pro4);
            articlesList.Add(pro5);

            //articlesList = ArticleDAO.getAll();
            for (int i = 0; i < articlesList.Count; i++)
            {
                dgvArticles.Rows.Add(articlesList[i].IdArticle, articlesList[i].Name, "");
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
                if (rbtnNameArticle.Checked == true) {

                    if (articlesList[i].Name.ToLower().Contains(parameter) == true)
                    {
                        dgvArticles.Rows.Add(articlesList[i].IdArticle, articlesList[i].Name, "");
                    }

                } else if (rbtnIdArticle.Checked == true) {

                    if ((articlesList[i].IdArticle+"").Contains(parameter) == true)
                    {
                        dgvArticles.Rows.Add(articlesList[i].IdArticle, articlesList[i].Name, "");
                    }

                }
                
            }
        }

    }
}
