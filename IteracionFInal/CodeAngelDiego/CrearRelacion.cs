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
            // Validar que el nombre no esté vacío o sea el predeterminado
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

            // Validar que los productos seleccionados sean diferentes
            if (listBox1.SelectedValue.ToString() == listBox2.SelectedValue.ToString())
            {
                MessageBox.Show("Same products chosen!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener los valores ingresados
            string nombreRelacion = textBox1.Text;
            string productoSKU1 = listBox1.SelectedValue.ToString();
            string productoSKU2 = listBox2.SelectedValue.ToString();

            // Insertar la nueva relación en la base de datos
            try
            {
                using (var dbContext = new DataClasses1DataContext()) // Reemplaza con el nombre de tu contexto
                {
                    // Comprobar que no exista ya una relación con el mismo nombre
                    bool existeRelacion = dbContext.Relacion.Any(r => r.nombre == nombreRelacion);

                    // Comprobar que no exista un producto con el mismo nombre en SKU o GTIN
                    bool existeProducto = dbContext.Producto.Any(p => p.SKU == nombreRelacion || p.GTIN == nombreRelacion);

                    if (existeRelacion)
                    {
                        MessageBox.Show("A relationship with this name already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (existeProducto)
                    {
                        MessageBox.Show("Invalid name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

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

                    // Recargar las relaciones en el formulario principal
                    this._form1.CargarRelaciones();

                    // Cerrar el formulario actual
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show("Error while creating the relationship: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    .Select(p => new { p.SKU, p.GTIN }) 
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
