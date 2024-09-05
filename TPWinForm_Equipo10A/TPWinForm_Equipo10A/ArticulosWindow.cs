using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace TPWinForm_Equipo10A
{
    public partial class ArticulosWindow : Form
    {
        public ArticulosWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            Articulo art = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                art.Nombre = txtbNombre.Text;
                art.Codigo = txtbCodAr.Text;
                art.Descripcion = txtbDescAr.Text;
                art.Marca = cbxMarca.TabIndex;
                art.Categoria = cbxCat.TabIndex;
                art.Precio = decimal.Parse(txtbPrecio.Text);
                art.Descripcion = txtbDescAr.Text;

                negocio.Agregar(art);

                MessageBox.Show("Articulo agregado correctamente.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
