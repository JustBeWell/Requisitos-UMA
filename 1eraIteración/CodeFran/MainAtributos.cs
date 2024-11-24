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
            dataGridViewAtributos.EditMode = DataGridViewEditMode.EditOnEnter; // Permite la edición al entrar a la celda
            dataGridViewAtributos.CellDoubleClick += dataGridViewAtributos_CellDoubleClick;
            dataGridViewAtributos.CellValueChanged += dataGridViewAtributos_CellValueChanged;
            dataGridViewAtributos.CellBeginEdit += dataGridViewAtributos_CellBeginEdit;

        }


        private void MainAtributos_Load(object sender, EventArgs e)
        {
            UserAttributes = new List<Atributo>();

            ResaltarBoton(this.Atributo);
            ActualizarInterfaz();
            load();
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

            Boolean maxReached = UserAttributes.Count >= MaxAttributes;

            if (maxReached)
            {
                // Inhabilita el botón de añadir si se alcanza el límite de User Attributes
                btn_AñadirAtributo.Enabled = false;
                MessageBox.Show("Max attributes reached. Please delete.");
            }
            else
            {
                // Habilita el botón de añadir si no se ha alcanzado el límite
                btn_AñadirAtributo.Enabled = true;
            }
        }


        public void load()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            var listaAtributos = from a in db.Atributo
                                 join ta in db.TipoAtributo on a.tipo equals ta.id
                                 select new
                                 {
                                     Type = ta.nombre, // Nombre del tipo
                                     TypeID = ta.id, // ID para el ComboBox
                                     Name = a.nombre, // Nombre del atributo
                                     AtributoID = a.id // ID del atributo
                                 };

            dataGridViewAtributos.DataSource = listaAtributos.ToList();
            dataGridViewAtributos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Configurar columnas editables
            ConfigurarColumnasDataGridView(); // Llama al nuevo método aquí
            dataGridViewAtributos.Columns["TypeID"].Visible = false;
            dataGridViewAtributos.Columns["AtributoID"].Visible = false;
            // Reemplazar la columna Type con un ComboBox editable
            AgregarColumnaTipo();

            // Agregar botones de acciones
            AgregarColumnasDeBotones();
        }




        private void ConfigurarColumnasDataGridView()
        {
            // Desenlazar temporalmente el DataGridView de su fuente de datos
            var fuenteDatos = dataGridViewAtributos.DataSource; // Guarda la fuente de datos actual
            dataGridViewAtributos.DataSource = null;

            // Configurar las columnas como editables o no
            foreach (DataGridViewColumn column in dataGridViewAtributos.Columns)
            {
                if (column.Name == "Name")
                {
                    column.ReadOnly = false; // Estas columnas pueden editarse
                }
                else
                {
                    // column.ReadOnly = true; // Otras columnas son de solo lectura
                }
            }

            // Volver a enlazar la fuente de datos
            dataGridViewAtributos.DataSource = fuenteDatos;
        }


        private void AgregarColumnaTipo()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            // Crear una columna ComboBox editable
            if (dataGridViewAtributos.Columns["TypeEditable"] == null)
            {
                DataGridViewComboBoxColumn comboColumn = new DataGridViewComboBoxColumn
                {
                    HeaderText = "Type",
                    DataPropertyName = "TypeID",
                    Name = "TypeEditable",
                    DataSource = db.TipoAtributo.ToList(), // Fuente de datos
                    DisplayMember = "nombre", // Campo a mostrar
                    ValueMember = "id", // Valor a asociar
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                };

                // Reemplazar columna anterior (si existe) con el ComboBox
                if (dataGridViewAtributos.Columns.Contains("Type"))
                {
                    dataGridViewAtributos.Columns.Remove("Type");
                }
                dataGridViewAtributos.Columns.Add(comboColumn);
            }
        }






        private void AgregarColumnasDeBotones()
        {
            if (dataGridViewAtributos.Rows.Count > 0)
            {
                // Agregar columna de botón eliminar si no existe
                if (!dataGridViewAtributos.Columns.Contains("Eliminar"))
                {
                    DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
                    {
                        Name = "Eliminar",
                        HeaderText = "Actions",
                        Text = "DELETE",
                        UseColumnTextForButtonValue = true
                    };
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
            CrearAtributo nuevoAtributo = new CrearAtributo(this);
            nuevoAtributo.ShowDialog();
            // Arreglar que cuando regrese de CrearAtributo no se cambien las columnas de lugar
        }

        private void Categoria_Click(object sender, EventArgs e)
        {

        }


        private void dataGridViewAtributos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridViewAtributos.Rows[e.RowIndex];
                dynamic atributoModificado = row.DataBoundItem;

                if (atributoModificado != null)
                {
                    using (var context = new DataClasses1DataContext())
                    {
                        int atributoID = atributoModificado.AtributoID;
                        var atributoEnDB = context.Atributo.FirstOrDefault(a => a.id == atributoID);

                        if (atributoEnDB != null)
                        {
                            // Actualizar los valores según las columnas editadas
                            if (dataGridViewAtributos.Columns[e.ColumnIndex].Name == "Name")
                            {
                                atributoEnDB.nombre = atributoModificado.Name;
                            }
                            else if (dataGridViewAtributos.Columns[e.ColumnIndex].Name == "TypeEditable")
                            {
                                atributoEnDB.tipo = (int)row.Cells["TypeEditable"].Value;
                            }

                            context.SubmitChanges(); // Guardar cambios en la base de datos
                        }
                    }
                }
            }
        }



        private void dataGridViewAtributos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var columnName = dataGridViewAtributos.Columns[e.ColumnIndex].Name;
                // Solo permitir edición en la columna "Name"
                if (columnName == "Name")
                {
                    dataGridViewAtributos.BeginEdit(true); // Comienza la edición
                }
            }
        }


        private void dataGridViewAtributos_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // Obtener el nombre de la columna
            var columnName = dataGridViewAtributos.Columns[e.ColumnIndex].Name;

            // Permitir edición solo en columnas específicas
            //   if (columnName != "Name" && columnName != "TypeEditable")
            //   {
            //       e.Cancel = true; // Cancela la edición si no es una columna editable
            //   }
        }

        private void dataGridViewAtributos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewAtributos.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int atributoID = (int)dataGridViewAtributos.Rows[e.RowIndex].Cells["AtributoID"].Value;

                using (var context = new DataClasses1DataContext())
                {
                    var atributo = context.Atributo.FirstOrDefault(a => a.id == atributoID);
                    if (atributo != null)
                    {
                        // Crear el formulario de confirmación
                        BorrarAtributo confirmDelete = new BorrarAtributo();
                        confirmDelete.ShowDialog(); // Mostrar el formulario de confirmación

                        if (confirmDelete.IsConfirmed) // Si el usuario acepta
                        {
                            context.Atributo.DeleteOnSubmit(atributo);
                            context.SubmitChanges();
                            ActualizarInterfaz(); // Actualizar la interfaz después de eliminar
                        }
                    }
                }
            }
        }





    }
}
