namespace WindowsFormsApplication2
{
    partial class CrearAtributo
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
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.tBox_Nombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirm.Location = new System.Drawing.Point(652, 391);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(410, 143);
            this.btn_Confirm.TabIndex = 9;
            this.btn_Confirm.Text = "CONFIRM";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(473, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Type: ";
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.Location = new System.Drawing.Point(627, 292);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(205, 40);
            this.comboBox_Type.TabIndex = 7;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(341, 199);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(231, 32);
            this.label_Name.TabIndex = 6;
            this.label_Name.Text = "Attribute name: ";
            // 
            // tBox_Nombre
            // 
            this.tBox_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox_Nombre.Location = new System.Drawing.Point(627, 199);
            this.tBox_Nombre.Name = "tBox_Nombre";
            this.tBox_Nombre.Size = new System.Drawing.Size(457, 39);
            this.tBox_Nombre.TabIndex = 5;
            // 
            // CrearAtributo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1558, 806);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Type);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.tBox_Nombre);
            this.Name = "CrearAtributo";
            this.Text = "CrearAtributo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Type;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox tBox_Nombre;
    }
}