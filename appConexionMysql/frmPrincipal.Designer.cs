namespace appConexionMysql
{
    partial class frmPrincipal
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
            this.btnProgramas = new System.Windows.Forms.Button();
            this.btnAprendices = new System.Windows.Forms.Button();
            this.btnInformes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProgramas
            // 
            this.btnProgramas.Location = new System.Drawing.Point(234, 67);
            this.btnProgramas.Name = "btnProgramas";
            this.btnProgramas.Size = new System.Drawing.Size(274, 135);
            this.btnProgramas.TabIndex = 0;
            this.btnProgramas.Text = "Ver Programas de Formación";
            this.btnProgramas.UseVisualStyleBackColor = true;
            this.btnProgramas.Click += new System.EventHandler(this.btnProgramas_Click);
            // 
            // btnAprendices
            // 
            this.btnAprendices.Location = new System.Drawing.Point(223, 246);
            this.btnAprendices.Name = "btnAprendices";
            this.btnAprendices.Size = new System.Drawing.Size(294, 121);
            this.btnAprendices.TabIndex = 1;
            this.btnAprendices.Text = "Ver Aprendices SENA";
            this.btnAprendices.UseVisualStyleBackColor = true;
            this.btnAprendices.Click += new System.EventHandler(this.btnAprendices_Click);
            // 
            // btnInformes
            // 
            this.btnInformes.Location = new System.Drawing.Point(223, 411);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(294, 121);
            this.btnInformes.TabIndex = 2;
            this.btnInformes.Text = "Informes";
            this.btnInformes.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 615);
            this.Controls.Add(this.btnInformes);
            this.Controls.Add(this.btnAprendices);
            this.Controls.Add(this.btnProgramas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProgramas;
        private System.Windows.Forms.Button btnAprendices;
        private System.Windows.Forms.Button btnInformes;
    }
}

