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
    public partial class MainMenuWindow : Form
    {
        public MainMenuWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarListasArticulos();
        }

        private void tsmListarArticulos_Click(object sender, EventArgs e)
        {
            cargarListasArticulos();
        }

        private void cargarListasArticulos()
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(listarArticuloWindow))
                {
                    return;
                }
            }
            listarArticuloWindow listarArticuloWindow = new listarArticuloWindow();
            listarArticuloWindow.MdiParent = this;
            listarArticuloWindow.Show();
        }

        private void verDetallesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMarcas();
        }

        private void verDetallesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmCategorias();
        }

        //======= LLAMADAS FMR =======
        private void frmCategorias()
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(CategoriaWindow))
                {
                    return;
                }
            }
            CategoriaWindow CategoriaWindow = new CategoriaWindow();
            //CategoriaWindow.MdiParent = this;
            CategoriaWindow.ShowDialog();
        }
        
        private void frmMarcas()
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(MarcasWindow))
                {
                    return;
                }
            }
            MarcasWindow MarcasWindow = new MarcasWindow();
            MarcasWindow.MdiParent = this;
            MarcasWindow.Show();
        }

    }
}
