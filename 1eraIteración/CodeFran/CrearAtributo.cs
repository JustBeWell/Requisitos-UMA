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

        public Atributo AtributoCreado { get; private set; }

        public CrearAtributo()
        {
            InitializeComponent();
            LoadTipoAtributos();
        }

        private void LoadTipoAtributos()
        {
            using (var db = new DataClasses1DataContext())
            {
                var tipos = db.TipoAtributo.Select(t => new { t.id, t.nombre }).ToList();
                comboBox_Type.DataSource = tipos;
                comboBox_Type.DisplayMember = "nombre";
                comboBox_Type.ValueMember = "id";
            }
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

            DialogResult = DialogResult.OK;
            Close();
        }


    }
}
