namespace WindowsFormsApplication2
{
    partial class CuentaMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuentaMain));
            this.buttonJSON = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxRelations = new System.Windows.Forms.TextBox();
            this.textBoxUA = new System.Windows.Forms.TextBox();
            this.textBoxCategories = new System.Windows.Forms.TextBox();
            this.textBoxProducts = new System.Windows.Forms.TextBox();
            this.labelProductoCount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Ayuda = new System.Windows.Forms.Button();
            this.Relacion = new System.Windows.Forms.Button();
            this.Atributo = new System.Windows.Forms.Button();
            this.Categoria = new System.Windows.Forms.Button();
            this.Assets = new System.Windows.Forms.Button();
            this.Producto = new System.Windows.Forms.Button();
            this.Dashboard = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonJSON
            // 
            this.buttonJSON.Location = new System.Drawing.Point(56, 340);
            this.buttonJSON.Name = "buttonJSON";
            this.buttonJSON.Size = new System.Drawing.Size(119, 23);
            this.buttonJSON.TabIndex = 0;
            this.buttonJSON.Text = "Export JSON";
            this.buttonJSON.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Account Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date and time of account creation:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of products of the account";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Number of products categories created:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Number of user attributes created:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Number of relationships created:";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Enabled = false;
            this.textBoxDate.Location = new System.Drawing.Point(433, 207);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxDate.TabIndex = 8;
            // 
            // textBoxRelations
            // 
            this.textBoxRelations.Enabled = false;
            this.textBoxRelations.Location = new System.Drawing.Point(433, 338);
            this.textBoxRelations.Name = "textBoxRelations";
            this.textBoxRelations.Size = new System.Drawing.Size(100, 20);
            this.textBoxRelations.TabIndex = 9;
            // 
            // textBoxUA
            // 
            this.textBoxUA.Enabled = false;
            this.textBoxUA.Location = new System.Drawing.Point(433, 309);
            this.textBoxUA.Name = "textBoxUA";
            this.textBoxUA.Size = new System.Drawing.Size(100, 20);
            this.textBoxUA.TabIndex = 10;
            // 
            // textBoxCategories
            // 
            this.textBoxCategories.Enabled = false;
            this.textBoxCategories.Location = new System.Drawing.Point(433, 274);
            this.textBoxCategories.Name = "textBoxCategories";
            this.textBoxCategories.Size = new System.Drawing.Size(100, 20);
            this.textBoxCategories.TabIndex = 11;
            // 
            // textBoxProducts
            // 
            this.textBoxProducts.Enabled = false;
            this.textBoxProducts.Location = new System.Drawing.Point(433, 241);
            this.textBoxProducts.Name = "textBoxProducts";
            this.textBoxProducts.Size = new System.Drawing.Size(100, 20);
            this.textBoxProducts.TabIndex = 12;
            // 
            // labelProductoCount
            // 
            this.labelProductoCount.AutoSize = true;
            this.labelProductoCount.Location = new System.Drawing.Point(70, 298);
            this.labelProductoCount.Name = "labelProductoCount";
            this.labelProductoCount.Size = new System.Drawing.Size(95, 13);
            this.labelProductoCount.TabIndex = 14;
            this.labelProductoCount.Text = "labelTotalProducts";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Ayuda);
            this.panel1.Controls.Add(this.Relacion);
            this.panel1.Controls.Add(this.Atributo);
            this.panel1.Controls.Add(this.Categoria);
            this.panel1.Controls.Add(this.Assets);
            this.panel1.Controls.Add(this.Producto);
            this.panel1.Controls.Add(this.Dashboard);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 51);
            this.panel1.TabIndex = 13;
            // 
            // Ayuda
            // 
            this.Ayuda.Location = new System.Drawing.Point(476, 12);
            this.Ayuda.Name = "Ayuda";
            this.Ayuda.Size = new System.Drawing.Size(66, 25);
            this.Ayuda.TabIndex = 7;
            this.Ayuda.Text = "Help";
            this.Ayuda.UseVisualStyleBackColor = true;
            // 
            // Relacion
            // 
            this.Relacion.Location = new System.Drawing.Point(388, 12);
            this.Relacion.Name = "Relacion";
            this.Relacion.Size = new System.Drawing.Size(82, 25);
            this.Relacion.TabIndex = 11;
            this.Relacion.Text = "Relationships";
            this.Relacion.UseVisualStyleBackColor = true;
            this.Relacion.Click += new System.EventHandler(this.Relacion_Click);
            // 
            // Atributo
            // 
            this.Atributo.Location = new System.Drawing.Point(310, 12);
            this.Atributo.Name = "Atributo";
            this.Atributo.Size = new System.Drawing.Size(72, 25);
            this.Atributo.TabIndex = 10;
            this.Atributo.Text = "Attributes";
            this.Atributo.UseVisualStyleBackColor = true;
            this.Atributo.Click += new System.EventHandler(this.Atributo_Click);
            // 
            // Categoria
            // 
            this.Categoria.Location = new System.Drawing.Point(232, 12);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(72, 25);
            this.Categoria.TabIndex = 9;
            this.Categoria.Text = "Categories";
            this.Categoria.UseVisualStyleBackColor = true;
            this.Categoria.Click += new System.EventHandler(this.Categoria_Click);
            // 
            // Assets
            // 
            this.Assets.Location = new System.Drawing.Point(167, 12);
            this.Assets.Name = "Assets";
            this.Assets.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Assets.Size = new System.Drawing.Size(59, 25);
            this.Assets.TabIndex = 8;
            this.Assets.Text = "Assets";
            this.Assets.UseVisualStyleBackColor = true;
            // 
            // Producto
            // 
            this.Producto.Location = new System.Drawing.Point(96, 12);
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(65, 25);
            this.Producto.TabIndex = 7;
            this.Producto.Text = "Products";
            this.Producto.UseVisualStyleBackColor = true;
            this.Producto.Click += new System.EventHandler(this.Producto_Click);
            // 
            // Dashboard
            // 
            this.Dashboard.Location = new System.Drawing.Point(14, 12);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(76, 25);
            this.Dashboard.TabIndex = 6;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(675, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 72);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(45, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 197);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // CuentaMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 472);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelProductoCount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxProducts);
            this.Controls.Add(this.textBoxCategories);
            this.Controls.Add(this.textBoxUA);
            this.Controls.Add(this.textBoxRelations);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonJSON);
            this.Name = "CuentaMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CuentaMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonJSON;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxRelations;
        private System.Windows.Forms.TextBox textBoxUA;
        private System.Windows.Forms.TextBox textBoxCategories;
        private System.Windows.Forms.TextBox textBoxProducts;
        private System.Windows.Forms.Label labelProductoCount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Ayuda;
        private System.Windows.Forms.Button Relacion;
        private System.Windows.Forms.Button Atributo;
        private System.Windows.Forms.Button Categoria;
        private System.Windows.Forms.Button Assets;
        private System.Windows.Forms.Button Producto;
        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.Button button1;
    }
}