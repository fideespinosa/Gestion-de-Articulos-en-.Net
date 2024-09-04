using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listarArticulos()
        {
            List<Articulo> lista = new List<Articulo>();
           AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("Select Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio, i.ImagenUrl FROM ARTICULOS A, IMAGENES I where A.Id = I.IdArticulo");
                datos.EjecturaLectura();

               

                while (datos.lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)datos.lector["Codigo"];
                    aux.Nombre = (string)datos.lector["Nombre"];
                    aux.Descripcion = (string)datos.lector["Descripcion"];
                    aux.Marca = (int)datos.lector["IdMarca"];
                    aux.Categoria = (int)datos.lector["IdCategoria"];
                    aux.Precio = (decimal)datos.lector["Precio"];
                    aux.Imagen = new ArtImg();
                    aux.Imagen.ImgUrl = (string)datos.lector["ImagenUrl"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
            
        }
    }
}
