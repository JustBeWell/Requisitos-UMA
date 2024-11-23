namespace WindowsFormsApplication2
{
    partial class EditarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarProducto));
            this.Salir = new System.Windows.Forms.Button();
            this.Categorias = new System.Windows.Forms.ComboBox();
            this.CategoriasCheck = new System.Windows.Forms.CheckBox();
            this.LabelCheck = new System.Windows.Forms.CheckBox();
            this.U1Check = new System.Windows.Forms.CheckBox();
            this.U2Check = new System.Windows.Forms.CheckBox();
            this.U3Check = new System.Windows.Forms.CheckBox();
            this.U4Check = new System.Windows.Forms.CheckBox();
            this.U5Check = new System.Windows.Forms.CheckBox();
            this.GtinCheck = new System.Windows.Forms.CheckBox();
            this.textBoxLabel = new System.Windows.Forms.TextBox();
            this.textBoxU1 = new System.Windows.Forms.TextBox();
            this.textBoxU2 = new System.Windows.Forms.TextBox();
            this.textBoxU5 = new System.Windows.Forms.TextBox();
            this.textBoxU4 = new System.Windows.Forms.TextBox();
            this.textBoxU3 = new System.Windows.Forms.TextBox();
            this.textBoxGTIN = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Upload = new System.Windows.Forms.Button();
            this.Confirmar = new System.Windows.Forms.Button();
            this.textBoxSKU = new System.Windows.Forms.TextBox();
            this.checkBoxSKU = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(28, 426);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(176, 98);
            this.Salir.TabIndex = 44;
            this.Salir.Text = "EXIT";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Categorias
            // 
            this.Categorias.Enabled = false;
            this.Categorias.FormattingEnabled = true;
            this.Categorias.Location = new System.Drawing.Point(256, 326);
            this.Categorias.Name = "Categorias";
            this.Categorias.Size = new System.Drawing.Size(258, 21);
            this.Categorias.TabIndex = 43;
            // 
            // CategoriasCheck
            // 
            this.CategoriasCheck.AutoSize = true;
            this.CategoriasCheck.Location = new System.Drawing.Point(530, 326);
            this.CategoriasCheck.Name = "CategoriasCheck";
            this.CategoriasCheck.Size = new System.Drawing.Size(15, 14);
            this.CategoriasCheck.TabIndex = 42;
            this.CategoriasCheck.UseVisualStyleBackColor = true;
            this.CategoriasCheck.CheckedChanged += new System.EventHandler(this.CategoriasCheck_CheckedChanged);
            // 
            // LabelCheck
            // 
            this.LabelCheck.AutoSize = true;
            this.LabelCheck.Location = new System.Drawing.Point(530, 91);
            this.LabelCheck.Name = "LabelCheck";
            this.LabelCheck.Size = new System.Drawing.Size(15, 14);
            this.LabelCheck.TabIndex = 40;
            this.LabelCheck.UseVisualStyleBackColor = true;
            this.LabelCheck.CheckedChanged += new System.EventHandler(this.LabelCheck_CheckedChanged);
            // 
            // U1Check
            // 
            this.U1Check.AutoSize = true;
            this.U1Check.Location = new System.Drawing.Point(530, 129);
            this.U1Check.Name = "U1Check";
            this.U1Check.Size = new System.Drawing.Size(15, 14);
            this.U1Check.TabIndex = 39;
            this.U1Check.UseVisualStyleBackColor = true;
            this.U1Check.CheckedChanged += new System.EventHandler(this.U1Check_CheckedChanged);
            // 
            // U2Check
            // 
            this.U2Check.AutoSize = true;
            this.U2Check.Location = new System.Drawing.Point(530, 168);
            this.U2Check.Name = "U2Check";
            this.U2Check.Size = new System.Drawing.Size(15, 14);
            this.U2Check.TabIndex = 38;
            this.U2Check.UseVisualStyleBackColor = true;
            this.U2Check.CheckedChanged += new System.EventHandler(this.U2Check_CheckedChanged);
            // 
            // U3Check
            // 
            this.U3Check.AutoSize = true;
            this.U3Check.Location = new System.Drawing.Point(530, 209);
            this.U3Check.Name = "U3Check";
            this.U3Check.Size = new System.Drawing.Size(15, 14);
            this.U3Check.TabIndex = 37;
            this.U3Check.UseVisualStyleBackColor = true;
            this.U3Check.CheckedChanged += new System.EventHandler(this.U3Check_CheckedChanged);
            // 
            // U4Check
            // 
            this.U4Check.AutoSize = true;
            this.U4Check.Location = new System.Drawing.Point(530, 252);
            this.U4Check.Name = "U4Check";
            this.U4Check.Size = new System.Drawing.Size(15, 14);
            this.U4Check.TabIndex = 36;
            this.U4Check.UseVisualStyleBackColor = true;
            this.U4Check.CheckedChanged += new System.EventHandler(this.U4Check_CheckedChanged);
            // 
            // U5Check
            // 
            this.U5Check.AutoSize = true;
            this.U5Check.Location = new System.Drawing.Point(530, 288);
            this.U5Check.Name = "U5Check";
            this.U5Check.Size = new System.Drawing.Size(15, 14);
            this.U5Check.TabIndex = 35;
            this.U5Check.UseVisualStyleBackColor = true;
            this.U5Check.CheckedChanged += new System.EventHandler(this.U5Check_CheckedChanged);
            // 
            // GtinCheck
            // 
            this.GtinCheck.AutoSize = true;
            this.GtinCheck.Location = new System.Drawing.Point(530, 23);
            this.GtinCheck.Name = "GtinCheck";
            this.GtinCheck.Size = new System.Drawing.Size(15, 14);
            this.GtinCheck.TabIndex = 34;
            this.GtinCheck.UseVisualStyleBackColor = true;
            this.GtinCheck.CheckedChanged += new System.EventHandler(this.GtinCheck_CheckedChanged);
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.Enabled = false;
            this.textBoxLabel.Location = new System.Drawing.Point(256, 87);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(258, 20);
            this.textBoxLabel.TabIndex = 32;
            this.textBoxLabel.Text = "Label";
            // 
            // textBoxU1
            // 
            this.textBoxU1.Enabled = false;
            this.textBoxU1.Location = new System.Drawing.Point(256, 129);
            this.textBoxU1.Name = "textBoxU1";
            this.textBoxU1.Size = new System.Drawing.Size(258, 20);
            this.textBoxU1.TabIndex = 31;
            // 
            // textBoxU2
            // 
            this.textBoxU2.Enabled = false;
            this.textBoxU2.Location = new System.Drawing.Point(256, 166);
            this.textBoxU2.Name = "textBoxU2";
            this.textBoxU2.Size = new System.Drawing.Size(258, 20);
            this.textBoxU2.TabIndex = 30;
            // 
            // textBoxU5
            // 
            this.textBoxU5.Enabled = false;
            this.textBoxU5.Location = new System.Drawing.Point(256, 288);
            this.textBoxU5.Name = "textBoxU5";
            this.textBoxU5.Size = new System.Drawing.Size(258, 20);
            this.textBoxU5.TabIndex = 29;
            // 
            // textBoxU4
            // 
            this.textBoxU4.Enabled = false;
            this.textBoxU4.Location = new System.Drawing.Point(256, 252);
            this.textBoxU4.Name = "textBoxU4";
            this.textBoxU4.Size = new System.Drawing.Size(258, 20);
            this.textBoxU4.TabIndex = 28;
            // 
            // textBoxU3
            // 
            this.textBoxU3.Enabled = false;
            this.textBoxU3.Location = new System.Drawing.Point(256, 209);
            this.textBoxU3.Name = "textBoxU3";
            this.textBoxU3.Size = new System.Drawing.Size(258, 20);
            this.textBoxU3.TabIndex = 27;
            // 
            // textBoxGTIN
            // 
            this.textBoxGTIN.Enabled = false;
            this.textBoxGTIN.Location = new System.Drawing.Point(256, 21);
            this.textBoxGTIN.Name = "textBoxGTIN";
            this.textBoxGTIN.Size = new System.Drawing.Size(258, 20);
            this.textBoxGTIN.TabIndex = 26;
            this.textBoxGTIN.Text = "GTIN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 265);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // Upload
            // 
            this.Upload.Location = new System.Drawing.Point(28, 289);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(176, 39);
            this.Upload.TabIndex = 24;
            this.Upload.Text = "Upload Asset";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // Confirmar
            // 
            this.Confirmar.Location = new System.Drawing.Point(548, 414);
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.Size = new System.Drawing.Size(191, 124);
            this.Confirmar.TabIndex = 23;
            this.Confirmar.Text = "CONFIRM";
            this.Confirmar.UseVisualStyleBackColor = true;
            this.Confirmar.Click += new System.EventHandler(this.Confirmar_Click);
            // 
            // textBoxSKU
            // 
            this.textBoxSKU.Enabled = false;
            this.textBoxSKU.Location = new System.Drawing.Point(256, 56);
            this.textBoxSKU.Name = "textBoxSKU";
            this.textBoxSKU.Size = new System.Drawing.Size(258, 20);
            this.textBoxSKU.TabIndex = 45;
            this.textBoxSKU.Text = "SKU";
            // 
            // checkBoxSKU
            // 
            this.checkBoxSKU.AutoSize = true;
            this.checkBoxSKU.Location = new System.Drawing.Point(530, 58);
            this.checkBoxSKU.Name = "checkBoxSKU";
            this.checkBoxSKU.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSKU.TabIndex = 46;
            this.checkBoxSKU.UseVisualStyleBackColor = true;
            this.checkBoxSKU.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // EditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 559);
            this.Controls.Add(this.checkBoxSKU);
            this.Controls.Add(this.textBoxSKU);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Categorias);
            this.Controls.Add(this.CategoriasCheck);
            this.Controls.Add(this.LabelCheck);
            this.Controls.Add(this.U1Check);
            this.Controls.Add(this.U2Check);
            this.Controls.Add(this.U3Check);
            this.Controls.Add(this.U4Check);
            this.Controls.Add(this.U5Check);
            this.Controls.Add(this.GtinCheck);
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
            this.Name = "EditarProducto";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.EditarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.ComboBox Categorias;
        private System.Windows.Forms.CheckBox CategoriasCheck;
        private System.Windows.Forms.CheckBox LabelCheck;
        private System.Windows.Forms.CheckBox U1Check;
        private System.Windows.Forms.CheckBox U2Check;
        private System.Windows.Forms.CheckBox U3Check;
        private System.Windows.Forms.CheckBox U4Check;
        private System.Windows.Forms.CheckBox U5Check;
        private System.Windows.Forms.CheckBox GtinCheck;
        private System.Windows.Forms.TextBox textBoxLabel;
        private System.Windows.Forms.TextBox textBoxU1;
        private System.Windows.Forms.TextBox textBoxU2;
        private System.Windows.Forms.TextBox textBoxU5;
        private System.Windows.Forms.TextBox textBoxU4;
        private System.Windows.Forms.TextBox textBoxU3;
        private System.Windows.Forms.TextBox textBoxGTIN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.Button Confirmar;
        private System.Windows.Forms.TextBox textBoxSKU;
        private System.Windows.Forms.CheckBox checkBoxSKU;
    }
}