using appConexionMysql.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appConexionMysql
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnProgramas_Click(object sender, EventArgs e)
        {
            frmPrograma objFrmPrograma = new frmPrograma();
            objFrmPrograma.Show();
        }

        private void btnAprendices_Click(object sender, EventArgs e)
        {
            frmAprendiz objFrmAprendiz = new frmAprendiz();
            objFrmAprendiz.Show();
        }
    }
}
