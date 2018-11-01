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
    public partial class FrmArticleCatalog : Form
    {
        public FrmArticleCatalog()
        {
            InitializeComponent();
            dgvArticles.Rows.Add();
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
    }
}
