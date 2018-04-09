namespace Telefonia
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTelefonia = new System.Windows.Forms.DataGridView();
            this.txtbtel = new System.Windows.Forms.TextBox();
            this.txtbLugar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTelefonia
            // 
            this.dgvTelefonia.AllowUserToAddRows = false;
            this.dgvTelefonia.AllowUserToDeleteRows = false;
            this.dgvTelefonia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefonia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataTelefono,
            this.dataLugar});
            this.dgvTelefonia.Location = new System.Drawing.Point(156, 176);
            this.dgvTelefonia.Name = "dgvTelefonia";
            this.dgvTelefonia.ReadOnly = true;
            this.dgvTelefonia.RowTemplate.Height = 24;
            this.dgvTelefonia.Size = new System.Drawing.Size(240, 150);
            this.dgvTelefonia.TabIndex = 0;
            // 
            // txtbtel
            // 
            this.txtbtel.Location = new System.Drawing.Point(251, 34);
            this.txtbtel.Name = "txtbtel";
            this.txtbtel.Size = new System.Drawing.Size(100, 22);
            this.txtbtel.TabIndex = 1;
            // 
            // txtbLugar
            // 
            this.txtbLugar.Location = new System.Drawing.Point(251, 81);
            this.txtbLugar.Name = "txtbLugar";
            this.txtbLugar.Size = new System.Drawing.Size(100, 22);
            this.txtbLugar.TabIndex = 1;
            this.txtbLugar.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtbLugar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbLugar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "label1";
            // 
            // dataTelefono
            // 
            this.dataTelefono.Frozen = true;
            this.dataTelefono.HeaderText = "Teléfono";
            this.dataTelefono.Name = "dataTelefono";
            this.dataTelefono.ReadOnly = true;
            // 
            // dataLugar
            // 
            this.dataLugar.Frozen = true;
            this.dataLugar.HeaderText = "Lugar";
            this.dataLugar.Name = "dataLugar";
            this.dataLugar.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbLugar);
            this.Controls.Add(this.txtbtel);
            this.Controls.Add(this.dgvTelefonia);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTelefonia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLugar;
        private System.Windows.Forms.TextBox txtbtel;
        private System.Windows.Forms.TextBox txtbLugar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

