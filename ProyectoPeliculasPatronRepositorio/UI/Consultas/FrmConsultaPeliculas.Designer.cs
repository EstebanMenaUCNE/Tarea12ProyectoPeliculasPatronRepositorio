﻿namespace ProyectoPeliculasPatronRepositorio.UI.Consultas
{
    partial class FrmConsultaPeliculas
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
            this.PeliculasDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PeliculasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PeliculasDataGridView
            // 
            this.PeliculasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PeliculasDataGridView.Location = new System.Drawing.Point(22, 63);
            this.PeliculasDataGridView.Name = "PeliculasDataGridView";
            this.PeliculasDataGridView.Size = new System.Drawing.Size(240, 150);
            this.PeliculasDataGridView.TabIndex = 0;
            // 
            // FrmConsultaPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.PeliculasDataGridView);
            this.Name = "FrmConsultaPeliculas";
            this.Text = "Consulta de Peliculas";
            ((System.ComponentModel.ISupportInitialize)(this.PeliculasDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PeliculasDataGridView;
    }
}