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
    public partial class CrearRelacion : Form
    {
        private RelacionesMain _form1;
        public CrearRelacion(RelacionesMain form1)
        {
            _form1 = form1;
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || textBox1.Text == "New name")
            {
                MessageBox.Show("Choose a valid name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que ambos productos estén seleccionados
            if (listBox1.SelectedItem == null || listBox2.SelectedItem == null)
            {
                MessageBox.Show("Select one product for each List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (listBox1.SelectedItem.Equals(listBox2.SelectedItem))
            {
                MessageBox.Show("Same products chosen!");
                return;
            }
            // Obtener los valores seleccionados
            string nombreRelacion = textBox1.Text;
            string productoSKU1 = listBox1.SelectedValue.ToString(); // SKU del producto 1
            string productoSKU2 = listBox2.SelectedValue.ToString(); // SKU del producto 2

            // Insertar la nueva relación en la base de datos
            try
            {
                using (var dbContext = new DataClasses1DataContext()) // Reemplaza TuDbContext con el nombre de tu DbContext
                {
                    // Crear una nueva instancia de Relacion
                    var nuevaRelacion = new Relacion
                    {
                        nombre = nombreRelacion,
                        producto_SKU1 = productoSKU1,
                        producto_SKU2 = productoSKU2
                    };

                    // Agregar la relación a la base de datos
                    dbContext.Relacion.InsertOnSubmit(nuevaRelacion);
                    dbContext.SubmitChanges();
                    this._form1.CargarRelaciones();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show(ex.Message);
            }
        }

        private void CrearRelacion_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }
        private void CargarProductos()
        {
            using (var dbContext = new DataClasses1DataContext())
            {
                // Obtener la lista de productos de la base de datos
                var productos = dbContext.Producto
                    .Select(p => new { p.SKU, p.GTIN }) // Asegúrate de que estas propiedades existen en tu modelo
                    .ToList();

                // Cargar los productos en los ListBox
                listBox1.DataSource = productos;
                listBox1.DisplayMember = "SKU"; // Mostrar el nombre del producto
                listBox1.ValueMember = "SKU"; // Usar el SKU como identificador

                listBox2.DataSource = productos.ToList(); // Crear una copia para el segundo ListBox
                listBox2.DisplayMember = "SKU";
                listBox2.ValueMember = "SKU";
            }
        }
    }
}
