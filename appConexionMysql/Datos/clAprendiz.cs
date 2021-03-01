using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace appConexionMysql.Datos
{
    class clAprendiz
    {

       

        public DataTable mtdListar()
        {
            string consulta = "select * from aprendiz";
            clConexion objConexion = new clConexion();
            DataTable tblAprendiz = new DataTable();
            tblAprendiz = objConexion.mtdDesconectado(consulta);
           
            
            
            
            return tblAprendiz;

        }




    }
}
