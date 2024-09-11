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
    public partial class MarcasWindow : Form
    {
        public MarcasWindow()
        {
            InitializeComponent();
        }

        private List<Marcas> ListaMarcas;
        private void MarcasWindow_Load(object sender, EventArgs e)
        {
            MarcasNegocio marca = new MarcasNegocio();
            ListaMarcas = marca.ListarMarcas();
            dgvListarMarcas.DataSource = ListaMarcas;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmCrearMarca frmCrearMarca = new frmCrearMarca();
            frmCrearMarca.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

    }
}
