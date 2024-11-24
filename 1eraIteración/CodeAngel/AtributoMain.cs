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
        private const int MaxAttributes = 5;   // Una misma cuenta no puede tener más de 5 atributos de usuario
        private int UserAttributes;

        public AtributoMain()
        {
            InitializeComponent();
            dataGridViewAtributos.CellValueChanged += dataGridViewAtributos_CellValueChanged;
        }

        private void AtributoMain_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            CargarNumeroDeAtributos();
            ActualizarInterfaz();
            CargarDatos(); // Cargar los datos de la base de datos
            ConfigurarInterfaz(); // Configurar las columnas y el DataGridView
        }
        private void ActualizarInterfaz()
    {
        // Mostrar el número de atributos actuales y el límite máximo
        // Usar string.Format para mostrar los contadores en la interfaz
        label_UserAttributes.Text = string.Format("User Attributes: {0}", UserAttributes);
        label_AvailableAttributes.Text = string.Format("Available: {0} of {1}", MaxAttributes - UserAttributes, MaxAttributes);

        // Habilitar o deshabilitar el botón de añadir atributos según el límite
        btn_AñadirAtributo.Enabled = UserAttributes < MaxAttributes;
    }
        private void CargarNumeroDeAtributos()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                // Contar el número de atributos actuales en la base de datos
                UserAttributes = db.Atributo.Count();
            }
        }
        private void CargarDatos()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                // Consulta para obtener los atributos y su información relacionada
                var listaAtributos = from a in db.Atributo
                                     join ta in db.TipoAtributo on a.tipo equals ta.id
                                     select new
                                     {
                                         Type = ta.nombre, // Nombre del tipo
                                         TypeID = ta.id,   // ID del tipo (para el ComboBox)
                                         Name = a.nombre,  // Nombre del atributo
                                         AtributoID = a.id // ID del atributo
                                     };

                // Asignar los datos al DataGridView
                dataGridViewAtributos.DataSource = listaAtributos.ToList();
            }
        }

        private void ConfigurarInterfaz()
        {
            dataGridViewAtributos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Configurar columnas como editables o no
            foreach (DataGridViewColumn column in dataGridViewAtributos.Columns)
            {
                if (column.Name == "Name") // Permitir edición solo en la columna "Name"
                {
                    column.ReadOnly = false;
                }
                else
                {
                    column.ReadOnly = true;
                }
            }
            // Ocultar columnas innecesarias como IDs
            if (dataGridViewAtributos.Columns["TypeID"] != null)
                dataGridViewAtributos.Columns["TypeID"].Visible = false;

            if (dataGridViewAtributos.Columns["AtributoID"] != null)
                dataGridViewAtributos.Columns["AtributoID"].Visible = false;

            // Configurar la columna "Type" como ComboBox
            AgregarColumnaComboBox();

            // Agregar la columna de acción (Eliminar)
            AgregarColumnaBotonEliminar();
        }

        private void AgregarColumnaComboBox()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                // Crear la columna ComboBox si no existe
                if (dataGridViewAtributos.Columns["TypeEditable"] == null)
                {
                    DataGridViewComboBoxColumn comboColumn = new DataGridViewComboBoxColumn
                    {
                        HeaderText = "Type",
                        DataPropertyName = "TypeID", // Asociar con la propiedad TypeID
                        Name = "TypeEditable",
                        DataSource = db.TipoAtributo.ToList(), // Fuente de datos para el ComboBox
                        DisplayMember = "nombre", // Mostrar el nombre del tipo
                        ValueMember = "id", // Asociar con el ID del tipo
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    };

                    // Reemplazar la columna existente "Type" con el ComboBox
                    if (dataGridViewAtributos.Columns.Contains("Type"))
                    {
                        dataGridViewAtributos.Columns.Remove("Type");
                    }
                    dataGridViewAtributos.Columns.Add(comboColumn);
                }
            }
        }

        private void AgregarColumnaBotonEliminar()
        {
            if (!dataGridViewAtributos.Columns.Contains("Eliminar"))
            {
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Eliminar",
                    HeaderText = "Action",
                    Text = "DELETE",
                    UseColumnTextForButtonValue = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                };

                dataGridViewAtributos.Columns.Add(deleteButtonColumn);
            }
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
                        // Confirmar eliminación
                        BorrarAtributo confirmDelete = new BorrarAtributo();
                        confirmDelete.ShowDialog();

                        if (confirmDelete.IsConfirmed)
                        {
                            context.Atributo.DeleteOnSubmit(atributo);
                            context.SubmitChanges();

                            // Actualizar el número de atributos y la interfaz
                            CargarNumeroDeAtributos();
                            ActualizarInterfaz();
                            CargarDatos();
                        }
                    }
                }
            }
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
                            // Guardar cambios en "Name"
                            if (dataGridViewAtributos.Columns[e.ColumnIndex].Name == "Name")
                            {
                                atributoEnDB.nombre = row.Cells["Name"].Value.ToString();
                            }
                            // Guardar cambios en "TypeEditable"
                            else if (dataGridViewAtributos.Columns[e.ColumnIndex].Name == "TypeEditable")
                            {
                                atributoEnDB.tipo = (int)row.Cells["TypeEditable"].Value;
                            }

                            context.SubmitChanges(); // Guardar cambios en la base de datos
                        }
                    }

                    // Recargar la interfaz
                    CargarDatos();
                    ActualizarInterfaz();
                }
            }
        }

        private void btn_AñadirAtributo_Click(object sender, EventArgs e)
        {
            CrearAtributo nuevoAtributo = new CrearAtributo(this);
            nuevoAtributo.ShowDialog();

            // Actualizar el número de atributos y la interfaz
            CargarNumeroDeAtributos();
            ActualizarInterfaz();
            CargarDatos();
        }



    }
}
