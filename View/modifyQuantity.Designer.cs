namespace View
{
    partial class modifyQuantity
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
            this.lblArticle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnAddRemove = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCurrentAmount = new System.Windows.Forms.Label();
            this.spnInputOutput = new System.Windows.Forms.NumericUpDown();
            this.dgvModify = new System.Windows.Forms.DataGridView();
            this.btnReturn = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modify = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.spnInputOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModify)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArticle
            // 
            this.lblArticle.AutoSize = true;
            this.lblArticle.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblArticle.Location = new System.Drawing.Point(12, 15);
            this.lblArticle.Name = "lblArticle";
            this.lblArticle.Size = new System.Drawing.Size(74, 19);
            this.lblArticle.TabIndex = 0;
            this.lblArticle.Text = "Artículo: --";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label2.Location = new System.Drawing.Point(8, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entradas/Salidas";
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnClean.Location = new System.Drawing.Point(202, 6);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(110, 25);
            this.btnClean.TabIndex = 2;
            this.btnClean.Text = "Limpiar historial";
            this.btnClean.UseVisualStyleBackColor = true;
            // 
            // btnAddRemove
            // 
            this.btnAddRemove.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnAddRemove.Location = new System.Drawing.Point(118, 212);
            this.btnAddRemove.Name = "btnAddRemove";
            this.btnAddRemove.Size = new System.Drawing.Size(75, 25);
            this.btnAddRemove.TabIndex = 3;
            this.btnAddRemove.Text = "Agregar";
            this.btnAddRemove.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnClose.Location = new System.Drawing.Point(237, 242);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 25);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblCurrentAmount
            // 
            this.lblCurrentAmount.AutoSize = true;
            this.lblCurrentAmount.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblCurrentAmount.Location = new System.Drawing.Point(191, 190);
            this.lblCurrentAmount.Name = "lblCurrentAmount";
            this.lblCurrentAmount.Size = new System.Drawing.Size(121, 19);
            this.lblCurrentAmount.TabIndex = 6;
            this.lblCurrentAmount.Text = "Existencia actual: --";
            // 
            // spnInputOutput
            // 
            this.spnInputOutput.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.spnInputOutput.Location = new System.Drawing.Point(12, 212);
            this.spnInputOutput.Name = "spnInputOutput";
            this.spnInputOutput.Size = new System.Drawing.Size(100, 25);
            this.spnInputOutput.TabIndex = 7;
            // 
            // dgvModify
            // 
            this.dgvModify.AllowUserToAddRows = false;
            this.dgvModify.AllowUserToDeleteRows = false;
            this.dgvModify.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModify.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.modify});
            this.dgvModify.Location = new System.Drawing.Point(12, 37);
            this.dgvModify.Name = "dgvModify";
            this.dgvModify.ReadOnly = true;
            this.dgvModify.Size = new System.Drawing.Size(300, 150);
            this.dgvModify.TabIndex = 8;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnReturn.Location = new System.Drawing.Point(118, 242);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 25);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Devolución";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.date.HeaderText = "Fecha";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 62;
            // 
            // modify
            // 
            this.modify.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.modify.HeaderText = "Modificación";
            this.modify.Name = "modify";
            this.modify.ReadOnly = true;
            // 
            // modifyQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 279);
            this.Controls.Add(this.dgvModify);
            this.Controls.Add(this.spnInputOutput);
            this.Controls.Add(this.lblCurrentAmount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddRemove);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblArticle);
            this.Name = "modifyQuantity";
            this.Text = "modifyQuantity";
            ((System.ComponentModel.ISupportInitialize)(this.spnInputOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModify)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArticle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnAddRemove;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCurrentAmount;
        private System.Windows.Forms.NumericUpDown spnInputOutput;
        private System.Windows.Forms.DataGridView dgvModify;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn modify;
    }
}