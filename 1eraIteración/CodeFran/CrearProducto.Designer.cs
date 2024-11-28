namespace WindowsFormsApplication2
{
    partial class CrearProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearProducto));
            this.Confirmar = new System.Windows.Forms.Button();
            this.Upload = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxGTIN = new System.Windows.Forms.TextBox();
            this.textBoxU3 = new System.Windows.Forms.TextBox();
            this.textBoxU4 = new System.Windows.Forms.TextBox();
            this.textBoxU5 = new System.Windows.Forms.TextBox();
            this.textBoxU2 = new System.Windows.Forms.TextBox();
            this.textBoxU1 = new System.Windows.Forms.TextBox();
            this.textBoxLabel = new System.Windows.Forms.TextBox();
            this.textBoxSKU = new System.Windows.Forms.TextBox();
            this.GtinCheck = new System.Windows.Forms.CheckBox();
            this.U5Check = new System.Windows.Forms.CheckBox();
            this.U4Check = new System.Windows.Forms.CheckBox();
            this.U3Check = new System.Windows.Forms.CheckBox();
            this.U2Check = new System.Windows.Forms.CheckBox();
            this.U1Check = new System.Windows.Forms.CheckBox();
            this.LabelCheck = new System.Windows.Forms.CheckBox();
            this.SKUCheck = new System.Windows.Forms.CheckBox();
            this.CategoriasCheck = new System.Windows.Forms.CheckBox();
            this.Categorias = new System.Windows.Forms.ComboBox();
            this.Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Confirmar
            // 
            this.Confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Confirmar.Location = new System.Drawing.Point(1106, 805);
            this.Confirmar.Margin = new System.Windows.Forms.Padding(6);
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.Size = new System.Drawing.Size(350, 230);
            this.Confirmar.TabIndex = 0;
            this.Confirmar.Text = "CONFIRM";
            this.Confirmar.UseVisualStyleBackColor = true;
            this.Confirmar.Click += new System.EventHandler(this.Confirmar_Click);
            // 
            // Upload
            // 
            this.Upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Upload.Location = new System.Drawing.Point(33, 534);
            this.Upload.Margin = new System.Windows.Forms.Padding(6);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(323, 72);
            this.Upload.TabIndex = 1;
            this.Upload.Text = "Upload Asset";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 489);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxGTIN
            // 
            this.textBoxGTIN.Enabled = false;
            this.textBoxGTIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxGTIN.Location = new System.Drawing.Point(522, 33);
            this.textBoxGTIN.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxGTIN.Name = "textBoxGTIN";
            this.textBoxGTIN.Size = new System.Drawing.Size(470, 34);
            this.textBoxGTIN.TabIndex = 3;
            this.textBoxGTIN.Text = "GTIN";
            // 
            // textBoxU3
            // 
            this.textBoxU3.Enabled = false;
            this.textBoxU3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxU3.Location = new System.Drawing.Point(522, 406);
            this.textBoxU3.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxU3.Name = "textBoxU3";
            this.textBoxU3.Size = new System.Drawing.Size(470, 34);
            this.textBoxU3.TabIndex = 4;
            this.textBoxU3.TextChanged += new System.EventHandler(this.textBoxU3_TextChanged);
            // 
            // textBoxU4
            // 
            this.textBoxU4.Enabled = false;
            this.textBoxU4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxU4.Location = new System.Drawing.Point(522, 486);
            this.textBoxU4.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxU4.Name = "textBoxU4";
            this.textBoxU4.Size = new System.Drawing.Size(470, 34);
            this.textBoxU4.TabIndex = 5;
            // 
            // textBoxU5
            // 
            this.textBoxU5.Enabled = false;
            this.textBoxU5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxU5.Location = new System.Drawing.Point(522, 552);
            this.textBoxU5.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxU5.Name = "textBoxU5";
            this.textBoxU5.Size = new System.Drawing.Size(470, 34);
            this.textBoxU5.TabIndex = 6;
            // 
            // textBoxU2
            // 
            this.textBoxU2.Enabled = false;
            this.textBoxU2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxU2.Location = new System.Drawing.Point(522, 327);
            this.textBoxU2.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxU2.Name = "textBoxU2";
            this.textBoxU2.Size = new System.Drawing.Size(470, 34);
            this.textBoxU2.TabIndex = 7;
            // 
            // textBoxU1
            // 
            this.textBoxU1.Enabled = false;
            this.textBoxU1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxU1.Location = new System.Drawing.Point(522, 259);
            this.textBoxU1.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxU1.Name = "textBoxU1";
            this.textBoxU1.Size = new System.Drawing.Size(470, 34);
            this.textBoxU1.TabIndex = 8;
            this.textBoxU1.TextChanged += new System.EventHandler(this.textBoxU1_TextChanged);
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.Enabled = false;
            this.textBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxLabel.Location = new System.Drawing.Point(522, 181);
            this.textBoxLabel.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(470, 34);
            this.textBoxLabel.TabIndex = 9;
            this.textBoxLabel.Text = "Label";
            // 
            // textBoxSKU
            // 
            this.textBoxSKU.Enabled = false;
            this.textBoxSKU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxSKU.Location = new System.Drawing.Point(522, 105);
            this.textBoxSKU.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxSKU.Name = "textBoxSKU";
            this.textBoxSKU.Size = new System.Drawing.Size(470, 34);
            this.textBoxSKU.TabIndex = 10;
            this.textBoxSKU.Text = "SKU";
            this.textBoxSKU.TextChanged += new System.EventHandler(this.textBoxSKU_TextChanged);
            // 
            // GtinCheck
            // 
            this.GtinCheck.AutoSize = true;
            this.GtinCheck.Location = new System.Drawing.Point(1025, 43);
            this.GtinCheck.Margin = new System.Windows.Forms.Padding(6);
            this.GtinCheck.Name = "GtinCheck";
            this.GtinCheck.Size = new System.Drawing.Size(22, 21);
            this.GtinCheck.TabIndex = 12;
            this.GtinCheck.UseVisualStyleBackColor = true;
            this.GtinCheck.CheckedChanged += new System.EventHandler(this.GtinCheck_CheckedChanged);
            // 
            // U5Check
            // 
            this.U5Check.AutoSize = true;
            this.U5Check.Location = new System.Drawing.Point(1025, 561);
            this.U5Check.Margin = new System.Windows.Forms.Padding(6);
            this.U5Check.Name = "U5Check";
            this.U5Check.Size = new System.Drawing.Size(22, 21);
            this.U5Check.TabIndex = 13;
            this.U5Check.UseVisualStyleBackColor = true;
            this.U5Check.CheckedChanged += new System.EventHandler(this.U5Check_CheckedChanged);
            // 
            // U4Check
            // 
            this.U4Check.AutoSize = true;
            this.U4Check.Location = new System.Drawing.Point(1025, 496);
            this.U4Check.Margin = new System.Windows.Forms.Padding(6);
            this.U4Check.Name = "U4Check";
            this.U4Check.Size = new System.Drawing.Size(22, 21);
            this.U4Check.TabIndex = 14;
            this.U4Check.UseVisualStyleBackColor = true;
            this.U4Check.CheckedChanged += new System.EventHandler(this.U4Check_CheckedChanged);
            // 
            // U3Check
            // 
            this.U3Check.AutoSize = true;
            this.U3Check.Location = new System.Drawing.Point(1025, 416);
            this.U3Check.Margin = new System.Windows.Forms.Padding(6);
            this.U3Check.Name = "U3Check";
            this.U3Check.Size = new System.Drawing.Size(22, 21);
            this.U3Check.TabIndex = 15;
            this.U3Check.UseVisualStyleBackColor = true;
            this.U3Check.CheckedChanged += new System.EventHandler(this.U3Check_CheckedChanged);
            // 
            // U2Check
            // 
            this.U2Check.AutoSize = true;
            this.U2Check.Location = new System.Drawing.Point(1025, 337);
            this.U2Check.Margin = new System.Windows.Forms.Padding(6);
            this.U2Check.Name = "U2Check";
            this.U2Check.Size = new System.Drawing.Size(22, 21);
            this.U2Check.TabIndex = 16;
            this.U2Check.UseVisualStyleBackColor = true;
            this.U2Check.CheckedChanged += new System.EventHandler(this.U2Check_CheckedChanged);
            // 
            // U1Check
            // 
            this.U1Check.AutoSize = true;
            this.U1Check.Location = new System.Drawing.Point(1025, 269);
            this.U1Check.Margin = new System.Windows.Forms.Padding(6);
            this.U1Check.Name = "U1Check";
            this.U1Check.Size = new System.Drawing.Size(22, 21);
            this.U1Check.TabIndex = 17;
            this.U1Check.UseVisualStyleBackColor = true;
            this.U1Check.CheckedChanged += new System.EventHandler(this.U1Check_CheckedChanged);
            // 
            // LabelCheck
            // 
            this.LabelCheck.AutoSize = true;
            this.LabelCheck.Location = new System.Drawing.Point(1025, 191);
            this.LabelCheck.Margin = new System.Windows.Forms.Padding(6);
            this.LabelCheck.Name = "LabelCheck";
            this.LabelCheck.Size = new System.Drawing.Size(22, 21);
            this.LabelCheck.TabIndex = 18;
            this.LabelCheck.UseVisualStyleBackColor = true;
            this.LabelCheck.CheckedChanged += new System.EventHandler(this.LabelCheck_CheckedChanged);
            // 
            // SKUCheck
            // 
            this.SKUCheck.AutoSize = true;
            this.SKUCheck.Location = new System.Drawing.Point(1025, 115);
            this.SKUCheck.Margin = new System.Windows.Forms.Padding(6);
            this.SKUCheck.Name = "SKUCheck";
            this.SKUCheck.Size = new System.Drawing.Size(22, 21);
            this.SKUCheck.TabIndex = 19;
            this.SKUCheck.UseVisualStyleBackColor = true;
            this.SKUCheck.CheckedChanged += new System.EventHandler(this.SKUCheck_CheckedChanged);
            // 
            // CategoriasCheck
            // 
            this.CategoriasCheck.AutoSize = true;
            this.CategoriasCheck.Location = new System.Drawing.Point(1025, 632);
            this.CategoriasCheck.Margin = new System.Windows.Forms.Padding(6);
            this.CategoriasCheck.Name = "CategoriasCheck";
            this.CategoriasCheck.Size = new System.Drawing.Size(22, 21);
            this.CategoriasCheck.TabIndex = 20;
            this.CategoriasCheck.UseVisualStyleBackColor = true;
            this.CategoriasCheck.CheckedChanged += new System.EventHandler(this.CategoriasCheck_CheckedChanged);
            // 
            // Categorias
            // 
            this.Categorias.Enabled = false;
            this.Categorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Categorias.FormattingEnabled = true;
            this.Categorias.Location = new System.Drawing.Point(522, 622);
            this.Categorias.Margin = new System.Windows.Forms.Padding(6);
            this.Categorias.Name = "Categorias";
            this.Categorias.Size = new System.Drawing.Size(470, 37);
            this.Categorias.TabIndex = 21;
            // 
            // Salir
            // 
            this.Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Salir.Location = new System.Drawing.Point(72, 805);
            this.Salir.Margin = new System.Windows.Forms.Padding(6);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(350, 230);
            this.Salir.TabIndex = 22;
            this.Salir.Text = "EXIT";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // CrearProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1776, 1364);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Categorias);
            this.Controls.Add(this.CategoriasCheck);
            this.Controls.Add(this.SKUCheck);
            this.Controls.Add(this.LabelCheck);
            this.Controls.Add(this.U1Check);
            this.Controls.Add(this.U2Check);
            this.Controls.Add(this.U3Check);
            this.Controls.Add(this.U4Check);
            this.Controls.Add(this.U5Check);
            this.Controls.Add(this.GtinCheck);
            this.Controls.Add(this.textBoxSKU);
            this.Controls.Add(this.textBoxLabel);
            this.Controls.Add(this.textBoxU1);
            this.Controls.Add(this.textBoxU2);
            this.Controls.Add(this.textBoxU5);
            this.Controls.Add(this.textBoxU4);
            this.Controls.Add(this.textBoxU3);
            this.Controls.Add(this.textBoxGTIN);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.Confirmar);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CrearProducto";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Confirmar;
        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxGTIN;
        private System.Windows.Forms.TextBox textBoxU3;
        private System.Windows.Forms.TextBox textBoxU4;
        private System.Windows.Forms.TextBox textBoxU5;
        private System.Windows.Forms.TextBox textBoxU2;
        private System.Windows.Forms.TextBox textBoxU1;
        private System.Windows.Forms.TextBox textBoxLabel;
        private System.Windows.Forms.TextBox textBoxSKU;
        private System.Windows.Forms.CheckBox GtinCheck;
        private System.Windows.Forms.CheckBox U5Check;
        private System.Windows.Forms.CheckBox U4Check;
        private System.Windows.Forms.CheckBox U3Check;
        private System.Windows.Forms.CheckBox U2Check;
        private System.Windows.Forms.CheckBox U1Check;
        private System.Windows.Forms.CheckBox LabelCheck;
        private System.Windows.Forms.CheckBox SKUCheck;
        private System.Windows.Forms.CheckBox CategoriasCheck;
        private System.Windows.Forms.ComboBox Categorias;
        private System.Windows.Forms.Button Salir;
    }
}