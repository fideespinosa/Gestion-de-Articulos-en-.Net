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
    public partial class frmAltaMarca : Form
    {
        private Marcas seleccionado;

        public frmAltaMarca()
        {
            InitializeComponent();
        }

        public frmAltaMarca(Marcas seleccionado)
        {
            this.seleccionado=seleccionado;
            InitializeComponent();
            this.lblTitulo.Text  = "MODIFICAR MARCA";
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            MarcasNegocio negocio = new MarcasNegocio();
            Marcas marca = new Marcas();

            try 
            {
                marca.Descripcion = txtbxNombre.Text;
                negocio.AgregarMarca(marca);
                MessageBox.Show("Marca Agregada exitosamente");
                Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString()) ;
            }
        }

        private void frmAltaMarca_Load(object sender, EventArgs e)
        {

        }
    }
}
