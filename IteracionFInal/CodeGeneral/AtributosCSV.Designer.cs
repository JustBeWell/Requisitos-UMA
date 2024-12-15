namespace WindowsFormsApplication2
{
    partial class AtributosCSV
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
            this.labelSKU = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelFulfilledBy = new System.Windows.Forms.Label();
            this.labelAmazon_SKU = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelOfferPrice = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.labelCompulsoryAtributes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSKU
            // 
            this.labelSKU.AutoSize = true;
            this.labelSKU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSKU.Location = new System.Drawing.Point(221, 129);
            this.labelSKU.Name = "labelSKU";
            this.labelSKU.Size = new System.Drawing.Size(42, 20);
            this.labelSKU.TabIndex = 0;
            this.labelSKU.Text = "SKU";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(221, 170);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(38, 20);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Title";
            // 
            // labelFulfilledBy
            // 
            this.labelFulfilledBy.AutoSize = true;
            this.labelFulfilledBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFulfilledBy.Location = new System.Drawing.Point(221, 218);
            this.labelFulfilledBy.Name = "labelFulfilledBy";
            this.labelFulfilledBy.Size = new System.Drawing.Size(81, 20);
            this.labelFulfilledBy.TabIndex = 2;
            this.labelFulfilledBy.Text = "FulfilledBy";
            // 
            // labelAmazon_SKU
            // 
            this.labelAmazon_SKU.AutoSize = true;
            this.labelAmazon_SKU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmazon_SKU.Location = new System.Drawing.Point(221, 257);
            this.labelAmazon_SKU.Name = "labelAmazon_SKU";
            this.labelAmazon_SKU.Size = new System.Drawing.Size(110, 20);
            this.labelAmazon_SKU.TabIndex = 3;
            this.labelAmazon_SKU.Text = "Amazon_SKU";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(221, 297);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(44, 20);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "Price";
            this.labelPrice.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelOfferPrice
            // 
            this.labelOfferPrice.AutoSize = true;
            this.labelOfferPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOfferPrice.Location = new System.Drawing.Point(221, 336);
            this.labelOfferPrice.Name = "labelOfferPrice";
            this.labelOfferPrice.Size = new System.Drawing.Size(80, 20);
            this.labelOfferPrice.TabIndex = 5;
            this.labelOfferPrice.Text = "OfferPrice";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(362, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(219, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Product SKU";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(362, 172);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(219, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Product Label";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(362, 220);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(219, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "Account Name";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(362, 259);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(219, 20);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "Product GTIN";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(362, 299);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(219, 20);
            this.textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(362, 338);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(219, 20);
            this.textBox6.TabIndex = 11;
            this.textBox6.Text = "FALSE";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(654, 411);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(203, 63);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "EXPORT";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // labelCompulsoryAtributes
            // 
            this.labelCompulsoryAtributes.AutoSize = true;
            this.labelCompulsoryAtributes.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompulsoryAtributes.Location = new System.Drawing.Point(12, 9);
            this.labelCompulsoryAtributes.Name = "labelCompulsoryAtributes";
            this.labelCompulsoryAtributes.Size = new System.Drawing.Size(303, 33);
            this.labelCompulsoryAtributes.TabIndex = 13;
            this.labelCompulsoryAtributes.Text = "Compulsory Attributes";
            // 
            // AtributosCSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 569);
            this.Controls.Add(this.labelCompulsoryAtributes);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelOfferPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelAmazon_SKU);
            this.Controls.Add(this.labelFulfilledBy);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelSKU);
            this.Name = "AtributosCSV";
            this.Text = "D";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSKU;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelFulfilledBy;
        private System.Windows.Forms.Label labelAmazon_SKU;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelOfferPrice;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label labelCompulsoryAtributes;
    }
}