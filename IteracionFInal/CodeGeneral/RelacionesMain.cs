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
    public partial class RelacionesMain : Form
    {
        private Form _form1;
        public RelacionesMain(Form form1)
        {
            _form1 = form1;
            InitializeComponent();
        }

        private void RelacionesMain_Load(object sender, EventArgs e)
        {
            ResaltarBoton(this.Relacion);
            this.Size = new Size(1200, 700);
            CargarRelaciones();
        }
        public void CargarRelaciones()
        {
            using (var dbContext = new DataClasses1DataContext()) // Reemplaza TuDbContext con el nombre de tu contexto
            {
                // Obtener las relaciones de la tabla 'Relaciones'
                var relaciones = dbContext.Relacion
                    .Select(r => new {r.nombre}) // Selecciona solo los campos que necesitas
                    .ToList();

                // Asignar la lista de relaciones como fuente de datos del DataGridView
                dataGridView1.DataSource = relaciones;
            }

            // Añadir columnas de botones de editar y borrar si no existen
            if (!dataGridView1.Columns.Contains("Edit"))
            {
                var editarButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Edit",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(editarButtonColumn);
            }

            if (!dataGridView1.Columns.Contains("Delete"))
            {
                var borrarButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(borrarButtonColumn);
            }

            // Configurar el ancho de las columnas
            int totalWidth = dataGridView1.ClientSize.Width; // Ancho total del DataGridView
            dataGridView1.Columns["Nombre"].Width = totalWidth / 2; // La columna "Nombre" ocupa la mitad del espacio
            dataGridView1.Columns["Edit"].Width = totalWidth / 4; // La columna "Editar" ocupa un cuarto del espacio
            dataGridView1.Columns["Delete"].Width = totalWidth / 4; // La columna "Borrar" ocupa un cuarto del espacio

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            CuentaMain cm = new CuentaMain(this);
            cm.FormClosed += (s, args) =>
            {
                this.Show(); // Se muestra el form de productos nuevamente
            };

            cm.Show();
            this.ActiveControl = null;
        }

        private void Añadir_Click(object sender, EventArgs e)
        {
            CrearRelacion cr = new CrearRelacion(this);
            cr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CrearRelacion cr = new CrearRelacion(this);
            cr.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string RelacionNombre = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();

                Relacion relacionSeleccionada = new Relacion
                {
                    nombre = RelacionNombre,
                };

                /*if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
                {
                    EditarRelacion editarForm = new EditarRelacion(this, relacionSeleccionada);
                    editarForm.ShowDialog();
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    BorrarRelacion borrarForm = new BorrarRelacion(this, relacionSeleccionada);
                    borrarForm.ShowDialog();
                }*/
            }
        }

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
            this.Hide();

            MainForm prod = new MainForm(this);
            prod.FormClosed += (s, args) =>
            {
                this.Show();
                ResaltarBoton(this.Producto);
                this.Close();
            };
            prod.Show();
            this.ActiveControl = null;
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
            ResaltarBoton((Button)sender);
        }

        private void Ayuda_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Click(object sender, EventArgs e)
        {

        }

    }
}
