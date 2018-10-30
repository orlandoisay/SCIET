namespace View
{
    partial class FrmSettingsDatabase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.lblHeader.Location = new System.Drawing.Point(9, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(154, 32);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Base de datos";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(11, 54);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(59, 19);
            this.lblServer.TabIndex = 2;
            this.lblServer.Text = "Servidor";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(11, 104);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(53, 19);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Usuario";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 154);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(75, 19);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Contraseña";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(190, 54);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(49, 19);
            this.lblPort.TabIndex = 5;
            this.lblPort.Text = "Puerto";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(15, 76);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(173, 25);
            this.txtServer.TabIndex = 6;
            this.txtServer.Text = "localhost";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(194, 76);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(64, 25);
            this.txtPort.TabIndex = 7;
            this.txtPort.Text = "3306";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(15, 126);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(148, 25);
            this.txtUser.TabIndex = 8;
            this.txtUser.Text = "root";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(16, 176);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(172, 25);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.Text = "root";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // FrmSettingsDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(453, 360);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmSettingsDatabase";
            this.Text = "FrmSettingsDatabase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
    }
}