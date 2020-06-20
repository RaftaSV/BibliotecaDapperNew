namespace AdminLabrary.formularios.insert_update
{
    partial class frmActualizarLibros
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
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label id_autorLabel;
            System.Windows.Forms.Label id_categoriaLabel;
            System.Windows.Forms.Label id_EditorialLabel;
            System.Windows.Forms.Label numero_edicionLabel;
            System.Windows.Forms.Label añoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActualizarLibros));
            this.btnEditorial = new System.Windows.Forms.Button();
            this.btnAutor = new System.Windows.Forms.Button();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_autorTextBox = new System.Windows.Forms.TextBox();
            this.id_categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_EditorialTextBox = new System.Windows.Forms.TextBox();
            this.numero_edicionTextBox = new System.Windows.Forms.TextBox();
            this.añoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            cantidadLabel = new System.Windows.Forms.Label();
            id_autorLabel = new System.Windows.Forms.Label();
            id_categoriaLabel = new System.Windows.Forms.Label();
            id_EditorialLabel = new System.Windows.Forms.Label();
            numero_edicionLabel = new System.Windows.Forms.Label();
            añoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(48, 238);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(51, 13);
            cantidadLabel.TabIndex = 54;
            cantidadLabel.Text = "cantidad:";
            // 
            // id_autorLabel
            // 
            id_autorLabel.AutoSize = true;
            id_autorLabel.Location = new System.Drawing.Point(48, 271);
            id_autorLabel.Name = "id_autorLabel";
            id_autorLabel.Size = new System.Drawing.Size(46, 13);
            id_autorLabel.TabIndex = 56;
            id_autorLabel.Text = "Id autor:";
            // 
            // id_categoriaLabel
            // 
            id_categoriaLabel.AutoSize = true;
            id_categoriaLabel.Location = new System.Drawing.Point(48, 312);
            id_categoriaLabel.Name = "id_categoriaLabel";
            id_categoriaLabel.Size = new System.Drawing.Size(66, 13);
            id_categoriaLabel.TabIndex = 58;
            id_categoriaLabel.Text = "Id categoria:";
            // 
            // id_EditorialLabel
            // 
            id_EditorialLabel.AutoSize = true;
            id_EditorialLabel.Location = new System.Drawing.Point(48, 346);
            id_EditorialLabel.Name = "id_EditorialLabel";
            id_EditorialLabel.Size = new System.Drawing.Size(59, 13);
            id_EditorialLabel.TabIndex = 60;
            id_EditorialLabel.Text = "Id Editorial:";
            // 
            // numero_edicionLabel
            // 
            numero_edicionLabel.AutoSize = true;
            numero_edicionLabel.Location = new System.Drawing.Point(48, 388);
            numero_edicionLabel.Name = "numero_edicionLabel";
            numero_edicionLabel.Size = new System.Drawing.Size(84, 13);
            numero_edicionLabel.TabIndex = 64;
            numero_edicionLabel.Text = "Numero edicion:";
            // 
            // añoLabel
            // 
            añoLabel.AutoSize = true;
            añoLabel.Location = new System.Drawing.Point(46, 161);
            añoLabel.Name = "añoLabel";
            añoLabel.Size = new System.Drawing.Size(29, 13);
            añoLabel.TabIndex = 52;
            añoLabel.Text = "Año:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(48, 161);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 66;
            nombreLabel.Text = "Nombre:";
            // 
            // btnEditorial
            // 
            this.btnEditorial.BackColor = System.Drawing.Color.Teal;
            this.btnEditorial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditorial.BackgroundImage")));
            this.btnEditorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditorial.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnEditorial.FlatAppearance.BorderSize = 0;
            this.btnEditorial.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.btnEditorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnEditorial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditorial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditorial.ForeColor = System.Drawing.Color.White;
            this.btnEditorial.Location = new System.Drawing.Point(412, 346);
            this.btnEditorial.Name = "btnEditorial";
            this.btnEditorial.Size = new System.Drawing.Size(119, 20);
            this.btnEditorial.TabIndex = 39;
            this.btnEditorial.UseVisualStyleBackColor = false;
            this.btnEditorial.Click += new System.EventHandler(this.btnEditorial_Click);
            // 
            // btnAutor
            // 
            this.btnAutor.BackColor = System.Drawing.Color.Teal;
            this.btnAutor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAutor.BackgroundImage")));
            this.btnAutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAutor.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnAutor.FlatAppearance.BorderSize = 0;
            this.btnAutor.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.btnAutor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnAutor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAutor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutor.ForeColor = System.Drawing.Color.White;
            this.btnAutor.Location = new System.Drawing.Point(412, 272);
            this.btnAutor.Name = "btnAutor";
            this.btnAutor.Size = new System.Drawing.Size(119, 19);
            this.btnAutor.TabIndex = 37;
            this.btnAutor.UseVisualStyleBackColor = false;
            this.btnAutor.Click += new System.EventHandler(this.btnAutor_Click);
            // 
            // txtEditorial
            // 
            this.txtEditorial.Enabled = false;
            this.txtEditorial.Location = new System.Drawing.Point(138, 346);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(236, 20);
            this.txtEditorial.TabIndex = 42;
            // 
            // txtAutor
            // 
            this.txtAutor.Enabled = false;
            this.txtAutor.Location = new System.Drawing.Point(138, 272);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(236, 20);
            this.txtAutor.TabIndex = 41;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Teal;
            this.btnActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.BackgroundImage")));
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(49, 415);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(480, 37);
            this.btnActualizar.TabIndex = 52;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "cantidad", true));
            this.cantidadTextBox.Location = new System.Drawing.Point(138, 235);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(236, 20);
            this.cantidadTextBox.TabIndex = 55;
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataSource = typeof(AdminLabrary.entidades.Libros);
            // 
            // id_autorTextBox
            // 
            this.id_autorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "Id_autor", true));
            this.id_autorTextBox.Enabled = false;
            this.id_autorTextBox.Location = new System.Drawing.Point(380, 271);
            this.id_autorTextBox.Name = "id_autorTextBox";
            this.id_autorTextBox.Size = new System.Drawing.Size(26, 20);
            this.id_autorTextBox.TabIndex = 57;
            // 
            // id_categoriaComboBox
            // 
            this.id_categoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.librosBindingSource, "Id_categoria", true));
            this.id_categoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "Id_categoria", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.id_categoriaComboBox.DataSource = this.categoriasBindingSource;
            this.id_categoriaComboBox.DisplayMember = "Categoria";
            this.id_categoriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_categoriaComboBox.FormattingEnabled = true;
            this.id_categoriaComboBox.Location = new System.Drawing.Point(138, 309);
            this.id_categoriaComboBox.Name = "id_categoriaComboBox";
            this.id_categoriaComboBox.Size = new System.Drawing.Size(236, 21);
            this.id_categoriaComboBox.TabIndex = 59;
            this.id_categoriaComboBox.ValueMember = "Id_categoria";
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataSource = typeof(AdminLabrary.entidades.Categorias);
            // 
            // id_EditorialTextBox
            // 
            this.id_EditorialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "Id_Editorial", true));
            this.id_EditorialTextBox.Enabled = false;
            this.id_EditorialTextBox.Location = new System.Drawing.Point(380, 346);
            this.id_EditorialTextBox.Name = "id_EditorialTextBox";
            this.id_EditorialTextBox.Size = new System.Drawing.Size(26, 20);
            this.id_EditorialTextBox.TabIndex = 61;
            // 
            // numero_edicionTextBox
            // 
            this.numero_edicionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "Numero_edicion", true));
            this.numero_edicionTextBox.Location = new System.Drawing.Point(138, 385);
            this.numero_edicionTextBox.Name = "numero_edicionTextBox";
            this.numero_edicionTextBox.Size = new System.Drawing.Size(236, 20);
            this.numero_edicionTextBox.TabIndex = 65;
            // 
            // añoDateTimePicker
            // 
            this.añoDateTimePicker.CustomFormat = "yyyy - MM - dd";
            this.añoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.librosBindingSource, "Año", true));
            this.añoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.añoDateTimePicker.Location = new System.Drawing.Point(138, 196);
            this.añoDateTimePicker.Name = "añoDateTimePicker";
            this.añoDateTimePicker.Size = new System.Drawing.Size(236, 20);
            this.añoDateTimePicker.TabIndex = 53;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(138, 158);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(236, 20);
            this.nombreTextBox.TabIndex = 67;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Teal;
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(49, 458);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(480, 34);
            this.btnEliminar.TabIndex = 68;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(138, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // frmActualizarLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(573, 502);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(añoLabel);
            this.Controls.Add(this.añoDateTimePicker);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(id_autorLabel);
            this.Controls.Add(this.id_autorTextBox);
            this.Controls.Add(id_categoriaLabel);
            this.Controls.Add(this.id_categoriaComboBox);
            this.Controls.Add(id_EditorialLabel);
            this.Controls.Add(this.id_EditorialTextBox);
            this.Controls.Add(numero_edicionLabel);
            this.Controls.Add(this.numero_edicionTextBox);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEditorial);
            this.Controls.Add(this.btnAutor);
            this.Controls.Add(this.txtEditorial);
            this.Controls.Add(this.txtAutor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmActualizarLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACTUALIZAR - ELIMINAR - LIBRO";
            this.Load += new System.EventHandler(this.frmActualizarLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtEditorial;
        public System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.ComboBox id_categoriaComboBox;
        private System.Windows.Forms.TextBox numero_edicionTextBox;
        public System.Windows.Forms.TextBox id_autorTextBox;
        public System.Windows.Forms.TextBox id_EditorialTextBox;
        private System.Windows.Forms.DateTimePicker añoDateTimePicker;
        private System.Windows.Forms.TextBox nombreTextBox;
        public System.Windows.Forms.Button btnActualizar;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnEditorial;
        public System.Windows.Forms.Button btnAutor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}