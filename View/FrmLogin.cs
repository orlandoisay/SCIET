using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Data;
using Model;

namespace View
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            UserDAO daoUser = new UserDAO();
            if (daoUser.Exist(new UserPOJO(txtNickname.Text, txtPassword.Text)))
            {
                this.Visible = false;
                FrmDashboard frmData = new FrmDashboard();
                frmData.ShowDialog();
                this.Visible = true;
                txtNickname.Text = "";
                txtPassword.Text = "";
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }
    }
}
