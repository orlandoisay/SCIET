namespace View
{
    partial class FrmModifyQuantity
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
            this.lblSubarticle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnAddRemove = new System.Windows.Forms.Button();
            this.lblCurrentAmount = new System.Windows.Forms.Label();
            this.spnInputOutput = new System.Windows.Forms.NumericUpDown();
            this.dgvModify = new System.Windows.Forms.DataGridView();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modify = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.spnInputOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModify)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubarticle
            // 
            this.lblSubarticle.AutoSize = true;
            this.lblSubarticle.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.lblSubarticle.ForeColor = System.Drawing.Color.White;
            this.lblSubarticle.Location = new System.Drawing.Point(12, 15);
            this.lblSubarticle.Name = "lblSubarticle";
            this.lblSubarticle.Size = new System.Drawing.Size(66, 21);
            this.lblSubarticle.TabIndex = 0;
            this.lblSubarticle.Text = "Clave: --";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entradas/Salidas";
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClean.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnClean.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnClean.Location = new System.Drawing.Point(216, 7);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(126, 29);
            this.btnClean.TabIndex = 5;
            this.btnClean.Text = "Limpiar historial";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnAddRemove
            // 
            this.btnAddRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnAddRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnAddRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRemove.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnAddRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnAddRemove.Location = new System.Drawing.Point(12, 254);
            this.btnAddRemove.Name = "btnAddRemove";
            this.btnAddRemove.Size = new System.Drawing.Size(95, 29);
            this.btnAddRemove.TabIndex = 2;
            this.btnAddRemove.Text = "Agregar";
            this.btnAddRemove.UseVisualStyleBackColor = false;
            this.btnAddRemove.Visible = false;
            this.btnAddRemove.Click += new System.EventHandler(this.btnAddRemove_Click);
            // 
            // lblCurrentAmount
            // 
            this.lblCurrentAmount.AutoSize = true;
            this.lblCurrentAmount.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.lblCurrentAmount.ForeColor = System.Drawing.Color.White;
            this.lblCurrentAmount.Location = new System.Drawing.Point(182, 195);
            this.lblCurrentAmount.Name = "lblCurrentAmount";
            this.lblCurrentAmount.Size = new System.Drawing.Size(138, 21);
            this.lblCurrentAmount.TabIndex = 6;
            this.lblCurrentAmount.Text = "Existencia actual: --";
            // 
            // spnInputOutput
            // 
            this.spnInputOutput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spnInputOutput.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.spnInputOutput.Location = new System.Drawing.Point(12, 219);
            this.spnInputOutput.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.spnInputOutput.Name = "spnInputOutput";
            this.spnInputOutput.ReadOnly = true;
            this.spnInputOutput.Size = new System.Drawing.Size(95, 29);
            this.spnInputOutput.TabIndex = 1;
            this.spnInputOutput.ValueChanged += new System.EventHandler(this.spnInputOutput_ValueChanged);
            // 
            // dgvModify
            // 
            this.dgvModify.AllowUserToAddRows = false;
            this.dgvModify.AllowUserToDeleteRows = false;
            this.dgvModify.BackgroundColor = System.Drawing.Color.White;
            this.dgvModify.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModify.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.modify,
            this.Cantidad});
            this.dgvModify.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvModify.Location = new System.Drawing.Point(12, 42);
            this.dgvModify.MultiSelect = false;
            this.dgvModify.Name = "dgvModify";
            this.dgvModify.ReadOnly = true;
            this.dgvModify.Size = new System.Drawing.Size(330, 150);
            this.dgvModify.TabIndex = 6;
            this.dgvModify.TabStop = false;
            this.dgvModify.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModify_CellClick);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnReturn.Location = new System.Drawing.Point(113, 254);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(95, 29);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Devolución";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Visible = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnBack.Location = new System.Drawing.Point(247, 253);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 29);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Cerrar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 74;
            // 
            // FrmModifyQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(354, 294);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvModify);
            this.Controls.Add(this.spnInputOutput);
            this.Controls.Add(this.lblCurrentAmount);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddRemove);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSubarticle);
            this.Name = "FrmModifyQuantity";
            this.Text = "Modificar existencia";
            ((System.ComponentModel.ISupportInitialize)(this.spnInputOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModify)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubarticle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnAddRemove;
        private System.Windows.Forms.Label lblCurrentAmount;
        private System.Windows.Forms.NumericUpDown spnInputOutput;
        private System.Windows.Forms.DataGridView dgvModify;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn modify;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}