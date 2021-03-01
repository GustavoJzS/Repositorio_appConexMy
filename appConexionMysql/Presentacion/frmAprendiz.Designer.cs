namespace appConexionMysql.Presentacion
{
    partial class frmAprendiz
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
            this.dgvAprendiz = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProgramas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAprendiz)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAprendiz
            // 
            this.dgvAprendiz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAprendiz.Location = new System.Drawing.Point(308, 236);
            this.dgvAprendiz.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvAprendiz.Name = "dgvAprendiz";
            this.dgvAprendiz.Size = new System.Drawing.Size(712, 361);
            this.dgvAprendiz.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(534, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "LISTADO DE APRENDICES";
            // 
            // cmbProgramas
            // 
            this.cmbProgramas.FormattingEnabled = true;
            this.cmbProgramas.Location = new System.Drawing.Point(550, 133);
            this.cmbProgramas.Name = "cmbProgramas";
            this.cmbProgramas.Size = new System.Drawing.Size(252, 32);
            this.cmbProgramas.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccione Programa";
            // 
            // frmAprendiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 672);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbProgramas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAprendiz);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmAprendiz";
            this.Text = "frmAprendiz";
            this.Load += new System.EventHandler(this.frmAprendiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAprendiz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAprendiz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProgramas;
        private System.Windows.Forms.Label label2;
    }
}