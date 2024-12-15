namespace WindowsFormsApplication2
{
    partial class MostrarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarProducto));
            this.textBoxSKU = new System.Windows.Forms.TextBox();
            this.Salir = new System.Windows.Forms.Button();
            this.Categorias = new System.Windows.Forms.ComboBox();
            this.textBoxLabel = new System.Windows.Forms.TextBox();
            this.textBoxU1 = new System.Windows.Forms.TextBox();
            this.textBoxU2 = new System.Windows.Forms.TextBox();
            this.textBoxU5 = new System.Windows.Forms.TextBox();
            this.textBoxU4 = new System.Windows.Forms.TextBox();
            this.textBoxU3 = new System.Windows.Forms.TextBox();
            this.textBoxGTIN = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Upload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxProductos = new System.Windows.Forms.ListBox();
            this.listBoxRelaciones = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSKU
            // 
            this.textBoxSKU.Enabled = false;
            this.textBoxSKU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxSKU.Location = new System.Drawing.Point(313, 70);
            this.textBoxSKU.Name = "textBoxSKU";
            this.textBoxSKU.ReadOnly = true;
            this.textBoxSKU.Size = new System.Drawing.Size(258, 23);
            this.textBoxSKU.TabIndex = 67;
            this.textBoxSKU.Text = "SKU";
            // 
            // Salir
            // 
            this.Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Salir.Location = new System.Drawing.Point(345, 493);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(176, 98);
            this.Salir.TabIndex = 66;
            this.Salir.Text = "EXIT";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click_1);
            // 
            // Categorias
            // 
            this.Categorias.Enabled = false;
            this.Categorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Categorias.FormattingEnabled = true;
            this.Categorias.Location = new System.Drawing.Point(313, 355);
            this.Categorias.Name = "Categorias";
            this.Categorias.Size = new System.Drawing.Size(258, 24);
            this.Categorias.TabIndex = 65;
            this.Categorias.SelectedIndexChanged += new System.EventHandler(this.Categorias_SelectedIndexChanged);
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.Enabled = false;
            this.textBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxLabel.Location = new System.Drawing.Point(313, 107);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.ReadOnly = true;
            this.textBoxLabel.Size = new System.Drawing.Size(258, 23);
            this.textBoxLabel.TabIndex = 56;
            this.textBoxLabel.Text = "Label";
            // 
            // textBoxU1
            // 
            this.textBoxU1.Enabled = false;
            this.textBoxU1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxU1.Location = new System.Drawing.Point(313, 148);
            this.textBoxU1.Name = "textBoxU1";
            this.textBoxU1.ReadOnly = true;
            this.textBoxU1.Size = new System.Drawing.Size(258, 23);
            this.textBoxU1.TabIndex = 55;
            this.textBoxU1.TextChanged += new System.EventHandler(this.textBoxU1_TextChanged);
            // 
            // textBoxU2
            // 
            this.textBoxU2.Enabled = false;
            this.textBoxU2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxU2.Location = new System.Drawing.Point(313, 191);
            this.textBoxU2.Name = "textBoxU2";
            this.textBoxU2.ReadOnly = true;
            this.textBoxU2.Size = new System.Drawing.Size(258, 23);
            this.textBoxU2.TabIndex = 54;
            // 
            // textBoxU5
            // 
            this.textBoxU5.Enabled = false;
            this.textBoxU5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxU5.Location = new System.Drawing.Point(313, 314);
            this.textBoxU5.Name = "textBoxU5";
            this.textBoxU5.ReadOnly = true;
            this.textBoxU5.Size = new System.Drawing.Size(258, 23);
            this.textBoxU5.TabIndex = 53;
            // 
            // textBoxU4
            // 
            this.textBoxU4.Enabled = false;
            this.textBoxU4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxU4.Location = new System.Drawing.Point(313, 272);
            this.textBoxU4.Name = "textBoxU4";
            this.textBoxU4.ReadOnly = true;
            this.textBoxU4.Size = new System.Drawing.Size(258, 23);
            this.textBoxU4.TabIndex = 52;
            // 
            // textBoxU3
            // 
            this.textBoxU3.Enabled = false;
            this.textBoxU3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxU3.Location = new System.Drawing.Point(313, 232);
            this.textBoxU3.Name = "textBoxU3";
            this.textBoxU3.ReadOnly = true;
            this.textBoxU3.Size = new System.Drawing.Size(258, 23);
            this.textBoxU3.TabIndex = 51;
            // 
            // textBoxGTIN
            // 
            this.textBoxGTIN.Enabled = false;
            this.textBoxGTIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxGTIN.Location = new System.Drawing.Point(313, 33);
            this.textBoxGTIN.Name = "textBoxGTIN";
            this.textBoxGTIN.ReadOnly = true;
            this.textBoxGTIN.Size = new System.Drawing.Size(258, 23);
            this.textBoxGTIN.TabIndex = 50;
            this.textBoxGTIN.Text = "GTIN";
            this.textBoxGTIN.TextChanged += new System.EventHandler(this.textBoxGTIN_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 265);
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // Upload
            // 
            this.Upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Upload.Location = new System.Drawing.Point(37, 302);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(176, 39);
            this.Upload.TabIndex = 48;
            this.Upload.Text = "Upload Asset";
            this.Upload.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "labelThumbnail";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBoxProductos
            // 
            this.listBoxProductos.FormattingEnabled = true;
            this.listBoxProductos.Location = new System.Drawing.Point(313, 444);
            this.listBoxProductos.Name = "listBoxProductos";
            this.listBoxProductos.Size = new System.Drawing.Size(258, 43);
            this.listBoxProductos.TabIndex = 69;
            // 
            // listBoxRelaciones
            // 
            this.listBoxRelaciones.FormattingEnabled = true;
            this.listBoxRelaciones.Location = new System.Drawing.Point(313, 392);
            this.listBoxRelaciones.Name = "listBoxRelaciones";
            this.listBoxRelaciones.Size = new System.Drawing.Size(258, 30);
            this.listBoxRelaciones.TabIndex = 70;
            this.listBoxRelaciones.SelectedIndexChanged += new System.EventHandler(this.listBoxRelaciones_SelectedIndexChanged);
            // 
            // MostrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 539);
            this.Controls.Add(this.listBoxRelaciones);
            this.Controls.Add(this.listBoxProductos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSKU);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Categorias);
            this.Controls.Add(this.textBoxLabel);
            this.Controls.Add(this.textBoxU1);
            this.Controls.Add(this.textBoxU2);
            this.Controls.Add(this.textBoxU5);
            this.Controls.Add(this.textBoxU4);
            this.Controls.Add(this.textBoxU3);
            this.Controls.Add(this.textBoxGTIN);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Upload);
            this.Name = "MostrarProducto";
            this.Load += new System.EventHandler(this.MostrarProducto_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSKU;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.ComboBox Categorias;
        private System.Windows.Forms.TextBox textBoxLabel;
        private System.Windows.Forms.TextBox textBoxU1;
        private System.Windows.Forms.TextBox textBoxU2;
        private System.Windows.Forms.TextBox textBoxU5;
        private System.Windows.Forms.TextBox textBoxU4;
        private System.Windows.Forms.TextBox textBoxU3;
        private System.Windows.Forms.TextBox textBoxGTIN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxProductos;
        private System.Windows.Forms.ListBox listBoxRelaciones;
    }
}