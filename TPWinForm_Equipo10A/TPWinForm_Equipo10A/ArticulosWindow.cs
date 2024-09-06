﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace TPWinForm_Equipo10A
{
    public partial class ArticulosWindow : Form
    {
        public ArticulosWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            Articulo art = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                art.Nombre = txtbNombre.Text;
                art.Codigo = txtbCodAr.Text;
                art.Descripcion = txtbDescAr.Text;
                art.MarcasCls = (Marcas)cbxMarca.SelectedItem;
                art.CategoriasCls = (Categorias)cbxCat.SelectedItem;
                art.Precio = decimal.Parse(txtbPrecio.Text);
                art.Descripcion = txtbDescAr.Text;

                negocio.Agregar(art);

                MessageBox.Show("Articulo agregado correctamente.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ArticulosWindow_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoria = new CategoriaNegocio();
            MarcasNegocio marca = new MarcasNegocio();

            try
            {
                cbxMarca.DataSource = marca.ListarMarcas();
              
                cbxCat.DataSource = categoria.ListarCategoria();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cbxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
