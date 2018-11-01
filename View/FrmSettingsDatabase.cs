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
    public partial class FrmSettingsDatabase : Form 
        
    {
        public FrmSettingsDatabase()
        {
            InitializeComponent();
            load();
        }

        public void load()
        {
            txtServer.Text = Common.Properties.Settings.Default.DB_HOST;
            txtPort.Text = Common.Properties.Settings.Default.DB_PORT;
            txtUser.Text = Common.Properties.Settings.Default.DB_USER;
            txtPassword.Text = Common.Properties.Settings.Default.DB_PASS;
        }

        public void save()
        {

            Common.Properties.Settings.Default.DB_HOST = txtServer.Text;
            Common.Properties.Settings.Default.DB_PORT = txtPort.Text;
            Common.Properties.Settings.Default.DB_USER = txtUser.Text;
            Common.Properties.Settings.Default.DB_PASS = txtPassword.Text;

            Common.Properties.Settings.Default.Save();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            save();
        }
    }
}
