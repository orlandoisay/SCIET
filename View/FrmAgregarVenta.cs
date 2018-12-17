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
        String[,] listaProductos;
        Model.ArticlePOJO[] listArt;
        Model.SubarticlePOJO[] listSubArt;
        double costoTotal;

        public FrmAgregarVenta()
        {
            InitializeComponent();
            listaProductos = new String[200,4];
            listArt = new Model.ArticlePOJO[200];
            listSubArt = new Model.SubarticlePOJO[200];
        }

        private void FrmAgregarVenta_Load(object sender, EventArgs e)
        {
            cbTiposVenta.SelectedIndex = 0;
            tbCant.Visible = chbPendiente.Checked;
            txtCDR.Visible = chbPendiente.Checked;
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
                        txt.Leave += new System.EventHandler(this.tbCant_Leave);
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
                        txt.Leave += new System.EventHandler(this.tbCant_Leave);
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

        }

        public void recalcular(int numPiezas) {
            Model.ArticlePOJO article;
            Model.SubarticlePOJO subArticle;
            costoTotal = 0;
            for (int i = 0; i < dgvListaProductos.RowCount; i++) {
                if (listaProductos[i, 1] != null)
                {
                    if (!listaProductos[i, 1].Equals(""))
                    {
                        article = listArt[i];
                        subArticle = listSubArt[i];
                        //----------------------------------------------------------------------------
                        if (subArticle != null)
                        {
                            double precio = 0;
                            if (numPiezas >= 1 && numPiezas <= 5)
                            {
                                precio = subArticle.Price1;
                                tipoVenta = 0;
                            }
                            else if (numPiezas >= 6 && numPiezas <= 11)
                            {
                                precio = subArticle.Price2;
                                tipoVenta = 1;
                            }
                            else if (numPiezas >= 12 && numPiezas <= 59)
                            {
                                precio = subArticle.Price3;
                                tipoVenta = 2;
                            }
                            else if (numPiezas >= 60)
                            {
                                precio = subArticle.Price4;
                                tipoVenta = 3;
                            }
                            listaProductos[i, 2] = precio + "";
                            listaProductos[i, 3] = (int.Parse(listaProductos[i, 0]) * precio) + "";
                            costoTotal += (int.Parse(listaProductos[i, 0]) * subArticle.Cost);
                            dgvListaProductos.Rows[i].Cells[2].Value = listaProductos[i, 2];
                            dgvListaProductos.Rows[i].Cells[3].Value = listaProductos[i, 3];


                        }
                        //----------------------------------------------------------------------------
                    }
                }
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
            /*
            calcularTotal();
            calcularTodo();
            */
        }
        int valor;
        public void calcularTotal() {
            try
            {
                valor = 0;
                cantidad = 0;
                for (int i = 0; i < dgvListaProductos.RowCount; i++)
                {
                    try
                    {
                        valor += int.Parse(listaProductos[i, 3] + "");
                        cantidad += int.Parse(listaProductos[i, 0] + "");
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
            //calcularTodo();
            recalcular(cantidad);
            calcularTotal();
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
                    pagoDado = int.Parse(tbCant.Value + "");
                }
                else
                {
                    estado = "Pagado";
                    pagoDado = -1;
                }
                DateTime fecha = DateTime.Now;
                int n = Data.SaleDAO.insertSale(fecha.Year + "-" + fecha.Month + "-" + fecha.Day, Double.Parse(label3.Text), costoTotal, cbTiposVenta.Text, estado, pagoDado);
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

        private void dgvListaProductos_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void dgvListaProductos_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void tbCant_Leave(object sender, EventArgs e)
        {
            if (cells == 0)
            {
                Model.ArticlePOJO article = listArt[rows];
                if (article != null)
                {
                    Model.SubarticlePOJO subArticle = listSubArt[rows];
                    if (subArticle != null)
                    {
                        int n;
                        try
                        {
                            n = int.Parse(dgvListaProductos[cells, rows].Value + "");
                        }
                        catch (Exception ex)
                        {
                            n = 1;
                        }
                        listaProductos[rows, cells] = n + "";
                        //-----------------------------------------------------------------------------------
                        calcularTotal();
                        recalcular(cantidad);
                        calcularTotal();
                        //-----------------------------------------------------------------------------------
                    }
                }

            }

            if (cells == 1)
            {
                Model.ArticlePOJO article = Data.ArticleDAO.getOneById(dgvListaProductos[cells, rows].Value + "");
                if (article != null)
                {
                    Model.SubarticlePOJO subArticle = Data.SubarticleDAO.getAllById(article.IdArticle)[0];
                    if (subArticle != null)
                    {
                        listArt[rows] = article;
                        listSubArt[rows] = subArticle;
                        listaProductos[rows, cells] = ((TextBox)sender).Text;
                        //cantidad += 1;
                        double precio = 0;
                        Console.WriteLine(cantidad + " %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
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
                        costoTotal += subArticle.Cost;
                        listaProductos[rows, 0] = "1";
                        listaProductos[rows, 2] = precio + "";
                        listaProductos[rows, 3] = precio + "";
                    }
                }
                else
                {
                    dgvListaProductos.Rows[rows].Cells[0].Value = "";
                    dgvListaProductos.Rows[rows].Cells[2].Value = "";
                    dgvListaProductos.Rows[rows].Cells[3].Value = "";
                    listaProductos[rows, 0] = "";
                    listaProductos[rows, 1] = "";
                    listaProductos[rows, 2] = "";
                    listaProductos[rows, 3] = "";
                    listArt[rows] = null;
                    listSubArt[rows] = null;
                    recalcular(cantidad);
                }
                calcularTotal();
            }
            cbTiposVenta.SelectedIndex = tipoVenta;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tbCant.Visible = chbPendiente.Checked;
            txtCDR.Visible = chbPendiente.Checked;
            tbCant.Maximum = valor;
            tbCant.Value = valor;
        }

    }
}
