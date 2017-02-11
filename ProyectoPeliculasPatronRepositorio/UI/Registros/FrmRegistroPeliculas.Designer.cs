namespace ProyectoPeliculasPatronRepositorio.UI.Registros
{
    partial class FrmRegistroPeliculas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label peliculaIdLabel;
            System.Windows.Forms.Label estrenoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label categoriaIdLabel;
            this.peliculasDbDataSet = new ProyectoPeliculasPatronRepositorio.PeliculasDbDataSet();
            this.peliculasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peliculasTableAdapter = new ProyectoPeliculasPatronRepositorio.PeliculasDbDataSetTableAdapters.PeliculasTableAdapter();
            this.tableAdapterManager = new ProyectoPeliculasPatronRepositorio.PeliculasDbDataSetTableAdapters.TableAdapterManager();
            this.peliculaIdTextBox = new System.Windows.Forms.TextBox();
            this.estrenoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.categoriaIdComboBox = new System.Windows.Forms.ComboBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            peliculaIdLabel = new System.Windows.Forms.Label();
            estrenoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            categoriaIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // peliculasDbDataSet
            // 
            this.peliculasDbDataSet.DataSetName = "PeliculasDbDataSet";
            this.peliculasDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // peliculasBindingSource
            // 
            this.peliculasBindingSource.DataMember = "Peliculas";
            this.peliculasBindingSource.DataSource = this.peliculasDbDataSet;
            // 
            // peliculasTableAdapter
            // 
            this.peliculasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriasTableAdapter = null;
            this.tableAdapterManager.PeliculasTableAdapter = this.peliculasTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProyectoPeliculasPatronRepositorio.PeliculasDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // peliculaIdLabel
            // 
            peliculaIdLabel.AutoSize = true;
            peliculaIdLabel.Location = new System.Drawing.Point(34, 68);
            peliculaIdLabel.Name = "peliculaIdLabel";
            peliculaIdLabel.Size = new System.Drawing.Size(59, 13);
            peliculaIdLabel.TabIndex = 1;
            peliculaIdLabel.Text = "Pelicula Id:";
            // 
            // peliculaIdTextBox
            // 
            this.peliculaIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "PeliculaId", true));
            this.peliculaIdTextBox.Location = new System.Drawing.Point(107, 65);
            this.peliculaIdTextBox.Name = "peliculaIdTextBox";
            this.peliculaIdTextBox.Size = new System.Drawing.Size(75, 20);
            this.peliculaIdTextBox.TabIndex = 2;
            // 
            // estrenoLabel
            // 
            estrenoLabel.AutoSize = true;
            estrenoLabel.Location = new System.Drawing.Point(34, 95);
            estrenoLabel.Name = "estrenoLabel";
            estrenoLabel.Size = new System.Drawing.Size(46, 13);
            estrenoLabel.TabIndex = 3;
            estrenoLabel.Text = "Estreno:";
            // 
            // estrenoDateTimePicker
            // 
            this.estrenoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.peliculasBindingSource, "Estreno", true));
            this.estrenoDateTimePicker.Location = new System.Drawing.Point(107, 91);
            this.estrenoDateTimePicker.Name = "estrenoDateTimePicker";
            this.estrenoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.estrenoDateTimePicker.TabIndex = 4;
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(34, 120);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 5;
            descripcionLabel.Text = "Descripcion:";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(107, 117);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(200, 20);
            this.descripcionTextBox.TabIndex = 6;
            // 
            // categoriaIdLabel
            // 
            categoriaIdLabel.AutoSize = true;
            categoriaIdLabel.Location = new System.Drawing.Point(34, 146);
            categoriaIdLabel.Name = "categoriaIdLabel";
            categoriaIdLabel.Size = new System.Drawing.Size(67, 13);
            categoriaIdLabel.TabIndex = 7;
            categoriaIdLabel.Text = "Categoria Id:";
            // 
            // categoriaIdComboBox
            // 
            this.categoriaIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "CategoriaId", true));
            this.categoriaIdComboBox.FormattingEnabled = true;
            this.categoriaIdComboBox.Location = new System.Drawing.Point(107, 143);
            this.categoriaIdComboBox.Name = "categoriaIdComboBox";
            this.categoriaIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.categoriaIdComboBox.TabIndex = 8;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(188, 63);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarButton.TabIndex = 14;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(218, 180);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 23);
            this.EliminarButton.TabIndex = 13;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(137, 180);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 12;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(56, 180);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 23);
            this.NuevoButton.TabIndex = 11;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            // 
            // FrmRegistroPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 261);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(peliculaIdLabel);
            this.Controls.Add(this.peliculaIdTextBox);
            this.Controls.Add(estrenoLabel);
            this.Controls.Add(this.estrenoDateTimePicker);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(categoriaIdLabel);
            this.Controls.Add(this.categoriaIdComboBox);
            this.Name = "FrmRegistroPeliculas";
            this.Text = "Registro de Peliculas";
            this.Load += new System.EventHandler(this.FrmRegistroPeliculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.peliculasDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PeliculasDbDataSet peliculasDbDataSet;
        private System.Windows.Forms.BindingSource peliculasBindingSource;
        private PeliculasDbDataSetTableAdapters.PeliculasTableAdapter peliculasTableAdapter;
        private PeliculasDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox peliculaIdTextBox;
        private System.Windows.Forms.DateTimePicker estrenoDateTimePicker;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.ComboBox categoriaIdComboBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
    }
}