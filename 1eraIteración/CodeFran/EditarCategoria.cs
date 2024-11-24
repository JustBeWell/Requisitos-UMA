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
    public partial class EditarCategoria : Form
    {
        private MainCategorias _form1;
        private Categoria cat;
        public EditarCategoria(MainCategorias form1,Categoria cat)
        {
            InitializeComponent();
            _form1 = form1;
            this.cat = cat;

        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text)){
                DataClasses1DataContext bd = new DataClasses1DataContext();
                var categoria = bd.Categoria.SingleOrDefault(c => c.id == cat.id);
                if (categoria != null)
                {      
                    categoria.nombre = textBox1.Text;
                    bd.SubmitChanges();

                    _form1.load();           
                     this.Close();
               }
            }
        }
    }
}
