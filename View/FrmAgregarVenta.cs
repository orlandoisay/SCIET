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
    public partial class FrmAgregarVenta : Form
    {
        public FrmAgregarVenta()
        {
            InitializeComponent();
        }

        private void FrmAgregarVenta_Load(object sender, EventArgs e)
        {
            cbTiposVenta.SelectedIndex = 0;
            tbCant.Visible = chbPendiente.Checked;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        Boolean entrar = false;

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                String hearder = dgvListaProductos.Columns[1].HeaderText;
                if (hearder.Equals("Producto"))
                {
                    TextBox txt = e.Control as TextBox;
                    if (txt != null)
                    {
                        txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
                        txt.AutoCompleteMode = AutoCompleteMode.Suggest;
                        txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        AutoCompleteStringCollection acsc = new AutoCompleteStringCollection();
                        List<Model.ArticlePOJO> list = Data.ArticleDAO.getAll();
                        foreach (Model.ArticlePOJO name in list)
                        {
                            acsc.Add(name.Name);
                        }
                        txt.AutoCompleteCustomSource = acsc;
                    }
                }
                hearder = dgvListaProductos.Columns[0].HeaderText;
                if (hearder.Equals("Cant."))
                {
                    TextBox txt = e.Control as TextBox;
                    if (txt != null)
                    {
                        txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
                    }
                }
            }
            catch (Exception) {
                MessageBox.Show("Error");
            }

        }

        private void dataGridView1_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }

        private int rows,cells;

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show(((TextBox)sender).Text + " " + cells);
                if (cells == 1)
                {
                    Model.ArticlePOJO article = Data.ArticleDAO.getOneById(((TextBox)sender).Text);
                    if (article != null)
                    {
                        Model.SubarticlePOJO subArticle = Data.SubarticleDAO.getOneById(article.IdArticle + "");
                        if (subArticle != null)
                        {
                            double precio = 0;
                            if (cantidad >= 1 && cantidad <= 5)
                            {
                                precio = subArticle.Price1;
                                tipoVenta = 0;
                            }
                            else if (cantidad >= 6 && cantidad <= 11)
                            {
                                precio = subArticle.Price2;
                                tipoVenta = 1;
                            }
                            else if (cantidad >= 12 && cantidad <= 59)
                            {
                                precio = subArticle.Price3;
                                tipoVenta = 2;
                            }
                            else if (cantidad >= 60)
                            {
                                precio = subArticle.Price4;
                                tipoVenta = 3;
                            }
                            dgvListaProductos.Rows[rows].Cells[0].Value = "1";
                            dgvListaProductos.Rows[rows].Cells[2].Value = precio + "";
                            dgvListaProductos.Rows[rows].Cells[3].Value = precio + "";
                        }
                    }
                    else
                    {
                        dgvListaProductos.Rows[rows].Cells[0].Value = "";
                        dgvListaProductos.Rows[rows].Cells[2].Value = "";
                        dgvListaProductos.Rows[rows].Cells[3].Value = "";
                    }
                    calcularTotal();
                }
                else if (cells == 0)
                {
                    Model.ArticlePOJO article = Data.ArticleDAO.getOneById(dgvListaProductos.Rows[rows].Cells[1].Value + "");
                    if (article != null)
                    {
                        Model.SubarticlePOJO subArticle = Data.SubarticleDAO.getOneById(article.IdArticle + "");
                        if (subArticle != null)
                        {
                            int n;
                            try
                            {
                                n = int.Parse(((TextBox)sender).Text);
                            }
                            catch (Exception ex)
                            {
                                n = 1;
                            }
                            double precio = 0;
                            if (cantidad + n >= 1 && cantidad + n <= 5)
                            {
                                precio = subArticle.Price1;
                                tipoVenta = 0;
                            }
                            else if (cantidad + n >= 6 && cantidad + n <= 11)
                            {
                                precio = subArticle.Price2;
                                tipoVenta = 1;
                            }
                            else if (cantidad + n >= 12 && cantidad + n <= 59)
                            {
                                precio = subArticle.Price3;
                                tipoVenta = 2;
                            }
                            else if (cantidad + n >= 60)
                            {
                                precio = subArticle.Price4;
                                tipoVenta = 3;
                            }
                            dgvListaProductos.Rows[rows].Cells[2].Value = precio + "";
                            dgvListaProductos.Rows[rows].Cells[3].Value = (n * precio) + "";
                            /*dataGridView1.Rows[rows].Cells[2].Value = article.Quantity + "";*/
                            calcularTotal();
                        }
                    }

                }
                cbTiposVenta.SelectedIndex = tipoVenta;
                //calcularTodo();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {    
            rows = e.RowIndex;
            cells = e.ColumnIndex;
        }

        int cantidad = 0;
        int tipoVenta = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            calcularTotal();
            calcularTodo();
        }

        public void calcularTotal() {
            try
            {
                int valor = 0;
                cantidad = 0;
                for (int i = 0; i < dgvListaProductos.RowCount; i++)
                {
                    try
                    {
                        valor += int.Parse(dgvListaProductos.Rows[i].Cells[3].Value + "");
                        cantidad += int.Parse(dgvListaProductos.Rows[i].Cells[0].Value + "");
                    }
                    catch (Exception ex)
                    {

                    }
                }
                label3.Text = valor + "";
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int n = cbTiposVenta.SelectedIndex;
            switch (n) {
                case 0:
                    cantidad = 3;
                    break;
                case 1:
                    cantidad = 8;
                    break;
                case 2:
                    cantidad = 40;
                    break;
                case 3:
                    cantidad = 70;
                    break;
            }
            calcularTodo();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string estado;
                double pagoDado = 0;
                if (chbPendiente.Checked)
                {
                    estado = "Pendiente";
                    pagoDado = Double.Parse(tbCant.Text);
                }
                else
                {
                    estado = "Pagado";
                    pagoDado = -1;
                }
                DateTime fecha = DateTime.Now;
                int n = Data.SaleDAO.insertSale(fecha.Year + "-" + fecha.Month + "-" + fecha.Day, Double.Parse(label3.Text), cbTiposVenta.Text, estado, pagoDado);
                int nArticle;
                for (int i = 0; i < dgvListaProductos.RowCount; i++)
                {
                    if ((dgvListaProductos.Rows[i].Cells[0].Value + "") != "")
                    {
                        nArticle = Data.SaleDAO.insertSaleArticles(dgvListaProductos.Rows[i].Cells[1].Value + "", int.Parse(dgvListaProductos.Rows[i].Cells[0].Value + ""),
                            double.Parse(dgvListaProductos.Rows[i].Cells[2].Value + ""), Double.Parse(dgvListaProductos.Rows[i].Cells[3].Value + ""));
                        Data.SaleDAO.insertDetail(n, nArticle);
                    }
                }
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tbCant.Visible = chbPendiente.Checked;
        }

        private void calcularTodo()
        {
            try
            {
                int valor = 0;
                int auxCant = cantidad;
                cantidad = 0;
                for (int i = 0; i < dgvListaProductos.RowCount; i++)
                {
                    try
                    {
                        Model.ArticlePOJO article = Data.ArticleDAO.getOneById(dgvListaProductos.Rows[i].Cells[1].Value + "");
                        Model.SubarticlePOJO subArticle = Data.SubarticleDAO.getOneById(article.IdArticle + "");
                        double precio = 0;
                        if (auxCant >= 1 && auxCant <= 5)
                        {
                            precio = subArticle.Price1;
                        }
                        else if (auxCant >= 6 && auxCant <= 11)
                        {
                            precio = subArticle.Price2;
                        }
                        else if (auxCant >= 12 && auxCant <= 59)
                        {
                            precio = subArticle.Price3;
                        }
                        else if (auxCant >= 60)
                        {
                            precio = subArticle.Price4;
                        }
                        int n = 0;
                        try
                        {
                            n = int.Parse(dgvListaProductos.Rows[i].Cells[0].Value + "");
                        }
                        catch (Exception ex)
                        {
                            n = 0;
                        }
                        dgvListaProductos.Rows[i].Cells[2].Value = precio;
                        dgvListaProductos.Rows[i].Cells[3].Value = precio * n;
                        valor += int.Parse(dgvListaProductos.Rows[i].Cells[3].Value + "");
                        cantidad += int.Parse(dgvListaProductos.Rows[i].Cells[0].Value + "");
                    }
                    catch (Exception ex)
                    {

                    }
                }
                label3.Text = valor + "";
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

    }
}
