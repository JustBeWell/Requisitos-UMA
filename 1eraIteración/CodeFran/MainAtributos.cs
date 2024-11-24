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
    public partial class MainAtributos : Form
    {

        private const int MaxAttributes = 5;   // Una misma cuenta no puede tener más de 5 atributos de usuario
        private List<Atributo> UserAttributes; 


        public MainAtributos()
        {
            InitializeComponent();
        }


        private void MainAtributos_Load(object sender, EventArgs e)
        {
            UserAttributes = new List<Atributo>();

            load();
            ResaltarBoton(this.Atributo);
            ActualizarInterfaz();
        }


        private void ActualizarInterfaz()
        {
            dataGridViewAtributos.DataSource = null; 
            dataGridViewAtributos.Rows.Clear();
            foreach (var atributo in UserAttributes)
            {
                dataGridViewAtributos.Rows.Add(atributo.tipo, atributo.nombre);
            }

            // Actualiza contadores en pantalla según la cuenta actual de User Attributes creados
            label_UserAttributes.Text = string.Format("User Attributes: {0}", UserAttributes.Count);
            label_AvailableAttributes.Text = string.Format("Available: {0}", MaxAttributes - UserAttributes.Count);

            // Inhabilita el botón de añadir si se alcanza el límite de User Attributes
            btn_AñadirAtributo.Enabled = UserAttributes.Count < MaxAttributes;

            // Avisa al usuario que ya no puede crear más atributos
            label_MaxReached.Visible = UserAttributes.Count >= MaxAttributes;
        }


        public void load()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            var atributosConTipo = db.TipoAtributo
                .Join(
                    db.TipoAtributo,
                    atributo => atributo.id,
                    tipo => tipo.id,
                    (atributo, tipo) => new
                    {
                        atributo.id,
                        atributo.nombre,
                        TipoNombre = tipo.nombre
                    }
                )
                .ToList();

            dataGridViewAtributos.DataSource = atributosConTipo;
            dataGridViewAtributos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewColumn column in dataGridViewAtributos.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            AgregarColumnasDeBotones();
        }


        private void AgregarColumnasDeBotones()
        {
            if (dataGridViewAtributos.Rows.Count > 0)
            { 
                if (!dataGridViewAtributos.Columns.Contains("Editar"))
                {
                    DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
                    editButtonColumn.HeaderText = "Actions";
                    editButtonColumn.Text = "EDIT";
                    editButtonColumn.UseColumnTextForButtonValue = true;
                    dataGridViewAtributos.Columns.Add(editButtonColumn);
                }

                if (!dataGridViewAtributos.Columns.Contains("Eliminar"))
                {
                    DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                    deleteButtonColumn.Text = "DELETE";
                    deleteButtonColumn.UseColumnTextForButtonValue = true;
                    dataGridViewAtributos.Columns.Add(deleteButtonColumn);
                }
            }
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


        private void dataGridAtributos_SelectionChanged(object sender, EventArgs e)
        {

        }


        private void Producto_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Atributo_Click(object sender, EventArgs e)
        {
            ResaltarBoton((Button)sender);
        }


        private void btn_AñadirAtributo_Click(object sender, EventArgs e)
        {
            // Nueva ventana donde se crea el atributo
            using (var formAdd = new CrearAtributo())
            {
                if (formAdd.ShowDialog() == DialogResult.OK)
                {
                    using (var db = new DataClasses1DataContext())
                    {
                        db.Atributo.InsertOnSubmit(formAdd.AtributoCreado);
                        db.SubmitChanges();
                    }

                    load();
                    ActualizarInterfaz();
                }
            }
        }

        private void Categoria_Click(object sender, EventArgs e)
        {

        }


    }
}
