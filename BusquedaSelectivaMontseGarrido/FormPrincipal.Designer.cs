namespace BusquedaSelectivaMontseGarrido
{
    partial class FormPrincipal
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btIzq = new System.Windows.Forms.Button();
            this.btDer = new System.Windows.Forms.Button();
            this.lbBusqueda = new System.Windows.Forms.Label();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(341, 45);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(398, 37);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Búsqueda Selectiva DGV";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(38, 167);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(895, 337);
            this.dgv.TabIndex = 1;
            // 
            // btIzq
            // 
            this.btIzq.BackColor = System.Drawing.SystemColors.Window;
            this.btIzq.Location = new System.Drawing.Point(38, 105);
            this.btIzq.Name = "btIzq";
            this.btIzq.Size = new System.Drawing.Size(68, 28);
            this.btIzq.TabIndex = 2;
            this.btIzq.Text = "<";
            this.btIzq.UseVisualStyleBackColor = false;
            this.btIzq.Click += new System.EventHandler(this.btIzq_Click);
            // 
            // btDer
            // 
            this.btDer.BackColor = System.Drawing.SystemColors.Window;
            this.btDer.Location = new System.Drawing.Point(853, 105);
            this.btDer.Name = "btDer";
            this.btDer.Size = new System.Drawing.Size(80, 28);
            this.btDer.TabIndex = 3;
            this.btDer.Text = ">";
            this.btDer.UseVisualStyleBackColor = false;
            this.btDer.Click += new System.EventHandler(this.btDer_Click);
            // 
            // lbBusqueda
            // 
            this.lbBusqueda.AutoSize = true;
            this.lbBusqueda.Location = new System.Drawing.Point(202, 109);
            this.lbBusqueda.Name = "lbBusqueda";
            this.lbBusqueda.Size = new System.Drawing.Size(191, 20);
            this.lbBusqueda.TabIndex = 5;
            this.lbBusqueda.Text = "Realiza aquí la búsqueda:";
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(400, 107);
            this.tbBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(362, 26);
            this.tbBuscar.TabIndex = 6;
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 578);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.lbBusqueda);
            this.Controls.Add(this.btDer);
            this.Controls.Add(this.btIzq);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lbTitulo);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btIzq;
        private System.Windows.Forms.Button btDer;
        private System.Windows.Forms.Label lbBusqueda;
        private System.Windows.Forms.TextBox tbBuscar;
    }
}

