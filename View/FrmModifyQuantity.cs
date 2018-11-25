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
    /// <summary>
    /// Clase encargada del manejo de existencias.
    /// </summary>
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

        /// <summary>
        /// Permite agregar o eliminar existencias del subartículo seleccionado previamente.
        /// </summary>
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

        /// <summary>
        /// Permite eliminar existencias del subartículo seleccionado previamente por motivo de devolución.
        /// </summary>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro que desea devolver esta cantidad?", "Info",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                return;

            insert("Devolución");

            updateTable();
        }

        /// <summary>
        /// Elimina todas las modificaciones registradas en la base de datos que involucren al subartículo 
        /// seleccionado.
        /// </summary>
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

        /// <summary>
        /// Especifica la cantidad de existencia a retirar o ingresar, dependiendo de la acción a realizar 
        /// se habilitan los botones.
        /// </summary>
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

        /// <summary>
        /// Actualiza los datos mostrados en la lista del formulario para que coincida con la base de datos actual.
        /// </summary>
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

        /// <summary>
        /// Realiza el calculo para conocer las existencias del subartículo después de la modificación.
        /// </summary>
        public void updateQuantity(int quantity)
        {
            spnInputOutput.Value = 0;
            selectedSubarticle.Quantity += quantity;
            SubarticleDAO.updateSubarticle(selectedSubarticle, selectedSubarticle.IdSubarticle);
            lblCurrentAmount.Text = "Existencia actual: " + selectedSubarticle.Quantity;
            spnInputOutput.Minimum = selectedSubarticle.Quantity * (-1);
        }

        /// <summary>
        /// Guarda en la base de datos la modificación realizada en las existencias del subartículo.
        /// </summary>
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

        /// <summary>
        /// Permite seleccionar un registro de la tabla del formulario.
        /// </summary>
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

        /// <summary>
        /// Cierra el formulario actual.
        /// </summary>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
