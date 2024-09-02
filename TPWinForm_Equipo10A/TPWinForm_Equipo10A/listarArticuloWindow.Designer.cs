namespace TPWinForm_Equipo10A
{
    partial class listarArticuloWindow
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
            this.dgvListarArticulos = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListarArticulos
            // 
            this.dgvListarArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListarArticulos.Location = new System.Drawing.Point(12, 123);
            this.dgvListarArticulos.Name = "dgvListarArticulos";
            this.dgvListarArticulos.Size = new System.Drawing.Size(662, 372);
            this.dgvListarArticulos.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(503, 48);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(155, 13);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "LISTADO DE ARTICULOS";
            // 
            // listarArticuloWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 603);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvListarArticulos);
            this.Name = "listarArticuloWindow";
            this.Text = "listarArticuloWindow";
            this.Load += new System.EventHandler(this.listarArticuloWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListarArticulos;
        private System.Windows.Forms.Label lblTitulo;
    }
}