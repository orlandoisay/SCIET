using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FrmSettingsGeneral : Form
    {

        public FrmSettingsGeneral()
        {
            InitializeComponent();
            load();
        }

        public void load()
        {
            pbLogo.ImageLocation = Common.Util.GetLogoPath();
            lblLogoPath.Text = Common.Properties.Settings.Default.LOGO_PATH;
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();

            dialog.AddExtension = true;
            dialog.Filter = "PNG (*.png)|*.png| JPG (*.jpg;*jpeg)|*.jpg;*.jpeg|GIF (*.gif)|*.gif";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            dialog.Multiselect = false;

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK) {
                var filepath = dialog.FileName;
                var filename = dialog.SafeFileName;

                lblLogoPath.Text = filename;
                pbLogo.ImageLocation = dialog.FileName;

                var newFilepath =
                    Path.Combine(Common.Util.GetSolutionFolder(), "Common", "Resources", filename);

                File.Copy(filepath, newFilepath, true);

                Common.Properties.Settings.Default.LOGO_PATH = filename;
                Common.Properties.Settings.Default.Save();
            }
        }

        
    }
}
