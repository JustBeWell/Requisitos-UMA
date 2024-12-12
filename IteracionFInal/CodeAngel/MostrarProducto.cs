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
    public partial class MostrarProducto : Form
    {
        private MainForm _form1;
        private Producto prod;

        public MostrarProducto(MainForm form1, Producto prod)
        {
            InitializeComponent();
            _form1 = form1;
            this.prod = prod;
            this.textBoxGTIN.Text = prod.GTIN;
            this.textBoxLabel.Text = prod.Label;
            this.textBoxSKU.Text = prod.SKU;
            this.label1.Text = prod.Thumbnail;
            DataClasses1DataContext db = new DataClasses1DataContext();
            List<ValorAtributo> atributosDelProducto = (from va in db.ValorAtributo
                                                       where va.producto_SKU.Equals(prod.SKU)
                                                       select va).Take(5).ToList();
            var categoriasProducto = from pc in db.ProductoCategoria
                                     join c in db.Categoria on pc.categoria_id equals c.id
                                     where pc.producto_SKU == prod.SKU // Asegúrate de que `prod.SKU` sea el SKU del producto actual
                                     select c;

            // Asignar las categorías a la combobox
            Categorias.Enabled = true;
            Categorias.DataSource = categoriasProducto.ToList();
            Categorias.DisplayMember = "nombre";
            Categorias.ValueMember = "id";
            Categorias.SelectedIndex = -1;


            var valoresAtributos = (from va in db.ValorAtributo
                                    join a in db.Atributo on va.atributo_id equals a.id
                                    where va.producto_SKU == prod.SKU
                                    select va.valor).Take(5).ToList();

            // Asignar los valores a los TextBox correspondientes
            textBoxU1.Text = valoresAtributos.ElementAtOrDefault(0) ?? "No User Attribute 1";
            textBoxU2.Text = valoresAtributos.ElementAtOrDefault(1) ?? "No User Attribute 2";
            textBoxU3.Text = valoresAtributos.ElementAtOrDefault(2) ?? "No User Attribute 3";
            textBoxU4.Text = valoresAtributos.ElementAtOrDefault(3) ?? "No User Attribute 4";
            textBoxU5.Text = valoresAtributos.ElementAtOrDefault(4) ?? "No User Attribute 5";
            int numOfAtributes = db.Atributo.Count();
            if (numOfAtributes < 1)
            {
       
                textBoxU1.Enabled = false;
                textBoxU1.Text = "No User Atribute 1";
            }
            if (numOfAtributes < 2)
            {
  
                textBoxU2.Enabled = false;
                textBoxU2.Text = "No User Atribute 2";
            }
            if (numOfAtributes < 3)
            {

                textBoxU3.Enabled = false;
                textBoxU3.Text = "No User Atribute 3";
            }
            if (numOfAtributes < 4)
            {

                textBoxU4.Enabled = false;
                textBoxU4.Text = "No User Atribute 4";
            }
            if (numOfAtributes < 5)
            {
      
                textBoxU5.Enabled = false;
                textBoxU5.Text = "No User Atribute 5";
            }


        }

        private void Salir_Click(object sender, EventArgs e)
        {
            _form1.cambiarColor(Color.White);
            this.Close();
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

        private void textBoxU1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxGTIN_TextChanged(object sender, EventArgs e)
        {

        }

        private void Salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarProducto_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Categorias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



    }
}
