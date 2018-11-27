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
    public partial class FrmVerVenta : Form
    {
        private int id;

        public FrmVerVenta(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        public void actualizarPagos() {
            txtDebe.Text = Data.SaleDAO.seDebe(id) + "";
            nudPago.Minimum = 100;
            nudPago.Maximum = int.Parse(txtDebe.Text);
            nudPago.Value = int.Parse(txtDebe.Text);
            lstbListaPagos.DataSource = Data.SaleDAO.getPayments(id);
            txtAbonos.Text = Data.SaleDAO.totalAbono(id) + "";
        }

        Model.SalePOJO sp;

        private void FrmVerVenta_Load(object sender, EventArgs e)
        {
            List<Model.SaleArticleDetail> listAr = Data.SaleDAO.getArticleList(id);
            dgvListaProductos.DataSource = listAr;
            sp = Data.SaleDAO.getSale(id);
            txtTotal.Text = "$"+sp.Total;
            txtTipoVenta.Text = sp.Estatus;
            if (sp.Estatus == "Pendiente")
            {
                panel1.Visible = true;
                actualizarPagos();
            }
            else
            {
                panel1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            int resultado = Data.SaleDAO.insertPayment(id, Double.Parse(nudPago.Value + ""), fecha.Year + "-" + fecha.Month + "-" + fecha.Day);
            MessageBox.Show(resultado + "");
            actualizarPagos();
            if (sp.Total <= Data.SaleDAO.totalAbono(id)) {
                panel1.Visible = false;
                Data.SaleDAO.pagado(id);
            }
        }
    }
}
