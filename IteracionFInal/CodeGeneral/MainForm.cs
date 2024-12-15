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
    public partial class MainForm : Form
    {
        private bool isFormLoading = true;
        private Form _form1;
        public MainForm(Form form1 = null)
        {
            InitializeComponent();
            _form1 = form1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            LoadAllProducts();
            this.Size = new Size(1200, 700);
            ResaltarBoton(this.Producto);
            loadCategories();
            isFormLoading = false;

        }
        



        private void textBoxSearchby_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
         
        }

        private void textBoxSearchby_Enter(object sender, EventArgs e)
        {
            textBoxSearchby.SelectAll();
        }

        private void textBoxSearchby_Click(object sender, EventArgs e)
        {
            textBoxSearchby.SelectAll();
        }

        private void textBoxSearchby_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Detecta si se presionó Enter
            {
                string searchText = textBoxSearchby.Text.Trim(); // Texto ingresado
                if (string.IsNullOrEmpty(searchText))
                {
                    // Si no hay texto, mostrar todos los productos
                    LoadAllProducts();
                }
                else
                {
                    // Realiza el filtro por SKU o Label
                    FilterProducts(searchText);
                }
            }
        }
        public void load()
        {
            LoadAllProducts();
        }
        private void LoadAllProducts()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var query = from p in db.Producto
                        join va in db.ValorAtributo on p.SKU equals va.producto_SKU into vaGroup
                        from va in vaGroup.DefaultIfEmpty()
                        join a in db.Atributo on va.atributo_id equals a.id into aGroup
                        from a in aGroup.DefaultIfEmpty()
                        group new { va, a } by new
                        {
                            p.SKU,
                            p.GTIN,
                            p.Thumbnail,
                            p.Label
                        } into grouped
                        select new
                        {
                            SKU = grouped.Key.SKU,
                            GTIN = grouped.Key.GTIN,
                            Thumbnail = grouped.Key.Thumbnail,
                            Label = grouped.Key.Label,
                            UserAttribute1 = grouped
                            .Where(g => g.a != null)
                            .OrderBy(g => g.a.id)
                            .Select(g => g.va.valor.Length > 50 ? g.va.valor.Substring(0, 50) : g.va.valor)
                            .FirstOrDefault(),
                            UserAttribute2 = grouped
                            .Where(g => g.a != null)
                            .OrderBy(g => g.a.id)
                            .Select(g => g.va.valor.Length > 50 ? g.va.valor.Substring(0, 50) : g.va.valor)
                            .Skip(1)
                            .FirstOrDefault()
                        };

            if (query.Count() == 0)
            {
                MessageBox.Show("There are no products loaded in the system");
            }
            dataGridViewProductos.DataSource = query.ToList();
            labelProductoCount.Text = db.Producto.Count().ToString() + " Products";
            }
        private void FilterProducts(string searchText)
        {
            {

                DataClasses1DataContext db = new DataClasses1DataContext();

                var query = from p in db.Producto
                            join va in db.ValorAtributo on p.SKU equals va.producto_SKU into vaGroup
                            from va in vaGroup.DefaultIfEmpty()
                            join a in db.Atributo on va.atributo_id equals a.id into aGroup
                            from a in aGroup.DefaultIfEmpty()
                            where
                                  (p.Label.Contains(searchText) || p.SKU.Contains(searchText))
                            group new { va, a } by new
                            {
                                p.SKU,
                                p.GTIN,
                                p.Thumbnail,
                                p.Label
                            } into grouped
                            select new
                            {
                                SKU = grouped.Key.SKU,
                                GTIN = grouped.Key.GTIN,
                                Thumbnail = grouped.Key.Thumbnail,
                                Label = grouped.Key.Label,
                                UserAttribute1 = grouped.Where(g => g.a != null).OrderBy(g => g.a.id).Select(g => g.va.valor).FirstOrDefault(),
                                UserAttribute2 = grouped.Where(g => g.a != null).OrderBy(g => g.a.id).Select(g => g.va.valor).Skip(1).FirstOrDefault()
                            };

                
                if(query.Count() == 0)
                {
                    labelProductoCount.Text = query.Count().ToString() + " Products";
                    MessageBox.Show("There are no products matching the search criteria");
                    
                    
                }
                dataGridViewProductos.DataSource = query.ToList();
                

            }
        }

        private void Añadir_Click(object sender, EventArgs e)
        {
            CrearProducto añadir = new CrearProducto(this);
            añadir.ShowDialog();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.SelectedRows[0] != null)
            {
                var filaSeleccionada = dataGridViewProductos.SelectedRows[0];
                try
                {
                    Producto p = new Producto()
                    {
                        SKU = filaSeleccionada.Cells[0].Value.ToString(),
                        GTIN = filaSeleccionada.Cells[1].Value.ToString(),
                        Label = filaSeleccionada.Cells[3].Value.ToString(),
                        
                    };
                    if (filaSeleccionada.Cells["Thumbnail"].Value == null)
                    {
                        p.Thumbnail = "No Thumbnail yet";
                    }
                    else
                    {
                        p.Thumbnail = filaSeleccionada.Cells["Thumbnail"].Value.ToString();
                    }
                    EditarProducto editar = new EditarProducto(this, p);
                    editar.ShowDialog();
                }
                catch (Exception ex)
                {
                    cambiarColor(Color.White);
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.SelectedRows[0] != null)
            {
                var filaSeleccionada = dataGridViewProductos.SelectedRows[0];
                try
                {
                    Producto p = new Producto()
                    {
                        SKU = filaSeleccionada.Cells[0].Value.ToString(),
                        GTIN = filaSeleccionada.Cells[1].Value.ToString(),
                        Label = filaSeleccionada.Cells[2].Value.ToString(),
                        Thumbnail = filaSeleccionada.Cells[3].Value.ToString()
                    };
                    BorrarProducto borrar = new BorrarProducto(this, p);
                    borrar.ShowDialog();
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        public void cambiarColor(Color color)
        {
            this.BackColor = color;
        }


        private void labelProductoCount_Click(object sender, EventArgs e)
        {

        }
        private void ResaltarBoton(Button botonSeleccionado)
        {
            // Restaurar estilo de todos los botones en el panel
            foreach (Control control in panel1.Controls)
            {
                    Button boton = control as Button; // Intenta convertir el control a Button
                    if (boton != null)
                    {
                        boton.BackColor = SystemColors.Control; // Color predeterminado
                        boton.ForeColor = Color.Black; // Texto en negro
                    }
            } 

            // Resaltar el botón seleccionado
            botonSeleccionado.BackColor = Color.Blue; // Color azul
            botonSeleccionado.ForeColor = Color.White; // Texto blanco
        }

        private void dataGridViewProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
    // Verifica que la fila seleccionada sea válida
            if (e.RowIndex >= 0)
            {
                // Obtén los valores de la fila seleccionada
                var filaSeleccionada = dataGridViewProductos.Rows[e.RowIndex];

                try
                {
                    // Crea una instancia del objeto Producto usando los valores de la fila seleccionada

                    Producto productoSeleccionado = new Producto()
                    {
                        SKU = filaSeleccionada.Cells["SKU"].Value.ToString(),
                        GTIN = filaSeleccionada.Cells["GTIN"].Value.ToString(),
                        Label = filaSeleccionada.Cells["Label"].Value.ToString()
                    };
                    if (filaSeleccionada.Cells["Thumbnail"].Value == null)
                    {
                        productoSeleccionado.Thumbnail = "No Thumbnail yet";
                    }
                    else
                    {
                        productoSeleccionado.Thumbnail = filaSeleccionada.Cells["Thumbnail"].Value.ToString();
                    }
                    // Abre el formulario MostrarProducto
                    MostrarProducto mostrarProductoForm = new MostrarProducto(this, productoSeleccionado);
                    mostrarProductoForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al mostrar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                }
           }


        private void comboBoxCategoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCategoryFilter.SelectedIndex != -1 && !isFormLoading)
            {

                int selectedCategoryId = (int)comboBoxCategoryFilter.SelectedValue;

                // Llama al método para filtrar productos por categoría
                FilterProductsByCategory(selectedCategoryId);
            }
        }

        private void loadCategories()
        {
           
                DataClasses1DataContext db = new DataClasses1DataContext();
                var categories = db.Categoria.Select(c => new { c.id, c.nombre }).ToList();
                comboBoxCategoryFilter.DataSource = categories;
                comboBoxCategoryFilter.DisplayMember = "nombre";
                comboBoxCategoryFilter.ValueMember = "id";
            
            
        }
        //Vamos a crear un método privado para cargar todas las categorías
        private void FilterProductsByCategory(int categoryId)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            var query = from p in db.Producto
                        join pc in db.ProductoCategoria on p.SKU equals pc.producto_SKU
                        where pc.categoria_id == categoryId
                        join va in db.ValorAtributo on p.SKU equals va.producto_SKU into vaGroup
                        from va in vaGroup.DefaultIfEmpty()
                        join a in db.Atributo on va.atributo_id equals a.id into aGroup
                        from a in aGroup.DefaultIfEmpty()
                        group new { va, a } by new
                        {
                            p.SKU,
                            p.GTIN,
                            p.Thumbnail,
                            p.Label
                        } into grouped
                        select new
                        {
                            SKU = grouped.Key.SKU,
                            GTIN = grouped.Key.GTIN,
                            Thumbnail = grouped.Key.Thumbnail,
                            Label = grouped.Key.Label,
                            UserAttribute1 = grouped.Where(g => g.a != null).OrderBy(g => g.a.id).Select(g => g.va.valor).FirstOrDefault(),
                            UserAttribute2 = grouped.Where(g => g.a != null).OrderBy(g => g.a.id).Select(g => g.va.valor).Skip(1).FirstOrDefault()
                        };

            if (query.Count() == 0)
            {
                MessageBox.Show("No products found for the selected category.");
                labelProductoCount.Text = "0 Products";
                loadCategories(); // Recarga las categorías
                LoadAllProducts();
            }
            else
            {
                labelProductoCount.Text = query.Count().ToString() + " Products";
                dataGridViewProductos.DataSource = query.ToList();
            }
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            LoadAllProducts(); // Carga todos los productos nuevamente
            comboBoxCategoryFilter.SelectedIndex = -1; // Reinicia la selección de la categoría
        }

        private void checkBoxClearFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxClearFilter.Checked)
            {
                LoadAllProducts(); // Carga todos los productos
                comboBoxCategoryFilter.SelectedIndex = -1; // Limpia la selección de la categoría
                comboBoxCategoryFilter.Enabled = false;
            }
            else
            {
                comboBoxCategoryFilter.Enabled = true;
            }
        }

<<<<<<< Updated upstream:IteracionFInal/CodeGeneral/MainForm.cs

        /*
 * Eventos de Navegación entre menús
 */

        private void Cuenta_Click(object sender, EventArgs e)
        {
            this.Hide();

            CuentaMain cm = new CuentaMain(this);
            cm.FormClosed += (s, args) =>
            {
                this.Show();
                ResaltarBoton(this.Atributo);
                this.Close();
            };

            cm.Show();
            this.ActiveControl = null;
        }

        private void Producto_Click(object sender, EventArgs e)
        {
            ResaltarBoton(Atributo);
        }

        private void Assets_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void Categoria_Click(object sender, EventArgs e)
        {
            this.Hide();

            CategoriasMain FormCategorias = new CategoriasMain(this);
            FormCategorias.FormClosed += (s, args) =>
            {
                this.Show();
                ResaltarBoton(this.Categoria);
                this.Close();
            };
            FormCategorias.Show();
            this.ActiveControl = null;
        }

        private void Atributo_Click(object sender, EventArgs e)
        {
            this.Hide();

            AtributoMain atrib = new AtributoMain(this);
            atrib.FormClosed += (s, args) =>
            {
                this.Show();
                ResaltarBoton(this.Categoria);
                this.Close();
            };

            atrib.Show();
            this.ActiveControl = null;
        }

        private void Relacion_Click(object sender, EventArgs e)
        {
            this.Hide();

            RelacionesMain rel = new RelacionesMain(this);
            rel.FormClosed += (s, args) =>
            {
                this.Show();
                ResaltarBoton(this.Relacion);
                this.Close();
            };

            rel.Show();
            this.ActiveControl = null;
        }

        private void Ayuda_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Click(object sender, EventArgs e)
        {

        }


=======
        private void btnCSV_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select at least one product to export.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataClasses1DataContext db = new DataClasses1DataContext();

            // Obtener los SKU de las filas seleccionadas
            List<string> selectedSKUs = new List<string>();
            foreach (DataGridViewRow fila in dataGridViewProductos.SelectedRows)
            {
                if (fila.Cells["SKU"].Value != null)
                {
                    selectedSKUs.Add(fila.Cells["SKU"].Value.ToString());
                }
            }

            // Filtrar los productos directamente con LINQ
            var selectedProducts = db.Producto
                .Where(p => selectedSKUs.Contains(p.SKU))
                .ToList();
            // Crear una instancia del formulario AtributosCSV
            AtributosCSV atributosForm = new AtributosCSV(selectedProducts);

            // Ocultar el MainForm
            this.Hide();

            // Mostrar el formulario de atributos como ventana modal
            atributosForm.FormClosed += (s, args) =>
            {
                // Mostrar el MainForm nuevamente cuando se cierre el formulario de atributos
                this.Show();
            };
            atributosForm.ShowDialog();
        }
>>>>>>> Stashed changes:IteracionFInal/CodeAngel/MainForm.cs
}


}

