namespace View
{
    partial class FrmArticlesCatalog
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dgvArticles = new System.Windows.Forms.DataGridView();
            this.idArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblIdArticle = new System.Windows.Forms.Label();
            this.lblNameArticle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.pnlAddEdit = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAttach = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtIdArticle = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).BeginInit();
            this.pnlDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlAddEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(323, 25);
            this.textBox1.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.radioButton1.Location = new System.Drawing.Point(77, 43);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 23);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nombre";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.radioButton2.Location = new System.Drawing.Point(12, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 23);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Clave";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // dgvArticles
            // 
            this.dgvArticles.AllowUserToAddRows = false;
            this.dgvArticles.AllowUserToDeleteRows = false;
            this.dgvArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idArticle,
            this.nameArticle,
            this.quantityArticle});
            this.dgvArticles.Location = new System.Drawing.Point(12, 72);
            this.dgvArticles.Name = "dgvArticles";
            this.dgvArticles.ReadOnly = true;
            this.dgvArticles.Size = new System.Drawing.Size(560, 150);
            this.dgvArticles.TabIndex = 3;
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
            // nameArticle
            // 
            this.nameArticle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameArticle.HeaderText = "Nombre";
            this.nameArticle.Name = "nameArticle";
            this.nameArticle.ReadOnly = true;
            // 
            // quantityArticle
            // 
            this.quantityArticle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quantityArticle.HeaderText = "Existencia";
            this.quantityArticle.Name = "quantityArticle";
            this.quantityArticle.ReadOnly = true;
            this.quantityArticle.Width = 80;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnAdd.Location = new System.Drawing.Point(335, 43);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnDelete.Location = new System.Drawing.Point(497, 43);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnEdit.Location = new System.Drawing.Point(416, 43);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.lblQuantity);
            this.pnlDetails.Controls.Add(this.richTextBox1);
            this.pnlDetails.Controls.Add(this.label3);
            this.pnlDetails.Controls.Add(this.lblNameArticle);
            this.pnlDetails.Controls.Add(this.lblIdArticle);
            this.pnlDetails.Controls.Add(this.pictureBox1);
            this.pnlDetails.Location = new System.Drawing.Point(12, 228);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(560, 150);
            this.pnlDetails.TabIndex = 7;
            this.pnlDetails.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(7, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblIdArticle
            // 
            this.lblIdArticle.AutoSize = true;
            this.lblIdArticle.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblIdArticle.Location = new System.Drawing.Point(3, 3);
            this.lblIdArticle.Name = "lblIdArticle";
            this.lblIdArticle.Size = new System.Drawing.Size(60, 19);
            this.lblIdArticle.TabIndex = 1;
            this.lblIdArticle.Text = "Clave: --";
            // 
            // lblNameArticle
            // 
            this.lblNameArticle.AutoSize = true;
            this.lblNameArticle.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblNameArticle.Location = new System.Drawing.Point(3, 128);
            this.lblNameArticle.Name = "lblNameArticle";
            this.lblNameArticle.Size = new System.Drawing.Size(78, 19);
            this.lblNameArticle.TabIndex = 2;
            this.lblNameArticle.Text = "Nombre: --";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label3.Location = new System.Drawing.Point(109, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripción:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.richTextBox1.Location = new System.Drawing.Point(113, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(444, 100);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblQuantity.Location = new System.Drawing.Point(448, 128);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(83, 19);
            this.lblQuantity.TabIndex = 8;
            this.lblQuantity.Text = "Existencia: --";
            // 
            // pnlAddEdit
            // 
            this.pnlAddEdit.Controls.Add(this.richTextBox2);
            this.pnlAddEdit.Controls.Add(this.textBox3);
            this.pnlAddEdit.Controls.Add(this.txtIdArticle);
            this.pnlAddEdit.Controls.Add(this.btnCancel);
            this.pnlAddEdit.Controls.Add(this.btnSave);
            this.pnlAddEdit.Controls.Add(this.btnAttach);
            this.pnlAddEdit.Controls.Add(this.label4);
            this.pnlAddEdit.Controls.Add(this.label2);
            this.pnlAddEdit.Controls.Add(this.label1);
            this.pnlAddEdit.Controls.Add(this.pictureBox2);
            this.pnlAddEdit.Location = new System.Drawing.Point(12, 384);
            this.pnlAddEdit.Name = "pnlAddEdit";
            this.pnlAddEdit.Size = new System.Drawing.Size(560, 200);
            this.pnlAddEdit.TabIndex = 8;
            this.pnlAddEdit.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox2.Location = new System.Drawing.Point(7, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label1.Location = new System.Drawing.Point(109, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clave:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label2.Location = new System.Drawing.Point(215, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label4.Location = new System.Drawing.Point(113, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripción:";
            // 
            // btnAttach
            // 
            this.btnAttach.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnAttach.Location = new System.Drawing.Point(7, 131);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(100, 23);
            this.btnAttach.TabIndex = 4;
            this.btnAttach.Text = "Adjuntar";
            this.btnAttach.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnSave.Location = new System.Drawing.Point(404, 174);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnCancel.Location = new System.Drawing.Point(482, 174);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtIdArticle
            // 
            this.txtIdArticle.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.txtIdArticle.Location = new System.Drawing.Point(113, 25);
            this.txtIdArticle.Name = "txtIdArticle";
            this.txtIdArticle.Size = new System.Drawing.Size(100, 25);
            this.txtIdArticle.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.textBox3.Location = new System.Drawing.Point(219, 25);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(338, 25);
            this.textBox3.TabIndex = 8;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.richTextBox2.Location = new System.Drawing.Point(113, 75);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(444, 95);
            this.richTextBox2.TabIndex = 9;
            this.richTextBox2.Text = "";
            // 
            // FrmArticlesCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.Controls.Add(this.pnlAddEdit);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvArticles);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmArticlesCatalog";
            this.Text = "FrmArticlesCatalog";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).EndInit();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlAddEdit.ResumeLayout(false);
            this.pnlAddEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DataGridView dgvArticles;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameArticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityArticle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNameArticle;
        private System.Windows.Forms.Label lblIdArticle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlAddEdit;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtIdArticle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}