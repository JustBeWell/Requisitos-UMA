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
    public partial class BorrarProducto : Form
    {
        private MainForm _form1;
        private Producto prod;
        public BorrarProducto(MainForm form1, Producto prod)
        {
            InitializeComponent();
            _form1 = form1;
            this.prod = prod;
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var productoAEliminar = db.Producto.FirstOrDefault(p => p.SKU == prod.SKU);
            db.Producto.DeleteOnSubmit(productoAEliminar);
            db.SubmitChanges();
            _form1.load();
            _form1.cambiarColor(Color.White);
            this.Close();
        }

        private void No_Click(object sender, EventArgs e)
        {
            _form1.cambiarColor(Color.White);
            this.Close();
        }

        private void BorrarProducto_Load(object sender, EventArgs e)
        {
            _form1.cambiarColor(Color.Gray);
        }
    }
}
