namespace ProyectoPeliculasPatronRepositorio.UI.Consultas
{
    partial class FrmConsultaCategorias
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
            this.CategoriaDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoriaDataGridView
            // 
            this.CategoriaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoriaDataGridView.Location = new System.Drawing.Point(21, 61);
            this.CategoriaDataGridView.Name = "CategoriaDataGridView";
            this.CategoriaDataGridView.Size = new System.Drawing.Size(240, 150);
            this.CategoriaDataGridView.TabIndex = 0;
            // 
            // FrmConsultaCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CategoriaDataGridView);
            this.Name = "FrmConsultaCategorias";
            this.Text = "Consulta de Categorias";
            ((System.ComponentModel.ISupportInitialize)(this.CategoriaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CategoriaDataGridView;
    }
}