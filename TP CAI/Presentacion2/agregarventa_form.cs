using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion2
{
    public partial class agregarventa_form : Form
    {
        public agregarventa_form()
        {
            InitializeComponent();
        }

        public void agregarventa_form_Load(object sender, EventArgs e)
        {
            ProductoService productoService = new ProductoService();
            List<Producto> listaproductos = productoService.TraerProductos();
            foreach (Producto producto in listaproductos)
            {
                comboBox1.Items.Add(producto.Nombre);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string productoSeleccionado = comboBox1.SelectedItem.ToString();

            dataGridView1.Rows.Add(productoSeleccionado);
        }
    }
}
