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
    public partial class BorrarCategoria : Form
    {
        private CategoriasMain _form1;
        private Categoria catg;
        private int numCatAss;
        public BorrarCategoria(CategoriasMain form1, Categoria catg, int numCatAss)
        {
            InitializeComponent();
            _form1 = form1;
            this.catg = catg;
            this.numCatAss = numCatAss;
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var categoriaAEliminar = db.Categoria.FirstOrDefault(p => p.nombre == catg.nombre);
            if (numCatAss > 0)
            {
                MessageBox.Show("You cannot delete a category that has associated products");
                
            }
            else
            {
                db.Categoria.DeleteOnSubmit(categoriaAEliminar);
                db.SubmitChanges();
                _form1.load();
            }
            

            this.Close();
        }

        private void No_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void BorrarProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
