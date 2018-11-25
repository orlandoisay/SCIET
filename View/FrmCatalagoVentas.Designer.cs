namespace View
{
    partial class FrmCatalagoVentas
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
            this.dtpFechaIncio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvListaVentas = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.chbBuscar = new System.Windows.Forms.CheckBox();
            this.pnlContenedorBuscar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVentas)).BeginInit();
            this.pnlContenedorBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFechaIncio
            // 
            this.dtpFechaIncio.CustomFormat = "yyyy-MM-dd";
            this.dtpFechaIncio.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.dtpFechaIncio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaIncio.Location = new System.Drawing.Point(8, 17);
            this.dtpFechaIncio.Name = "dtpFechaIncio";
            this.dtpFechaIncio.Size = new System.Drawing.Size(106, 29);
            this.dtpFechaIncio.TabIndex = 0;
            this.dtpFechaIncio.Value = new System.DateTime(2018, 11, 7, 12, 0, 28, 0);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CustomFormat = "yyyy-MM-dd";
            this.dtpFechaFin.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFin.Location = new System.Drawing.Point(144, 17);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(104, 29);
            this.dtpFechaFin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(120, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "a";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(77)))), ((int)(((byte)(60)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(282, 14);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 34);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvListaVentas
            // 
            this.dgvListaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvListaVentas.Location = new System.Drawing.Point(57, 90);
            this.dgvListaVentas.Name = "dgvListaVentas";
            this.dgvListaVentas.Size = new System.Drawing.Size(642, 260);
            this.dgvListaVentas.TabIndex = 4;
            this.dgvListaVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dgvListaVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // No
            // 
            this.No.DataPropertyName = "IdSale";
            this.No.HeaderText = "No";
            this.No.Name = "No";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Prenda";
            this.Column1.HeaderText = "Prenda";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Date";
            this.Column2.HeaderText = "Fecha";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TypeSale";
            this.Column3.HeaderText = "Tipo de venta";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Total";
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Estatus";
            this.Column5.HeaderText = "Estatus";
            this.Column5.Name = "Column5";
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(77)))), ((int)(((byte)(60)))));
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.Location = new System.Drawing.Point(624, 52);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 32);
            this.btnReporte.TabIndex = 5;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(77)))), ((int)(((byte)(60)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(657, 356);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(42, 34);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.button3_Click);
            // 
            // chbBuscar
            // 
            this.chbBuscar.AutoSize = true;
            this.chbBuscar.Checked = true;
            this.chbBuscar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbBuscar.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.chbBuscar.ForeColor = System.Drawing.Color.White;
            this.chbBuscar.Location = new System.Drawing.Point(447, 35);
            this.chbBuscar.Name = "chbBuscar";
            this.chbBuscar.Size = new System.Drawing.Size(73, 25);
            this.chbBuscar.TabIndex = 8;
            this.chbBuscar.Text = "Buscar";
            this.chbBuscar.UseVisualStyleBackColor = true;
            this.chbBuscar.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // pnlContenedorBuscar
            // 
            this.pnlContenedorBuscar.Controls.Add(this.dtpFechaFin);
            this.pnlContenedorBuscar.Controls.Add(this.dtpFechaIncio);
            this.pnlContenedorBuscar.Controls.Add(this.label1);
            this.pnlContenedorBuscar.Controls.Add(this.btnBuscar);
            this.pnlContenedorBuscar.Location = new System.Drawing.Point(57, 12);
            this.pnlContenedorBuscar.Name = "pnlContenedorBuscar";
            this.pnlContenedorBuscar.Size = new System.Drawing.Size(384, 61);
            this.pnlContenedorBuscar.TabIndex = 9;
            // 
            // FrmCatalagoVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(759, 402);
            this.Controls.Add(this.pnlContenedorBuscar);
            this.Controls.Add(this.chbBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.dgvListaVentas);
            this.Name = "FrmCatalagoVentas";
            this.Text = "FrmCatalagoVentas";
            this.Load += new System.EventHandler(this.FrmCatalagoVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVentas)).EndInit();
            this.pnlContenedorBuscar.ResumeLayout(false);
            this.pnlContenedorBuscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaIncio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvListaVentas;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.CheckBox chbBuscar;
        private System.Windows.Forms.Panel pnlContenedorBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}