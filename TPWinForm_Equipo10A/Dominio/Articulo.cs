using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marcas MarcasCls;
        public Categorias CategoriasCls;

        public decimal Precio { get; set; }
        public ArtImg Imagen{ get; set; }

        public String Categoria { get; set; }
        public string Marca { get; set; }

    }

   
}
