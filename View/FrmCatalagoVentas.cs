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
    public partial class FrmCatalagoVentas : Form
    {
        public FrmCatalagoVentas()
        {
            InitializeComponent();
        }

        private void FrmCatalagoVentas_Load(object sender, EventArgs e)
        {
            dgvListaVentas.DataSource = SaleDAO.getAll();          
        }      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (chbBuscar.Checked)
            {
                pnlContenedorBuscar.Visible = true;
            }
            else
            {
                pnlContenedorBuscar.Visible = false;
                dgvListaVentas.DataSource = SaleDAO.getAll();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmAgregarVenta fav = new FrmAgregarVenta();
            fav.ShowDialog();
            dgvListaVentas.DataSource = SaleDAO.getAll();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5) {
                FrmVerVenta fvv = new FrmVerVenta(int.Parse(dgvListaVentas.Rows[e.RowIndex].Cells[0].Value + ""));
                fvv.ShowDialog();
                dgvListaVentas.DataSource = SaleDAO.getAll();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Parse(dtpFechaFin.Value + "");
            DateTime date2 = DateTime.Parse(dtpFechaIncio.Value + "");
            dgvListaVentas.DataSource = Data.SaleDAO.getAllDate(date2.Year + "-" + date2.Month + "-" + date2.Day, date.Year + "-" + date.Month + "-" + date.Day);
        }
    }
}






