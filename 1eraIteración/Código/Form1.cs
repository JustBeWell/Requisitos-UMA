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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAllProducts();


            MessageBox.Show("Buenas noches buenas noches");
        }

        private void textBoxSearchby_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
         
        }

        private void textBoxSearchby_Enter(object sender, EventArgs e)
        {
            textBoxSearchby.SelectAll();
        }

        private void textBoxSearchby_Click(object sender, EventArgs e)
        {
            textBoxSearchby.SelectAll();
        }

        private void textBoxSearchby_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Detecta si se presionó Enter
            {
                string searchText = textBoxSearchby.Text.Trim(); // Texto ingresado
                if (string.IsNullOrEmpty(searchText))
                {
                    // Si no hay texto, mostrar todos los productos
                    LoadAllProducts();
                }
                else
                {
                    // Realiza el filtro por SKU o Label
                    FilterProducts(searchText);
                }
            }
        }

        private void LoadAllProducts()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var query = from p in db.Producto
                        join va in db.ValorAtributo on p.SKU equals va.producto_SKU into vaGroup
                        from va in vaGroup.DefaultIfEmpty()
                        join a in db.Atributo on va.atributo_id equals a.id into aGroup
                        from a in aGroup.DefaultIfEmpty()
                        group new { va, a } by new
                        {
                            p.SKU,
                            p.GTIN,
                            p.Thumbnail,
                            p.Label
                        } into grouped
                        select new
                        {
                            SKU = grouped.Key.SKU,
                            GTIN = grouped.Key.GTIN,
                            Thumbnail = grouped.Key.Thumbnail,
                            Label = grouped.Key.Label,
                            UserAttribute1 = grouped.Where(g => g.a != null).OrderBy(g => g.a.id).Select(g => g.va.valor).FirstOrDefault(),
                            UserAttribute2 = grouped.Where(g => g.a != null).OrderBy(g => g.a.id).Select(g => g.va.valor).Skip(1).FirstOrDefault()
                        };


            dataGridViewProductos.DataSource = query.ToList();
            }
        private void FilterProducts(string searchText)
        {
            {

                DataClasses1DataContext db = new DataClasses1DataContext();

                var query = from p in db.Producto
                            join va in db.ValorAtributo on p.SKU equals va.producto_SKU into vaGroup
                            from va in vaGroup.DefaultIfEmpty()
                            join a in db.Atributo on va.atributo_id equals a.id into aGroup
                            from a in aGroup.DefaultIfEmpty()
                            where
                                  (p.Label.Contains(searchText) || p.SKU.Contains(searchText))
                            group new { va, a } by new
                            {
                                p.SKU,
                                p.GTIN,
                                p.Thumbnail,
                                p.Label
                            } into grouped
                            select new
                            {
                                SKU = grouped.Key.SKU,
                                GTIN = grouped.Key.GTIN,
                                Thumbnail = grouped.Key.Thumbnail,
                                Label = grouped.Key.Label,
                                UserAttribute1 = grouped.Where(g => g.a != null).OrderBy(g => g.a.id).Select(g => g.va.valor).FirstOrDefault(),
                                UserAttribute2 = grouped.Where(g => g.a != null).OrderBy(g => g.a.id).Select(g => g.va.valor).Skip(1).FirstOrDefault()
                            };


                dataGridViewProductos.DataSource = query.ToList();


            }
        }


}


}

