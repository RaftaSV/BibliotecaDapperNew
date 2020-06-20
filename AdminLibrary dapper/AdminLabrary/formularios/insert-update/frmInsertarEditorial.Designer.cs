namespace AdminLabrary.formularios.insert_update
{
    partial class frmInsertarEditorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsertarEditorial));
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.editorialTextBox = new System.Windows.Forms.TextBox();
            this.fundadaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
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
            direccionLabel.Location = new System.Drawing.Point(41, 227);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(79, 20);
            direccionLabel.TabIndex = 1;
            direccionLabel.Text = "Direccion:";
            // 
            // editorialLabel
            // 
            editorialLabel.AutoSize = true;
            editorialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            editorialLabel.Location = new System.Drawing.Point(41, 196);
            editorialLabel.Name = "editorialLabel";
            editorialLabel.Size = new System.Drawing.Size(70, 20);
            editorialLabel.TabIndex = 3;
            editorialLabel.Text = "Editorial:";
            // 
            // fundadaLabel
            // 
            fundadaLabel.AutoSize = true;
            fundadaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fundadaLabel.Location = new System.Drawing.Point(41, 257);
            fundadaLabel.Name = "fundadaLabel";
            fundadaLabel.Size = new System.Drawing.Size(77, 20);
            fundadaLabel.TabIndex = 5;
            fundadaLabel.Text = "Fundada:";
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.editorialesBindingSource, "Direccion", true));
            this.direccionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionTextBox.Location = new System.Drawing.Point(143, 224);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(280, 26);
            this.direccionTextBox.TabIndex = 2;
            // 
            // editorialTextBox
            // 
            this.editorialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.editorialesBindingSource, "Editorial", true));
            this.editorialTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editorialTextBox.Location = new System.Drawing.Point(143, 190);
            this.editorialTextBox.Name = "editorialTextBox";
            this.editorialTextBox.Size = new System.Drawing.Size(280, 26);
            this.editorialTextBox.TabIndex = 1;
            // 
            // fundadaDateTimePicker
            // 
            this.fundadaDateTimePicker.CustomFormat = "yyyy - MM - dd";
            this.fundadaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.editorialesBindingSource, "Fundada", true));
            this.fundadaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fundadaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fundadaDateTimePicker.Location = new System.Drawing.Point(143, 257);
            this.fundadaDateTimePicker.Name = "fundadaDateTimePicker";
            this.fundadaDateTimePicker.Size = new System.Drawing.Size(280, 26);
            this.fundadaDateTimePicker.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Teal;
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(36, 299);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(387, 27);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(111, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // editorialesBindingSource
            // 
            this.editorialesBindingSource.DataSource = typeof(AdminLabrary.entidades.Editoriales);
            // 
            // frmInsertarEditorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 348);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(editorialLabel);
            this.Controls.Add(this.editorialTextBox);
            this.Controls.Add(fundadaLabel);
            this.Controls.Add(this.fundadaDateTimePicker);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInsertarEditorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NUEVO EDITORIAL";
            this.Load += new System.EventHandler(this.frmInsertarEditorial_Load);
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
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}