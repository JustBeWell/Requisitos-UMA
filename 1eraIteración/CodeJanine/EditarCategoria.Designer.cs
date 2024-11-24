namespace WindowsFormsApplication2
{
    partial class EditarCategoria
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Confirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 214);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(438, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "New name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter category\'s name";
            // 
            // Confirmar
            // 
            this.Confirmar.Location = new System.Drawing.Point(429, 319);
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.Size = new System.Drawing.Size(174, 78);
            this.Confirmar.TabIndex = 2;
            this.Confirmar.Text = "Confirm";
            this.Confirmar.UseVisualStyleBackColor = true;
            this.Confirmar.Click += new System.EventHandler(this.Confirmar_Click);
            // 
            // EditarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 424);
            this.Controls.Add(this.Confirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "EditarCategoria";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Confirmar;
    }
}