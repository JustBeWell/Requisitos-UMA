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
    public partial class AtributoMain : Form
    {
        private Form _form1;
        private const int MaxAttributes = 5;
        private int UserAttributes;

        DataClasses1DataContext database = new DataClasses1DataContext();

        public AtributoMain(Form form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        /*
         * Evento que se ejecuta al abrir la seccion de Attributes
         */ 
        private void AtributoMain_Load(object sender, EventArgs e)
        {
            load();
            this.Size = new Size(1200, 700);
        }

        /*
         * Evento que recarga los valores de la DataGridViewAtributos
         */ 
        private void load()
        {
            CargarNumeroDeAtributos();
            ActualizarInterfaz();
            CargarDatos();

            ResaltarBoton(Atributo);
        }

        /*
         * Método para mostrar el número de atributos actuales y el límite máximo
         */
        private void ActualizarInterfaz()
        {
            label_UserAttributes.Text = string.Format("User Attributes ({0})", UserAttributes);
            label_AvailableAttributes.Text = string.Format("Available attributes ({0})", MaxAttributes - UserAttributes);

            // Deshabilita el botón para añadir atributos si hemos llegamos a MaxAttributes
            // btn_AñadirAtributo.Enabled = UserAttributes < MaxAttributes;
        }

        /*
         * Método para mantener los cambios de Available attributes en todo momento
         */
        private void CargarNumeroDeAtributos()
        {
            UserAttributes = database.Atributo.Count();
        }

        /*
         * Método que muestra en el DataGridViewAtributos la información de la Base de Datos
         */
        private void CargarDatos()
        {
            var listaAtributos = from a in database.Atributo
                                 join ta in database.TipoAtributo on a.tipo equals ta.id
                                 select new
                                 {
                                     Type = ta.nombre,  // TipoAtributo -> nombre
                                     Name = a.nombre,   // Atributo     -> nombre
                                     AtributoID = a.id, // Atributo     -> id
                                     TypeID = ta.id     // TipoAtributo -> id
                                 };
            dataGridViewAtributos.DataSource = listaAtributos.ToList();

            /* En listaAtributos recuperamos una referencia del ID del Atributo
             * que necesitamos tener activo para poder encontrar el Atributo
             * que se modificó el DataGridView tras hacer doble clic, ya sea
             * un cambio en la ComboBox (usamos ComboBox_SelectedIndexChanged)
             * con TypeID o en la TextBox (usamos GuardarCambios_TextBox)
             * 
             * Por su puesto, los dejamos hidden por que no la necesitamos en la UI
             */
            if (dataGridViewAtributos.Columns["AtributoID"] != null)
                dataGridViewAtributos.Columns["AtributoID"].Visible = false;

            if (dataGridViewAtributos.Columns["TypeID"] != null)
                dataGridViewAtributos.Columns["TypeID"].Visible = false;

            // Siempre añadimos el botón de eliminar
            if (!dataGridViewAtributos.Columns.Contains("Delete"))
            {
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    HeaderText = "Action",
                    Text = "DELETE",
                    UseColumnTextForButtonValue = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                };
                dataGridViewAtributos.Columns.Add(deleteButtonColumn);
            }
        }

        /*
         * Evento que permite al usuario crear un nuevo atributo
         * Carga el Form de CrearAtributo
         */ 
        private void btn_AñadirAtributo_Click(object sender, EventArgs e)
        {
            CrearAtributo nuevoAtributo = new CrearAtributo(this);
            nuevoAtributo.ShowDialog();

            CargarNumeroDeAtributos();
            ActualizarInterfaz();
            CargarDatos();
        }

        /*
         * Método para resaltar el botón en el Dashboard de la sección actual (Attributes)
         */ 
        private void ResaltarBoton(Button botonSeleccionado)
        {
            foreach (Control control in panel1.Controls)
            {
                Button boton = control as Button;
                if (boton != null)
                {
                    boton.BackColor = SystemColors.Control;
                    boton.ForeColor = Color.Black;
                }
            }
            botonSeleccionado.BackColor = Color.Blue;  // Highlight de selección
            botonSeleccionado.ForeColor = Color.White; // Color del texto
        }

        /*
         * Eventos de Navegación entre menús
         */
        private void Producto_Click(object sender, EventArgs e)
        {
            this.Close();
           
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
            ResaltarBoton(Atributo);
        }

        private void Relacion_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void Ayuda_Click(object sender, EventArgs e)
        {
           
        }

        /*
         * Eventos del DataGridViewAtributos
         */

        /*
         * Flujo para este evento:
         * Vamos hacer modificaciones dinámicas sobre el DataGridViewAtributos. Si queremos
         * modificar el nombre del atributo, se creará una TextBox donde el usuario escribirá
         * y al hacer clic en otro sitio (perdemos el focus de la TextBox), se guardan los cambios
         * y se borrará la TextBox regresando a la columna estática de Name.
         * 
         * Similarmente, la columna de Type creará una ComboBox donde el usuario podrá seleccionar
         * uno de los tipos para el atributo. Cuando la selección de tipo termina, se guardan los cambios
         * en la base de datos y se borra la ComboBox regresando a la columna estática de Type.
         */ 
        private void dataGridViewAtributos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Verificaremos en que Columna se esta haciendo el DoubleClick
                string columnName = dataGridViewAtributos.Columns[e.ColumnIndex].Name;

                if (columnName == "Name")
                {
                    // Crea dinámicamente un TextBox en la celda escogida
                    DataGridViewCell cell = dataGridViewAtributos.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    Rectangle cellRectangle = dataGridViewAtributos.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                    TextBox textBox = new TextBox
                    {
                        Bounds = cellRectangle, // Ajusta el tamaño del TextBox al tamaño de la celda
                        Text = cell.Value.ToString() ?? string.Empty, // Muestra el valor actual de la celda en la TextBox
                        Tag = new { RowIndex = e.RowIndex, ColumnIndex = e.ColumnIndex }, // Guarda los índices de la celda
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    // Evento para guardar los cambios al salir del TextBox
                    textBox.Leave += TextBox_Leave;

                    // Agrega el TextBox al DataGridView
                    dataGridViewAtributos.Controls.Add(textBox);
                    textBox.Focus(); // Ahora estamos sobre la TextBox listos para escribir
                }


                if (columnName == "Type")
                {
                    // Crea dinámicamente una ComboBox en la celda escogida
                    DataGridViewCell cell = dataGridViewAtributos.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    Rectangle cellRectangle = dataGridViewAtributos.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                    ComboBox comboBox = new ComboBox
                    {
                        Bounds = cellRectangle, // Ajusta tamaño al de la celda
                        DataSource = database.TipoAtributo.ToList(), // Recuperamos los TipoAtributo de la base de datos
                        DisplayMember = "nombre", // DisplayMember muestra en la seleccion de la ComboBox los nombres de cada tipo para los atributos
                        ValueMember = "id",       // Esto es lo que identifica al tipo de aatributo
                        DropDownStyle = ComboBoxStyle.DropDownList,
                        Tag = new { RowIndex = e.RowIndex, ColumnIndex = e.ColumnIndex } // Guarda los índices de la celda
                    };

                    // Selecciona el valor actual
                    var currentValue = cell.Value.ToString();
                    comboBox.SelectedIndex = comboBox.FindStringExact(currentValue);

                    // Eventos para guardar los cambios
                    comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
                    comboBox.Leave += ComboBox_Leave;

                    // Agrega el ComboBox al DataGridViewAtributos
                    dataGridViewAtributos.Controls.Add(comboBox);
                    comboBox.Focus(); // Ahora estamos en la selección de tipos para el atributo
                }
            }
        }

        /*
         * Evento para registrar que no tenemos focus de la TextBox
         */ 
        private void TextBox_Leave(object sender, EventArgs e)
        {
            // Cuando perdemos focus guardamos los cambios en la base de datos
            GuardarCambios_TextBox(sender);
        }

        /*
         * Método para recuperar lo escrito en la TextBox, subir los cambios y borrarla
         */ 
        private void GuardarCambios_TextBox(object sender)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                // Obtiene los índices de la celda desde el Tag del TextBox
                dynamic tag = textBox.Tag;
                int rowIndex = tag.RowIndex;
                int columnIndex = tag.ColumnIndex;

                // Recupera lo que se escribió en la TextBox
                string nuevoValor = textBox.Text;

                // Escoge el ID del atributo desde el DataBoundItem
                var dataItem = dataGridViewAtributos.Rows[rowIndex].DataBoundItem;
                if (dataItem != null)
                {
                    dynamic atributo = dataItem;
                    int atributoID = atributo.AtributoID; // ID asociado al objeto enlazado.
                    // AtributoID lo sacamos de la query al configurar la DataGridView en CargarDatos()

                    // Actualizamos cambios a la base de datos
                    var atributoEnDatabase = database.Atributo.FirstOrDefault(a => a.id == atributoID);
                    if (atributoEnDatabase != null)
                    {
                        atributoEnDatabase.nombre = nuevoValor;
                        database.SubmitChanges();
                    }

                    // Refleja los cambios en el valor del DataGridView
                    dataGridViewAtributos.Rows[rowIndex].Cells[columnIndex].Value = nuevoValor;
                }

                // Elimina la TextBox después de guardar los cambios
                textBox.Leave -= TextBox_Leave;
                dataGridViewAtributos.Controls.Remove(textBox);
                textBox.Dispose();

                // Finalmente, actualiza el DataGridView
                load();
            }
        }

        /*
         * Evento para registrar que no tenemos focus de la ComboBox
         */
        private void ComboBox_Leave(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox != null)
            {
                dynamic tag = comboBox.Tag;
                int rowIndex = tag.RowIndex;

                var dataItem = dataGridViewAtributos.Rows[rowIndex].DataBoundItem;
                if (dataItem != null)
                {
                    dynamic atributo = dataItem;
                    int atributoID = atributo.AtributoID;
                    int nuevoTipoID = (int)comboBox.SelectedValue; // ID del tipo seleccionado en ComboBox

                    if (atributo.TypeID != nuevoTipoID)
                    {
                        ComboBox_SelectedIndexChanged(sender, e);
                    }
                    else
                    {
                        dataGridViewAtributos.Controls.Remove(comboBox);
                        comboBox.Dispose();
                    }
                }
            }
        }

        /*
         * Evento para subir el nuevo tipo de atributo a la base de datos y eliminar la ComboBox
         */  
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            if (comboBox != null)
            {
                dynamic tag = comboBox.Tag;
                int rowIndex = tag.RowIndex;
                int columnIndex = tag.ColumnIndex;

                // Obtiene el ID del atributo desde el DataBoundItem
                var dataItem = dataGridViewAtributos.Rows[rowIndex].DataBoundItem;
                if (dataItem != null)
                {
                    dynamic atributo = dataItem;
                    int atributoID = atributo.AtributoID;          // ID asociado al objeto enlazado
                    int nuevoTipoID = (int)comboBox.SelectedValue; // ID del tipo seleccionado en ComboBox

                    // Actualizamos en la base de datos
                    var atributoEnDB = database.Atributo.FirstOrDefault(a => a.id == atributoID);
                    if (atributoEnDB != null)
                    {
                        atributoEnDB.tipo = nuevoTipoID; 
                        database.SubmitChanges();
                    }

                    // Actualiza visualmente en el DataGridView
                    dataGridViewAtributos.Rows[rowIndex].Cells[columnIndex].Value = comboBox.Text;

                    // Elimina el ComboBox después de guardar
                    dataGridViewAtributos.Controls.Remove(comboBox);
                    comboBox.Dispose();

                    // Finalmente, actualiza el DataGridView
                    load();
                }
            }
        }

        /*
         * Evento para registrar que hayamos clicado en el DataGridView, usado para la funcionalidad
         * del botón Delete
         */  
        private void dataGridViewAtributos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewAtributos.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int atributoID = (int)dataGridViewAtributos.Rows[e.RowIndex].Cells["AtributoID"].Value;

                var atributo = database.Atributo.FirstOrDefault(a => a.id == atributoID);
                if (atributo != null)
                {
                    // Crea el Form BorrarAtributo
                    BorrarAtributo confirmDelete = new BorrarAtributo();
                    confirmDelete.ShowDialog();

                    if (confirmDelete.IsConfirmed) // Dice que Si
                    {
                        database.Atributo.DeleteOnSubmit(atributo);
                        database.SubmitChanges();

                        // Actualiza el número de atributos y la interfaz
                        CargarNumeroDeAtributos();
                        ActualizarInterfaz();
                        CargarDatos();
                    }
                    // Si dice que "No", ninguna acción se ejecuta
                }
            }
        }



    }
}
