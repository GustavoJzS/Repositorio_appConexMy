using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appConexionMysql.Datos
{
    class clPrograma
    {
        //atributos-- Propiedades
        public int idprograma { get; set; }
        public string ficha { get; set; }
        public string nombrePrograma { get; set; }
        public string jornada { get; set; }

        //metodos


        public List<clPrograma> mtdListar()
        {
            string consulta = "select * from programa";
            clConexion objConexion = new clConexion();
            DataTable tblProgramas = new DataTable();
            tblProgramas = objConexion.mtdDesconectado(consulta);

            List<clPrograma> listaProgramas = new List<clPrograma>();


            for (int i = 0; i < tblProgramas.Rows.Count; i++)
            {
                clPrograma objPasarPrograma = new clPrograma();
                objPasarPrograma.idprograma = int.Parse(tblProgramas.Rows[i]["idprograma"].ToString());
                objPasarPrograma.ficha = tblProgramas.Rows[i]["ficha"].ToString();
                objPasarPrograma.nombrePrograma = tblProgramas.Rows[i]["nombrePrograma"].ToString();
                objPasarPrograma.jornada = tblProgramas.Rows[i]["jornada"].ToString();
                listaProgramas.Add(objPasarPrograma);

            }

            return listaProgramas;
        }



        public int mtdRegistrarForma1()
        {
            string sqlInsert = "insert into programa(ficha,nombrePrograma,jornada)" +
                             "values('" + ficha + "','" + nombrePrograma + "','" + jornada + "')";
            clConexion objConexion = new clConexion();
            int registrosAfectados = objConexion.mtdConectado(sqlInsert);
            return registrosAfectados;

        }

        public int mtdRegistrarForma2(string fic, string pro, string jor)
        {

            string sqlInsert = "insert into programa(ficha,nombrePrograma,jornada)" +
                             "values('" + fic + "','" + pro + "','" + jor + "')";
            clConexion objConexion = new clConexion();
            int registrosAfectados = objConexion.mtdConectado(sqlInsert);
            return registrosAfectados;
        }


        public void mtdEliminar()
        {

        }



    }
}
