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
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAllProducts();
            dataGridViewProductos.ClearSelection();
            ResaltarBoton(this.Producto);
            

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
                            UserAttribute1 = grouped.Where(g => g.a != null).OrderBy(g => g.a.id).Select(g => g.va.valor).FirstOrDefault(),
                            UserAttribute2 = grouped.Where(g => g.a != null).OrderBy(g => g.a.id).Select(g => g.va.valor).Skip(1).FirstOrDefault()
                        };


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
                        Label = filaSeleccionada.Cells[2].Value.ToString(),
                        Thumbnail = filaSeleccionada.Cells[3].Value.ToString()
                    };
                    EditarProducto editar = new EditarProducto(this, p);
                    editar.ShowDialog();
                }
                catch (NullReferenceException ex)
                {
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

        private void Categoria_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            MainCategorias cat = new MainCategorias();
            cat.FormClosed += (s, args) =>
            {
                this.Show(); // Muestra el MainForm nuevamente
                ResaltarBoton(this.Producto); // Resalta el botón de productos
            };
            cat.Show();
            this.ActiveControl = null;
            
        }

        private void Atributo_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainAtributos atr = new MainAtributos();
            atr.FormClosed += (s, args) =>
            {
                this.Show(); // Muestra el MainForm nuevamente
                ResaltarBoton(this.Producto); // Resalta el botón de productos
            };
            atr.Show();
            this.ActiveControl = null;
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {

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

        private void Producto_Click(object sender, EventArgs e)
        {
            ResaltarBoton((Button)sender);
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
                        Label = filaSeleccionada.Cells["Label"].Value.ToString(),
                        Thumbnail = filaSeleccionada.Cells["Thumbnail"].Value.ToString()
                    };

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

        private void Assets_Click(object sender, EventArgs e)
        {

        }

}


}

