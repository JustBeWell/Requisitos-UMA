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
            DataClasses1DataContext db = new DataClasses1DataContext();
            List<ValorAtributo> atributosDelProducto = (from va in db.ValorAtributo
                                                       where va.producto_SKU.Equals(prod.SKU)
                                                       select va).Take(5).ToList();

            /*if (atributosDelProducto.Count < 1 || atributosDelProducto[0].valor.Equals(""))
            {
                this.textBoxU1.Text = "NULL";
            }else{
                this.textBoxU1.Text = atributosDelProducto[0].valor;
            }
            if (atributosDelProducto.Count < 2 || atributosDelProducto[1].valor.Equals(""))
            {
                this.textBoxU2.Text = "NULL";
            }
            else
            {
                this.textBoxU2.Text = atributosDelProducto[1].valor;
            }
            if (atributosDelProducto.Count < 3 || atributosDelProducto[2].valor.Equals(""))
            {
                this.textBoxU3.Text = "NULL";
            }
            else
            {
                this.textBoxU3.Text = atributosDelProducto[2].valor;
            }
            if (atributosDelProducto.Count < 4 || atributosDelProducto[3].valor.Equals(""))
            {
                this.textBoxU4.Text = "NULL";
            }
            else
            {
                this.textBoxU4.Text = atributosDelProducto[3].valor;
            }
            if (atributosDelProducto.Count < 5 || atributosDelProducto[4].valor.Equals(""))
            {
                this.textBoxU5.Text = "NULL";
            }
            else
            {
                this.textBoxU5.Text = atributosDelProducto[4].valor;
            } 
            var categorias = db.Categoria.Take(100).ToList();
           
            Categorias.DataSource = categorias;
            Categorias.DisplayMember = "nombre";
            Categorias.ValueMember = "id";
            Categorias.SelectedIndex = -1;*/
        }

        private void MostrarProducto_Load(object sender, EventArgs e)
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



    }
}
