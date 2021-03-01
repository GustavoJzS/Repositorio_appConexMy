using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appConexionMysql.Datos;

namespace appConexionMysql.Presentacion
{
    public partial class frmAprendiz : Form
    {
        public frmAprendiz()
        {
            InitializeComponent();
        }

        private void frmAprendiz_Load(object sender, EventArgs e)
        {
            clAprendiz objAprendiz = new clAprendiz();
            DataTable tblAprendiz = new DataTable();

            tblAprendiz = objAprendiz.mtdListar();
            dgvAprendiz.DataSource = tblAprendiz;

            //Cargar Combo con Programas
            clPrograma objProgama = new clPrograma();
            List<clPrograma> listaPrograms = new List<clPrograma>();
            listaPrograms= objProgama.mtdListar();
            cmbProgramas.DataSource = listaPrograms;
            cmbProgramas.DisplayMember = "nombrePrograma";
            cmbProgramas.ValueMember = "idprograma";


        }
    }
}
