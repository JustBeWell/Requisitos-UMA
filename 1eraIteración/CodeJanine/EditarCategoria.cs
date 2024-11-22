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
    public partial class EditarCategoria : Form
    {
        private MainForm _form1;
        private Categoria catg;

        public EditarCategoria(MainForm form1,Categoria catg)
        {
            InitializeComponent();
            _form1 = form1;
            this.catg = catg;
        }

        private void EditarProducto_Load(object sender, EventArgs e)
        {
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

        private void GtinCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (GtinCheck.Checked) textBoxGTIN.Enabled = true;
            else textBoxGTIN.Enabled = false;
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
            if (!U3Check.Checked) textBoxU3.Enabled = true;
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

        private void Confirmar_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var producto = db.Producto.FirstOrDefault(p => p.SKU == prod.SKU);

            if (producto != null)
            {
                if (GtinCheck.Checked && !string.IsNullOrWhiteSpace(textBoxGTIN.Text))
                {
                    producto.GTIN = textBoxGTIN.Text.Trim();
                }

                if (LabelCheck.Checked && !string.IsNullOrWhiteSpace(textBoxLabel.Text))
                {
                    producto.Label = textBoxLabel.Text.Trim();
                }

                var atributos = db.Atributo.Take(5).ToList();

                if (atributos.Count > 0 && U1Check.Checked && !string.IsNullOrWhiteSpace(textBoxU1.Text))
                {
                    var atributoU1 = atributos.ElementAtOrDefault(0);
                    if (atributoU1 != null)
                        ActualizarAtributo(db, producto.SKU, atributoU1.id, textBoxU1.Text.Trim());
                }

                if (atributos.Count > 1 && U2Check.Checked && !string.IsNullOrWhiteSpace(textBoxU2.Text))
                {
                    var atributoU2 = atributos.ElementAtOrDefault(1);
                    if (atributoU2 != null)
                        ActualizarAtributo(db, producto.SKU, atributoU2.id, textBoxU2.Text.Trim());
                }

                if (atributos.Count > 2 && U3Check.Checked && !string.IsNullOrWhiteSpace(textBoxU3.Text))
                {
                    var atributoU3 = atributos.ElementAtOrDefault(2);
                    if (atributoU3 != null)
                        ActualizarAtributo(db, producto.SKU, atributoU3.id, textBoxU3.Text.Trim());
                }

                if (atributos.Count > 3 && U4Check.Checked && !string.IsNullOrWhiteSpace(textBoxU4.Text))
                {
                    var atributoU4 = atributos.ElementAtOrDefault(3);
                    if (atributoU4 != null)
                        ActualizarAtributo(db, producto.SKU, atributoU4.id, textBoxU4.Text.Trim());
                }

                if (atributos.Count > 4 && U5Check.Checked && !string.IsNullOrWhiteSpace(textBoxU5.Text))
                {
                    var atributoU5 = atributos.ElementAtOrDefault(4);
                    if (atributoU5 != null)
                        ActualizarAtributo(db, producto.SKU, atributoU5.id, textBoxU5.Text.Trim());
                }

                if (CategoriasCheck.Checked && Categorias.SelectedValue != null)
                {
                    int categoriaId = (int)Categorias.SelectedValue;

                    // Eliminar asociaciones previas y añadir la nueva
                    var categoriasProducto = db.ProductoCategoria.Where(pc => pc.producto_SKU == producto.SKU);
                    db.ProductoCategoria.DeleteAllOnSubmit(categoriasProducto);

                    db.ProductoCategoria.InsertOnSubmit(new ProductoCategoria
                    {
                        producto_SKU = producto.SKU,
                        categoria_id = categoriaId
                    });
                }
            }

                db.SubmitChanges();
                _form1.load();
                _form1.cambiarColor(Color.White);
                this.Close();
        }
        private void ActualizarAtributo(DataClasses1DataContext db, string sku, int atributoId, string valor)
        {
            var atributo = db.ValorAtributo.FirstOrDefault(a => a.producto_SKU == sku && a.atributo_id == atributoId);

            if (atributo != null)
            {
                atributo.valor = valor;
            }
            else
            {
                db.ValorAtributo.InsertOnSubmit(new ValorAtributo
                {
                    producto_SKU = sku,
                    atributo_id = atributoId,
                    valor = valor
                });
            }
        }

    }
}
