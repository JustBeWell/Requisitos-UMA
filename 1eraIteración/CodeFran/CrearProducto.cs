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
            //Aqui se insertaria el producto antes de irse todo a la mierda :)
            DataClasses1DataContext db = new DataClasses1DataContext();
            if (string.IsNullOrWhiteSpace(textBoxSKU.Text) ||
                string.IsNullOrWhiteSpace(textBoxGTIN.Text) ||
                string.IsNullOrWhiteSpace(textBoxLabel.Text)){
                    MessageBox.Show("Incomplete Data", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }
            Producto p = new Producto
            {

                SKU = textBoxSKU.Text.Trim(),
                GTIN = textBoxGTIN.Text.Trim(),
                Label = textBoxLabel.Text.Trim(),
                Thumbnail = pictureBox1.ImageLocation ?? string.Empty
             
            };
            db.Producto.InsertOnSubmit(p);
            db.SubmitChanges();
            var atributos = db.Atributo.Take(5).ToList();
            if (!string.IsNullOrWhiteSpace(textBoxU1.Text))
            {
                
                db.ValorAtributo.InsertOnSubmit(new ValorAtributo
                {
                    producto_SKU = p.SKU,
                    atributo_id = atributos[0].id,
                    valor = textBoxU1.Text.Trim()
                });
                db.SubmitChanges();
            }

            if (!string.IsNullOrWhiteSpace(textBoxU2.Text))
            {
                db.ValorAtributo.InsertOnSubmit(new ValorAtributo
                {
                    producto_SKU = p.SKU,
                    atributo_id = atributos[1].id,
                    valor = textBoxU2.Text.Trim()
                });
                db.SubmitChanges();
            }

             if (!string.IsNullOrWhiteSpace(textBoxU3.Text))
            {
                db.ValorAtributo.InsertOnSubmit(new ValorAtributo
                {
                    producto_SKU = p.SKU,
                    atributo_id = atributos[2].id,
                    valor = textBoxU3.Text.Trim()
                });
                db.SubmitChanges();
            }
             if (!string.IsNullOrWhiteSpace(textBoxU4.Text))
            {
                db.ValorAtributo.InsertOnSubmit(new ValorAtributo
                {
                    producto_SKU = p.SKU,
                    atributo_id = atributos[3].id, 
                    valor = textBoxU4.Text.Trim()
                });
                db.SubmitChanges();
            }
             if (!string.IsNullOrWhiteSpace(textBoxU5.Text))
            {
                db.ValorAtributo.InsertOnSubmit(new ValorAtributo
                {
                    producto_SKU = p.SKU,
                    atributo_id = atributos[4].id, 
                    valor = textBoxU5.Text.Trim()
                });
                db.SubmitChanges();
            }
            // Insertar categoría
            if (Categorias.SelectedValue != null)
            {
                int categoriaId = (int)Categorias.SelectedValue;
                var categoriaExistente = db.Categoria.FirstOrDefault(c => c.id == categoriaId);
                if (categoriaExistente == null) return;
                db.ProductoCategoria.InsertOnSubmit(new ProductoCategoria
                {
                    producto_SKU = p.SKU,
                    categoria_id = categoriaExistente.id
                });
            }
            db.SubmitChanges();
            _form1.load();
            _form1.cambiarColor(Color.White);
            this.Close();
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