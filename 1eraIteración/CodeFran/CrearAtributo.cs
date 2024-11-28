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
    public partial class CrearAtributo : Form
    {
        private AtributoMain _form1;
        public Atributo AtributoCreado { get; private set; }

        DataClasses1DataContext database = new DataClasses1DataContext();

        public CrearAtributo(AtributoMain form1)
        {
            InitializeComponent();
            LoadTipoAtributos();
            _form1 = form1;
        }

        private void LoadTipoAtributos()
        {
            var tipos = database.TipoAtributo.Select(t => new { t.id, t.nombre }).ToList();
            comboBox_Type.DataSource = tipos;
            comboBox_Type.DisplayMember = "nombre";
            comboBox_Type.ValueMember = "id"; 
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBox_Nombre.Text) || comboBox_Type.SelectedValue == null)
            {
                MessageBox.Show("Please fill in the name field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AtributoCreado = new Atributo
            {
                nombre = tBox_Nombre.Text,
                tipo = (int)comboBox_Type.SelectedValue
            };

            if (database.Atributo.Count() >= 5)
            {
                MessageBox.Show("Maximum amount of User Attributes reached");
            }
            else
            {
                database.Atributo.InsertOnSubmit(AtributoCreado);
                database.SubmitChanges();
            }


            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CrearAtributo_Load(object sender, EventArgs e)
        {

        }


    }
}
