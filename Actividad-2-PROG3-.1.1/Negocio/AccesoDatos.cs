using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Negocio
{
    class AccesoDatos
    {

            private SqlConnection conexion;
            private SqlCommand comando;
            private SqlDataReader lector;

            public AccesoDatos()//accede a la DB
            {

            ///conexion = new SqlConnection("data source=.\\ SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi");
            conexion = new SqlConnection("data source=DESKTOP-CEKNLMQ\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi");
            comando = new SqlCommand();
            }

            public void setearConsulta(string consulta)//setea la consulta
            {
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = consulta;
             
            }

            public void ejecutarlectura()
            {

                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
            }

            public void cerrarConexion()
            {
                if (lector != null)
                    lector.Close();
                conexion.Close();
            }

            public SqlDataReader Lector
            {
                get { return lector; }
            }

        }

}
