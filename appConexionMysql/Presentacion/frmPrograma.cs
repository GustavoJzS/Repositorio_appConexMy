using appConexionMysql.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appConexionMysql.Presentacion
{
    public partial class frmPrograma : Form
    {
        public frmPrograma()
        {
            InitializeComponent();
        }

        private void frmPrograma_Load(object sender, EventArgs e)
        {
            mtdCargarGrid();

        }

        public void mtdCargarGrid()
        {
            clPrograma objPrograma = new clPrograma();
            List<clPrograma> listProgramas = new List<clPrograma>();
            listProgramas = objPrograma.mtdListar();
            dgvProgramas.DataSource = listProgramas;
        }




        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           
            clPrograma objPrograma = new clPrograma();

            //FORMA 1 Usando las propiedades de la clase
            //validar que el usuario digito datos
           /* objPrograma.ficha = txtFicha.Text;
            objPrograma.nombrePrograma = txtPrograma.Text;
            objPrograma.jornada = txtJornada.Text;
            int canReg = objPrograma.mtdRegistrarForma1();

            if (canReg>0)
            {
                mtdCargarGrid();
                MessageBox.Show("Programa Registrado!!!!","ADSI",MessageBoxButtons.OK);
                
            }
            else
            {
                MessageBox.Show("Error al Registrar!!!!", "ADSI", MessageBoxButtons.OK);
            }*/


            //FORMA 2  Enviando los parametros desde la vista a la clase

            string ficha = txtFicha.Text;
            string programa = txtPrograma.Text;
            string jornada = txtJornada.Text;
            int canReg = objPrograma.mtdRegistrarForma2(ficha, programa, jornada);
            if (canReg > 0)
            {
                mtdCargarGrid();
                MessageBox.Show("Programa Registrado!!!!", "ADSI", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Error al Registrar!!!!", "ADSI", MessageBoxButtons.OK);
            }


        }
    }
}
