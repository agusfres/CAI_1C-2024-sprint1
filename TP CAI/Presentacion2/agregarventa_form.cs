using Datos;
using Persistencia;
using Presentacion;
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

            //string productoSeleccionado = comboBox1.SelectedItem.ToString();

            // dataGridView1.Rows.Add(productoSeleccionado)  
               
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Validador validadorCampos = new Validador();

            string combobox = comboBox1.Text;
            string txCantidad = txtCantidad.Text;

           // string errorProducto = validadorCampos.ValidarProducto(combobox, "Producto");
            string errorCantidad = validadorCampos.ValidarCantidadProd(txCantidad, "Cantidad");

           // lblErrorProducto.Text = errorProducto;
            lblErrorCantidad.Text = errorCantidad;

                
            ProductoService productoService = new ProductoService();
            List<Producto> listaproductos = productoService.TraerProductos();
            Producto producto = listaproductos.Find(p => p.Nombre == combobox);
        }

        private void linkLabelVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            vendedor_menu_form vendedor_menu = new vendedor_menu_form();
            vendedor_menu.Show();
        }
    }
}
