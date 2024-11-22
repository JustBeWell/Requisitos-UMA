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
            LoadAllCategorias();
            dataGridViewCategorias.ClearSelection();
            

        }

        private void textBoxSearchby_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void dataGridViewCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    // Si no hay texto, mostrar todas las categorias
                    LoadAllCategorias();
                }

            }
        }
        public void load()
        {
            LoadAllCategorias();
        }
        private void LoadAllCategorias()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            }

        private void Añadir_Click(object sender, EventArgs e)
        {
            CrearCategoria añadir = new CrearCategoria(this);
            añadir.ShowDialog();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            if (dataGridViewCategorias.SelectedRows[0] != null)
            {
                var filaSeleccionada = dataGridViewCategorias.SelectedRows[0];
                try
                {
                    Categoria catg = new Categoria()
                    {
                        nombre = filaSeleccionada.Cells[0].Value.ToString()
                    };
                    EditarCategoria editar = new EditarCategoria(this, catg);
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
            if (dataGridViewCategorias.SelectedRows[0] != null)
            {
                var filaSeleccionada = dataGridViewCategorias.SelectedRows[0];
                try
                {
                    Categoria p = new Categoria()
                    {
                        nombre = filaSeleccionada.Cells[0].Value.ToString(),
                    };
                    BorrarCategoria borrar = new BorrarCategoria(this, p);
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
        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
}


}

