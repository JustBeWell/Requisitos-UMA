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
    public partial class BorrarAtributo : Form
    {
        public bool IsConfirmed { get; private set; }

        public BorrarAtributo()
        {
            InitializeComponent();
            IsConfirmed = false;
        }

        private void btn_Yes_Click(object sender, EventArgs e)
        {
            IsConfirmed = true;
            this.Close();
        }

        private void btn_No_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BorrarAtributo_Load(object sender, EventArgs e)
        {

        }
    }
}
