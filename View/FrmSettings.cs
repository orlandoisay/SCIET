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
    public partial class FrmSettings : Form
    {
        private Form currentForm = null;

        public FrmSettings()
        {
            InitializeComponent();  
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            displayForm(new FrmSettingsGeneral());
        }
        
        private void btnDatabase_Click(object sender, EventArgs e)
        {
            displayForm(new FrmSettingsDatabase());
        }

        public void displayForm(Form subform)
        {
            pnlContent.Controls.Clear();
            subform.TopLevel = false;
            pnlContent.Controls.Add(subform);
            subform.FormBorderStyle = FormBorderStyle.None;
            subform.Dock = DockStyle.Fill;
            subform.Show();

            currentForm = subform;
        }

    }
}
