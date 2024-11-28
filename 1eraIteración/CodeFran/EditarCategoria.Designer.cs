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
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(163, 395);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(800, 34);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "New name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 279);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(619, 67);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter category\'s name";
            // 
            // Confirmar
            // 
            this.Confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Confirmar.Location = new System.Drawing.Point(397, 517);
            this.Confirmar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.Size = new System.Drawing.Size(319, 144);
            this.Confirmar.TabIndex = 2;
            this.Confirmar.Text = "CONFIRM";
            this.Confirmar.UseVisualStyleBackColor = true;
            this.Confirmar.Click += new System.EventHandler(this.Confirmar_Click);
            // 
            // EditarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 1056);
            this.Controls.Add(this.Confirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "EditarCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Confirmar;
    }
}