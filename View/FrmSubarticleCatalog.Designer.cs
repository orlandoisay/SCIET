namespace View
{
    partial class FrmSubarticleCatalog
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
            this.dgvSubarticles = new System.Windows.Forms.DataGridView();
            this.idSubarticles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChangeQuantity = new System.Windows.Forms.Button();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.spnQuantity = new System.Windows.Forms.NumericUpDown();
            this.spnPrice1 = new System.Windows.Forms.NumericUpDown();
            this.spnPrice3 = new System.Windows.Forms.NumericUpDown();
            this.spnPrice4 = new System.Windows.Forms.NumericUpDown();
            this.spnCost = new System.Windows.Forms.NumericUpDown();
            this.spnPrice2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlAddEdit = new System.Windows.Forms.Panel();
            this.spnIdSubarticle = new System.Windows.Forms.NumericUpDown();
            this.cbxSize = new System.Windows.Forms.ComboBox();
            this.lblArticle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubarticles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPrice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPrice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPrice4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPrice2)).BeginInit();
            this.pnlAddEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnIdSubarticle)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSubarticles
            // 
            this.dgvSubarticles.AllowUserToAddRows = false;
            this.dgvSubarticles.AllowUserToDeleteRows = false;
            this.dgvSubarticles.BackgroundColor = System.Drawing.Color.White;
            this.dgvSubarticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubarticles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSubarticles,
            this.size,
            this.color,
            this.cost,
            this.precio1,
            this.precio2,
            this.precio3,
            this.precio4,
            this.quantity});
            this.dgvSubarticles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvSubarticles.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSubarticles.Location = new System.Drawing.Point(12, 43);
            this.dgvSubarticles.MultiSelect = false;
            this.dgvSubarticles.Name = "dgvSubarticles";
            this.dgvSubarticles.ReadOnly = true;
            this.dgvSubarticles.Size = new System.Drawing.Size(670, 150);
            this.dgvSubarticles.TabIndex = 1;
            this.dgvSubarticles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubarticles_CellClick);
            // 
            // idSubarticles
            // 
            this.idSubarticles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idSubarticles.HeaderText = "Clave";
            this.idSubarticles.Name = "idSubarticles";
            this.idSubarticles.ReadOnly = true;
            this.idSubarticles.Width = 59;
            // 
            // size
            // 
            this.size.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.size.HeaderText = "Talla";
            this.size.Name = "size";
            this.size.ReadOnly = true;
            this.size.Width = 55;
            // 
            // color
            // 
            this.color.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.color.HeaderText = "Color";
            this.color.Name = "color";
            this.color.ReadOnly = true;
            this.color.Width = 56;
            // 
            // cost
            // 
            this.cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cost.HeaderText = "Costo";
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            this.cost.Width = 59;
            // 
            // precio1
            // 
            this.precio1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.precio1.HeaderText = "Menudeo";
            this.precio1.Name = "precio1";
            this.precio1.ReadOnly = true;
            this.precio1.Width = 77;
            // 
            // precio2
            // 
            this.precio2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.precio2.HeaderText = "Medio mayoreo";
            this.precio2.Name = "precio2";
            this.precio2.ReadOnly = true;
            this.precio2.Width = 96;
            // 
            // precio3
            // 
            this.precio3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.precio3.HeaderText = "Mayoreo";
            this.precio3.Name = "precio3";
            this.precio3.ReadOnly = true;
            this.precio3.Width = 73;
            // 
            // precio4
            // 
            this.precio4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.precio4.HeaderText = "Especial";
            this.precio4.Name = "precio4";
            this.precio4.ReadOnly = true;
            this.precio4.Width = 72;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quantity.HeaderText = "Existencia";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 80;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnAdd.Location = new System.Drawing.Point(376, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnEdit.Location = new System.Drawing.Point(482, 8);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(97, 29);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnDelete.Location = new System.Drawing.Point(585, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 29);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChangeQuantity
            // 
            this.btnChangeQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnChangeQuantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeQuantity.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnChangeQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeQuantity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnChangeQuantity.Location = new System.Drawing.Point(12, 196);
            this.btnChangeQuantity.Name = "btnChangeQuantity";
            this.btnChangeQuantity.Size = new System.Drawing.Size(180, 29);
            this.btnChangeQuantity.TabIndex = 5;
            this.btnChangeQuantity.Text = "Modificar existencia";
            this.btnChangeQuantity.UseVisualStyleBackColor = false;
            this.btnChangeQuantity.Visible = false;
            this.btnChangeQuantity.Click += new System.EventHandler(this.btnChangeQuantity_Click);
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtColor.Location = new System.Drawing.Point(99, 25);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(75, 29);
            this.txtColor.TabIndex = 0;
            // 
            // spnQuantity
            // 
            this.spnQuantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spnQuantity.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.spnQuantity.Location = new System.Drawing.Point(99, 76);
            this.spnQuantity.Name = "spnQuantity";
            this.spnQuantity.ReadOnly = true;
            this.spnQuantity.Size = new System.Drawing.Size(75, 29);
            this.spnQuantity.TabIndex = 8;
            // 
            // spnPrice1
            // 
            this.spnPrice1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spnPrice1.DecimalPlaces = 2;
            this.spnPrice1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.spnPrice1.Location = new System.Drawing.Point(194, 26);
            this.spnPrice1.Name = "spnPrice1";
            this.spnPrice1.Size = new System.Drawing.Size(100, 29);
            this.spnPrice1.TabIndex = 9;
            this.spnPrice1.ValueChanged += new System.EventHandler(this.spnPrice1_ValueChanged);
            // 
            // spnPrice3
            // 
            this.spnPrice3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spnPrice3.DecimalPlaces = 2;
            this.spnPrice3.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.spnPrice3.Location = new System.Drawing.Point(314, 25);
            this.spnPrice3.Name = "spnPrice3";
            this.spnPrice3.Size = new System.Drawing.Size(100, 29);
            this.spnPrice3.TabIndex = 10;
            // 
            // spnPrice4
            // 
            this.spnPrice4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spnPrice4.DecimalPlaces = 2;
            this.spnPrice4.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.spnPrice4.Location = new System.Drawing.Point(314, 77);
            this.spnPrice4.Name = "spnPrice4";
            this.spnPrice4.Size = new System.Drawing.Size(100, 29);
            this.spnPrice4.TabIndex = 11;
            // 
            // spnCost
            // 
            this.spnCost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spnCost.DecimalPlaces = 2;
            this.spnCost.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.spnCost.Location = new System.Drawing.Point(433, 25);
            this.spnCost.Name = "spnCost";
            this.spnCost.Size = new System.Drawing.Size(100, 29);
            this.spnCost.TabIndex = 12;
            // 
            // spnPrice2
            // 
            this.spnPrice2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spnPrice2.DecimalPlaces = 2;
            this.spnPrice2.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.spnPrice2.Location = new System.Drawing.Point(194, 78);
            this.spnPrice2.Name = "spnPrice2";
            this.spnPrice2.Size = new System.Drawing.Size(100, 29);
            this.spnPrice2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Clave:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Talla:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(95, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Color:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(95, 54);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(78, 21);
            this.lblQuantity.TabIndex = 17;
            this.lblQuantity.Text = "Existencia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(190, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Menudeo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(310, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "Mayoreo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(190, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "Medio mayoreo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(310, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 21);
            this.label8.TabIndex = 21;
            this.label8.Text = "Especial:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(429, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 21);
            this.label9.TabIndex = 22;
            this.label9.Text = "Costo:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnSave.Location = new System.Drawing.Point(570, 43);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 29);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnCancel.Location = new System.Drawing.Point(570, 76);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 29);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlAddEdit
            // 
            this.pnlAddEdit.Controls.Add(this.spnIdSubarticle);
            this.pnlAddEdit.Controls.Add(this.cbxSize);
            this.pnlAddEdit.Controls.Add(this.spnCost);
            this.pnlAddEdit.Controls.Add(this.btnCancel);
            this.pnlAddEdit.Controls.Add(this.btnSave);
            this.pnlAddEdit.Controls.Add(this.label9);
            this.pnlAddEdit.Controls.Add(this.txtColor);
            this.pnlAddEdit.Controls.Add(this.label8);
            this.pnlAddEdit.Controls.Add(this.spnQuantity);
            this.pnlAddEdit.Controls.Add(this.label7);
            this.pnlAddEdit.Controls.Add(this.spnPrice1);
            this.pnlAddEdit.Controls.Add(this.label6);
            this.pnlAddEdit.Controls.Add(this.spnPrice3);
            this.pnlAddEdit.Controls.Add(this.label5);
            this.pnlAddEdit.Controls.Add(this.spnPrice4);
            this.pnlAddEdit.Controls.Add(this.lblQuantity);
            this.pnlAddEdit.Controls.Add(this.spnPrice2);
            this.pnlAddEdit.Controls.Add(this.label3);
            this.pnlAddEdit.Controls.Add(this.label1);
            this.pnlAddEdit.Controls.Add(this.label2);
            this.pnlAddEdit.Location = new System.Drawing.Point(12, 225);
            this.pnlAddEdit.Name = "pnlAddEdit";
            this.pnlAddEdit.Size = new System.Drawing.Size(670, 106);
            this.pnlAddEdit.TabIndex = 25;
            this.pnlAddEdit.Visible = false;
            // 
            // spnIdSubarticle
            // 
            this.spnIdSubarticle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spnIdSubarticle.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.spnIdSubarticle.Location = new System.Drawing.Point(7, 25);
            this.spnIdSubarticle.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spnIdSubarticle.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnIdSubarticle.Name = "spnIdSubarticle";
            this.spnIdSubarticle.ReadOnly = true;
            this.spnIdSubarticle.Size = new System.Drawing.Size(75, 29);
            this.spnIdSubarticle.TabIndex = 26;
            this.spnIdSubarticle.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbxSize
            // 
            this.cbxSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxSize.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.cbxSize.FormattingEnabled = true;
            this.cbxSize.Items.AddRange(new object[] {
            "XS",
            "S",
            "M",
            "L",
            "XL",
            "XXL",
            "XXXL"});
            this.cbxSize.Location = new System.Drawing.Point(7, 75);
            this.cbxSize.Name = "cbxSize";
            this.cbxSize.Size = new System.Drawing.Size(75, 29);
            this.cbxSize.TabIndex = 25;
            // 
            // lblArticle
            // 
            this.lblArticle.AutoSize = true;
            this.lblArticle.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticle.ForeColor = System.Drawing.Color.White;
            this.lblArticle.Location = new System.Drawing.Point(15, 14);
            this.lblArticle.Name = "lblArticle";
            this.lblArticle.Size = new System.Drawing.Size(66, 21);
            this.lblArticle.TabIndex = 26;
            this.lblArticle.Text = "Clave: --";
            this.lblArticle.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnBack.Location = new System.Drawing.Point(582, 196);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 29);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "Cerrar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmSubarticleCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(694, 345);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblArticle);
            this.Controls.Add(this.pnlAddEdit);
            this.Controls.Add(this.btnChangeQuantity);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvSubarticles);
            this.Name = "FrmSubarticleCatalog";
            this.Text = "FrmSubarticleCatalog";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubarticles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPrice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPrice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPrice4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPrice2)).EndInit();
            this.pnlAddEdit.ResumeLayout(false);
            this.pnlAddEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnIdSubarticle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSubarticles;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChangeQuantity;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.NumericUpDown spnQuantity;
        private System.Windows.Forms.NumericUpDown spnPrice1;
        private System.Windows.Forms.NumericUpDown spnPrice3;
        private System.Windows.Forms.NumericUpDown spnPrice4;
        private System.Windows.Forms.NumericUpDown spnCost;
        private System.Windows.Forms.NumericUpDown spnPrice2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlAddEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSubarticles;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio1;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio2;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio3;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio4;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.Label lblArticle;
        private System.Windows.Forms.ComboBox cbxSize;
        private System.Windows.Forms.NumericUpDown spnIdSubarticle;
        private System.Windows.Forms.Button btnBack;
    }
}