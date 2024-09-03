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
    public partial class listarArticuloWindow : Form
    {
        public listarArticuloWindow()
        {
            InitializeComponent();
        }

        private List<Articulo> ListaArticulos;
        private void listarArticuloWindow_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            ListaArticulos = negocio.listarArticulos();
            dgvListarArticulos.DataSource = ListaArticulos;
            picbxArticulo.Load(ListaArticulos[0].Imagen.ToString());
            dgvListarArticulos.Columns["Imagen"].Visible = false;
           
      

        }

        private void dgvListarArticulos_SelectionChanged(object sender, EventArgs e)
        {
             Articulo Seleccionado = (Articulo)dgvListarArticulos.CurrentRow.DataBoundItem;
            picbxArticulo.Load(Seleccionado.Imagen.ToString());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ArticulosWindow))
                {
                    return;
                }
            }
            ArticulosWindow CrearArticulo = new ArticulosWindow();
            //CrearArticulo.MdiParent = this;
            CrearArticulo.Show();

        }
    }
}
