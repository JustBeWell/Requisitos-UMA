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
            CargarRelacionesEnListBox();
            //CargarProductosRelacionados();
        }

        private void CargarRelacionesEnListBox()
        {
            using (var dbContext = new DataClasses1DataContext()) // Reemplaza con tu contexto real
            {
                // Obtener todas las relaciones desde la base de datos
                var relaciones = dbContext.Relacion
                    .Select(r => new { r.nombre })
                    .ToList();

                if (relaciones.Any())
                {
                    // Configurar la primera ListBox para mostrar las relaciones
                    listBoxRelaciones.DataSource = relaciones;
                    listBoxRelaciones.DisplayMember = "nombre"; // Mostrar el nombre de la relación
                    listBoxRelaciones.ValueMember = "nombre"; // Usar el nombre como valor de la relación
                }
                else
                {
                    // Si no hay relaciones disponibles, vaciar el ListBox y mostrar un mensaje opcional
                    listBoxRelaciones.DataSource = null;
                    MessageBox.Show("No hay relaciones disponibles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void CargarProductosRelacionados()
        {
            using (var dbContext = new DataClasses1DataContext()) // Reemplaza con tu contexto real
            {
                // Obtener todos los productos relacionados de la base de datos
                var productosRelacionados = dbContext.Relacion
                    .SelectMany(r => new[] { r.producto_SKU1, r.producto_SKU2 }) // Expandir todos los productos relacionados
                    .Where(sku => sku != null) // Filtrar valores nulos
                    .Join(dbContext.Producto, sku => sku, p => p.SKU, (sku, p) => new
                    {
                        p.SKU,
                        p.GTIN
                    })
                    .ToList();

                if (productosRelacionados.Any())
                {
                    // Configurar la última ListBox con los productos relacionados
                    listBoxProductos.DataSource = productosRelacionados;
                    listBoxProductos.DisplayMember = "SKU"; // Mostrar el SKU
                    listBoxProductos.ValueMember = "SKU";  // Usar el SKU como valor del producto
                }
                else
                {
                    // Si no hay productos relacionados, vaciar el ListBox y mostrar un mensaje opcional
                    listBoxProductos.DataSource = null;
                    MessageBox.Show("No hay productos relacionados disponibles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Categorias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void listBoxRelaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*try
            {
                // Verificar que hay una relación seleccionada
                if (listBoxRelaciones.SelectedValue != null && !string.IsNullOrEmpty(listBoxRelaciones.SelectedValue.ToString()))
                {
                    // Obtener el ID de la relación seleccionada
                    string nombreRel = listBoxRelaciones.SelectedValue as string;

                    using (var dbContext = new DataClasses1DataContext()) // Reemplaza con tu contexto real
                    {
                        // Obtener los SKUs relacionados a la relación seleccionada
                        var skusRelacionados = dbContext.Relacion
                            .Where(r => r.nombre == nombreRel)
                            .SelectMany(r => new[] { r.producto_SKU1, r.producto_SKU2 }) // Expandir los SKUs
                            .Where(sku => sku != null) // Filtrar valores nulos
                            .ToList();

                        // Obtener los detalles de los productos relacionados
                        var productosRelacionados = dbContext.Producto
                            .Where(p => skusRelacionados.Contains(p.SKU))
                            .Select(p => new
                            {
                                p.SKU,
                                p.GTIN
                            })
                            .ToList();

                        // Configurar el ListBox con los productos relacionados
                        listBoxProductos.DataSource = productosRelacionados;
                        listBoxProductos.DisplayMember = "SKU"; // Mostrar el SKU
                        listBoxProductos.ValueMember = "SKU";  // Usar el SKU como valor del producto
                    }
                }
                else
                {
                    // Si no hay selección, vaciar el ListBox de productos
                    listBoxProductos.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
             */
        }



    }
}
