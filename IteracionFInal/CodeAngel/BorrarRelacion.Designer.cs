﻿namespace WindowsFormsApplication2
{
    partial class BorrarRelacion
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
            this.Yes = new System.Windows.Forms.Button();
            this.No = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Yes
            // 
            this.Yes.Location = new System.Drawing.Point(62, 138);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(145, 68);
            this.Yes.TabIndex = 0;
            this.Yes.Text = "Yes";
            this.Yes.UseVisualStyleBackColor = true;
            this.Yes.Click += new System.EventHandler(this.Yes_Click);
            // 
            // No
            // 
            this.No.Location = new System.Drawing.Point(320, 138);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(137, 68);
            this.No.TabIndex = 1;
            this.No.Text = "No";
            this.No.UseVisualStyleBackColor = true;
            this.No.Click += new System.EventHandler(this.No_Click);
            // 
            // BorrarRelacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 236);
            this.Controls.Add(this.No);
            this.Controls.Add(this.Yes);
            this.Name = "BorrarRelacion";
            this.Text = "BorrarRelacion";
            this.Load += new System.EventHandler(this.BorrarRelacion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Yes;
        private System.Windows.Forms.Button No;
    }
}