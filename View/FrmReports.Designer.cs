namespace View
{
    partial class FrmReports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnExportProducts = new System.Windows.Forms.Button();
            this.dtgReportProducts = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mayoreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menudeo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnInventory = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rdbCustomInputsAndOutputs = new System.Windows.Forms.RadioButton();
            this.rdbDayInputOutput = new System.Windows.Forms.RadioButton();
            this.rdbWeekInputOutput = new System.Windows.Forms.RadioButton();
            this.rdbMonthInputOutput = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbInitialDateInputOutput = new System.Windows.Forms.DateTimePicker();
            this.cmbFinalDateInputOutput = new System.Windows.Forms.DateTimePicker();
            this.btnInputOutput = new System.Windows.Forms.Button();
            this.dtgInputOutput = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdbYeadInputOutput = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnReportInOut = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rdbCustomSales = new System.Windows.Forms.RadioButton();
            this.rdbDaySales = new System.Windows.Forms.RadioButton();
            this.rdbWeekSales = new System.Windows.Forms.RadioButton();
            this.rdbMonthSales = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbInitialSalesDate = new System.Windows.Forms.DateTimePicker();
            this.cmbFinalSalesDare = new System.Windows.Forms.DateTimePicker();
            this.btnExportSales = new System.Windows.Forms.Button();
            this.dtgSalesReport = new System.Windows.Forms.DataGridView();
            this.rdbYearSales = new System.Windows.Forms.RadioButton();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnReportSales = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReportProducts)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInputOutput)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSalesReport)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.tabPage4.Controls.Add(this.btnInventory);
            this.tabPage4.Controls.Add(this.panel3);
            this.tabPage4.Controls.Add(this.dtgReportProducts);
            this.tabPage4.Controls.Add(this.btnExportProducts);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(954, 490);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Reporte de Inventario";
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // btnExportProducts
            // 
            this.btnExportProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnExportProducts.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportProducts.ForeColor = System.Drawing.Color.White;
            this.btnExportProducts.Location = new System.Drawing.Point(17, 435);
            this.btnExportProducts.Name = "btnExportProducts";
            this.btnExportProducts.Size = new System.Drawing.Size(130, 45);
            this.btnExportProducts.TabIndex = 41;
            this.btnExportProducts.Text = "Exportar a Excel";
            this.btnExportProducts.UseVisualStyleBackColor = false;
            this.btnExportProducts.Click += new System.EventHandler(this.btnExportProducts_Click);
            // 
            // dtgReportProducts
            // 
            this.dtgReportProducts.AllowUserToAddRows = false;
            this.dtgReportProducts.AllowUserToDeleteRows = false;
            this.dtgReportProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReportProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn13,
            this.Column5,
            this.Menudeo,
            this.dataGridViewTextBoxColumn15,
            this.Mayoreo,
            this.Especial,
            this.Column6});
            this.dtgReportProducts.Location = new System.Drawing.Point(2, 115);
            this.dtgReportProducts.Name = "dtgReportProducts";
            this.dtgReportProducts.ReadOnly = true;
            this.dtgReportProducts.Size = new System.Drawing.Size(948, 302);
            this.dtgReportProducts.TabIndex = 42;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Existencia";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Especial
            // 
            this.Especial.HeaderText = "Especial";
            this.Especial.Name = "Especial";
            this.Especial.ReadOnly = true;
            // 
            // Mayoreo
            // 
            this.Mayoreo.HeaderText = "Mayoreo";
            this.Mayoreo.Name = "Mayoreo";
            this.Mayoreo.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "Medio Mayoreo";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // Menudeo
            // 
            this.Menudeo.HeaderText = "Menudeo";
            this.Menudeo.Name = "Menudeo";
            this.Menudeo.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Costo";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Color";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Talla";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Clave";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(948, 60);
            this.panel3.TabIndex = 44;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.Image = global::View.Properties.Resources.logo;
            this.pictureBox3.InitialImage = global::View.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(14, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(157, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(186, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 30);
            this.label11.TabIndex = 2;
            this.label11.Text = "Inventario";
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnInventory.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Location = new System.Drawing.Point(17, 69);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(113, 40);
            this.btnInventory.TabIndex = 45;
            this.btnInventory.Text = "Generar Reporte";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.tabPage2.Controls.Add(this.btnReportInOut);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.rdbYeadInputOutput);
            this.tabPage2.Controls.Add(this.dtgInputOutput);
            this.tabPage2.Controls.Add(this.btnInputOutput);
            this.tabPage2.Controls.Add(this.cmbFinalDateInputOutput);
            this.tabPage2.Controls.Add(this.cmbInitialDateInputOutput);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.rdbMonthInputOutput);
            this.tabPage2.Controls.Add(this.rdbWeekInputOutput);
            this.tabPage2.Controls.Add(this.rdbDayInputOutput);
            this.tabPage2.Controls.Add(this.rdbCustomInputsAndOutputs);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(954, 490);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reporte de Entradas y Salidas";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // rdbCustomInputsAndOutputs
            // 
            this.rdbCustomInputsAndOutputs.AutoSize = true;
            this.rdbCustomInputsAndOutputs.Checked = true;
            this.rdbCustomInputsAndOutputs.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCustomInputsAndOutputs.ForeColor = System.Drawing.Color.White;
            this.rdbCustomInputsAndOutputs.Location = new System.Drawing.Point(27, 79);
            this.rdbCustomInputsAndOutputs.Name = "rdbCustomInputsAndOutputs";
            this.rdbCustomInputsAndOutputs.Size = new System.Drawing.Size(100, 21);
            this.rdbCustomInputsAndOutputs.TabIndex = 22;
            this.rdbCustomInputsAndOutputs.TabStop = true;
            this.rdbCustomInputsAndOutputs.Text = "Personalizado";
            this.rdbCustomInputsAndOutputs.UseVisualStyleBackColor = true;
            this.rdbCustomInputsAndOutputs.CheckedChanged += new System.EventHandler(this.rdbCustomInputsAndOutputs_CheckedChanged);
            // 
            // rdbDayInputOutput
            // 
            this.rdbDayInputOutput.AutoSize = true;
            this.rdbDayInputOutput.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDayInputOutput.ForeColor = System.Drawing.Color.White;
            this.rdbDayInputOutput.Location = new System.Drawing.Point(143, 79);
            this.rdbDayInputOutput.Name = "rdbDayInputOutput";
            this.rdbDayInputOutput.Size = new System.Drawing.Size(44, 21);
            this.rdbDayInputOutput.TabIndex = 23;
            this.rdbDayInputOutput.Text = "Día";
            this.rdbDayInputOutput.UseVisualStyleBackColor = true;
            this.rdbDayInputOutput.CheckedChanged += new System.EventHandler(this.rdbDayInputOutput_CheckedChanged);
            // 
            // rdbWeekInputOutput
            // 
            this.rdbWeekInputOutput.AutoSize = true;
            this.rdbWeekInputOutput.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbWeekInputOutput.ForeColor = System.Drawing.Color.White;
            this.rdbWeekInputOutput.Location = new System.Drawing.Point(211, 79);
            this.rdbWeekInputOutput.Name = "rdbWeekInputOutput";
            this.rdbWeekInputOutput.Size = new System.Drawing.Size(69, 21);
            this.rdbWeekInputOutput.TabIndex = 24;
            this.rdbWeekInputOutput.Text = "Semana";
            this.rdbWeekInputOutput.UseVisualStyleBackColor = true;
            this.rdbWeekInputOutput.CheckedChanged += new System.EventHandler(this.rdbWeekInputOutput_CheckedChanged);
            // 
            // rdbMonthInputOutput
            // 
            this.rdbMonthInputOutput.AutoSize = true;
            this.rdbMonthInputOutput.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMonthInputOutput.ForeColor = System.Drawing.Color.White;
            this.rdbMonthInputOutput.Location = new System.Drawing.Point(309, 79);
            this.rdbMonthInputOutput.Name = "rdbMonthInputOutput";
            this.rdbMonthInputOutput.Size = new System.Drawing.Size(49, 21);
            this.rdbMonthInputOutput.TabIndex = 25;
            this.rdbMonthInputOutput.Text = "Mes";
            this.rdbMonthInputOutput.UseVisualStyleBackColor = true;
            this.rdbMonthInputOutput.CheckedChanged += new System.EventHandler(this.rdbMonthInputOutput_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Fecha Inicial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Fecha Final";
            // 
            // cmbInitialDateInputOutput
            // 
            this.cmbInitialDateInputOutput.Location = new System.Drawing.Point(10, 176);
            this.cmbInitialDateInputOutput.Name = "cmbInitialDateInputOutput";
            this.cmbInitialDateInputOutput.Size = new System.Drawing.Size(200, 20);
            this.cmbInitialDateInputOutput.TabIndex = 28;
            // 
            // cmbFinalDateInputOutput
            // 
            this.cmbFinalDateInputOutput.Location = new System.Drawing.Point(10, 240);
            this.cmbFinalDateInputOutput.Name = "cmbFinalDateInputOutput";
            this.cmbFinalDateInputOutput.Size = new System.Drawing.Size(200, 20);
            this.cmbFinalDateInputOutput.TabIndex = 29;
            // 
            // btnInputOutput
            // 
            this.btnInputOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnInputOutput.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInputOutput.ForeColor = System.Drawing.Color.White;
            this.btnInputOutput.Location = new System.Drawing.Point(17, 383);
            this.btnInputOutput.Name = "btnInputOutput";
            this.btnInputOutput.Size = new System.Drawing.Size(122, 51);
            this.btnInputOutput.TabIndex = 30;
            this.btnInputOutput.Text = "Exportar a Excel";
            this.btnInputOutput.UseVisualStyleBackColor = false;
            this.btnInputOutput.Click += new System.EventHandler(this.btnInputOutput_Click);
            // 
            // dtgInputOutput
            // 
            this.dtgInputOutput.AllowUserToAddRows = false;
            this.dtgInputOutput.AllowUserToDeleteRows = false;
            this.dtgInputOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInputOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dtgInputOutput.Location = new System.Drawing.Point(225, 133);
            this.dtgInputOutput.Name = "dtgInputOutput";
            this.dtgInputOutput.ReadOnly = true;
            this.dtgInputOutput.Size = new System.Drawing.Size(467, 301);
            this.dtgInputOutput.TabIndex = 31;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Transacción";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // rdbYeadInputOutput
            // 
            this.rdbYeadInputOutput.AutoSize = true;
            this.rdbYeadInputOutput.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbYeadInputOutput.ForeColor = System.Drawing.Color.White;
            this.rdbYeadInputOutput.Location = new System.Drawing.Point(393, 79);
            this.rdbYeadInputOutput.Name = "rdbYeadInputOutput";
            this.rdbYeadInputOutput.Size = new System.Drawing.Size(48, 21);
            this.rdbYeadInputOutput.TabIndex = 32;
            this.rdbYeadInputOutput.Text = "Año";
            this.rdbYeadInputOutput.UseVisualStyleBackColor = true;
            this.rdbYeadInputOutput.CheckedChanged += new System.EventHandler(this.rdbYeadInputOutput_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 60);
            this.panel1.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::View.Properties.Resources.logo;
            this.pictureBox1.InitialImage = global::View.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(14, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(186, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 30);
            this.label9.TabIndex = 2;
            this.label9.Text = "Entradas y Salidas";
            // 
            // btnReportInOut
            // 
            this.btnReportInOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnReportInOut.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportInOut.ForeColor = System.Drawing.Color.White;
            this.btnReportInOut.Location = new System.Drawing.Point(10, 117);
            this.btnReportInOut.Name = "btnReportInOut";
            this.btnReportInOut.Size = new System.Drawing.Size(110, 26);
            this.btnReportInOut.TabIndex = 35;
            this.btnReportInOut.Text = "Generar Reporte";
            this.btnReportInOut.UseVisualStyleBackColor = false;
            this.btnReportInOut.Click += new System.EventHandler(this.btnReportInOut_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.tabPage1.Controls.Add(this.btnReportSales);
            this.tabPage1.Controls.Add(this.pnlTop);
            this.tabPage1.Controls.Add(this.rdbYearSales);
            this.tabPage1.Controls.Add(this.dtgSalesReport);
            this.tabPage1.Controls.Add(this.btnExportSales);
            this.tabPage1.Controls.Add(this.cmbFinalSalesDare);
            this.tabPage1.Controls.Add(this.cmbInitialSalesDate);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.rdbMonthSales);
            this.tabPage1.Controls.Add(this.rdbWeekSales);
            this.tabPage1.Controls.Add(this.rdbDaySales);
            this.tabPage1.Controls.Add(this.rdbCustomSales);
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(954, 490);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Reporte de Ventas";
            // 
            // rdbCustomSales
            // 
            this.rdbCustomSales.AutoSize = true;
            this.rdbCustomSales.Checked = true;
            this.rdbCustomSales.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCustomSales.ForeColor = System.Drawing.Color.White;
            this.rdbCustomSales.Location = new System.Drawing.Point(26, 79);
            this.rdbCustomSales.Name = "rdbCustomSales";
            this.rdbCustomSales.Size = new System.Drawing.Size(100, 21);
            this.rdbCustomSales.TabIndex = 22;
            this.rdbCustomSales.TabStop = true;
            this.rdbCustomSales.Text = "Personalizado";
            this.rdbCustomSales.UseVisualStyleBackColor = true;
            this.rdbCustomSales.CheckedChanged += new System.EventHandler(this.rdbCustomSales_CheckedChanged);
            // 
            // rdbDaySales
            // 
            this.rdbDaySales.AutoSize = true;
            this.rdbDaySales.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDaySales.ForeColor = System.Drawing.Color.White;
            this.rdbDaySales.Location = new System.Drawing.Point(137, 79);
            this.rdbDaySales.Name = "rdbDaySales";
            this.rdbDaySales.Size = new System.Drawing.Size(44, 21);
            this.rdbDaySales.TabIndex = 23;
            this.rdbDaySales.Text = "Día";
            this.rdbDaySales.UseVisualStyleBackColor = true;
            this.rdbDaySales.CheckedChanged += new System.EventHandler(this.rdbDaySales_CheckedChanged);
            // 
            // rdbWeekSales
            // 
            this.rdbWeekSales.AutoSize = true;
            this.rdbWeekSales.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbWeekSales.ForeColor = System.Drawing.Color.White;
            this.rdbWeekSales.Location = new System.Drawing.Point(205, 79);
            this.rdbWeekSales.Name = "rdbWeekSales";
            this.rdbWeekSales.Size = new System.Drawing.Size(69, 21);
            this.rdbWeekSales.TabIndex = 24;
            this.rdbWeekSales.Text = "Semana";
            this.rdbWeekSales.UseVisualStyleBackColor = true;
            this.rdbWeekSales.CheckedChanged += new System.EventHandler(this.rdbWeekSales_CheckedChanged);
            // 
            // rdbMonthSales
            // 
            this.rdbMonthSales.AutoSize = true;
            this.rdbMonthSales.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMonthSales.ForeColor = System.Drawing.Color.White;
            this.rdbMonthSales.Location = new System.Drawing.Point(303, 79);
            this.rdbMonthSales.Name = "rdbMonthSales";
            this.rdbMonthSales.Size = new System.Drawing.Size(49, 21);
            this.rdbMonthSales.TabIndex = 25;
            this.rdbMonthSales.Text = "Mes";
            this.rdbMonthSales.UseVisualStyleBackColor = true;
            this.rdbMonthSales.CheckedChanged += new System.EventHandler(this.rdbMonthSales_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Fecha Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Fecha Final";
            // 
            // cmbInitialSalesDate
            // 
            this.cmbInitialSalesDate.Location = new System.Drawing.Point(4, 176);
            this.cmbInitialSalesDate.Name = "cmbInitialSalesDate";
            this.cmbInitialSalesDate.Size = new System.Drawing.Size(200, 20);
            this.cmbInitialSalesDate.TabIndex = 28;
            // 
            // cmbFinalSalesDare
            // 
            this.cmbFinalSalesDare.Location = new System.Drawing.Point(4, 240);
            this.cmbFinalSalesDare.Name = "cmbFinalSalesDare";
            this.cmbFinalSalesDare.Size = new System.Drawing.Size(200, 20);
            this.cmbFinalSalesDare.TabIndex = 29;
            // 
            // btnExportSales
            // 
            this.btnExportSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnExportSales.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportSales.ForeColor = System.Drawing.Color.White;
            this.btnExportSales.Location = new System.Drawing.Point(26, 400);
            this.btnExportSales.Name = "btnExportSales";
            this.btnExportSales.Size = new System.Drawing.Size(154, 48);
            this.btnExportSales.TabIndex = 30;
            this.btnExportSales.Text = "Exportar a Excel";
            this.btnExportSales.UseVisualStyleBackColor = false;
            this.btnExportSales.Click += new System.EventHandler(this.btnExportSales_Click);
            // 
            // dtgSalesReport
            // 
            this.dtgSalesReport.AllowUserToAddRows = false;
            this.dtgSalesReport.AllowUserToDeleteRows = false;
            this.dtgSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSalesReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Date,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgSalesReport.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgSalesReport.Location = new System.Drawing.Point(219, 133);
            this.dtgSalesReport.Name = "dtgSalesReport";
            this.dtgSalesReport.ReadOnly = true;
            this.dtgSalesReport.Size = new System.Drawing.Size(449, 301);
            this.dtgSalesReport.TabIndex = 31;
            // 
            // rdbYearSales
            // 
            this.rdbYearSales.AutoSize = true;
            this.rdbYearSales.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbYearSales.ForeColor = System.Drawing.Color.White;
            this.rdbYearSales.Location = new System.Drawing.Point(387, 79);
            this.rdbYearSales.Name = "rdbYearSales";
            this.rdbYearSales.Size = new System.Drawing.Size(48, 21);
            this.rdbYearSales.TabIndex = 32;
            this.rdbYearSales.Text = "Año";
            this.rdbYearSales.UseVisualStyleBackColor = true;
            this.rdbYearSales.CheckedChanged += new System.EventHandler(this.rdbYearSales_CheckedChanged);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.lblHeader);
            this.pnlTop.Controls.Add(this.pbLogo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(3, 3);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(948, 60);
            this.pnlTop.TabIndex = 33;
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pbLogo.Image = global::View.Properties.Resources.logo;
            this.pbLogo.InitialImage = global::View.Properties.Resources.logo;
            this.pbLogo.Location = new System.Drawing.Point(14, 14);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(157, 32);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.White;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(186, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(74, 30);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Ventas";
            // 
            // btnReportSales
            // 
            this.btnReportSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnReportSales.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportSales.ForeColor = System.Drawing.Color.White;
            this.btnReportSales.Location = new System.Drawing.Point(4, 115);
            this.btnReportSales.Name = "btnReportSales";
            this.btnReportSales.Size = new System.Drawing.Size(110, 27);
            this.btnReportSales.TabIndex = 34;
            this.btnReportSales.Text = "Generar Reporte";
            this.btnReportSales.UseVisualStyleBackColor = false;
            this.btnReportSales.Click += new System.EventHandler(this.btnReportSales_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(6, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(962, 516);
            this.tabControl1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = global::View.Properties.Resources.logo;
            this.pictureBox2.InitialImage = global::View.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(14, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(157, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(186, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 30);
            this.label10.TabIndex = 2;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Importe";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Comprador";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Fecha";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Clave";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // FrmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 513);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmReports";
            this.Text = "Reportes";
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgReportProducts)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInputOutput)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSalesReport)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dtgReportProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menudeo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mayoreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnExportProducts;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnReportInOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rdbYeadInputOutput;
        private System.Windows.Forms.DataGridView dtgInputOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnInputOutput;
        private System.Windows.Forms.DateTimePicker cmbFinalDateInputOutput;
        private System.Windows.Forms.DateTimePicker cmbInitialDateInputOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbMonthInputOutput;
        private System.Windows.Forms.RadioButton rdbWeekInputOutput;
        private System.Windows.Forms.RadioButton rdbDayInputOutput;
        private System.Windows.Forms.RadioButton rdbCustomInputsAndOutputs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnReportSales;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.RadioButton rdbYearSales;
        private System.Windows.Forms.DataGridView dtgSalesReport;
        private System.Windows.Forms.Button btnExportSales;
        private System.Windows.Forms.DateTimePicker cmbFinalSalesDare;
        private System.Windows.Forms.DateTimePicker cmbInitialSalesDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbMonthSales;
        private System.Windows.Forms.RadioButton rdbWeekSales;
        private System.Windows.Forms.RadioButton rdbDaySales;
        private System.Windows.Forms.RadioButton rdbCustomSales;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label10;
    }
}