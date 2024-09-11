using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class MarcasNegocio
    {
        public List<Marcas> ListarMarcas()
        {
           
            AccesoDatos datos = new AccesoDatos();
            List<Marcas> list = new List<Marcas>();

            try
            {
                datos.SetearConsulta("SELECT Id, Descripcion from MARCAS");
                datos.EjecutarLectura();
                

                while (datos.lector.Read())
                {
                    Marcas aux = new Marcas();

                    aux.Id = (int)datos.lector["Id"];
                    aux.Marca = (string)datos.lector["Descripcion"];
                    list.Add(aux);
                }
                return list;
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
