namespace View
{
    partial class FrmArticleCatalog
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rbtnIdArticle = new System.Windows.Forms.RadioButton();
            this.rbtnNameArticle = new System.Windows.Forms.RadioButton();
            this.dgvArticles = new System.Windows.Forms.DataGridView();
            this.idArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.btnShowSubarticles = new System.Windows.Forms.Button();
            this.lblQuantityArticle = new System.Windows.Forms.Label();
            this.txtaDescriptionDetails = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNameArticle = new System.Windows.Forms.Label();
            this.lblIdArticle = new System.Windows.Forms.Label();
            this.pbxDetails = new System.Windows.Forms.PictureBox();
            this.pnlAddEdit = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.spnIdArticle = new System.Windows.Forms.NumericUpDown();
            this.txtaDescriptionAddEdit = new System.Windows.Forms.RichTextBox();
            this.txtNameArticle = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAttach = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbxAddEdit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).BeginInit();
            this.pnlDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDetails)).BeginInit();
            this.pnlAddEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnIdArticle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtSearch.Location = new System.Drawing.Point(9, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 29);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // rbtnIdArticle
            // 
            this.rbtnIdArticle.AutoSize = true;
            this.rbtnIdArticle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnIdArticle.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.rbtnIdArticle.ForeColor = System.Drawing.SystemColors.Control;
            this.rbtnIdArticle.Location = new System.Drawing.Point(98, 42);
            this.rbtnIdArticle.Name = "rbtnIdArticle";
            this.rbtnIdArticle.Size = new System.Drawing.Size(64, 25);
            this.rbtnIdArticle.TabIndex = 4;
            this.rbtnIdArticle.TabStop = true;
            this.rbtnIdArticle.Text = "Clave";
            this.rbtnIdArticle.UseVisualStyleBackColor = true;
            // 
            // rbtnNameArticle
            // 
            this.rbtnNameArticle.AutoSize = true;
            this.rbtnNameArticle.Checked = true;
            this.rbtnNameArticle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnNameArticle.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.rbtnNameArticle.ForeColor = System.Drawing.SystemColors.Control;
            this.rbtnNameArticle.Location = new System.Drawing.Point(9, 42);
            this.rbtnNameArticle.Name = "rbtnNameArticle";
            this.rbtnNameArticle.Size = new System.Drawing.Size(83, 25);
            this.rbtnNameArticle.TabIndex = 5;
            this.rbtnNameArticle.TabStop = true;
            this.rbtnNameArticle.Text = "Nombre";
            this.rbtnNameArticle.UseVisualStyleBackColor = true;
            this.rbtnNameArticle.CheckedChanged += new System.EventHandler(this.rbtnNameArticle_CheckedChanged);
            // 
            // dgvArticles
            // 
            this.dgvArticles.AllowUserToAddRows = false;
            this.dgvArticles.AllowUserToDeleteRows = false;
            this.dgvArticles.BackgroundColor = System.Drawing.Color.White;
            this.dgvArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idArticle,
            this.name,
            this.quantityArticle});
            this.dgvArticles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvArticles.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvArticles.Location = new System.Drawing.Point(9, 71);
            this.dgvArticles.MultiSelect = false;
            this.dgvArticles.Name = "dgvArticles";
            this.dgvArticles.ReadOnly = true;
            this.dgvArticles.Size = new System.Drawing.Size(506, 150);
            this.dgvArticles.TabIndex = 13;
            this.dgvArticles.TabStop = false;
            this.dgvArticles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticles_CellClick);
            // 
            // idArticle
            // 
            this.idArticle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idArticle.HeaderText = "Clave";
            this.idArticle.Name = "idArticle";
            this.idArticle.ReadOnly = true;
            this.idArticle.Width = 59;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Nombre";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // quantityArticle
            // 
            this.quantityArticle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quantityArticle.HeaderText = "Existencia";
            this.quantityArticle.Name = "quantityArticle";
            this.quantityArticle.ReadOnly = true;
            this.quantityArticle.Width = 80;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnEdit.Location = new System.Drawing.Point(359, 38);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 29);
            this.btnEdit.TabIndex = 1;
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
            this.btnDelete.Location = new System.Drawing.Point(440, 38);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 29);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnAdd.Location = new System.Drawing.Point(278, 38);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 29);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlDetails
            // 
            this.pnlDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDetails.Controls.Add(this.btnShowSubarticles);
            this.pnlDetails.Controls.Add(this.lblQuantityArticle);
            this.pnlDetails.Controls.Add(this.txtaDescriptionDetails);
            this.pnlDetails.Controls.Add(this.label3);
            this.pnlDetails.Controls.Add(this.lblNameArticle);
            this.pnlDetails.Controls.Add(this.lblIdArticle);
            this.pnlDetails.Controls.Add(this.pbxDetails);
            this.pnlDetails.Location = new System.Drawing.Point(9, 227);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(506, 190);
            this.pnlDetails.TabIndex = 7;
            this.pnlDetails.Visible = false;
            // 
            // btnShowSubarticles
            // 
            this.btnShowSubarticles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnShowSubarticles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowSubarticles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnShowSubarticles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnShowSubarticles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowSubarticles.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowSubarticles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnShowSubarticles.Location = new System.Drawing.Point(341, 150);
            this.btnShowSubarticles.Name = "btnShowSubarticles";
            this.btnShowSubarticles.Size = new System.Drawing.Size(156, 29);
            this.btnShowSubarticles.TabIndex = 6;
            this.btnShowSubarticles.Text = "Ver subartículos";
            this.btnShowSubarticles.UseVisualStyleBackColor = false;
            this.btnShowSubarticles.Click += new System.EventHandler(this.btnShowSubarticles_Click);
            // 
            // lblQuantityArticle
            // 
            this.lblQuantityArticle.AutoSize = true;
            this.lblQuantityArticle.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.lblQuantityArticle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblQuantityArticle.Location = new System.Drawing.Point(337, 126);
            this.lblQuantityArticle.Name = "lblQuantityArticle";
            this.lblQuantityArticle.Size = new System.Drawing.Size(94, 21);
            this.lblQuantityArticle.TabIndex = 9;
            this.lblQuantityArticle.Text = "Existencia: --";
            // 
            // txtaDescriptionDetails
            // 
            this.txtaDescriptionDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.txtaDescriptionDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtaDescriptionDetails.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaDescriptionDetails.ForeColor = System.Drawing.Color.White;
            this.txtaDescriptionDetails.Location = new System.Drawing.Point(109, 23);
            this.txtaDescriptionDetails.Name = "txtaDescriptionDetails";
            this.txtaDescriptionDetails.ReadOnly = true;
            this.txtaDescriptionDetails.Size = new System.Drawing.Size(388, 100);
            this.txtaDescriptionDetails.TabIndex = 13;
            this.txtaDescriptionDetails.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(106, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Descripción:";
            // 
            // lblNameArticle
            // 
            this.lblNameArticle.AutoSize = true;
            this.lblNameArticle.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.lblNameArticle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNameArticle.Location = new System.Drawing.Point(3, 126);
            this.lblNameArticle.Name = "lblNameArticle";
            this.lblNameArticle.Size = new System.Drawing.Size(85, 21);
            this.lblNameArticle.TabIndex = 11;
            this.lblNameArticle.Text = "Nombre: --";
            // 
            // lblIdArticle
            // 
            this.lblIdArticle.AutoSize = true;
            this.lblIdArticle.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.lblIdArticle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIdArticle.Location = new System.Drawing.Point(3, 3);
            this.lblIdArticle.Name = "lblIdArticle";
            this.lblIdArticle.Size = new System.Drawing.Size(66, 21);
            this.lblIdArticle.TabIndex = 10;
            this.lblIdArticle.Text = "Clave: --";
            // 
            // pbxDetails
            // 
            this.pbxDetails.BackColor = System.Drawing.Color.White;
            this.pbxDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxDetails.ErrorImage = global::View.Properties.Resources.logo;
            this.pbxDetails.Location = new System.Drawing.Point(3, 23);
            this.pbxDetails.Name = "pbxDetails";
            this.pbxDetails.Size = new System.Drawing.Size(100, 100);
            this.pbxDetails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDetails.TabIndex = 9;
            this.pbxDetails.TabStop = false;
            this.pbxDetails.Click += new System.EventHandler(this.pbxDetails_Click);
            // 
            // pnlAddEdit
            // 
            this.pnlAddEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddEdit.Controls.Add(this.label1);
            this.pnlAddEdit.Controls.Add(this.lblPath);
            this.pnlAddEdit.Controls.Add(this.spnIdArticle);
            this.pnlAddEdit.Controls.Add(this.txtaDescriptionAddEdit);
            this.pnlAddEdit.Controls.Add(this.txtNameArticle);
            this.pnlAddEdit.Controls.Add(this.btnCancel);
            this.pnlAddEdit.Controls.Add(this.btnSave);
            this.pnlAddEdit.Controls.Add(this.btnAttach);
            this.pnlAddEdit.Controls.Add(this.label7);
            this.pnlAddEdit.Controls.Add(this.label6);
            this.pnlAddEdit.Controls.Add(this.label5);
            this.pnlAddEdit.Controls.Add(this.pbxAddEdit);
            this.pnlAddEdit.Location = new System.Drawing.Point(9, 423);
            this.pnlAddEdit.Name = "pnlAddEdit";
            this.pnlAddEdit.Size = new System.Drawing.Size(506, 194);
            this.pnlAddEdit.TabIndex = 8;
            this.pnlAddEdit.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ruta:";
            this.label1.Visible = false;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblPath.Location = new System.Drawing.Point(38, 168);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(0, 19);
            this.lblPath.TabIndex = 11;
            this.lblPath.Visible = false;
            // 
            // spnIdArticle
            // 
            this.spnIdArticle.BackColor = System.Drawing.Color.White;
            this.spnIdArticle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spnIdArticle.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.spnIdArticle.Location = new System.Drawing.Point(112, 26);
            this.spnIdArticle.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.spnIdArticle.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnIdArticle.Name = "spnIdArticle";
            this.spnIdArticle.ReadOnly = true;
            this.spnIdArticle.Size = new System.Drawing.Size(70, 29);
            this.spnIdArticle.TabIndex = 7;
            this.spnIdArticle.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtaDescriptionAddEdit
            // 
            this.txtaDescriptionAddEdit.BackColor = System.Drawing.Color.White;
            this.txtaDescriptionAddEdit.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtaDescriptionAddEdit.Location = new System.Drawing.Point(109, 75);
            this.txtaDescriptionAddEdit.Name = "txtaDescriptionAddEdit";
            this.txtaDescriptionAddEdit.Size = new System.Drawing.Size(388, 79);
            this.txtaDescriptionAddEdit.TabIndex = 9;
            this.txtaDescriptionAddEdit.Text = "";
            // 
            // txtNameArticle
            // 
            this.txtNameArticle.BackColor = System.Drawing.Color.White;
            this.txtNameArticle.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtNameArticle.Location = new System.Drawing.Point(186, 25);
            this.txtNameArticle.Name = "txtNameArticle";
            this.txtNameArticle.Size = new System.Drawing.Size(311, 29);
            this.txtNameArticle.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnCancel.Location = new System.Drawing.Point(417, 160);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 29);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnSave.Location = new System.Drawing.Point(331, 160);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 29);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAttach
            // 
            this.btnAttach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnAttach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttach.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnAttach.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnAttach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttach.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnAttach.Location = new System.Drawing.Point(6, 125);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(100, 29);
            this.btnAttach.TabIndex = 10;
            this.btnAttach.Text = "Adjuntar";
            this.btnAttach.UseVisualStyleBackColor = false;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(109, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "Descripción:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(182, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(106, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Clave:";
            // 
            // pbxAddEdit
            // 
            this.pbxAddEdit.BackColor = System.Drawing.Color.White;
            this.pbxAddEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxAddEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxAddEdit.ErrorImage = global::View.Properties.Resources.logo;
            this.pbxAddEdit.Location = new System.Drawing.Point(6, 25);
            this.pbxAddEdit.Name = "pbxAddEdit";
            this.pbxAddEdit.Size = new System.Drawing.Size(100, 100);
            this.pbxAddEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAddEdit.TabIndex = 0;
            this.pbxAddEdit.TabStop = false;
            // 
            // FrmArticleCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(524, 431);
            this.Controls.Add(this.pnlAddEdit);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvArticles);
            this.Controls.Add(this.rbtnNameArticle);
            this.Controls.Add(this.rbtnIdArticle);
            this.Controls.Add(this.txtSearch);
            this.Name = "FrmArticleCatalog";
            this.Text = "Catálogo de artículos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).EndInit();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDetails)).EndInit();
            this.pnlAddEdit.ResumeLayout(false);
            this.pnlAddEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnIdArticle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rbtnIdArticle;
        private System.Windows.Forms.RadioButton rbtnNameArticle;
        private System.Windows.Forms.DataGridView dgvArticles;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Label lblQuantityArticle;
        private System.Windows.Forms.RichTextBox txtaDescriptionDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNameArticle;
        private System.Windows.Forms.Label lblIdArticle;
        private System.Windows.Forms.PictureBox pbxDetails;
        private System.Windows.Forms.Panel pnlAddEdit;
        private System.Windows.Forms.RichTextBox txtaDescriptionAddEdit;
        private System.Windows.Forms.TextBox txtNameArticle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbxAddEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityArticle;
        private System.Windows.Forms.Button btnShowSubarticles;
        private System.Windows.Forms.NumericUpDown spnIdArticle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPath;
    }
}