namespace WindowsFormsApplication2
{
    partial class CrearJSON
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
            this.textBoxJSONPreview = new System.Windows.Forms.TextBox();
            this.textBoxPathPreview = new System.Windows.Forms.TextBox();
            this.buttonSelectPath = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxJSONPreview
            // 
            this.textBoxJSONPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxJSONPreview.Location = new System.Drawing.Point(0, 0);
            this.textBoxJSONPreview.Multiline = true;
            this.textBoxJSONPreview.Name = "textBoxJSONPreview";
            this.textBoxJSONPreview.ReadOnly = true;
            this.textBoxJSONPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxJSONPreview.Size = new System.Drawing.Size(977, 502);
            this.textBoxJSONPreview.TabIndex = 0;
            // 
            // textBoxPathPreview
            // 
            this.textBoxPathPreview.Location = new System.Drawing.Point(185, 554);
            this.textBoxPathPreview.Name = "textBoxPathPreview";
            this.textBoxPathPreview.ReadOnly = true;
            this.textBoxPathPreview.Size = new System.Drawing.Size(623, 29);
            this.textBoxPathPreview.TabIndex = 1;
            // 
            // buttonSelectPath
            // 
            this.buttonSelectPath.Location = new System.Drawing.Point(20, 545);
            this.buttonSelectPath.Name = "buttonSelectPath";
            this.buttonSelectPath.Size = new System.Drawing.Size(159, 48);
            this.buttonSelectPath.TabIndex = 2;
            this.buttonSelectPath.Text = "SELECT PATH";
            this.buttonSelectPath.UseVisualStyleBackColor = true;
            this.buttonSelectPath.Click += new System.EventHandler(this.buttonSelectPath_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(825, 530);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(139, 79);
            this.buttonConfirm.TabIndex = 3;
            this.buttonConfirm.Text = "CONFIRM";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // CrearJSON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 636);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonSelectPath);
            this.Controls.Add(this.textBoxPathPreview);
            this.Controls.Add(this.textBoxJSONPreview);
            this.Name = "CrearJSON";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JSON Preview";
            this.Load += new System.EventHandler(this.CrearJSON_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxJSONPreview;
        private System.Windows.Forms.TextBox textBoxPathPreview;
        private System.Windows.Forms.Button buttonSelectPath;
        private System.Windows.Forms.Button buttonConfirm;
    }
}