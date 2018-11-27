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
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
            Load();
        }

        
        private void btnSettings_Click(object sender, EventArgs e)
        {
            (new FrmSettings()).ShowDialog();
            Load();
        }

        /// <summary>
        /// Carga los elementos dinamicos de la ventana.
        /// </summary>
        public void Load()
        {
            pbLogo.ImageLocation = Common.Util.GetLogoPath();
        }
        
        private void btnArticles_Click(object sender, EventArgs e)
        {

            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "FrmArticleCatalog").SingleOrDefault<Form>();

            if (existe != null)
            {
                existe.WindowState = FormWindowState.Normal;
                existe.BringToFront();
            }
            else
            {
                FrmArticleCatalog frmArticle = new FrmArticleCatalog();
                frmArticle.Show();
            }
            
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            (new FrmReports()).Show();
        }

        private void pnlBottom_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
