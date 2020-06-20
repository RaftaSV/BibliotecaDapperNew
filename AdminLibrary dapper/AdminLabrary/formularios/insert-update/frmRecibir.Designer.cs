namespace AdminLabrary.formularios.principales
{
    partial class frmRecibir
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
            System.Windows.Forms.Label id_LectorLabel;
            System.Windows.Forms.Label id_libroLabel;
            System.Windows.Forms.Label recibidoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecibir));
            this.txtLibro = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtLector = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.recibirTextBox = new System.Windows.Forms.TextBox();
            this.alquileresPendientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            id_LectorLabel = new System.Windows.Forms.Label();
            id_libroLabel = new System.Windows.Forms.Label();
            recibidoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.alquileresPendientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // id_LectorLabel
            // 
            id_LectorLabel.AutoSize = true;
            id_LectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_LectorLabel.Location = new System.Drawing.Point(25, 157);
            id_LectorLabel.Name = "id_LectorLabel";
            id_LectorLabel.Size = new System.Drawing.Size(54, 18);
            id_LectorLabel.TabIndex = 18;
            id_LectorLabel.Text = "Lector:";
            // 
            // id_libroLabel
            // 
            id_libroLabel.AutoSize = true;
            id_libroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_libroLabel.Location = new System.Drawing.Point(25, 200);
            id_libroLabel.Name = "id_libroLabel";
            id_libroLabel.Size = new System.Drawing.Size(45, 18);
            id_libroLabel.TabIndex = 19;
            id_libroLabel.Text = "Libro:";
            // 
            // recibidoLabel
            // 
            recibidoLabel.AutoSize = true;
            recibidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            recibidoLabel.Location = new System.Drawing.Point(24, 239);
            recibidoLabel.Name = "recibidoLabel";
            recibidoLabel.Size = new System.Drawing.Size(75, 20);
            recibidoLabel.TabIndex = 24;
            recibidoLabel.Text = "Recibido:";
            // 
            // txtLibro
            // 
            this.txtLibro.Enabled = false;
            this.txtLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLibro.Location = new System.Drawing.Point(128, 194);
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.Size = new System.Drawing.Size(191, 24);
            this.txtLibro.TabIndex = 23;
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
            this.btnGuardar.Location = new System.Drawing.Point(28, 275);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(492, 31);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtLector
            // 
            this.txtLector.Enabled = false;
            this.txtLector.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLector.Location = new System.Drawing.Point(128, 151);
            this.txtLector.Name = "txtLector";
            this.txtLector.Size = new System.Drawing.Size(191, 24);
            this.txtLector.TabIndex = 21;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(128, 235);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(191, 24);
            this.txtUsuario.TabIndex = 20;
            // 
            // recibirTextBox
            // 
            this.recibirTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alquileresPendientesBindingSource, "Recibir", true));
            this.recibirTextBox.Enabled = false;
            this.recibirTextBox.Location = new System.Drawing.Point(351, 235);
            this.recibirTextBox.Multiline = true;
            this.recibirTextBox.Name = "recibirTextBox";
            this.recibirTextBox.Size = new System.Drawing.Size(77, 24);
            this.recibirTextBox.TabIndex = 26;
            // 
            // alquileresPendientesBindingSource
            // 
            this.alquileresPendientesBindingSource.DataSource = typeof(AdminLabrary.entidades.AlquileresPendientes);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(375, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(28, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(492, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // frmRecibir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 318);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.recibirTextBox);
            this.Controls.Add(recibidoLabel);
            this.Controls.Add(this.txtLibro);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtLector);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(id_LectorLabel);
            this.Controls.Add(id_libroLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRecibir";
            this.Text = "RECIBIR";
            this.Load += new System.EventHandler(this.frmRecibir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alquileresPendientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtLibro;
        private System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.TextBox txtLector;
        public System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.BindingSource alquileresPendientesBindingSource;
        private System.Windows.Forms.TextBox recibirTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}