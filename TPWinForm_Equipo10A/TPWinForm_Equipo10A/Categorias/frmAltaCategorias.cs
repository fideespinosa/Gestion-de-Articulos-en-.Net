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
    public partial class frmAltaCategoria : Form
    {
        public frmAltaCategoria()
        {
            InitializeComponent();
        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Categorias categorias = new Categorias();   
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio(); 

            try
            {
                categorias.Descripcion = txtbxNombre.Text;
                categoriaNegocio.agregar(categorias);
                MessageBox.Show("Marca Agregada exitosamente");
                Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
            finally { }
        }

        private void txtbxCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAltaCategoria_Load(object sender, EventArgs e)
        {

        }
    }
}
