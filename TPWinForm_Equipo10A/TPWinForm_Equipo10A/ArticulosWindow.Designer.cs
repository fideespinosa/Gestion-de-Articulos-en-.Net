namespace TPWinForm_Equipo10A
{
    partial class ArticulosWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombreAr = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.lblCodAr = new System.Windows.Forms.Label();
            this.txtbCodAr = new System.Windows.Forms.TextBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cbxCat = new System.Windows.Forms.ComboBox();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtbPrecio = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(419, 44);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(187, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CREAR ARTICULO";
            // 
            // lblNombreAr
            // 
            this.lblNombreAr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreAr.AutoSize = true;
            this.lblNombreAr.Location = new System.Drawing.Point(35, 100);
            this.lblNombreAr.Name = "lblNombreAr";
            this.lblNombreAr.Size = new System.Drawing.Size(54, 13);
            this.lblNombreAr.TabIndex = 1;
            this.lblNombreAr.Text = "Nombre:";
            // 
            // txtbNombre
            // 
            this.txtbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbNombre.Location = new System.Drawing.Point(155, 97);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(738, 20);
            this.txtbNombre.TabIndex = 2;
            // 
            // lblCodAr
            // 
            this.lblCodAr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodAr.AutoSize = true;
            this.lblCodAr.Location = new System.Drawing.Point(35, 141);
            this.lblCodAr.Name = "lblCodAr";
            this.lblCodAr.Size = new System.Drawing.Size(110, 13);
            this.lblCodAr.TabIndex = 3;
            this.lblCodAr.Text = "Código de articulo";
            // 
            // txtbCodAr
            // 
            this.txtbCodAr.Location = new System.Drawing.Point(155, 141);
            this.txtbCodAr.Name = "txtbCodAr";
            this.txtbCodAr.Size = new System.Drawing.Size(230, 20);
            this.txtbCodAr.TabIndex = 4;
            // 
            // cbxMarca
            // 
            this.cbxMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(738, 140);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(155, 21);
            this.cbxMarca.TabIndex = 5;
            // 
            // lblMarca
            // 
            this.lblMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(686, 144);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(46, 13);
            this.lblMarca.TabIndex = 6;
            this.lblMarca.Text = "Marca:";
            // 
            // cbxCat
            // 
            this.cbxCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCat.FormattingEnabled = true;
            this.cbxCat.Location = new System.Drawing.Point(738, 185);
            this.cbxCat.Name = "cbxCat";
            this.cbxCat.Size = new System.Drawing.Size(155, 21);
            this.cbxCat.TabIndex = 7;
            // 
            // lblCat
            // 
            this.lblCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(667, 188);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(65, 13);
            this.lblCat.TabIndex = 8;
            this.lblCat.Text = "Categoria:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(685, 226);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(47, 13);
            this.lblPrecio.TabIndex = 9;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtbPrecio
            // 
            this.txtbPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbPrecio.Location = new System.Drawing.Point(739, 226);
            this.txtbPrecio.Name = "txtbPrecio";
            this.txtbPrecio.Size = new System.Drawing.Size(154, 20);
            this.txtbPrecio.TabIndex = 10;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(35, 277);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(78, 13);
            this.lblDesc.TabIndex = 11;
            this.lblDesc.Text = "Descripción:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(119, 274);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(363, 175);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(858, 579);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 35);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Location = new System.Drawing.Point(786, 471);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(107, 35);
            this.btnAgregarArticulo.TabIndex = 14;
            this.btnAgregarArticulo.Text = "Agregar";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            // 
            // ArticulosWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1024, 546);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtbPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.cbxCat);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.txtbCodAr);
            this.Controls.Add(this.lblCodAr);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.lblNombreAr);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1040, 585);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1040, 585);
            this.Name = "ArticulosWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombreAr;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.Label lblCodAr;
        private System.Windows.Forms.TextBox txtbCodAr;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cbxCat;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtbPrecio;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAgregarArticulo;
    }
}