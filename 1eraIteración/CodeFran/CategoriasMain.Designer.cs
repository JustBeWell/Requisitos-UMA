﻿namespace WindowsFormsApplication2
{
    partial class CategoriasMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriasMain));
            this.label1 = new System.Windows.Forms.Label();
            this.Categorias = new System.Windows.Forms.DataGridView();
            this.Añadir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Ayuda = new System.Windows.Forms.Button();
            this.Dashboard = new System.Windows.Forms.Button();
            this.Producto = new System.Windows.Forms.Button();
            this.Relacion = new System.Windows.Forms.Button();
            this.Assets = new System.Windows.Forms.Button();
            this.Categoria = new System.Windows.Forms.Button();
            this.Atributo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Categorias)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 221);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(653, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "LIST OF CATEGORIES";
            // 
            // Categorias
            // 
            this.Categorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Categorias.Location = new System.Drawing.Point(128, 294);
            this.Categorias.Margin = new System.Windows.Forms.Padding(6);
            this.Categorias.Name = "Categorias";
            this.Categorias.Size = new System.Drawing.Size(1386, 439);
            this.Categorias.TabIndex = 1;
            this.Categorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Categorias_CellContentClick);
            // 
            // Añadir
            // 
            this.Añadir.Location = new System.Drawing.Point(350, 744);
            this.Añadir.Margin = new System.Windows.Forms.Padding(6);
            this.Añadir.Name = "Añadir";
            this.Añadir.Size = new System.Drawing.Size(1164, 138);
            this.Añadir.TabIndex = 2;
            this.Añadir.Text = "Add a new category";
            this.Añadir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Añadir.UseVisualStyleBackColor = true;
            this.Añadir.Click += new System.EventHandler(this.Añadir_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(128, 744);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(226, 138);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.panel1.Location = new System.Drawing.Point(121, 109);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 94);
            this.panel1.TabIndex = 6;
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
            // Relacion
            // 
            this.Relacion.Location = new System.Drawing.Point(711, 22);
            this.Relacion.Margin = new System.Windows.Forms.Padding(6);
            this.Relacion.Name = "Relacion";
            this.Relacion.Size = new System.Drawing.Size(150, 46);
            this.Relacion.TabIndex = 11;
            this.Relacion.Text = "Relationships";
            this.Relacion.UseVisualStyleBackColor = true;
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
            // Categoria
            // 
            this.Categoria.Location = new System.Drawing.Point(425, 22);
            this.Categoria.Margin = new System.Windows.Forms.Padding(6);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(132, 46);
            this.Categoria.TabIndex = 9;
            this.Categoria.Text = "Categories";
            this.Categoria.UseVisualStyleBackColor = true;
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
            // CategoriasMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1976, 1364);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Añadir);
            this.Controls.Add(this.Categorias);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CategoriasMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Mini PIM";
            this.Load += new System.EventHandler(this.CategoriasMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Categorias)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Categorias;
        private System.Windows.Forms.Button Añadir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Ayuda;
        private System.Windows.Forms.Button Relacion;
        private System.Windows.Forms.Button Atributo;
        private System.Windows.Forms.Button Categoria;
        private System.Windows.Forms.Button Assets;
        private System.Windows.Forms.Button Producto;
        private System.Windows.Forms.Button Dashboard;
    }
}