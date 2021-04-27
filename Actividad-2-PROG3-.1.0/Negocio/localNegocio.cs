using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class localNegocio
    {

        public List<Articulo> listar()
        {
            
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            
            try
            {
                datos.setearConsulta("select codigo, Nombre, Descripcion,  precio from ARTICULOS");
                datos.ejecutarlectura();

                while (datos.Lector.Read())
                {
                    Articulo ar = new Articulo();
                    ar.Cod_articulo = (string)datos.Lector["Codigo"];
                    ar.Nombre = (string)datos.Lector["nombre"];
                    ar.Descripcion = (string)datos.Lector["descripcion"];
                    ar.Precio = (int)datos.Lector["precio"];

                    lista.Add(ar);

                    
                   

                }
                    return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }




            

        }



    }
}

