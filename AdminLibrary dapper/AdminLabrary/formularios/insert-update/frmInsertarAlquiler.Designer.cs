namespace AdminLabrary.formularios.principales
{
    partial class frmInsertarAlquiler
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
            System.Windows.Forms.Label entregadoLabel;
            System.Windows.Forms.Label id_LectorLabel;
            System.Windows.Forms.Label id_libroLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsertarAlquiler));
            this.entregadoTextBox = new System.Windows.Forms.TextBox();
            this.id_LectorTextBox = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtLector = new System.Windows.Forms.TextBox();
            this.btnSelecLec = new System.Windows.Forms.Button();
            this.btnSelecLIbro = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.id_libroTextBox = new System.Windows.Forms.TextBox();
            this.txtLibro = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.alquileresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            entregadoLabel = new System.Windows.Forms.Label();
            id_LectorLabel = new System.Windows.Forms.Label();
            id_libroLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquileresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // entregadoLabel
            // 
            entregadoLabel.AutoSize = true;
            entregadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            entregadoLabel.Location = new System.Drawing.Point(24, 235);
            entregadoLabel.Name = "entregadoLabel";
            entregadoLabel.Size = new System.Drawing.Size(80, 18);
            entregadoLabel.TabIndex = 1;
            entregadoLabel.Text = "Entregado:";
            // 
            // id_LectorLabel
            // 
            id_LectorLabel.AutoSize = true;
            id_LectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_LectorLabel.Location = new System.Drawing.Point(24, 154);
            id_LectorLabel.Name = "id_LectorLabel";
            id_LectorLabel.Size = new System.Drawing.Size(54, 18);
            id_LectorLabel.TabIndex = 5;
            id_LectorLabel.Text = "Lector:";
            // 
            // id_libroLabel
            // 
            id_libroLabel.AutoSize = true;
            id_libroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_libroLabel.Location = new System.Drawing.Point(24, 197);
            id_libroLabel.Name = "id_libroLabel";
            id_libroLabel.Size = new System.Drawing.Size(45, 18);
            id_libroLabel.TabIndex = 7;
            id_libroLabel.Text = "Libro:";
            // 
            // entregadoTextBox
            // 
            this.entregadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alquileresBindingSource, "Entregado", true));
            this.entregadoTextBox.Enabled = false;
            this.entregadoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entregadoTextBox.Location = new System.Drawing.Point(338, 232);
            this.entregadoTextBox.Name = "entregadoTextBox";
            this.entregadoTextBox.Size = new System.Drawing.Size(67, 24);
            this.entregadoTextBox.TabIndex = 2;
            // 
            // id_LectorTextBox
            // 
            this.id_LectorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alquileresBindingSource, "Id_Lector", true));
            this.id_LectorTextBox.Enabled = false;
            this.id_LectorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_LectorTextBox.Location = new System.Drawing.Point(338, 147);
            this.id_LectorTextBox.Name = "id_LectorTextBox";
            this.id_LectorTextBox.Size = new System.Drawing.Size(67, 24);
            this.id_LectorTextBox.TabIndex = 6;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(127, 232);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(191, 24);
            this.txtUsuario.TabIndex = 9;
            // 
            // txtLector
            // 
            this.txtLector.Enabled = false;
            this.txtLector.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLector.Location = new System.Drawing.Point(127, 148);
            this.txtLector.Name = "txtLector";
            this.txtLector.Size = new System.Drawing.Size(191, 24);
            this.txtLector.TabIndex = 10;
            // 
            // btnSelecLec
            // 
            this.btnSelecLec.BackColor = System.Drawing.Color.Teal;
            this.btnSelecLec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelecLec.BackgroundImage")));
            this.btnSelecLec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelecLec.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnSelecLec.FlatAppearance.BorderSize = 0;
            this.btnSelecLec.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.btnSelecLec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnSelecLec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelecLec.ForeColor = System.Drawing.Color.White;
            this.btnSelecLec.Location = new System.Drawing.Point(444, 149);
            this.btnSelecLec.Name = "btnSelecLec";
            this.btnSelecLec.Size = new System.Drawing.Size(115, 23);
            this.btnSelecLec.TabIndex = 12;
            this.btnSelecLec.UseVisualStyleBackColor = false;
            this.btnSelecLec.Click += new System.EventHandler(this.btnSelecLec_Click);
            // 
            // btnSelecLIbro
            // 
            this.btnSelecLIbro.BackColor = System.Drawing.Color.Teal;
            this.btnSelecLIbro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelecLIbro.BackgroundImage")));
            this.btnSelecLIbro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelecLIbro.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnSelecLIbro.FlatAppearance.BorderSize = 0;
            this.btnSelecLIbro.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.btnSelecLIbro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnSelecLIbro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelecLIbro.ForeColor = System.Drawing.Color.White;
            this.btnSelecLIbro.Location = new System.Drawing.Point(444, 193);
            this.btnSelecLIbro.Name = "btnSelecLIbro";
            this.btnSelecLIbro.Size = new System.Drawing.Size(115, 23);
            this.btnSelecLIbro.TabIndex = 13;
            this.btnSelecLIbro.UseVisualStyleBackColor = false;
            this.btnSelecLIbro.Click += new System.EventHandler(this.btnSelecLIbro_Click);
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
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(27, 272);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(532, 39);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // id_libroTextBox
            // 
            this.id_libroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alquileresBindingSource, "Id_libro", true));
            this.id_libroTextBox.Enabled = false;
            this.id_libroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_libroTextBox.Location = new System.Drawing.Point(338, 191);
            this.id_libroTextBox.Name = "id_libroTextBox";
            this.id_libroTextBox.Size = new System.Drawing.Size(67, 24);
            this.id_libroTextBox.TabIndex = 15;
            // 
            // txtLibro
            // 
            this.txtLibro.Enabled = false;
            this.txtLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLibro.Location = new System.Drawing.Point(127, 191);
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.Size = new System.Drawing.Size(191, 24);
            this.txtLibro.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(630, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(27, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(864, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // alquileresBindingSource
            // 
            this.alquileresBindingSource.DataSource = typeof(AdminLabrary.entidades.Alquileres);
            // 
            // frmInsertarAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(903, 328);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtLibro);
            this.Controls.Add(this.id_libroTextBox);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSelecLIbro);
            this.Controls.Add(this.btnSelecLec);
            this.Controls.Add(this.txtLector);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(entregadoLabel);
            this.Controls.Add(this.entregadoTextBox);
            this.Controls.Add(id_LectorLabel);
            this.Controls.Add(this.id_LectorTextBox);
            this.Controls.Add(id_libroLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInsertarAlquiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NUEVO PRESTAMO";
            this.Load += new System.EventHandler(this.frmInsertarAlquiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquileresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource alquileresBindingSource;
        public System.Windows.Forms.TextBox entregadoTextBox;
        public System.Windows.Forms.TextBox id_LectorTextBox;
        public System.Windows.Forms.TextBox txtUsuario;
        public System.Windows.Forms.TextBox txtLector;
        private System.Windows.Forms.Button btnSelecLec;
        private System.Windows.Forms.Button btnSelecLIbro;
        private System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.TextBox id_libroTextBox;
        public System.Windows.Forms.TextBox txtLibro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}