using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ImagenNegocio
    {
        public List<ArtImg> ListarImagenes(Articulo art)
        {
            List<ArtImg> lista = new List<ArtImg>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("SELECT A.Nombre, i.ImagenUrl, i.Id from IMAGENES i right join ARTICULOS as A on A.id = i.IdArticulo where i.IdArticulo = @artId");
                datos.setearParametro("@artId", art.Id);
                datos.EjecutarLectura();

                while (datos.lector.Read())
                {
                    ArtImg aux = new ArtImg();
                    aux.ImagenUrl = (string)datos.lector["ImagenUrl"];
                    aux.Desc = (string)datos.lector["Nombre"];
                    aux.Id = (int)datos.lector["Id"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
        public void Agregar(string url, Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();;
            try
            {
                datos.SetearConsulta("insert into IMAGENES (ImagenUrl, IdArticulo) VALUES (@url, @Id)");
                datos.setearParametro("@url", url);
                datos.setearParametro("@Id", art.Id);
                datos.EjecutarAccion();
                    }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}
