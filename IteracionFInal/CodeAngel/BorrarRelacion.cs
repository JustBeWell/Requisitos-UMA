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

    public partial class BorrarRelacion : Form
    {
        private RelacionesMain _form1;
        private Relacion rel;

        public BorrarRelacion(RelacionesMain form1, Relacion rel)
        {
            InitializeComponent();
            _form1 = form1;
            this.rel = rel;
        }

        private void No_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var relacionAEliminar = db.Relacion.FirstOrDefault(p => p.nombre == rel.nombre);
            db.Relacion.DeleteOnSubmit(relacionAEliminar);
            db.SubmitChanges();
            _form1.load(); //no se porque no funca el load

            this.Close();
        }

        private void BorrarRelacion_Load(object sender, EventArgs e)
        {

        }
    }
}
