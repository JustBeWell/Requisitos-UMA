namespace WindowsFormsApplication2
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.textBoxSearchby = new System.Windows.Forms.TextBox();
            this.Añadir = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.Button();
            this.Dashboard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Producto = new System.Windows.Forms.Button();
            this.Assets = new System.Windows.Forms.Button();
            this.Categoria = new System.Windows.Forms.Button();
            this.Atributo = new System.Windows.Forms.Button();
            this.Relacion = new System.Windows.Forms.Button();
            this.Ayuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Location = new System.Drawing.Point(66, 134);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductos.Size = new System.Drawing.Size(918, 282);
            this.dataGridViewProductos.TabIndex = 0;
            this.dataGridViewProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductos_CellContentClick);
            // 
            // textBoxSearchby
            // 
            this.textBoxSearchby.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSearchby.Location = new System.Drawing.Point(777, 108);
            this.textBoxSearchby.Name = "textBoxSearchby";
            this.textBoxSearchby.Size = new System.Drawing.Size(207, 20);
            this.textBoxSearchby.TabIndex = 1;
            this.textBoxSearchby.Text = "Search by...";
            this.textBoxSearchby.Click += new System.EventHandler(this.textBoxSearchby_Click);
            this.textBoxSearchby.TextChanged += new System.EventHandler(this.textBoxSearchby_TextChanged);
            this.textBoxSearchby.DoubleClick += new System.EventHandler(this.textBoxSearchby_TextChanged);
            this.textBoxSearchby.Enter += new System.EventHandler(this.textBoxSearchby_Enter);
            this.textBoxSearchby.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearchby_KeyDown);
            // 
            // Añadir
            // 
            this.Añadir.Image = ((System.Drawing.Image)(resources.GetObject("Añadir.Image")));
            this.Añadir.Location = new System.Drawing.Point(66, 435);
            this.Añadir.Name = "Añadir";
            this.Añadir.Size = new System.Drawing.Size(126, 123);
            this.Añadir.TabIndex = 2;
            this.Añadir.Text = "button1";
            this.Añadir.UseVisualStyleBackColor = true;
            this.Añadir.Click += new System.EventHandler(this.Añadir_Click);
            // 
            // Editar
            // 
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.Location = new System.Drawing.Point(217, 435);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(126, 123);
            this.Editar.TabIndex = 3;
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Borrar
            // 
            this.Borrar.Image = ((System.Drawing.Image)(resources.GetObject("Borrar.Image")));
            this.Borrar.Location = new System.Drawing.Point(367, 435);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(126, 123);
            this.Borrar.TabIndex = 4;
            this.Borrar.UseVisualStyleBackColor = true;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // Dashboard
            // 
            this.Dashboard.Location = new System.Drawing.Point(0, 0);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(109, 51);
            this.Dashboard.TabIndex = 6;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.UseVisualStyleBackColor = true;
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
            this.panel1.Location = new System.Drawing.Point(66, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 51);
            this.panel1.TabIndex = 5;
            // 
            // Producto
            // 
            this.Producto.Location = new System.Drawing.Point(107, 0);
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(103, 51);
            this.Producto.TabIndex = 7;
            this.Producto.Text = "Products";
            this.Producto.UseVisualStyleBackColor = true;
            // 
            // Assets
            // 
            this.Assets.Location = new System.Drawing.Point(208, 0);
            this.Assets.Name = "Assets";
            this.Assets.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Assets.Size = new System.Drawing.Size(97, 51);
            this.Assets.TabIndex = 8;
            this.Assets.Text = "Assets";
            this.Assets.UseVisualStyleBackColor = true;
            // 
            // Categoria
            // 
            this.Categoria.Location = new System.Drawing.Point(301, 0);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(109, 51);
            this.Categoria.TabIndex = 9;
            this.Categoria.Text = "Categories";
            this.Categoria.UseVisualStyleBackColor = true;
            this.Categoria.Click += new System.EventHandler(this.Categoria_Click);
            // 
            // Atributo
            // 
            this.Atributo.Location = new System.Drawing.Point(407, 0);
            this.Atributo.Name = "Atributo";
            this.Atributo.Size = new System.Drawing.Size(107, 51);
            this.Atributo.TabIndex = 10;
            this.Atributo.Text = "Attributes";
            this.Atributo.UseVisualStyleBackColor = true;
            this.Atributo.Click += new System.EventHandler(this.Atributo_Click);
            // 
            // Relacion
            // 
            this.Relacion.Location = new System.Drawing.Point(512, 0);
            this.Relacion.Name = "Relacion";
            this.Relacion.Size = new System.Drawing.Size(102, 51);
            this.Relacion.TabIndex = 11;
            this.Relacion.Text = "Relationships";
            this.Relacion.UseVisualStyleBackColor = true;
            // 
            // Ayuda
            // 
            this.Ayuda.Location = new System.Drawing.Point(612, 0);
            this.Ayuda.Name = "Ayuda";
            this.Ayuda.Size = new System.Drawing.Size(108, 51);
            this.Ayuda.TabIndex = 7;
            this.Ayuda.Text = "Help";
            this.Ayuda.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 598);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.Añadir);
            this.Controls.Add(this.textBoxSearchby);
            this.Controls.Add(this.dataGridViewProductos);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.TextBox textBoxSearchby;
        private System.Windows.Forms.Button Añadir;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Ayuda;
        private System.Windows.Forms.Button Relacion;
        private System.Windows.Forms.Button Atributo;
        private System.Windows.Forms.Button Categoria;
        private System.Windows.Forms.Button Assets;
        private System.Windows.Forms.Button Producto;
    }
}

