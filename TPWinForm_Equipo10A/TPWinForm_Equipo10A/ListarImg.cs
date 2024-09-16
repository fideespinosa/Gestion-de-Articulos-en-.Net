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
    public partial class ListarImg : Form
    {
        public Articulo articulo{ get; set; }
        public ArtImg seleccionado { get; set; }
        private List<ArtImg> ListaImagenes;
        public ListarImg()
        {
            InitializeComponent();
        }

        public ListarImg(Articulo art)
        {
            articulo = art;
            InitializeComponent();
        }
        private void ListarImg_Load(object sender, EventArgs e)
        {
            ImagenNegocio negocio = new ImagenNegocio();
            try
            {
                ListaImagenes = negocio.ListarImagenes(articulo);
                dgvImagenes.DataSource = ListaImagenes;
                seleccionado = (ArtImg)dgvImagenes.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                picbxImagenes.Load(imagen);
            }
            catch (Exception)
            {
                picbxImagenes.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
            }
        }

        private void dgvImagenes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                seleccionado = (ArtImg)dgvImagenes.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        private void btnAgregarImg_Click(object sender, EventArgs e)
        {
            ImagenNegocio negocio = new ImagenNegocio();
            AltaImagen altaImagen = new AltaImagen(articulo);
            altaImagen.ShowDialog();     
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
