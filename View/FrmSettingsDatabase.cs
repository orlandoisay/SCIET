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

        /// <summary>
        /// Carga los datos de conexion a la base de datos para mostrarlos
        /// en las cajas de texto de esta pantalla
        /// </summary>
        public void load()
        {
            txtServer.Text = Common.Properties.Settings.Default.DB_HOST;
            txtPort.Text = Common.Properties.Settings.Default.DB_PORT;
            txtUser.Text = Common.Properties.Settings.Default.DB_USER;
            txtPassword.Text = Common.Properties.Settings.Default.DB_PASS;
        }

        /// <summary>
        /// Almacena los valores de la conexion a la base de datos de 
        /// forma persistente.
        /// </summary>
        public void save()
        {
            Common.Properties.Settings.Default.DB_HOST = txtServer.Text;
            Common.Properties.Settings.Default.DB_PORT = txtPort.Text;
            Common.Properties.Settings.Default.DB_USER = txtUser.Text;
            Common.Properties.Settings.Default.DB_PASS = txtPassword.Text;

            Common.Properties.Settings.Default.Save();

            MessageBox.Show("Información actualizada correctamente.", "Info", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            save();
        }
    }
}
