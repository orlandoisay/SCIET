namespace View
{
    partial class FrmSettingsGeneral
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
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblLogoPath = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnLogo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.lblHeader.Location = new System.Drawing.Point(11, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(93, 32);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "General";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Location = new System.Drawing.Point(15, 52);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(65, 19);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "Logotipo:";
            // 
            // lblLogoPath
            // 
            this.lblLogoPath.AutoSize = true;
            this.lblLogoPath.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLogoPath.Location = new System.Drawing.Point(74, 52);
            this.lblLogoPath.Name = "lblLogoPath";
            this.lblLogoPath.Size = new System.Drawing.Size(62, 19);
            this.lblLogoPath.TabIndex = 2;
            this.lblLogoPath.Text = "logo.png";
            // 
            // pbLogo
            // 
            this.pbLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLogo.Location = new System.Drawing.Point(19, 74);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(149, 143);
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // btnLogo
            // 
            this.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogo.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.btnLogo.Location = new System.Drawing.Point(19, 223);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(126, 32);
            this.btnLogo.TabIndex = 4;
            this.btnLogo.Text = "Cambiar logotipo";
            this.btnLogo.UseVisualStyleBackColor = true;
            // 
            // FrmSettingsGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(644, 400);
            this.Controls.Add(this.btnLogo);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblLogoPath);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmSettingsGeneral";
            this.Text = "FrmSettingsGeneral";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblLogoPath;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnLogo;
    }
}