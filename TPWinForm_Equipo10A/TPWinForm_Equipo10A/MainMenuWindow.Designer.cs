﻿namespace TPWinForm_Equipo10A
{
    partial class MainMenuWindow
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.articuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.articuloToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.articuloToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tspArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmListarArticulos = new System.Windows.Forms.ToolStripMenuItem();
            this.tspMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.verDetallesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verDetallesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articuloToolStripMenuItem,
            this.marcaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 48);
            // 
            // articuloToolStripMenuItem
            // 
            this.articuloToolStripMenuItem.Name = "articuloToolStripMenuItem";
            this.articuloToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.articuloToolStripMenuItem.Text = "Articulo";
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.marcaToolStripMenuItem.Text = "Marca";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articuloToolStripMenuItem1,
            this.marcaToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(117, 48);
            // 
            // articuloToolStripMenuItem1
            // 
            this.articuloToolStripMenuItem1.Name = "articuloToolStripMenuItem1";
            this.articuloToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.articuloToolStripMenuItem1.Text = "Articulo";
            // 
            // marcaToolStripMenuItem1
            // 
            this.marcaToolStripMenuItem1.Name = "marcaToolStripMenuItem1";
            this.marcaToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.marcaToolStripMenuItem1.Text = "Marca";
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articuloToolStripMenuItem2,
            this.marcaToolStripMenuItem2});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(117, 48);
            // 
            // articuloToolStripMenuItem2
            // 
            this.articuloToolStripMenuItem2.Name = "articuloToolStripMenuItem2";
            this.articuloToolStripMenuItem2.Size = new System.Drawing.Size(116, 22);
            this.articuloToolStripMenuItem2.Text = "Articulo";
            // 
            // marcaToolStripMenuItem2
            // 
            this.marcaToolStripMenuItem2.Name = "marcaToolStripMenuItem2";
            this.marcaToolStripMenuItem2.Size = new System.Drawing.Size(116, 22);
            this.marcaToolStripMenuItem2.Text = "Marca";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspArticulo,
            this.tspMarca,
            this.categoriaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1124, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tspArticulo
            // 
            this.tspArticulo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmListarArticulos});
            this.tspArticulo.Name = "tspArticulo";
            this.tspArticulo.Size = new System.Drawing.Size(61, 20);
            this.tspArticulo.Text = "Articulo";
            // 
            // tsmListarArticulos
            // 
            this.tsmListarArticulos.Name = "tsmListarArticulos";
            this.tsmListarArticulos.Size = new System.Drawing.Size(102, 22);
            this.tsmListarArticulos.Text = "Listar";
            this.tsmListarArticulos.Click += new System.EventHandler(this.tsmListarArticulos_Click);
            // 
            // tspMarca
            // 
            this.tspMarca.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verDetallesToolStripMenuItem1});
            this.tspMarca.Name = "tspMarca";
            this.tspMarca.Size = new System.Drawing.Size(52, 20);
            this.tspMarca.Text = "Marca";
            // 
            // verDetallesToolStripMenuItem1
            // 
            this.verDetallesToolStripMenuItem1.Name = "verDetallesToolStripMenuItem1";
            this.verDetallesToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.verDetallesToolStripMenuItem1.Text = "Ver detalles";
            this.verDetallesToolStripMenuItem1.Click += new System.EventHandler(this.verDetallesToolStripMenuItem1_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verDetallesToolStripMenuItem2});
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            // 
            // verDetallesToolStripMenuItem2
            // 
            this.verDetallesToolStripMenuItem2.Name = "verDetallesToolStripMenuItem2";
            this.verDetallesToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.verDetallesToolStripMenuItem2.Text = "Ver detalles";
            this.verDetallesToolStripMenuItem2.Click += new System.EventHandler(this.verDetallesToolStripMenuItem2_Click);
            // 
            // MainMenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1124, 646);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1140, 685);
            this.MinimumSize = new System.Drawing.Size(1140, 685);
            this.Name = "MainMenuWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem articuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem articuloToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem articuloToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tspArticulo;
        private System.Windows.Forms.ToolStripMenuItem tspMarca;
        private System.Windows.Forms.ToolStripMenuItem verDetallesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verDetallesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmListarArticulos;
    }
}

