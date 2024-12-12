namespace WindowsFormsApplication2
{
    partial class AtributoMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtributoMain));
            this.label_AvailableAttributes = new System.Windows.Forms.Label();
            this.label_UserAttributes = new System.Windows.Forms.Label();
            this.dataGridViewAtributos = new System.Windows.Forms.DataGridView();
            this.tipoAtributoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Ayuda = new System.Windows.Forms.Button();
            this.Dashboard = new System.Windows.Forms.Button();
            this.Producto = new System.Windows.Forms.Button();
            this.Relacion = new System.Windows.Forms.Button();
            this.Assets = new System.Windows.Forms.Button();
            this.Categoria = new System.Windows.Forms.Button();
            this.Atributo = new System.Windows.Forms.Button();
            this.tipoAtributoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_AñadirAtributo = new WindowsFormsApplication2.RoundButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAtributos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoAtributoBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoAtributoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label_AvailableAttributes
            // 
            this.label_AvailableAttributes.AutoSize = true;
            this.label_AvailableAttributes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AvailableAttributes.Location = new System.Drawing.Point(591, 221);
            this.label_AvailableAttributes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_AvailableAttributes.Name = "label_AvailableAttributes";
            this.label_AvailableAttributes.Size = new System.Drawing.Size(153, 17);
            this.label_AvailableAttributes.TabIndex = 24;
            this.label_AvailableAttributes.Text = "Available  attributes";
            // 
            // label_UserAttributes
            // 
            this.label_UserAttributes.AutoSize = true;
            this.label_UserAttributes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserAttributes.Location = new System.Drawing.Point(84, 221);
            this.label_UserAttributes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_UserAttributes.Name = "label_UserAttributes";
            this.label_UserAttributes.Size = new System.Drawing.Size(116, 17);
            this.label_UserAttributes.TabIndex = 23;
            this.label_UserAttributes.Text = "User attributes";
            // 
            // dataGridViewAtributos
            // 
            this.dataGridViewAtributos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAtributos.Location = new System.Drawing.Point(87, 253);
            this.dataGridViewAtributos.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewAtributos.Name = "dataGridViewAtributos";
            this.dataGridViewAtributos.RowTemplate.Height = 31;
            this.dataGridViewAtributos.Size = new System.Drawing.Size(446, 159);
            this.dataGridViewAtributos.TabIndex = 22;
            this.dataGridViewAtributos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAtributos_CellContentClick);
            this.dataGridViewAtributos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAtributos_CellContentDoubleClick);
            // 
            // tipoAtributoBindingSource1
            // 
            this.tipoAtributoBindingSource1.DataMember = "TipoAtributo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Ayuda);
            this.panel1.Controls.Add(this.Dashboard);
            this.panel1.Controls.Add(this.Producto);
            this.panel1.Controls.Add(this.Relacion);
            this.panel1.Controls.Add(this.Assets);
            this.panel1.Controls.Add(this.Categoria);
            this.panel1.Controls.Add(this.Atributo);
            this.panel1.Location = new System.Drawing.Point(66, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 51);
            this.panel1.TabIndex = 21;
            // 
            // Ayuda
            // 
            this.Ayuda.Location = new System.Drawing.Point(476, 12);
            this.Ayuda.Name = "Ayuda";
            this.Ayuda.Size = new System.Drawing.Size(66, 25);
            this.Ayuda.TabIndex = 7;
            this.Ayuda.Text = "Help";
            this.Ayuda.UseVisualStyleBackColor = true;
            this.Ayuda.Click += new System.EventHandler(this.Ayuda_Click);
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
            // Relacion
            // 
            this.Relacion.Location = new System.Drawing.Point(388, 12);
            this.Relacion.Name = "Relacion";
            this.Relacion.Size = new System.Drawing.Size(82, 25);
            this.Relacion.TabIndex = 11;
            this.Relacion.Text = "Relationships";
            this.Relacion.UseVisualStyleBackColor = true;
            this.Relacion.Click += new System.EventHandler(this.Relacion_Click_1);
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
            // tipoAtributoBindingSource
            // 
            this.tipoAtributoBindingSource.DataMember = "TipoAtributo";
            // 
            // btn_AñadirAtributo
            // 
            this.btn_AñadirAtributo.Location = new System.Drawing.Point(594, 263);
            this.btn_AñadirAtributo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AñadirAtributo.Name = "btn_AñadirAtributo";
            this.btn_AñadirAtributo.Size = new System.Drawing.Size(122, 119);
            this.btn_AñadirAtributo.TabIndex = 25;
            this.btn_AñadirAtributo.Text = "Add Attribute";
            this.btn_AñadirAtributo.UseVisualStyleBackColor = true;
            this.btn_AñadirAtributo.Click += new System.EventHandler(this.btn_AñadirAtributo_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(950, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 72);
            this.button1.TabIndex = 26;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AtributoMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 539);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_AñadirAtributo);
            this.Controls.Add(this.label_AvailableAttributes);
            this.Controls.Add(this.label_UserAttributes);
            this.Controls.Add(this.dataGridViewAtributos);
            this.Controls.Add(this.panel1);
            this.Name = "AtributoMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Mini PIM";
            this.Load += new System.EventHandler(this.AtributoMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAtributos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoAtributoBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tipoAtributoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton btn_AñadirAtributo;
        private System.Windows.Forms.Label label_AvailableAttributes;
        private System.Windows.Forms.Label label_UserAttributes;
        private System.Windows.Forms.DataGridView dataGridViewAtributos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Ayuda;
        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.Button Producto;
        private System.Windows.Forms.Button Relacion;
        private System.Windows.Forms.Button Assets;
        private System.Windows.Forms.Button Categoria;
        private System.Windows.Forms.Button Atributo;
        private System.Windows.Forms.BindingSource tipoAtributoBindingSource;
        private System.Windows.Forms.BindingSource tipoAtributoBindingSource1;
        private System.Windows.Forms.Button button1;
    }
}