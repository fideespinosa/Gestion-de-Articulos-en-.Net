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
    public partial class frmAltaArticulo : Form
    {
        public frmAltaArticulo()
        {
            InitializeComponent();
        }
        private Articulo articulo = null;
        private ArtImg ArtImg = null;

        public frmAltaArticulo(Articulo Articulo)
        {
            InitializeComponent();
            this.articulo = Articulo;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            Articulo art = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            art.Imagen = new ArtImg();
            ArtImg img = new ArtImg();   

            try
            {
                img.ImagenUrl = txtbUrlImagen.Text;
                art.Nombre = txtbNombre.Text;
                art.Codigo = txtbCodAr.Text;
                art.Descripcion = txtbDescAr.Text;
                art.MarcasCls = (Marcas)cbxMarca.SelectedItem;
                art.CategoriasCls = (Categorias)cbxCat.SelectedItem;
                art.Precio = decimal.Parse(txtbPrecio.Text);
                art.Descripcion = txtbDescAr.Text; 
                img.ImagenUrl = txtbUrlImagen.Text;

                negocio.Agregar(art, img);
               // negocio.AgregarImagen(img, art);
                MessageBox.Show("Articulo agregado correctamente.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void ArticulosWindow_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoria = new CategoriaNegocio();
            MarcasNegocio marca = new MarcasNegocio();

            try
            {
                cbxMarca.DataSource = marca.ListarMarcas();
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Descripcion";
                cbxCat.DataSource = categoria.ListarCategoria();
                cbxCat.ValueMember = "Id";
                cbxCat.DisplayMember = "Descripcion";

                if (articulo != null) 
                {
                    //artImg.ImagenUrl = txtbUrlImagen.Text;
                    txtbNombre.Text = articulo.Nombre;
                    txtbCodAr.Text = articulo.Codigo;
                    txtbDescAr.Text = articulo.Descripcion;
                    txtbPrecio.Text = articulo.Precio.ToString();
                    cbxMarca.SelectedValue = articulo.MarcasCls.Id;
                    cbxCat.SelectedValue = articulo.CategoriasCls.Id;

                    //artImg.ImagenUrl = txtbUrlImagen.Text;
                    // imagen se puede generar funcion para que con el id de articulo muestre imagen
                    // se puede sobre cargar cargar imagen para que lo haga con el id de articulo.
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cbxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtbUrlImagen_Leave(object sender, EventArgs e)
        {   
            cargarImagen(txtbUrlImagen.Text);   
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticuloImagen.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticuloImagen.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
            }
        }

        private void pbxArticuloImagen_Click(object sender, EventArgs e)
        {

        }

        private void lblCodAr_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
