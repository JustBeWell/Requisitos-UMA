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
        private MainCategorias _form1;
        private Categoria catg;
        public BorrarCategoria(MainCategorias form1, Categoria catg)
        {
            InitializeComponent();
            _form1 = form1;
            this.catg = catg;
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var categoriaAEliminar = db.Categoria.FirstOrDefault(p => p.nombre == catg.nombre);
            db.Categoria.DeleteOnSubmit(categoriaAEliminar);
            db.SubmitChanges();
            _form1.load();

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
