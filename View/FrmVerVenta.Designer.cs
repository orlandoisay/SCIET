namespace View
{
    partial class FrmVerVenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipoVenta = new System.Windows.Forms.Label();
            this.dgvListaProductos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudPago = new System.Windows.Forms.NumericUpDown();
            this.btnRealizar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDebe = new System.Windows.Forms.Label();
            this.txtAbonos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstbListaPagos = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPago)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de venta: ";
            // 
            // txtTipoVenta
            // 
            this.txtTipoVenta.AutoSize = true;
            this.txtTipoVenta.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtTipoVenta.ForeColor = System.Drawing.Color.White;
            this.txtTipoVenta.Location = new System.Drawing.Point(140, 35);
            this.txtTipoVenta.Name = "txtTipoVenta";
            this.txtTipoVenta.Size = new System.Drawing.Size(22, 21);
            this.txtTipoVenta.TabIndex = 1;
            this.txtTipoVenta.Text = "...";
            // 
            // dgvListaProductos
            // 
            this.dgvListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvListaProductos.Location = new System.Drawing.Point(42, 62);
            this.dgvListaProductos.Name = "dgvListaProductos";
            this.dgvListaProductos.Size = new System.Drawing.Size(439, 169);
            this.dgvListaProductos.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "Producto";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Quantity";
            this.Column2.HeaderText = "Cantidad";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Price";
            this.Column3.HeaderText = "Precio unitario";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Total";
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(403, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total: ";
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtTotal.ForeColor = System.Drawing.Color.White;
            this.txtTotal.Location = new System.Drawing.Point(435, 243);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(62, 21);
            this.txtTotal.TabIndex = 4;
            this.txtTotal.Text = "$000.00";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nudPago);
            this.panel1.Controls.Add(this.btnRealizar);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtDebe);
            this.panel1.Controls.Add(this.txtAbonos);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lstbListaPagos);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(43, 269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 145);
            this.panel1.TabIndex = 5;
            // 
            // nudPago
            // 
            this.nudPago.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.nudPago.Location = new System.Drawing.Point(382, 43);
            this.nudPago.Name = "nudPago";
            this.nudPago.Size = new System.Drawing.Size(53, 29);
            this.nudPago.TabIndex = 8;
            // 
            // btnRealizar
            // 
            this.btnRealizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(77)))), ((int)(((byte)(60)))));
            this.btnRealizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizar.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnRealizar.ForeColor = System.Drawing.Color.White;
            this.btnRealizar.Location = new System.Drawing.Point(341, 78);
            this.btnRealizar.Name = "btnRealizar";
            this.btnRealizar.Size = new System.Drawing.Size(94, 31);
            this.btnRealizar.TabIndex = 7;
            this.btnRealizar.Text = "Realizar";
            this.btnRealizar.UseVisualStyleBackColor = false;
            this.btnRealizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(338, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 21);
            this.label10.TabIndex = 6;
            this.label10.Text = "Pago: ";
            // 
            // txtDebe
            // 
            this.txtDebe.AutoSize = true;
            this.txtDebe.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtDebe.ForeColor = System.Drawing.Color.White;
            this.txtDebe.Location = new System.Drawing.Point(246, 78);
            this.txtDebe.Name = "txtDebe";
            this.txtDebe.Size = new System.Drawing.Size(22, 21);
            this.txtDebe.TabIndex = 5;
            this.txtDebe.Text = "...";
            // 
            // txtAbonos
            // 
            this.txtAbonos.AutoSize = true;
            this.txtAbonos.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtAbonos.ForeColor = System.Drawing.Color.White;
            this.txtAbonos.Location = new System.Drawing.Point(239, 46);
            this.txtAbonos.Name = "txtAbonos";
            this.txtAbonos.Size = new System.Drawing.Size(22, 21);
            this.txtAbonos.TabIndex = 4;
            this.txtAbonos.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(180, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "Se debe: $";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(177, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Abonos: $";
            // 
            // lstbListaPagos
            // 
            this.lstbListaPagos.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.lstbListaPagos.FormattingEnabled = true;
            this.lstbListaPagos.ItemHeight = 21;
            this.lstbListaPagos.Location = new System.Drawing.Point(17, 39);
            this.lstbListaPagos.Name = "lstbListaPagos";
            this.lstbListaPagos.Size = new System.Drawing.Size(154, 88);
            this.lstbListaPagos.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Pagos";
            // 
            // FrmVerVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(524, 426);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvListaProductos);
            this.Controls.Add(this.txtTipoVenta);
            this.Controls.Add(this.label1);
            this.Name = "FrmVerVenta";
            this.Text = "FrmVerVenta";
            this.Load += new System.EventHandler(this.FrmVerVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtTipoVenta;
        private System.Windows.Forms.DataGridView dgvListaProductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudPago;
        private System.Windows.Forms.Button btnRealizar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label txtDebe;
        private System.Windows.Forms.Label txtAbonos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstbListaPagos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}