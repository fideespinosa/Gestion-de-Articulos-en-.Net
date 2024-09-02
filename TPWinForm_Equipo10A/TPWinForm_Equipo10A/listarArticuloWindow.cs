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

        private void listarArticuloWindow_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            dgvListarArticulos.DataSource = negocio.listarArticulos();
        }
    }
}
