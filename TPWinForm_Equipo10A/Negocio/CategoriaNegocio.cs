using Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categorias> ListarCategoria()
        {
            List<Categorias> lista = new List<Categorias>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("SELECT Descripcion from CATEGORIAS");
                datos.EjecutarLectura();

                while (datos.lector.Read())
                {
                    Categorias aux = new Categorias();

                    aux.Categoria = (string)datos.lector["Descripcion"];
                    
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
                
            }
            finally
            {
                datos.CerrarConexion();
            }



            
        }
    }
}
