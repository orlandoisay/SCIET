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
    public partial class modifyQuantity : Form
    {
        public modifyQuantity()
        {
            InitializeComponent();
            dgvModify.Rows.Add();
            //dgvModify.CurrentCell = Nothing;
        }

        private void btnAddRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar los registros?", "Info",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                return;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void spnInputOutput_ValueChanged(object sender, EventArgs e)
        {
            int valor = (int) spnInputOutput.Value;
            btnAddRemove.Visible = true;

            if (valor == 0){
                btnAddRemove.Visible = false;
                btnReturn.Visible = false;
            } else if (valor > 0) {
                btnAddRemove.Text = "Agregar";
                btnReturn.Visible = false;
            } else {
                btnAddRemove.Text = "Quitar";
                btnReturn.Visible = true;
            }

        }
    }
}
