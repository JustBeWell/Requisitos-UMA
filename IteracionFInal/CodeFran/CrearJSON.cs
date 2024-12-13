using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class CrearJSON : Form
    {
        private Form _form1;
        private String JSON_Data;

        public CrearJSON(string informeCuenta, Form form1)
        {
            _form1 = form1;
            JSON_Data = informeCuenta;
            InitializeComponent();
        }

        private void CrearJSON_Load(object sender, EventArgs e)
        {
            // Recuperamos el informe de la cuenta del constructor y lo guardamos en JSON_Data
            // Luego lo mostramos en la TextBox del preview
            textBoxJSONPreview.Text = JSON_Data;
        }

        private void buttonSelectPath_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "JSON files (*.json)|*.json",
                    Title = "Select path to save JSON file",
                    FileName = "AccountReport.json" // Imponemos un nombre por defecto
                };

                // Mostrar el menu para seleccionar el PATH
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Mostrar la PATH en el TextBox
                    textBoxPathPreview.Text = saveFileDialog.FileName;
                    File.WriteAllText(saveFileDialog.FileName, JSON_Data);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error ocurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            // Verificar si se seleccionó una PATH
            if (string.IsNullOrWhiteSpace(textBoxPathPreview.Text))
            {
                MessageBox.Show("No path selected yet.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else 
            {
                this.Close();
            }
        }


    }
}
