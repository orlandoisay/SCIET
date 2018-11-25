using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.Devices;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Model;
using Data;

namespace View
{
    /// <summary>
    /// Clase encargada del manejo de artículos.
    /// </summary>
    public partial class FrmArticleCatalog : Form
    {
        List<ArticlePOJO> articlesList = new List<ArticlePOJO>();
        ArticlePOJO selectedItem;
        Computer myComputer = new Computer();
        int index;
        string sourceFileName, destinationFileName;
        public FrmArticleCatalog()
        {
            InitializeComponent();
            updateTable();
            isEmpty();
        }

        /// <summary>
        /// Abre el panel encargado de proporcionar los campos para el llenado de un nuevo artículo.
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlDetails.Visible = false;
            pnlAddEdit.Visible = true;
            pnlAddEdit.Location = new Point(pnlDetails.Location.X, pnlDetails.Location.Y);

            cleanPanelAddEdit();
            btnSave.Text = "Guardar";
            spnIdArticle.Enabled = true;

            btnsShowHide(false, true, false);
            if (articlesList.Count == 0)
            {
                btnEdit.Enabled = false;
            }
        }

        /// <summary>
        /// Abre el panel encargado de proporcionar los campos para la edición del artículo seleccionado.
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlDetails.Visible = false;
            pnlAddEdit.Visible = true;
            pnlAddEdit.Location = new Point(pnlDetails.Location.X, pnlDetails.Location.Y);

            cleanPanelAddEdit();
            spnIdArticle.Value = selectedItem.IdArticle;
            txtNameArticle.Text = selectedItem.Name;
            txtaDescriptionAddEdit.Text = selectedItem.Description;
            if (selectedItem.Image != "")
            {
                var newFilepath =
                    Path.Combine(Common.Util.GetSolutionFolder(), "Common", "Resources\\Articles", selectedItem.Image);
                pbxAddEdit.ImageLocation = newFilepath;

            }
            else
            {
                pbxAddEdit.Image = null;
            }
            btnSave.Text = "Cambiar";
            spnIdArticle.Enabled = false;


            btnsShowHide(true, false, false);
        }

        /// <summary>
        /// Elimina el artículo seleccionado.
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar el artículo?", "Info",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                return;
            
            if (selectedItem.Image != null)
            {
                var newFilepath =
                    Path.Combine(Common.Util.GetSolutionFolder(), "Common", "Resources\\Articles", selectedItem.Image);
                if (myComputer.FileSystem.FileExists(newFilepath))
                {
                    myComputer.FileSystem.DeleteFile(newFilepath);
                }
            }
            
            ArticleDAO.deleteById(selectedItem.IdArticle);
            updateTable();
            cleanPanelAddEdit();
            pnlAddEdit.Visible = false;
            pnlDetails.Visible = false;

            isEmpty();

        }

        /// <summary>
        /// Permite ubicar al artículo seleccionado para posteriores operaciones.
        /// </summary>
        private void dgvArticles_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                index = e.RowIndex;
                dgvArticles.Rows[index].Selected = true;
                pnlDetails.Visible = true;
                pnlAddEdit.Visible = false;
                btnsShowHide(true, true, true);

                selectedItem = ArticleDAO.getOneById(int.Parse(dgvArticles.Rows[index].Cells[0].Value + ""));

                fillDetails(selectedItem, index);
            }
            catch (Exception)
            {
            }

        }

        /// <summary>
        /// Abre el formulario encargado de mostrar los subartículos del artículo seleccionado.
        /// </summary>
        private void btnShowSubarticles_Click(object sender, EventArgs e)
        {
            new FrmSubarticleCatalog(selectedItem.IdArticle).ShowDialog();
            updateTable();
            isEmpty();
        }

        /// <summary>
        /// Guarda ya sea un nuevo artículo o los cambios realizado a un artículo existente.
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (((spnIdArticle.Value) + "").Length == 0 || txtNameArticle.Text == "")
            {
                MessageBox.Show("Clave y nombre son campos obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (btnSave.Text == "Guardar")
            {

                if (ArticleDAO.getOneById(int.Parse((spnIdArticle.Value) + "")) != null)
                {
                    MessageBox.Show("Clave duplicada, pruebe con otra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult dr = MessageBox.Show("¿Está seguro que desea guardar el artículo?", "Info",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                    return;

                ArticlePOJO newArticle = new ArticlePOJO();
                newArticle.IdArticle = int.Parse(spnIdArticle.Text);
                newArticle.Name = txtNameArticle.Text;
                newArticle.Description = txtaDescriptionAddEdit.Text;
                if (lblPath.Text!="") {
                    if (myComputer.FileSystem.FileExists(destinationFileName))
                    {
                        MessageBox.Show("Actualmente existe un archivo con el mismo nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    myComputer.FileSystem.CopyFile(sourceFileName, destinationFileName);
                    newArticle.Image = lblPath.Text;
                    lblPath.Text = "";
                }
                else {
                    newArticle.Image = null;
                }

                ArticleDAO.insertArticle(newArticle);
                updateTable();

                cleanPanelAddEdit();
                pnlAddEdit.Visible = false;

            }
            else
            {

                DialogResult dr = MessageBox.Show("¿Está seguro que desea cambiar el artículo?", "Info",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                    return;

                ArticlePOJO newArticle = new ArticlePOJO();
                newArticle.IdArticle = int.Parse((spnIdArticle.Value) + "");
                newArticle.Name = txtNameArticle.Text;
                newArticle.Description = txtaDescriptionAddEdit.Text;

                if (lblPath.Text != "")
                {
                    if (myComputer.FileSystem.FileExists(destinationFileName))
                    {
                        MessageBox.Show("Actualmente existe un archivo con el mismo nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var newFilepath =
                    Path.Combine(Common.Util.GetSolutionFolder(), "Common", "Resources\\Articles", selectedItem.Image);

                    if (myComputer.FileSystem.FileExists(newFilepath))
                    {
                        myComputer.FileSystem.DeleteFile(newFilepath);
                    }

                    myComputer.FileSystem.CopyFile(sourceFileName, destinationFileName);
                    newArticle.Image = lblPath.Text;
                    lblPath.Text = "";
                }
                else {
                    newArticle.Image = selectedItem.Image;
                }

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

            btnsShowHide(true, true, true);

        }

        /// <summary>
        /// Encargado de cancelar el proceso para agregar o editar un artículo.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            cleanPanelAddEdit();
            pnlAddEdit.Visible = false;

            if (articlesList.Count != 0)
            {

                fillDetails(selectedItem, index);
                pnlDetails.Visible = true;

                btnsShowHide(true, true, true);

            }
            else
            {
                btnsShowHide(true, false, false);
            }
        }

        /// <summary>
        /// Actualiza los datos mostrados en la lista del formulario para que coincida con la base de datos actual.
        /// </summary>
        public void updateTable()
        {

            dgvArticles.Rows.Clear();
            articlesList = ArticleDAO.getAll();

            for (int i = 0; i < articlesList.Count; i++)
            {
                articlesList[i].Quantity = ArticleDAO.getTotalQuantity(articlesList[i].IdArticle);
                dgvArticles.Rows.Add(articlesList[i].IdArticle, articlesList[i].Name, articlesList[i].Quantity);
            }

        }

        /// <summary>
        /// Evento capaz de disparar la búsqueda de artículos.
        /// </summary>
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            filterResults(txtSearch.Text.ToLower());
        }

        /// <summary>
        /// Filtra los resultados mostrados en la tabla según el parámetro ingresado, dicha búsqueda se realiza
        /// ya sea por clave o por nombre.
        /// </summary>
        /// <param name="parameter"></param>
        /// Contiene el valor a buscar.
        public void filterResults(string parameter)
        {
            dgvArticles.Rows.Clear();
            for (int i = 0; i < articlesList.Count; i++)
            {
                if (rbtnNameArticle.Checked == true)
                {

                    if (articlesList[i].Name.ToLower().Contains(parameter) == true)
                    {
                        dgvArticles.Rows.Add(articlesList[i].IdArticle, articlesList[i].Name, articlesList[i].Quantity);
                    }

                }
                else if (rbtnIdArticle.Checked == true)
                {
                    
                    if ((articlesList[i].IdArticle + "").Contains(parameter) == true)
                    {
                        dgvArticles.Rows.Add(articlesList[i].IdArticle, articlesList[i].Name, articlesList[i].Quantity);
                    }

                }

            }

            if (dgvArticles.RowCount == 0)
            {
                pnlDetails.Visible = false;
            }
            else {
                selectedItem = ArticleDAO.getOneById(int.Parse(dgvArticles.Rows[0].Cells[0].Value+""));
                index = 0;
                fillDetails(selectedItem, index);
                dgvArticles.Rows[index].Selected = true;
            }

        }

        /// <summary>
        /// Limpia los campos de los paneles usados para agregar o editar artículos.
        /// </summary>
        public void cleanPanelAddEdit()
        {
            if (dgvArticles.RowCount > 0) {
                spnIdArticle.Value = articlesList[articlesList.Count - 1].IdArticle + 1;
            }
            else
            {
                spnIdArticle.Value = 1;
            }
            txtNameArticle.Text = "";
            txtaDescriptionAddEdit.Text = "";
            pbxAddEdit.Image = null;
        }

        /// <summary>
        /// Llena los campos del panel usado para editar con los datos del artículo previamente seleccionado.
        /// </summary>
        /// <param name="article"></param>
        /// Contiene los datos del artículo seleccionado.
        /// <param name="index"></param>
        /// Índice del artículo seleccionado.
        public void fillDetails(ArticlePOJO article, int index)
        {
            lblIdArticle.Text = "Clave: " + article.IdArticle;
            lblNameArticle.Text = article.Name;
            txtaDescriptionDetails.Text = article.Description;
            lblQuantityArticle.Text = "Existencia: " + dgvArticles.Rows[index].Cells[2].Value;

            if (article.Image != null)
            {
                var newFilepath =
                    Path.Combine(Common.Util.GetSolutionFolder(), "Common", "Resources\\Articles", article.Image);
                if (myComputer.FileSystem.FileExists(newFilepath))
                {
                    sourceFileName = newFilepath;
                    pbxDetails.ImageLocation = newFilepath;
                }
                else
                {
                    pbxDetails.Image = null;
                }
            }
            else {
                pbxDetails.Image = null;
            }
        }

        /// <summary>
        /// Permite o restringe funciones dependiendo de si existen o no artículos en la base de datos.
        /// </summary>
        /// <returns>
        /// Retorna true si no existen artículos en la base de datos, de otro modo retorna false.
        /// </returns>
        public bool isEmpty()
        {

            if (articlesList.Count == 0)
            {
                
                btnsShowHide(true, false, false);
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

        /// <summary>
        /// Facilita el control para habilitar o deshabilitar botones.
        /// </summary>
        public void btnsShowHide(bool action1, bool action2, bool action3)
        {
            btnAdd.Enabled = action1;
            btnEdit.Enabled = action2;
            btnDelete.Enabled = action3;
        }

        /// <summary>
        /// Permite seleccionar una imagen para asignarla a un artículo.
        /// </summary>
        private void btnAttach_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();

            dialog.AddExtension = true;
            dialog.Filter = "PNG (*.png)|*.png| JPG (*.jpg;*jpeg)|*.jpg;*.jpeg|GIF (*.gif)|*.gif";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            dialog.Multiselect = false;

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                var filepath = dialog.FileName;
                var filename = dialog.SafeFileName;

                lblPath.Text = filename;
                pbxAddEdit.ImageLocation = dialog.FileName;

                var newFilepath =
                    Path.Combine(Common.Util.GetSolutionFolder(), "Common", "Resources\\Articles", filename);

                sourceFileName = filepath;
                destinationFileName = newFilepath;
            }
        }

        /// <summary>
        /// Limpia el campo encargado de realizar las búsquedas cada vez que cambie el parámetro del mismo 
        /// (nombre o clave).
        /// </summary>
        private void rbtnNameArticle_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            filterResults("");
            isEmpty();
        }

        /// <summary>
        /// Si existe una imagen adjunta al artículo, al seleccionarla esta se mostrará en el visor de imágenes.
        /// </summary>
        private void pbxDetails_Click(object sender, EventArgs e)
        {
            if (pbxDetails.Image != null) {
                Process.Start(sourceFileName);
            }
        }
    }
}
