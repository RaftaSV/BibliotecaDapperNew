namespace AdminLabrary.formularios.insert_update
{
    partial class frmInsertarLibro
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
            System.Windows.Forms.Label añoLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label id_autorLabel;
            System.Windows.Forms.Label id_categoriaLabel;
            System.Windows.Forms.Label id_EditorialLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label numero_edicionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsertarLibro));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.btnAutor = new System.Windows.Forms.Button();
            this.btnEditorial = new System.Windows.Forms.Button();
            this.añoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.id_autorTextBox = new System.Windows.Forms.TextBox();
            this.id_categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_EditorialTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.numero_edicionTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            añoLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            id_autorLabel = new System.Windows.Forms.Label();
            id_categoriaLabel = new System.Windows.Forms.Label();
            id_EditorialLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            numero_edicionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // añoLabel
            // 
            añoLabel.AutoSize = true;
            añoLabel.Location = new System.Drawing.Point(92, 126);
            añoLabel.Name = "añoLabel";
            añoLabel.Size = new System.Drawing.Size(35, 16);
            añoLabel.TabIndex = 21;
            añoLabel.Text = "Año:";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(76, 164);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(63, 16);
            cantidadLabel.TabIndex = 23;
            cantidadLabel.Text = "cantidad:";
            // 
            // id_autorLabel
            // 
            id_autorLabel.AutoSize = true;
            id_autorLabel.Location = new System.Drawing.Point(84, 204);
            id_autorLabel.Name = "id_autorLabel";
            id_autorLabel.Size = new System.Drawing.Size(42, 16);
            id_autorLabel.TabIndex = 25;
            id_autorLabel.Text = "Autor:";
            // 
            // id_categoriaLabel
            // 
            id_categoriaLabel.AutoSize = true;
            id_categoriaLabel.Location = new System.Drawing.Point(57, 244);
            id_categoriaLabel.Name = "id_categoriaLabel";
            id_categoriaLabel.Size = new System.Drawing.Size(70, 16);
            id_categoriaLabel.TabIndex = 27;
            id_categoriaLabel.Text = "Categoria:";
            // 
            // id_EditorialLabel
            // 
            id_EditorialLabel.AutoSize = true;
            id_EditorialLabel.Location = new System.Drawing.Point(65, 285);
            id_EditorialLabel.Name = "id_EditorialLabel";
            id_EditorialLabel.Size = new System.Drawing.Size(60, 16);
            id_EditorialLabel.TabIndex = 29;
            id_EditorialLabel.Text = "Editorial:";
            id_EditorialLabel.Click += new System.EventHandler(this.id_EditorialLabel_Click);
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(79, 87);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(60, 16);
            nombreLabel.TabIndex = 31;
            nombreLabel.Text = "Nombre:";
            // 
            // numero_edicionLabel
            // 
            numero_edicionLabel.AutoSize = true;
            numero_edicionLabel.Location = new System.Drawing.Point(33, 326);
            numero_edicionLabel.Name = "numero_edicionLabel";
            numero_edicionLabel.Size = new System.Drawing.Size(106, 16);
            numero_edicionLabel.TabIndex = 33;
            numero_edicionLabel.Text = "Numero edicion:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Teal;
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(30, 359);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(546, 30);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtAutor
            // 
            this.txtAutor.Enabled = false;
            this.txtAutor.Location = new System.Drawing.Point(156, 205);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(236, 22);
            this.txtAutor.TabIndex = 17;
            // 
            // txtEditorial
            // 
            this.txtEditorial.Enabled = false;
            this.txtEditorial.Location = new System.Drawing.Point(156, 284);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(236, 22);
            this.txtEditorial.TabIndex = 18;
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
            this.btnAutor.Location = new System.Drawing.Point(427, 204);
            this.btnAutor.Name = "btnAutor";
            this.btnAutor.Size = new System.Drawing.Size(149, 23);
            this.btnAutor.TabIndex = 4;
            this.btnAutor.UseVisualStyleBackColor = false;
            this.btnAutor.Click += new System.EventHandler(this.btnAutor_Click);
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
            this.btnEditorial.Location = new System.Drawing.Point(427, 285);
            this.btnEditorial.Name = "btnEditorial";
            this.btnEditorial.Size = new System.Drawing.Size(149, 23);
            this.btnEditorial.TabIndex = 6;
            this.btnEditorial.UseVisualStyleBackColor = false;
            this.btnEditorial.Click += new System.EventHandler(this.btnEditorial_Click);
            // 
            // añoDateTimePicker
            // 
            this.añoDateTimePicker.CustomFormat = "yyyy -  MM - dd";
            this.añoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.librosBindingSource, "Año", true));
            this.añoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.añoDateTimePicker.Location = new System.Drawing.Point(156, 121);
            this.añoDateTimePicker.Name = "añoDateTimePicker";
            this.añoDateTimePicker.Size = new System.Drawing.Size(236, 22);
            this.añoDateTimePicker.TabIndex = 2;
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataSource = typeof(AdminLabrary.entidades.Libros);
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "cantidad", true));
            this.cantidadTextBox.Location = new System.Drawing.Point(156, 161);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(236, 22);
            this.cantidadTextBox.TabIndex = 3;
            // 
            // id_autorTextBox
            // 
            this.id_autorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "Id_autor", true));
            this.id_autorTextBox.Enabled = false;
            this.id_autorTextBox.Location = new System.Drawing.Point(398, 205);
            this.id_autorTextBox.Name = "id_autorTextBox";
            this.id_autorTextBox.Size = new System.Drawing.Size(23, 22);
            this.id_autorTextBox.TabIndex = 26;
            // 
            // id_categoriaComboBox
            // 
            this.id_categoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.librosBindingSource, "Id_categoria", true));
            this.id_categoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "Id_categoria", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.id_categoriaComboBox.DataSource = this.categoriasBindingSource;
            this.id_categoriaComboBox.DisplayMember = "Categoria";
            this.id_categoriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_categoriaComboBox.FormattingEnabled = true;
            this.id_categoriaComboBox.Location = new System.Drawing.Point(156, 244);
            this.id_categoriaComboBox.Name = "id_categoriaComboBox";
            this.id_categoriaComboBox.Size = new System.Drawing.Size(236, 24);
            this.id_categoriaComboBox.TabIndex = 5;
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
            this.id_EditorialTextBox.Location = new System.Drawing.Point(398, 285);
            this.id_EditorialTextBox.Name = "id_EditorialTextBox";
            this.id_EditorialTextBox.Size = new System.Drawing.Size(23, 22);
            this.id_EditorialTextBox.TabIndex = 30;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(156, 84);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(236, 22);
            this.nombreTextBox.TabIndex = 1;
            // 
            // numero_edicionTextBox
            // 
            this.numero_edicionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "Numero_edicion", true));
            this.numero_edicionTextBox.Location = new System.Drawing.Point(156, 323);
            this.numero_edicionTextBox.Name = "numero_edicionTextBox";
            this.numero_edicionTextBox.Size = new System.Drawing.Size(236, 22);
            this.numero_edicionTextBox.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(411, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(30, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(546, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // frmInsertarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(623, 414);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
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
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(numero_edicionLabel);
            this.Controls.Add(this.numero_edicionTextBox);
            this.Controls.Add(this.btnEditorial);
            this.Controls.Add(this.btnAutor);
            this.Controls.Add(this.txtEditorial);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.btnGuardar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInsertarLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NUEVO LIBRO";
            this.Load += new System.EventHandler(this.frmInsertarLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.TextBox txtAutor;
        public System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.Button btnAutor;
        private System.Windows.Forms.Button btnEditorial;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private System.Windows.Forms.DateTimePicker añoDateTimePicker;
        private System.Windows.Forms.TextBox cantidadTextBox;
        public System.Windows.Forms.TextBox id_autorTextBox;
        private System.Windows.Forms.ComboBox id_categoriaComboBox;
        public System.Windows.Forms.TextBox id_EditorialTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox numero_edicionTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}