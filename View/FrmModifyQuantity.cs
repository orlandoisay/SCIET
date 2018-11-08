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

        SubarticlePOJO selectedSubarticle;
        List<BatchPOJO> batchesList = new List<BatchPOJO>();

        public FrmModifyQuantity(string idSubarticle)
        {
            InitializeComponent();
            selectedSubarticle = SubarticleDAO.getOneById(idSubarticle);
            lblSubarticle.Text = "Clave: " + idSubarticle;
            lblCurrentAmount.Text = "Existencia actual: " + selectedSubarticle.Quantity;
            updateTable();
            spnInputOutput.Minimum = selectedSubarticle.Quantity * (-1);
        }

        private void btnAddRemove_Click(object sender, EventArgs e)
        {
            if (btnAddRemove.Text == "Agregar")
            {
                DialogResult dr = MessageBox.Show("¿Está seguro que desea agregar esta cantidad?", "Info",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                    return;

                insert("Entrada");
                btnClean.Enabled = true;
            }
            else
            {
                DialogResult dr = MessageBox.Show("¿Está seguro que desea retirar esta cantidad?", "Info",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                    return;

                insert("Salida");
            }

            updateTable();

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro que desea devolver esta cantidad?", "Info",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                return;

            insert("Devolución");

            updateTable();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar los registros?", "Info",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                return;

            BatchDAO.deleteAllById(selectedSubarticle.IdSubarticle, batchesList);
            updateTable();
            btnClean.Enabled = false;
        }

        private void spnInputOutput_ValueChanged(object sender, EventArgs e)
        {
            int valor = (int)spnInputOutput.Value;
            btnAddRemove.Visible = true;

            if (valor == 0)
            {
                btnAddRemove.Visible = false;
                btnReturn.Visible = false;
            }
            else if (valor > 0)
            {
                btnAddRemove.Text = "Agregar";
                btnReturn.Visible = false;
            }
            else
            {
                btnAddRemove.Text = "Retirar";
                btnReturn.Visible = true;
            }

        }

        public void updateTable()
        {

            dgvModify.Rows.Clear();
            batchesList = BatchDAO.getAllById(selectedSubarticle.IdSubarticle);

            for (int i = 0; i < batchesList.Count; i++)
            {
                dgvModify.Rows.Add(batchesList[i].Date, batchesList[i].Reason, batchesList[i].Quantity);
            }

            if (batchesList.Count == 0)
            {
                btnClean.Enabled = false;
            }
            else
            {
                dgvModify.Rows[0].Selected = true;
            }

        }

        private void dgvModify_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvModify.Rows[e.RowIndex].Selected = true;
            }
            catch (Exception)
            {
            }
        }

        public void updateQuantity(int quantity)
        {
            spnInputOutput.Value = 0;
            selectedSubarticle.Quantity += quantity;
            SubarticleDAO.updateSubarticle(selectedSubarticle, selectedSubarticle.IdSubarticle);
            lblCurrentAmount.Text = "Existencia actual: " + selectedSubarticle.Quantity;
            spnInputOutput.Minimum = selectedSubarticle.Quantity * (-1);
        }

        public void insert(string reason)
        {
            BatchPOJO newBatch = new BatchPOJO();
            newBatch.Date = DateTime.Now;
            newBatch.Reason = reason;
            newBatch.Quantity = int.Parse((spnInputOutput.Value) + "");
            BatchDAO.insertBatch(newBatch);
            batchesList = BatchDAO.getAll();
            BatchDAO.insertDetailBatch(selectedSubarticle.IdSubarticle, batchesList[(batchesList.Count) - 1].IdBatch);

            updateQuantity(newBatch.Quantity);
        }
    }
}
