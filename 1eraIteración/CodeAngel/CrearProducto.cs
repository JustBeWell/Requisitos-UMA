using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class CrearProducto : Form
    {
        private MainForm _form1;
        public CrearProducto(MainForm form1)
        {
            _form1 = form1;
            InitializeComponent();
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                DataClasses1DataContext db = new DataClasses1DataContext();

                // Comprobaciones iniciales
                if (string.IsNullOrWhiteSpace(textBoxSKU.Text) || !SKUCheck.Checked ||
                    string.IsNullOrWhiteSpace(textBoxGTIN.Text) || !GtinCheck.Checked ||
                    string.IsNullOrWhiteSpace(textBoxLabel.Text) || !LabelCheck.Checked)
                {
                    MessageBox.Show("Datos incompletos", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Comprobación GTIN
                if (textBoxGTIN.Text.Trim().Length > 14)
                {
                    MessageBox.Show("El GTIN debe tener como máximo 14 caracteres.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Comprobación SKU único
                if (db.Producto.Any(p => p.SKU == textBoxSKU.Text.Trim()))
                {
                    MessageBox.Show("El SKU debe ser único. Ya existe un producto con este SKU.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Comprobación Label
                if (textBoxLabel.Text.Trim().Length > 250)
                {
                    MessageBox.Show("El Label no debe exceder los 250 caracteres.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Comprobación Thumbnail
                if (!string.IsNullOrEmpty(pictureBox1.ImageLocation))
                {
                    var thumbnail = new Bitmap(pictureBox1.ImageLocation);
                    if (thumbnail.Width != 200 || thumbnail.Height != 200)
                    {
                        MessageBox.Show("El Thumbnail debe tener un tamaño de 200×200 píxeles.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (!pictureBox1.ImageLocation.EndsWith(".png") && !pictureBox1.ImageLocation.EndsWith(".jpg"))
                    {
                        MessageBox.Show("El Thumbnail debe estar en formato PNG o JPG.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                Producto prod = new Producto
                {

                    SKU = textBoxSKU.Text.Trim(),
                    GTIN = textBoxGTIN.Text.Trim(),
                    Label = textBoxLabel.Text.Trim(),
                    Thumbnail = pictureBox1.ImageLocation ?? string.Empty

                };

                db.Producto.InsertOnSubmit(prod);
                db.SubmitChanges();

                var atributos = db.Atributo.Take(5).ToList();

                // Insertar categoría
                if (Categorias.SelectedValue != null)
                {
                    int categoriaId = (int)Categorias.SelectedValue;
                    var categoriaExistente = db.Categoria.FirstOrDefault(c => c.id == categoriaId);
                    if (categoriaExistente != null)
                    {
                        db.ProductoCategoria.InsertOnSubmit(new ProductoCategoria
                        {
                            producto_SKU = prod.SKU,
                            categoria_id = categoriaExistente.id
                        });
                    }
                }

                db.SubmitChanges();
                _form1.load();
                _form1.cambiarColor(Color.White);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GtinCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (GtinCheck.Checked) textBoxGTIN.Enabled = true;
            else textBoxGTIN.Enabled = false;
        }

        private void SKUCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (SKUCheck.Checked) textBoxSKU.Enabled = true;
            else textBoxSKU.Enabled = false;
        }

        private void LabelCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (LabelCheck.Checked) textBoxLabel.Enabled = true;
            else textBoxLabel.Enabled = false;
        }

        private void U1Check_CheckedChanged(object sender, EventArgs e)
        {

            if (U1Check.Checked) textBoxU1.Enabled = true;
            else textBoxU1.Enabled = false;
        }

        private void U2Check_CheckedChanged(object sender, EventArgs e)
        {
            if (U2Check.Checked) textBoxU2.Enabled = true;
            else textBoxU2.Enabled = false;
        }

        private void U3Check_CheckedChanged(object sender, EventArgs e)
        {
            if (U3Check.Checked) textBoxU3.Enabled = true;
            else textBoxU3.Enabled = false;
        }

        private void U4Check_CheckedChanged(object sender, EventArgs e)
        {
            if (U4Check.Checked) textBoxU4.Enabled = true;
            else textBoxU4.Enabled = false;
        }

        private void U5Check_CheckedChanged(object sender, EventArgs e)
        {
            if (U5Check.Checked) textBoxU5.Enabled = true;
            else textBoxU5.Enabled = false;
        }

        private void CategoriasCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (CategoriasCheck.Checked) Categorias.Enabled = true;
            else Categorias.Enabled = false;
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select an image",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);

                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void Form2_Load(object sender, EventArgs e){
            _form1.cambiarColor(Color.Gray);
            DataClasses1DataContext db = new DataClasses1DataContext();
            var atributos = db.Atributo.Take(5).ToList();

            if (atributos.Count > 0) textBoxU1.Text = atributos.ElementAtOrDefault(0).nombre ?? string.Empty;
            if (atributos.Count > 1) textBoxU2.Text = atributos.ElementAtOrDefault(1).nombre ?? string.Empty;
            if (atributos.Count > 2) textBoxU3.Text = atributos.ElementAtOrDefault(2).nombre ?? string.Empty;
            if (atributos.Count > 3) textBoxU4.Text = atributos.ElementAtOrDefault(3).nombre ?? string.Empty;
            if (atributos.Count > 4) textBoxU5.Text = atributos.ElementAtOrDefault(4).nombre ?? string.Empty;

            var categorias = db.Categoria.Take(100).ToList();
            
            Categorias.DataSource = categorias;
            Categorias.DisplayMember = "nombre"; 
            Categorias.ValueMember = "id";     
            Categorias.SelectedIndex = -1;
            int numOfAtributes = db.Atributo.Count();
            if (numOfAtributes < 1)
            {
                U1Check.Enabled = false;
                textBoxU1.Enabled = false;
                 textBoxU1.Text = "No User Atribute 1";
            }
            if (numOfAtributes < 2)
            {
                U2Check.Enabled = false;
                textBoxU2.Enabled = false;
                 textBoxU2.Text = "No User Atribute 2";
            }
            if (numOfAtributes < 3)
            {
                U3Check.Enabled = false;
                textBoxU3.Enabled = false;
                 textBoxU3.Text = "No User Atribute 3";
            }
            if (numOfAtributes < 4)
            {
                U4Check.Enabled = false;
                textBoxU4.Enabled = false;
                 textBoxU4.Text = "No User Atribute 4";
            }
            if (numOfAtributes < 5)
            {
                U5Check.Enabled = false;
                textBoxU5.Enabled = false;
                 textBoxU5.Text = "No User Atribute 5";
            }


        }

        private void Salir_Click(object sender, EventArgs e)
        {
            _form1.cambiarColor(Color.White);
            this.Close();
        }

        private void textBoxU3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSKU_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxU1_TextChanged(object sender, EventArgs e)
        {

        }
        }
}