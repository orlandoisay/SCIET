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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.rbtnIdArticle = new System.Windows.Forms.RadioButton();
            this.rbtnNameArticle = new System.Windows.Forms.RadioButton();
            this.dgvArticles = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.idArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.pnlAddEdit = new System.Windows.Forms.Panel();
            this.pbxDetails = new System.Windows.Forms.PictureBox();
            this.pbxAddEdit = new System.Windows.Forms.PictureBox();
            this.lblIdArticle = new System.Windows.Forms.Label();
            this.lblNameArticle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtaDescriptionDetails = new System.Windows.Forms.RichTextBox();
            this.lblQuantityArticle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAttach = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtIdArticle = new System.Windows.Forms.TextBox();
            this.txtNameArticle = new System.Windows.Forms.TextBox();
            this.txtaDescriptionAddEdit = new System.Windows.Forms.RichTextBox();
            this.btnEditQuantity = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).BeginInit();
            this.pnlDetails.SuspendLayout();
            this.pnlAddEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.txtBuscar.Location = new System.Drawing.Point(9, 7);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(250, 25);
            this.txtBuscar.TabIndex = 0;
            // 
            // rbtnIdArticle
            // 
            this.rbtnIdArticle.AutoSize = true;
            this.rbtnIdArticle.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.rbtnIdArticle.Location = new System.Drawing.Point(9, 38);
            this.rbtnIdArticle.Name = "rbtnIdArticle";
            this.rbtnIdArticle.Size = new System.Drawing.Size(59, 23);
            this.rbtnIdArticle.TabIndex = 1;
            this.rbtnIdArticle.TabStop = true;
            this.rbtnIdArticle.Text = "Clave";
            this.rbtnIdArticle.UseVisualStyleBackColor = true;
            // 
            // rbtnNameArticle
            // 
            this.rbtnNameArticle.AutoSize = true;
            this.rbtnNameArticle.Checked = true;
            this.rbtnNameArticle.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.rbtnNameArticle.Location = new System.Drawing.Point(74, 38);
            this.rbtnNameArticle.Name = "rbtnNameArticle";
            this.rbtnNameArticle.Size = new System.Drawing.Size(77, 23);
            this.rbtnNameArticle.TabIndex = 2;
            this.rbtnNameArticle.TabStop = true;
            this.rbtnNameArticle.Text = "Nombre";
            this.rbtnNameArticle.UseVisualStyleBackColor = true;
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
            this.dgvArticles.Location = new System.Drawing.Point(9, 71);
            this.dgvArticles.Name = "dgvArticles";
            this.dgvArticles.ReadOnly = true;
            this.dgvArticles.Size = new System.Drawing.Size(500, 150);
            this.dgvArticles.TabIndex = 3;
            this.dgvArticles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticles_CellClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnEdit.Location = new System.Drawing.Point(353, 42);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnDelete.Location = new System.Drawing.Point(434, 42);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnAdd.Location = new System.Drawing.Point(272, 42);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.btnEditQuantity);
            this.pnlDetails.Controls.Add(this.lblQuantityArticle);
            this.pnlDetails.Controls.Add(this.txtaDescriptionDetails);
            this.pnlDetails.Controls.Add(this.label3);
            this.pnlDetails.Controls.Add(this.lblNameArticle);
            this.pnlDetails.Controls.Add(this.lblIdArticle);
            this.pnlDetails.Controls.Add(this.pbxDetails);
            this.pnlDetails.Location = new System.Drawing.Point(9, 227);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(500, 160);
            this.pnlDetails.TabIndex = 7;
            this.pnlDetails.Visible = false;
            // 
            // pnlAddEdit
            // 
            this.pnlAddEdit.Controls.Add(this.txtaDescriptionAddEdit);
            this.pnlAddEdit.Controls.Add(this.txtNameArticle);
            this.pnlAddEdit.Controls.Add(this.txtIdArticle);
            this.pnlAddEdit.Controls.Add(this.btnCancel);
            this.pnlAddEdit.Controls.Add(this.btnSave);
            this.pnlAddEdit.Controls.Add(this.btnAttach);
            this.pnlAddEdit.Controls.Add(this.label7);
            this.pnlAddEdit.Controls.Add(this.label6);
            this.pnlAddEdit.Controls.Add(this.label5);
            this.pnlAddEdit.Controls.Add(this.pbxAddEdit);
            this.pnlAddEdit.Location = new System.Drawing.Point(9, 383);
            this.pnlAddEdit.Name = "pnlAddEdit";
            this.pnlAddEdit.Size = new System.Drawing.Size(500, 190);
            this.pnlAddEdit.TabIndex = 8;
            this.pnlAddEdit.Visible = false;
            // 
            // pbxDetails
            // 
            this.pbxDetails.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbxDetails.Location = new System.Drawing.Point(3, 25);
            this.pbxDetails.Name = "pbxDetails";
            this.pbxDetails.Size = new System.Drawing.Size(100, 100);
            this.pbxDetails.TabIndex = 9;
            this.pbxDetails.TabStop = false;
            // 
            // pbxAddEdit
            // 
            this.pbxAddEdit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbxAddEdit.Location = new System.Drawing.Point(6, 25);
            this.pbxAddEdit.Name = "pbxAddEdit";
            this.pbxAddEdit.Size = new System.Drawing.Size(100, 100);
            this.pbxAddEdit.TabIndex = 0;
            this.pbxAddEdit.TabStop = false;
            // 
            // lblIdArticle
            // 
            this.lblIdArticle.AutoSize = true;
            this.lblIdArticle.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblIdArticle.Location = new System.Drawing.Point(3, 3);
            this.lblIdArticle.Name = "lblIdArticle";
            this.lblIdArticle.Size = new System.Drawing.Size(60, 19);
            this.lblIdArticle.TabIndex = 10;
            this.lblIdArticle.Text = "Clave: --";
            // 
            // lblNameArticle
            // 
            this.lblNameArticle.AutoSize = true;
            this.lblNameArticle.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblNameArticle.Location = new System.Drawing.Point(3, 128);
            this.lblNameArticle.Name = "lblNameArticle";
            this.lblNameArticle.Size = new System.Drawing.Size(78, 19);
            this.lblNameArticle.TabIndex = 11;
            this.lblNameArticle.Text = "Nombre: --";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label3.Location = new System.Drawing.Point(106, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Descripción:";
            // 
            // txtaDescriptionDetails
            // 
            this.txtaDescriptionDetails.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.txtaDescriptionDetails.Location = new System.Drawing.Point(109, 23);
            this.txtaDescriptionDetails.Name = "txtaDescriptionDetails";
            this.txtaDescriptionDetails.Size = new System.Drawing.Size(388, 100);
            this.txtaDescriptionDetails.TabIndex = 13;
            this.txtaDescriptionDetails.Text = "";
            // 
            // lblQuantityArticle
            // 
            this.lblQuantityArticle.AutoSize = true;
            this.lblQuantityArticle.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblQuantityArticle.Location = new System.Drawing.Point(367, 3);
            this.lblQuantityArticle.Name = "lblQuantityArticle";
            this.lblQuantityArticle.Size = new System.Drawing.Size(83, 19);
            this.lblQuantityArticle.TabIndex = 9;
            this.lblQuantityArticle.Text = "Existencia: --";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label5.Location = new System.Drawing.Point(106, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Clave:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label6.Location = new System.Drawing.Point(182, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nombre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label7.Location = new System.Drawing.Point(109, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Descripción:";
            // 
            // btnAttach
            // 
            this.btnAttach.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnAttach.Location = new System.Drawing.Point(6, 131);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(100, 23);
            this.btnAttach.TabIndex = 4;
            this.btnAttach.Text = "Adjuntar";
            this.btnAttach.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnSave.Location = new System.Drawing.Point(344, 164);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnCancel.Location = new System.Drawing.Point(422, 164);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtIdArticle
            // 
            this.txtIdArticle.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.txtIdArticle.Location = new System.Drawing.Point(110, 25);
            this.txtIdArticle.Name = "txtIdArticle";
            this.txtIdArticle.Size = new System.Drawing.Size(70, 25);
            this.txtIdArticle.TabIndex = 7;
            // 
            // txtNameArticle
            // 
            this.txtNameArticle.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.txtNameArticle.Location = new System.Drawing.Point(186, 25);
            this.txtNameArticle.Name = "txtNameArticle";
            this.txtNameArticle.Size = new System.Drawing.Size(311, 25);
            this.txtNameArticle.TabIndex = 8;
            // 
            // txtaDescriptionAddEdit
            // 
            this.txtaDescriptionAddEdit.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.txtaDescriptionAddEdit.Location = new System.Drawing.Point(109, 75);
            this.txtaDescriptionAddEdit.Name = "txtaDescriptionAddEdit";
            this.txtaDescriptionAddEdit.Size = new System.Drawing.Size(388, 79);
            this.txtaDescriptionAddEdit.TabIndex = 9;
            this.txtaDescriptionAddEdit.Text = "";
            // 
            // btnEditQuantity
            // 
            this.btnEditQuantity.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnEditQuantity.Location = new System.Drawing.Point(364, 127);
            this.btnEditQuantity.Name = "btnEditQuantity";
            this.btnEditQuantity.Size = new System.Drawing.Size(133, 23);
            this.btnEditQuantity.TabIndex = 14;
            this.btnEditQuantity.Text = "Modificar existencia";
            this.btnEditQuantity.UseVisualStyleBackColor = true;
            // 
            // FrmArticleCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 431);
            this.Controls.Add(this.pnlAddEdit);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvArticles);
            this.Controls.Add(this.rbtnNameArticle);
            this.Controls.Add(this.rbtnIdArticle);
            this.Controls.Add(this.txtBuscar);
            this.Name = "FrmArticleCatalog";
            this.Text = "FrmArticleCatalog";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).EndInit();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.pnlAddEdit.ResumeLayout(false);
            this.pnlAddEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.RadioButton rbtnIdArticle;
        private System.Windows.Forms.RadioButton rbtnNameArticle;
        private System.Windows.Forms.DataGridView dgvArticles;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameArticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityArticle;
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
        private System.Windows.Forms.TextBox txtIdArticle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbxAddEdit;
        private System.Windows.Forms.Button btnEditQuantity;
    }
}