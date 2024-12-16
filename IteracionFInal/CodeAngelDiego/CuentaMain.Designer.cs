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
            this.buttonJSON = new System.Windows.Forms.Button();
            this.labelAccountName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Ayuda = new System.Windows.Forms.Button();
            this.Relacion = new System.Windows.Forms.Button();
            this.Atributo = new System.Windows.Forms.Button();
            this.Categoria = new System.Windows.Forms.Button();
            this.Assets = new System.Windows.Forms.Button();
            this.Producto = new System.Windows.Forms.Button();
            this.Dashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelProducts = new System.Windows.Forms.Label();
            this.labelCategories = new System.Windows.Forms.Label();
            this.labelUA = new System.Windows.Forms.Label();
            this.labelRelationships = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonJSON
            // 
            this.buttonJSON.Location = new System.Drawing.Point(99, 628);
            this.buttonJSON.Margin = new System.Windows.Forms.Padding(6);
            this.buttonJSON.Name = "buttonJSON";
            this.buttonJSON.Size = new System.Drawing.Size(218, 42);
            this.buttonJSON.TabIndex = 0;
            this.buttonJSON.Text = "Export JSON";
            this.buttonJSON.UseVisualStyleBackColor = true;
            this.buttonJSON.Click += new System.EventHandler(this.buttonJSON_Click);
            // 
            // labelAccountName
            // 
            this.labelAccountName.AutoSize = true;
            this.labelAccountName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccountName.Location = new System.Drawing.Point(435, 236);
            this.labelAccountName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAccountName.Name = "labelAccountName";
            this.labelAccountName.Size = new System.Drawing.Size(417, 67);
            this.labelAccountName.TabIndex = 2;
            this.labelAccountName.Text = "Account Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(442, 382);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date and time of account creation:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(442, 445);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of products of the account:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(442, 510);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(353, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Number of products categories created:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(442, 568);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(305, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Number of user attributes created:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(442, 628);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(292, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Number of relationships created:";
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
            this.panel1.Location = new System.Drawing.Point(22, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 94);
            this.panel1.TabIndex = 13;
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
            // Dashboard
            // 
            this.Dashboard.Location = new System.Drawing.Point(26, 22);
            this.Dashboard.Margin = new System.Windows.Forms.Padding(6);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(139, 46);
            this.Dashboard.TabIndex = 6;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(74, 211);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 364);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(370, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(741, 497);
            this.dataGridView1.TabIndex = 14;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(831, 382);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(240, 25);
            this.labelDate.TabIndex = 15;
            this.labelDate.Text = "labelAccountCreationDate";
            // 
            // labelProducts
            // 
            this.labelProducts.AutoSize = true;
            this.labelProducts.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducts.Location = new System.Drawing.Point(831, 445);
            this.labelProducts.Name = "labelProducts";
            this.labelProducts.Size = new System.Drawing.Size(202, 25);
            this.labelProducts.TabIndex = 16;
            this.labelProducts.Text = "labelProductsAccount";
            // 
            // labelCategories
            // 
            this.labelCategories.AutoSize = true;
            this.labelCategories.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategories.Location = new System.Drawing.Point(831, 510);
            this.labelCategories.Name = "labelCategories";
            this.labelCategories.Size = new System.Drawing.Size(220, 25);
            this.labelCategories.TabIndex = 17;
            this.labelCategories.Text = "labelCategoriesAccount";
            // 
            // labelUA
            // 
            this.labelUA.AutoSize = true;
            this.labelUA.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelUA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUA.Location = new System.Drawing.Point(831, 568);
            this.labelUA.Name = "labelUA";
            this.labelUA.Size = new System.Drawing.Size(153, 25);
            this.labelUA.TabIndex = 18;
            this.labelUA.Text = "labelUAAccount";
            // 
            // labelRelationships
            // 
            this.labelRelationships.AutoSize = true;
            this.labelRelationships.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelRelationships.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRelationships.Location = new System.Drawing.Point(831, 628);
            this.labelRelationships.Name = "labelRelationships";
            this.labelRelationships.Size = new System.Drawing.Size(195, 25);
            this.labelRelationships.TabIndex = 19;
            this.labelRelationships.Text = "labelRelationAccount";
            // 
            // CuentaMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 871);
            this.Controls.Add(this.labelRelationships);
            this.Controls.Add(this.labelUA);
            this.Controls.Add(this.labelCategories);
            this.Controls.Add(this.labelProducts);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelAccountName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonJSON);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CuentaMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiniPIM";
            this.Load += new System.EventHandler(this.CuentaMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonJSON;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelAccountName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Ayuda;
        private System.Windows.Forms.Button Relacion;
        private System.Windows.Forms.Button Atributo;
        private System.Windows.Forms.Button Categoria;
        private System.Windows.Forms.Button Assets;
        private System.Windows.Forms.Button Producto;
        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelProducts;
        private System.Windows.Forms.Label labelCategories;
        private System.Windows.Forms.Label labelUA;
        private System.Windows.Forms.Label labelRelationships;
    }
}