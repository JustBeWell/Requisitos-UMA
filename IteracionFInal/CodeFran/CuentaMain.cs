using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json; // Para usarse, se intaló en la consola de administrador de paquetes: NuGet\Install-Package Newtonsoft.Json -Version 6.0.1
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class CuentaMain : Form
    {
        private Form _form1;
        private DateTime _accountCreationDate; // Fecha y hora de creación de la cuenta

        DataClasses1DataContext database = new DataClasses1DataContext();

        public CuentaMain(Form form1)
        {
            _form1 = form1;
            InitializeComponent();
        }

        private void CuentaMain_Load(object sender, EventArgs e)
        {
            _accountCreationDate = DateTime.Now;

            // Rellenar las TextBoxes
            LoadAccountInfo();
        }

        private void LoadAccountInfo()
        {
            // Nombre de la cuenta (puedes ajustarlo si tienes un nombre definido en base de datos)
            labelAccountName.Text = "Owner Account";

            // Fecha y hora de creación
            labelDate.Text = _accountCreationDate.ToString("yyyy-MM-dd HH:mm:ss");

            // Número de productos
            labelProducts.Text = database.Producto.Count().ToString();

            // Número de categorías creadas (máximo 3)
            labelCategories.Text = Math.Min(database.Categoria.Count(), 3).ToString();

            // Número de atributos creados (máximo 5)
            labelUA.Text = Math.Min(database.Atributo.Count(), 5).ToString();

            // Número de relaciones creadas (máximo 3)
            // labelRelationships.Text = Math.Min(database.Relacion.Count(), 3).ToString();
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

        /*
        * Eventos de Navegación entre menús
        */

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
            // TODO
        }

        private void buttonJSON_Click(object sender, EventArgs e)
        {
            try
            {
                // Recuperamos todos los datos de la cuenta en una variable
                var informeCuenta = new
                {
                    AccountName = labelAccountName.Text,
                    CreationDate = labelDate.Text,
                    ProductCount = labelProducts.Text,
                    CategoryCount = labelCategories.Text,
                    AttributeCount = labelUA.Text,
                    //RelationshipCount = labelRelationships.Text
                };

                // Convertir a JSON el informe de la cuenta
                string json = JsonConvert.SerializeObject(informeCuenta, Formatting.Indented);

                // Mostramos el menu de previsualización del JSON
                CrearJSON JSON_Preview = new CrearJSON(json, this);
                JSON_Preview.FormClosed += (s, args) =>
                {
                    this.Show();
                };
                JSON_Preview.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error ocurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
