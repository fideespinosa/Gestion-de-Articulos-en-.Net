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
    public partial class CategoriaWindow : Form
    {
        private List<Categorias> categorias;
        public CategoriaWindow()
        {
            InitializeComponent();
        }
        private void CategoriaWindow_Load(object sender, EventArgs e)
        {
            cargarListadoCategorias();
        }

        private void cargarListadoCategorias()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                categorias = negocio.ListarCategoria();
                dgvCategorias.DataSource = categorias;  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //======= MENU - CLICK =======
        private void tsmSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmAgregar_Click(object sender, EventArgs e)
        {
            AgregarCategoria AgregarCategoria = new AgregarCategoria();
            AgregarCategoria.ShowDialog();
        }
    }
}
