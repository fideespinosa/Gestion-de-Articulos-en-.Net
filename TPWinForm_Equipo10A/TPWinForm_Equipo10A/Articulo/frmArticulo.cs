using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TPWinForm_Equipo10A
{
    public partial class frmArticulo : Form
    {
        public frmArticulo()
        {
            InitializeComponent();
        }

        private List<Articulo> ListaArticulos;
        private void listarArticuloWindow_Load(object sender, EventArgs e)
        {
         cargarArticulo();

        }
        private void cargarArticulo()
        {

            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                ListaArticulos = negocio.ListarArticulos();
                dgvListarArticulos.DataSource = ListaArticulos;
                //picbxArticulo.Load(ListaArticulos[0].Imagen.ImagenUrl);
                cargarImagen(ListaArticulos[0].Imagen.ImagenUrl);
                //dgvListarArticulos.Columns["ImagenUrl"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void dgvListarArticulos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Articulo Seleccionado = (Articulo)dgvListarArticulos.CurrentRow.DataBoundItem;
                picbxArticulo.Load(Seleccionado.Imagen.ImagenUrl);
            }
            catch (Exception ex)
            {
                picbxArticulo.Load("https://www.campana.gob.ar/wp-content/uploads/2022/05/placeholder.png");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmAltaArticulo))
                {
                    return;
                }
            }
            frmAltaArticulo CrearArticulo = new frmAltaArticulo();
            //CrearArticulo.MdiParent = this;
            CrearArticulo.ShowDialog();
            cargarArticulo();
        }

        private void picbxArticulo_Click(object sender, EventArgs e)
        {

        }

        private void cargarImagen(string imagen)
        {
            try
            {
                picbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                picbxArticulo.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            Articulo Seleccionado = (Articulo)dgvListarArticulos.CurrentRow.DataBoundItem;
            frmAltaArticulo modificar = new frmAltaArticulo(Seleccionado);
            //CrearArticulo.MdiParent = this;
            modificar.ShowDialog();
            cargarArticulo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            frmCrearMarca _frmCrearMarca = new frmCrearMarca();
            //CrearArticulo.MdiParent = this;
            _frmCrearMarca.ShowDialog();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            frmAltaCategoria _frmAltaCate = new frmAltaCategoria();
            _frmAltaCate.ShowDialog();
        }
    }
}
