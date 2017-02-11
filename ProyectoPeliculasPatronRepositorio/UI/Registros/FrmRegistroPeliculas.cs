using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoPeliculasPatronRepositorio.UI.Registros
{
    public partial class FrmRegistroPeliculas : Form
    {
        public FrmRegistroPeliculas()
        {
            InitializeComponent();
        }

        private void peliculasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.peliculasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.peliculasDbDataSet);

        }

        private void FrmRegistroPeliculas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'peliculasDbDataSet.Peliculas' table. You can move, or remove it, as needed.
            this.peliculasTableAdapter.Fill(this.peliculasDbDataSet.Peliculas);

        }
    }
}
