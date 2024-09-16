using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_Equipo10A
{
    public partial class AltaImagen : Form
    {
        Articulo art = new Articulo();
   
        public AltaImagen()
        {
            InitializeComponent();
        }

        public AltaImagen(Articulo art)
        {
            this.art = art;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ImagenNegocio negocio = new ImagenNegocio();
            //
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ImagenNegocio negocio = new ImagenNegocio();
            negocio.Agregar(txtUrlImagen.Text, art);

        }

        private void pcbImagenUrl_Click(object sender, EventArgs e)
        {

        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pcbImagenUrl.Load(imagen);
            }
            catch (Exception)
            {
                pcbImagenUrl.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
            }
        }

        private void AltaImagen_Load(object sender, EventArgs e)
        {


        }

        private void btnMostrarImagen_Click(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
