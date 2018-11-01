﻿using System;
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
        //List<ArticlePOJO> articlesList;

        public FrmArticleCatalog()
        {
            InitializeComponent();
            dgvArticles.Rows.Add();
            //updateTable();
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
            articlesList = ArticleDAO.getAll();
            for (int i = 0; i < articlesList.Count; i++)
            {
                dgvArticles.Rows.Add(articlesList[i].IdArticle, articlesList[i].Name, "");
            }

        }
    }
}
