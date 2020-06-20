namespace AdminLabrary.formularios.insert_update
{
    partial class frmActualizarEditorial
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
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label editorialLabel;
            System.Windows.Forms.Label fundadaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActualizarEditorial));
            this.btnActualizareditorial = new System.Windows.Forms.Button();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.editorialTextBox = new System.Windows.Forms.TextBox();
            this.fundadaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.editorialesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            direccionLabel = new System.Windows.Forms.Label();
            editorialLabel = new System.Windows.Forms.Label();
            fundadaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorialesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direccionLabel.Location = new System.Drawing.Point(28, 249);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(79, 20);
            direccionLabel.TabIndex = 8;
            direccionLabel.Text = "Direccion:";
            // 
            // editorialLabel
            // 
            editorialLabel.AutoSize = true;
            editorialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            editorialLabel.Location = new System.Drawing.Point(28, 218);
            editorialLabel.Name = "editorialLabel";
            editorialLabel.Size = new System.Drawing.Size(70, 20);
            editorialLabel.TabIndex = 11;
            editorialLabel.Text = "Editorial:";
            // 
            // fundadaLabel
            // 
            fundadaLabel.AutoSize = true;
            fundadaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fundadaLabel.Location = new System.Drawing.Point(28, 279);
            fundadaLabel.Name = "fundadaLabel";
            fundadaLabel.Size = new System.Drawing.Size(77, 20);
            fundadaLabel.TabIndex = 13;
            fundadaLabel.Text = "Fundada:";
            // 
            // btnActualizareditorial
            // 
            this.btnActualizareditorial.BackColor = System.Drawing.Color.Teal;
            this.btnActualizareditorial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizareditorial.BackgroundImage")));
            this.btnActualizareditorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizareditorial.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnActualizareditorial.FlatAppearance.BorderSize = 0;
            this.btnActualizareditorial.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.btnActualizareditorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnActualizareditorial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizareditorial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizareditorial.ForeColor = System.Drawing.Color.White;
            this.btnActualizareditorial.Location = new System.Drawing.Point(32, 325);
            this.btnActualizareditorial.Name = "btnActualizareditorial";
            this.btnActualizareditorial.Size = new System.Drawing.Size(298, 30);
            this.btnActualizareditorial.TabIndex = 7;
            this.btnActualizareditorial.UseVisualStyleBackColor = false;
            this.btnActualizareditorial.Click += new System.EventHandler(this.button1_Click);
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.editorialesBindingSource, "Direccion", true));
            this.direccionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionTextBox.Location = new System.Drawing.Point(130, 246);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(200, 26);
            this.direccionTextBox.TabIndex = 10;
            // 
            // editorialTextBox
            // 
            this.editorialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.editorialesBindingSource, "Editorial", true));
            this.editorialTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editorialTextBox.Location = new System.Drawing.Point(130, 212);
            this.editorialTextBox.Name = "editorialTextBox";
            this.editorialTextBox.Size = new System.Drawing.Size(200, 26);
            this.editorialTextBox.TabIndex = 9;
            // 
            // fundadaDateTimePicker
            // 
            this.fundadaDateTimePicker.CustomFormat = "yyyy - MM - dd";
            this.fundadaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.editorialesBindingSource, "Fundada", true));
            this.fundadaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fundadaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fundadaDateTimePicker.Location = new System.Drawing.Point(130, 279);
            this.fundadaDateTimePicker.Name = "fundadaDateTimePicker";
            this.fundadaDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.fundadaDateTimePicker.TabIndex = 12;
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
            this.btnEliminar.Location = new System.Drawing.Point(32, 361);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(298, 30);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // editorialesBindingSource
            // 
            this.editorialesBindingSource.DataSource = typeof(AdminLabrary.entidades.Editoriales);
            // 
            // frmActualizarEditorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(358, 402);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(editorialLabel);
            this.Controls.Add(this.editorialTextBox);
            this.Controls.Add(fundadaLabel);
            this.Controls.Add(this.fundadaDateTimePicker);
            this.Controls.Add(this.btnActualizareditorial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmActualizarEditorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACTUALIZAR - ELIMINAR - EDITORIAL";
            this.Load += new System.EventHandler(this.FrmActualizarEditorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorialesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource editorialesBindingSource;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox editorialTextBox;
        private System.Windows.Forms.DateTimePicker fundadaDateTimePicker;
        public System.Windows.Forms.Button btnActualizareditorial;
        public System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}