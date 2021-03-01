namespace appConexionMysql.Presentacion
{
    partial class frmPrograma
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProgramas = new System.Windows.Forms.DataGridView();
            this.txtFicha = new System.Windows.Forms.TextBox();
            this.txtPrograma = new System.Windows.Forms.TextBox();
            this.txtJornada = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgramas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROGRAMAS DE FORMACIÓN";
            // 
            // dgvProgramas
            // 
            this.dgvProgramas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProgramas.Location = new System.Drawing.Point(444, 113);
            this.dgvProgramas.Name = "dgvProgramas";
            this.dgvProgramas.Size = new System.Drawing.Size(541, 402);
            this.dgvProgramas.TabIndex = 1;
            // 
            // txtFicha
            // 
            this.txtFicha.Location = new System.Drawing.Point(196, 147);
            this.txtFicha.Name = "txtFicha";
            this.txtFicha.Size = new System.Drawing.Size(183, 29);
            this.txtFicha.TabIndex = 2;
            // 
            // txtPrograma
            // 
            this.txtPrograma.Location = new System.Drawing.Point(196, 182);
            this.txtPrograma.Name = "txtPrograma";
            this.txtPrograma.Size = new System.Drawing.Size(183, 29);
            this.txtPrograma.TabIndex = 3;
            // 
            // txtJornada
            // 
            this.txtJornada.Location = new System.Drawing.Point(196, 217);
            this.txtJornada.Name = "txtJornada";
            this.txtJornada.Size = new System.Drawing.Size(183, 29);
            this.txtJornada.TabIndex = 4;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(28, 297);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(163, 56);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar Programa";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ficha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre Programa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Jornada";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 56);
            this.button1.TabIndex = 9;
            this.button1.Text = "Actualizar Programa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 616);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtJornada);
            this.Controls.Add(this.txtPrograma);
            this.Controls.Add(this.txtFicha);
            this.Controls.Add(this.dgvProgramas);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmPrograma";
            this.Text = "frmPrograma";
            this.Load += new System.EventHandler(this.frmPrograma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgramas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProgramas;
        private System.Windows.Forms.TextBox txtFicha;
        private System.Windows.Forms.TextBox txtPrograma;
        private System.Windows.Forms.TextBox txtJornada;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}