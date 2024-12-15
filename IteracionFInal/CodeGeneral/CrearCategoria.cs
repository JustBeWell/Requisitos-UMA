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
    public partial class CrearCategoria : Form
    {
        private CategoriasMain _form1;
        public CrearCategoria(CategoriasMain form1)
        {
            InitializeComponent();
            _form1 = form1;

        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                DataClasses1DataContext bd = new DataClasses1DataContext();
                int nuevoId = bd.Categoria.Any()
                            ? bd.Categoria.Max(c => c.id) + 1
                            : 1;
                Categoria nuevaCategoria = new Categoria
                {
                    id = nuevoId,
                    nombre = textBox1.Text
                };

                bd.Categoria.InsertOnSubmit(nuevaCategoria);
                bd.SubmitChanges();

                _form1.load();

                this.Close();
            }
            else
            {
                MessageBox.Show("You must insert some string in order to add the category");
                this.Close();
            }
        }
    }
}
