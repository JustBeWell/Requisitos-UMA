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
    public partial class CategoriasMain : Form
    {
        private Form _form1;
        public CategoriasMain(Form form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        private void CategoriasMain_Load(object sender, EventArgs e)
        {
            load();
            this.Size = new Size(1200, 700);
            ResaltarBoton(this.Categoria);
        }

        public void load()
        {
            DataClasses1DataContext bd = new DataClasses1DataContext();
            var categoriasConConteo = bd.Categoria.GroupJoin(
            bd.ProductoCategoria,
            c => c.id,
            pc => pc.categoria_id,
            (categoria, productos) => new
            {
                categoria.id,
                categoria.nombre,
                NumeroDeProductos = productos.Count()
            }
        )
        .ToList();
            Categorias.DataSource = categoriasConConteo;

            Categorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewColumn column in Categorias.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            AgregarColumnasDeBotones();
        }
        private void AgregarColumnasDeBotones()
        {
            if (!Categorias.Columns.Contains("Editar"))
            {
                DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
                editButtonColumn.Name = "Editar";
                editButtonColumn.HeaderText = "Actions";
                editButtonColumn.Text = "EDIT";
                editButtonColumn.UseColumnTextForButtonValue = true;
                Categorias.Columns.Add(editButtonColumn);
            }

            if (!Categorias.Columns.Contains("Eliminar"))
            {
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                deleteButtonColumn.Name = "Eliminar";
                deleteButtonColumn.Text = "DELETE";
                deleteButtonColumn.UseColumnTextForButtonValue = true;
                Categorias.Columns.Add(deleteButtonColumn);
            }
        }
        private void Añadir_Click(object sender, EventArgs e)
        {
            CrearCategoria crear = new CrearCategoria(this);
            crear.ShowDialog();
        }

        private void Categorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int categoriaId = Convert.ToInt32(Categorias.Rows[e.RowIndex].Cells["id"].Value);
                string categoriaNombre = Categorias.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                int numeroDeProductos = Convert.ToInt32(Categorias.Rows[e.RowIndex].Cells["NumeroDeProductos"].Value);

                Categoria categoriaSeleccionada = new Categoria
                {
                    id = categoriaId,
                    nombre = categoriaNombre,
                };

                if (Categorias.Columns[e.ColumnIndex].Name == "Editar")
                {
                    EditarCategoria editarForm = new EditarCategoria(this, categoriaSeleccionada);
                    editarForm.ShowDialog();
                }
                else if (Categorias.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    BorrarCategoria borrarForm = new BorrarCategoria(this, categoriaSeleccionada, numeroDeProductos);
                    borrarForm.ShowDialog();
                }
            }
        }
       
        public void cambiarColor(Color color)
        {
            this.BackColor = color;
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

        private void button2_Click(object sender, EventArgs e)
        {
            CrearCategoria crear = new CrearCategoria(this);
            crear.ShowDialog();
            this.Close();
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
            ResaltarBoton((Button)sender);
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



    }
}
