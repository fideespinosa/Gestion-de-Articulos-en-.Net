namespace TPWinForm_Equipo10A
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
            this.lblNombreMenu = new System.Windows.Forms.Label();
            this.btnArticulos = new System.Windows.Forms.Button();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombreMenu
            // 
            this.lblNombreMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombreMenu.AutoSize = true;
            this.lblNombreMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblNombreMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombreMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblNombreMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMenu.Location = new System.Drawing.Point(219, 65);
            this.lblNombreMenu.Name = "lblNombreMenu";
            this.lblNombreMenu.Size = new System.Drawing.Size(353, 26);
            this.lblNombreMenu.TabIndex = 1;
            this.lblNombreMenu.Text = "ADMINISTRACION DE PRODUCTOS";
            this.lblNombreMenu.Click += new System.EventHandler(this.lblNombreMenu_Click);
            // 
            // btnArticulos
            // 
            this.btnArticulos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticulos.Location = new System.Drawing.Point(262, 161);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(249, 64);
            this.btnArticulos.TabIndex = 3;
            this.btnArticulos.Text = "ARTICULOS";
            this.btnArticulos.UseVisualStyleBackColor = true;
            this.btnArticulos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMarcas
            // 
            this.btnMarcas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcas.Location = new System.Drawing.Point(262, 253);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(249, 64);
            this.btnMarcas.TabIndex = 4;
            this.btnMarcas.Text = "MARCAS";
            this.btnMarcas.UseVisualStyleBackColor = true;
            this.btnMarcas.Click += new System.EventHandler(this.btnMarcas_Click);
            // 
            // MainMenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMarcas);
            this.Controls.Add(this.btnArticulos);
            this.Controls.Add(this.lblNombreMenu);
            this.IsMdiContainer = true;
            this.Name = "MainMenuWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreMenu;
        private System.Windows.Forms.Button btnArticulos;
        private System.Windows.Forms.Button btnMarcas;
    }
}

