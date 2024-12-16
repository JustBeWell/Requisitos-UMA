using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Para manejar archivos

namespace WindowsFormsApplication2
{
    public partial class AtributosCSV : Form
    {
        private string atributoPrice;
        private List<Producto> selectedProducts;
        public AtributosCSV(List<Producto> selectedProducts)
        {
            InitializeComponent();
            
            this.selectedProducts = selectedProducts;


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        

        private void encontrarAtributoPrice()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            // Consulta para buscar atributos de tipo Integer o Float
            var atributoValido = db.Atributo
                .Join(db.TipoAtributo,
                    a => a.tipo,
                    t => t.id,
                    (a, t) => new { Atributo = a, Tipo = t })
                .Where(at => at.Tipo.nombre == "Integer" || at.Tipo.nombre == "Float")
                .Select(at => at.Atributo)
                .FirstOrDefault();

            if (atributoValido != null)
            {
                // Se encontró un atributo válido, se procede con la exportación
                atributoPrice = atributoValido.nombre;
                MessageBox.Show(" Price will be mapped to: " + atributoPrice);
                textBox5.Text = atributoPrice;
                // Aquí puedes llamar al método para generar el CSV
                
            }
            else
            {
                // No se encontró un atributo válido, se cancela la exportación
                MessageBox.Show("There were no attributes of type Integer or Float to map Price, export closing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        /*private void AjustarAnchoColumnas(string filePath)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);
            Excel.Worksheet worksheet = workbook.Sheets[1];

            worksheet.Columns.AutoFit(); // Ajusta automáticamente el ancho de todas las columnas

            workbook.Save();
            workbook.Close();
            excelApp.Quit();

            // Libera los recursos de COM
            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
        }*/

        private void ExportarCSV()
        {
            try
            {
                // Crear el contexto de base de datos
                DataClasses1DataContext db = new DataClasses1DataContext();
                string nombreCuenta = db.Cuenta.First().nombre;
                // Consulta para obtener los productos y atributos
                var productos = selectedProducts.Select(p => new
                {
                    SKU = p.SKU,
                    Title = p.Label,
                    FulfilledBy = nombreCuenta,
                    Amazon_SKU = p.GTIN,
                    Price = (from va in db.ValorAtributo
                             join a in db.Atributo on va.atributo_id equals a.id
                             join t in db.TipoAtributo on a.tipo equals t.id
                             where (t.nombre == "Integer" || t.nombre == "Float") && va.producto_SKU == p.SKU
                             select va.valor).FirstOrDefault(),
                    OfferPrice = "FALSE" // Valor por defecto
                }).Where(p => !string.IsNullOrEmpty(p.Price)) // Filtrar productos con Price válido
            .ToList();

                if (!productos.Any())
                {
                    MessageBox.Show("There are no products to export", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //Implementación usando Microsoft.Office.Interop.Excel
                // Ruta donde se guardará el archivo
                /*Excel.Application excelApp = new Excel.Application();
                if (excelApp != null)
                {
                    // Crear un nuevo libro y hoja de trabajo
                    Excel.Workbook workbook = excelApp.Workbooks.Add();
                    Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];

                    // Escribir los encabezados
                    worksheet.Cells[1, 1] = "SKU";
                    worksheet.Cells[1, 2] = "Title";
                    worksheet.Cells[1, 3] = "FulfilledBy";
                    worksheet.Cells[1, 4] = "Amazon_SKU";
                    worksheet.Cells[1, 5] = "Price";
                    worksheet.Cells[1, 6] = "OfferPrice";

                    // Suponiendo que tienes una lista de productos
                    int row = 2;
                    foreach (var producto in productos)
                    {
                        worksheet.Cells[row, 1] = producto.SKU;
                        worksheet.Cells[row, 2] = producto.Title;
                        worksheet.Cells[row, 3] = producto.FulfilledBy;
                        worksheet.Cells[row, 4] = producto.Amazon_SKU;
                        worksheet.Cells[row, 5] = producto.Price;
                        worksheet.Cells[row, 6] = producto.OfferPrice;
                        row++;
                    }

                    // Guardar el archivo en la carpeta de Descargas del usuario
                    string rutaDescargas = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads\Exported_Products_AMAZON.csv";
                    
                    
                    workbook.SaveAs(rutaDescargas);
                    
                    MessageBox.Show("Products were succesfully exported to " + rutaDescargas);
                    workbook.Close();
                    excelApp.Quit();
                }*/
                string rutaDescargas = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads\Exported_Products_AMAZON.csv";
                using (StreamWriter writer = new StreamWriter(rutaDescargas, false, System.Text.Encoding.UTF8))
                 {
                        // Escribir los encabezados
                        writer.WriteLine("SKU;Title;FulfilledBy;Amazon_SKU;Price;OfferPrice");

                        // Escribir los datos
                        foreach (var producto in productos)
                        {
                            writer.WriteLine(producto.SKU + ";" + producto.Title + ";" + producto.FulfilledBy + ";'" + producto.Amazon_SKU + ";" + producto.Price +";" + producto.OfferPrice);
                        }
                    }
                MessageBox.Show("Product succesfully exported to: " + rutaDescargas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportarCSV();
            this.Close();
        }

        private void AtributosCSV_Load(object sender, EventArgs e)
        {
            encontrarAtributoPrice();
        }
    }
}
