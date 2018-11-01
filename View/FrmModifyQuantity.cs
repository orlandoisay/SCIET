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
    public partial class FrmModifyQuantity : Form
    {

        List<BatchPOJO> batchesList = new List<BatchPOJO>();

        public FrmModifyQuantity()
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
            this.Close();
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
                btnAddRemove.Text = "Retirar";
                btnReturn.Visible = true;
            }

        }

        public void updateTable()
        {

            dgvModify.Rows.Clear();
            batchesList = BatchDAO.getAllById(1);
            for (int i = 0; i < batchesList.Count; i++)
            {
                dgvModify.Rows.Add(batchesList[i].Date, batchesList[i].Reason);
            }

        }

    }
}
