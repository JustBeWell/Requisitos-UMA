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
        }

        private void Producto_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void Atributo_Click(object sender, EventArgs e)
        {
            this.Hide();

            AtributoMain atrib = new AtributoMain(this);
            atrib.FormClosed += (s, args) =>
            {
                this.Show();
                ResaltarBoton(this.Atributo);
                this.Close();
            };

            atrib.Show();
            this.ActiveControl = null;
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
    }
}
