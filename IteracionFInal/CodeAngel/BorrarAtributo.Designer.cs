namespace WindowsFormsApplication2
{
    partial class BorrarAtributo
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
            this.label_MsgBorrar = new System.Windows.Forms.Label();
            this.btn_Yes = new System.Windows.Forms.Button();
            this.btn_No = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_MsgBorrar
            // 
            this.label_MsgBorrar.AutoSize = true;
            this.label_MsgBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label_MsgBorrar.Location = new System.Drawing.Point(128, 122);
            this.label_MsgBorrar.Name = "label_MsgBorrar";
            this.label_MsgBorrar.Size = new System.Drawing.Size(719, 39);
            this.label_MsgBorrar.TabIndex = 0;
            this.label_MsgBorrar.Text = "Are you sure you want to delete this attribute?";
            // 
            // btn_Yes
            // 
            this.btn_Yes.Location = new System.Drawing.Point(147, 245);
            this.btn_Yes.Name = "btn_Yes";
            this.btn_Yes.Size = new System.Drawing.Size(275, 135);
            this.btn_Yes.TabIndex = 1;
            this.btn_Yes.Text = "YES";
            this.btn_Yes.UseVisualStyleBackColor = true;
            this.btn_Yes.Click += new System.EventHandler(this.btn_Yes_Click);
            // 
            // btn_No
            // 
            this.btn_No.Location = new System.Drawing.Point(550, 245);
            this.btn_No.Name = "btn_No";
            this.btn_No.Size = new System.Drawing.Size(275, 135);
            this.btn_No.TabIndex = 2;
            this.btn_No.Text = "NO";
            this.btn_No.UseVisualStyleBackColor = true;
            this.btn_No.Click += new System.EventHandler(this.btn_No_Click);
            // 
            // BorrarAtributo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 436);
            this.Controls.Add(this.btn_No);
            this.Controls.Add(this.btn_Yes);
            this.Controls.Add(this.label_MsgBorrar);
            this.Name = "BorrarAtributo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.BorrarAtributo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_MsgBorrar;
        private System.Windows.Forms.Button btn_Yes;
        private System.Windows.Forms.Button btn_No;
    }
}