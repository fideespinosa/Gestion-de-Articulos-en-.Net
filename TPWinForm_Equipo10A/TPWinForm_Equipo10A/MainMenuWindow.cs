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

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {

        }

        private void lblNombreMenu_Click(object sender, EventArgs e)
        {

        }

       

        private void tsmListarArticulos_Click(object sender, EventArgs e)
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
    }
}
