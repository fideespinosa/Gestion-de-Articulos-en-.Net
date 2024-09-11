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
                datos.SetearConsulta("Select Codigo, Nombre, A.Descripcion, M.Descripcion as Marca, C.Descripcion as Categoriass , Precio, i.ImagenUrl FROM ARTICULOS A, IMAGENES I, CATEGORIAS C, MARCAS M where A.Id = I.IdArticulo and  A.Id = M.Id and  A.Id = C.Id");
                datos.EjecutarLectura();

               

                while (datos.lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)datos.lector["Codigo"];
                    aux.Nombre = (string)datos.lector["Nombre"];
                    aux.Descripcion = (string)datos.lector["Descripcion"];
                    aux.MarcasCls = new Marcas();
                    aux.MarcasCls.Marca = (string)datos.lector["Marca"];
                    aux.CategoriasCls = new Categorias();
                    aux.CategoriasCls.Descripcion = (string)datos.lector["Categoriass"];
                    aux.Precio = (decimal)datos.lector["Precio"];
                    aux.Imagen = new ArtImg();
                    aux.Imagen.ImgUrl = (string)datos.lector["ImagenUrl"];

                    aux.Marca = aux.MarcasCls.Marca;
                    aux.Categoria = aux.CategoriasCls.Descripcion;

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

        public void Agregar(Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta
                    (
                    "Insert into ARTICULOS (Codigo, Nombre, Descripcion, idMarca, idCategoria, Precio) " +
                    "values ('" + art.Codigo + "', '" + art.Nombre + "', '" + art.Descripcion + "', '" + art.Marca + "','" + art.Categoria + "', '" + art.Precio + "')"
                    );
                datos.EjecutarAccion();

            }
            catch(Exception ex) 
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
