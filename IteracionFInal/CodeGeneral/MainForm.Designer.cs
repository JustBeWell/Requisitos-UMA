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
            this.Dashboard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Ayuda = new System.Windows.Forms.Button();
            this.Relacion = new System.Windows.Forms.Button();
            this.Atributo = new System.Windows.Forms.Button();
            this.Categoria = new System.Windows.Forms.Button();
            this.Assets = new System.Windows.Forms.Button();
            this.Producto = new System.Windows.Forms.Button();
            this.labelProductoCount = new System.Windows.Forms.Label();
            this.Borrar = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.Añadir = new System.Windows.Forms.Button();
            this.comboBoxCategoryFilter = new System.Windows.Forms.ComboBox();
            this.checkBoxClearFilter = new System.Windows.Forms.CheckBox();
            this.btnClearFilter = new System.Windows.Forms.Button();
<<<<<<< Updated upstream:IteracionFInal/CodeGeneral/MainForm.Designer.cs
            this.Cuenta = new WindowsFormsApplication2.RoundButton();
=======
            this.btnCSV = new System.Windows.Forms.Button();
>>>>>>> Stashed changes:IteracionFInal/CodeAngel/MainForm.Designer.cs
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Location = new System.Drawing.Point(121, 247);
            this.dataGridViewProductos.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductos.Size = new System.Drawing.Size(1683, 521);
            this.dataGridViewProductos.TabIndex = 0;
            this.dataGridViewProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductos_CellContentClick);
            this.dataGridViewProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductos_CellDoubleClick);
            // 
            // textBoxSearchby
            // 
            this.textBoxSearchby.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSearchby.Location = new System.Drawing.Point(1425, 199);
            this.textBoxSearchby.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxSearchby.Name = "textBoxSearchby";
            this.textBoxSearchby.Size = new System.Drawing.Size(376, 29);
            this.textBoxSearchby.TabIndex = 1;
            this.textBoxSearchby.Text = "Search by...";
            this.textBoxSearchby.Click += new System.EventHandler(this.textBoxSearchby_Click);
            this.textBoxSearchby.TextChanged += new System.EventHandler(this.textBoxSearchby_TextChanged);
            this.textBoxSearchby.DoubleClick += new System.EventHandler(this.textBoxSearchby_TextChanged);
            this.textBoxSearchby.Enter += new System.EventHandler(this.textBoxSearchby_Enter);
            this.textBoxSearchby.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearchby_KeyDown);
            // 
            // Dashboard
            // 
            this.Dashboard.Location = new System.Drawing.Point(26, 22);
            this.Dashboard.Margin = new System.Windows.Forms.Padding(6);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(139, 46);
            this.Dashboard.TabIndex = 6;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.UseVisualStyleBackColor = true;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
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
            this.panel1.Location = new System.Drawing.Point(121, 109);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 94);
            this.panel1.TabIndex = 5;
            // 
            // Ayuda
            // 
            this.Ayuda.Location = new System.Drawing.Point(873, 22);
            this.Ayuda.Margin = new System.Windows.Forms.Padding(6);
            this.Ayuda.Name = "Ayuda";
            this.Ayuda.Size = new System.Drawing.Size(121, 46);
            this.Ayuda.TabIndex = 7;
            this.Ayuda.Text = "Help";
            this.Ayuda.UseVisualStyleBackColor = true;
            this.Ayuda.Click += new System.EventHandler(this.Ayuda_Click);
            // 
            // Relacion
            // 
            this.Relacion.Location = new System.Drawing.Point(711, 22);
            this.Relacion.Margin = new System.Windows.Forms.Padding(6);
            this.Relacion.Name = "Relacion";
            this.Relacion.Size = new System.Drawing.Size(150, 46);
            this.Relacion.TabIndex = 11;
            this.Relacion.Text = "Relationships";
            this.Relacion.UseVisualStyleBackColor = true;
            this.Relacion.Click += new System.EventHandler(this.Relacion_Click);
            // 
            // Atributo
            // 
            this.Atributo.Location = new System.Drawing.Point(568, 22);
            this.Atributo.Margin = new System.Windows.Forms.Padding(6);
            this.Atributo.Name = "Atributo";
            this.Atributo.Size = new System.Drawing.Size(132, 46);
            this.Atributo.TabIndex = 10;
            this.Atributo.Text = "Attributes";
            this.Atributo.UseVisualStyleBackColor = true;
            this.Atributo.Click += new System.EventHandler(this.Atributo_Click);
            // 
            // Categoria
            // 
            this.Categoria.Location = new System.Drawing.Point(425, 22);
            this.Categoria.Margin = new System.Windows.Forms.Padding(6);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(132, 46);
            this.Categoria.TabIndex = 9;
            this.Categoria.Text = "Categories";
            this.Categoria.UseVisualStyleBackColor = true;
            this.Categoria.Click += new System.EventHandler(this.Categoria_Click);
            // 
            // Assets
            // 
            this.Assets.Location = new System.Drawing.Point(306, 22);
            this.Assets.Margin = new System.Windows.Forms.Padding(6);
            this.Assets.Name = "Assets";
            this.Assets.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Assets.Size = new System.Drawing.Size(108, 46);
            this.Assets.TabIndex = 8;
            this.Assets.Text = "Assets";
            this.Assets.UseVisualStyleBackColor = true;
            // 
            // Producto
            // 
            this.Producto.Location = new System.Drawing.Point(176, 22);
            this.Producto.Margin = new System.Windows.Forms.Padding(6);
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(119, 46);
            this.Producto.TabIndex = 7;
            this.Producto.Text = "Products";
            this.Producto.UseVisualStyleBackColor = true;
            this.Producto.Click += new System.EventHandler(this.Producto_Click);
            // 
            // labelProductoCount
            // 
            this.labelProductoCount.AutoSize = true;
            this.labelProductoCount.Location = new System.Drawing.Point(116, 212);
            this.labelProductoCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelProductoCount.Name = "labelProductoCount";
            this.labelProductoCount.Size = new System.Drawing.Size(174, 25);
            this.labelProductoCount.TabIndex = 6;
            this.labelProductoCount.Text = "labelTotalProducts";
            this.labelProductoCount.Click += new System.EventHandler(this.labelProductoCount_Click);
            // 
            // Borrar
            // 
            this.Borrar.Image = ((System.Drawing.Image)(resources.GetObject("Borrar.Image")));
            this.Borrar.Location = new System.Drawing.Point(673, 803);
            this.Borrar.Margin = new System.Windows.Forms.Padding(6);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(231, 227);
            this.Borrar.TabIndex = 4;
            this.Borrar.UseVisualStyleBackColor = true;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // Editar
            // 
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.Location = new System.Drawing.Point(398, 803);
            this.Editar.Margin = new System.Windows.Forms.Padding(6);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(231, 227);
            this.Editar.TabIndex = 3;
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Añadir
            // 
            this.Añadir.Image = ((System.Drawing.Image)(resources.GetObject("Añadir.Image")));
            this.Añadir.Location = new System.Drawing.Point(121, 803);
            this.Añadir.Margin = new System.Windows.Forms.Padding(6);
            this.Añadir.Name = "Añadir";
            this.Añadir.Size = new System.Drawing.Size(231, 227);
            this.Añadir.TabIndex = 2;
            this.Añadir.Text = "button1";
            this.Añadir.UseVisualStyleBackColor = true;
            this.Añadir.Click += new System.EventHandler(this.Añadir_Click);
            // 
            // comboBoxCategoryFilter
            // 
            this.comboBoxCategoryFilter.FormattingEnabled = true;
            this.comboBoxCategoryFilter.Location = new System.Drawing.Point(977, 844);
            this.comboBoxCategoryFilter.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxCategoryFilter.Name = "comboBoxCategoryFilter";
            this.comboBoxCategoryFilter.Size = new System.Drawing.Size(303, 32);
            this.comboBoxCategoryFilter.TabIndex = 8;
            this.comboBoxCategoryFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategoryFilter_SelectedIndexChanged);
            // 
            // checkBoxClearFilter
            // 
            this.checkBoxClearFilter.AutoSize = true;
            this.checkBoxClearFilter.Location = new System.Drawing.Point(977, 801);
            this.checkBoxClearFilter.Margin = new System.Windows.Forms.Padding(6);
            this.checkBoxClearFilter.Name = "checkBoxClearFilter";
            this.checkBoxClearFilter.Size = new System.Drawing.Size(186, 29);
            this.checkBoxClearFilter.TabIndex = 9;
            this.checkBoxClearFilter.Text = "FILTER ON/OFF";
            this.checkBoxClearFilter.UseVisualStyleBackColor = true;
            this.checkBoxClearFilter.CheckedChanged += new System.EventHandler(this.checkBoxClearFilter_CheckedChanged);
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Location = new System.Drawing.Point(988, 925);
            this.btnClearFilter.Margin = new System.Windows.Forms.Padding(6);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(293, 72);
            this.btnClearFilter.TabIndex = 10;
            this.btnClearFilter.TabStop = false;
            this.btnClearFilter.Text = "CLEAR";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
<<<<<<< Updated upstream:IteracionFInal/CodeGeneral/MainForm.Designer.cs
            // Cuenta
            // 
            this.Cuenta.Image = ((System.Drawing.Image)(resources.GetObject("Cuenta.Image")));
            this.Cuenta.Location = new System.Drawing.Point(1750, 40);
            this.Cuenta.Margin = new System.Windows.Forms.Padding(4);
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.Size = new System.Drawing.Size(109, 106);
            this.Cuenta.TabIndex = 29;
            this.Cuenta.UseVisualStyleBackColor = true;
            this.Cuenta.Click += new System.EventHandler(this.Cuenta_Click);
=======
            // btnCSV
            // 
            this.btnCSV.Location = new System.Drawing.Point(868, 424);
            this.btnCSV.Name = "btnCSV";
            this.btnCSV.Size = new System.Drawing.Size(116, 35);
            this.btnCSV.TabIndex = 11;
            this.btnCSV.Text = "CSV";
            this.btnCSV.UseVisualStyleBackColor = true;
            this.btnCSV.Click += new System.EventHandler(this.btnCSV_Click);
>>>>>>> Stashed changes:IteracionFInal/CodeAngel/MainForm.Designer.cs
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< Updated upstream:IteracionFInal/CodeGeneral/MainForm.Designer.cs
            this.ClientSize = new System.Drawing.Size(2044, 1137);
            this.Controls.Add(this.Cuenta);
=======
            this.ClientSize = new System.Drawing.Size(1115, 616);
            this.Controls.Add(this.btnCSV);
>>>>>>> Stashed changes:IteracionFInal/CodeAngel/MainForm.Designer.cs
            this.Controls.Add(this.btnClearFilter);
            this.Controls.Add(this.checkBoxClearFilter);
            this.Controls.Add(this.comboBoxCategoryFilter);
            this.Controls.Add(this.labelProductoCount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.Añadir);
            this.Controls.Add(this.textBoxSearchby);
            this.Controls.Add(this.dataGridViewProductos);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MiniPIM";
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
        private System.Windows.Forms.Label labelProductoCount;
        private System.Windows.Forms.ComboBox comboBoxCategoryFilter;
        private System.Windows.Forms.CheckBox checkBoxClearFilter;
        private System.Windows.Forms.Button btnClearFilter;
<<<<<<< Updated upstream:IteracionFInal/CodeGeneral/MainForm.Designer.cs
        private RoundButton Cuenta;
=======
        private System.Windows.Forms.Button btnCSV;
>>>>>>> Stashed changes:IteracionFInal/CodeAngel/MainForm.Designer.cs
    }
}

