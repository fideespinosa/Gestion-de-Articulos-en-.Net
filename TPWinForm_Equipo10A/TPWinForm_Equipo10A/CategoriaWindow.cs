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
    public partial class CategoriaWindow : Form
    {
        public CategoriaWindow()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            AgregarCategoria AgregarCategoria = new AgregarCategoria();
            AgregarCategoria.ShowDialog();
        }

        private void CategoriaWindow_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void tsmSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
