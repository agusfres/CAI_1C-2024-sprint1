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
               
        }
        List<CarritoProducto> carritoProductos = new List<CarritoProducto>();
        private void button1_Click_1(object sender, EventArgs e)
        {
            double Total = 0;
            string combobox = comboBox1.Text;
            string txCantidad = txtCantidad.Text;

            Validador validadorCampos = new Validador();
            ProductoService productoService = new ProductoService();
            List<Producto> listaproductos = productoService.TraerProductos();
            Producto producto = listaproductos.Find(p => p.Nombre == combobox);
            int stock = producto.Stock;
            Operacion operacion = new Operacion();
            int cantidad = operacion.TransformarStringInt(txCantidad);

            string errorCantidad = validadorCampos.ValidarCantidadProd(txCantidad, "Cantidad",stock);
            string errorCombo = validadorCampos.ValidarComboBox(combobox,"Producto");

            lblErrorCantidad.Text = errorCantidad;
            lblErrorProducto.Text = errorCombo;
            string acumulador = errorCantidad + errorCombo;

            if (acumulador == "")
            {
                CarritoProducto cp = new CarritoProducto(combobox, producto.Precio, cantidad);
                carritoProductos.Add(cp);
                dataGridView1.Rows.Add(combobox, cantidad, producto.Precio);
                foreach(CarritoProducto c in carritoProductos)
                {
                    Total += c.Cantidad * c.Precio; 
                }
                lbltotal.Text = "$   " + Total;
            }


        }

        private void linkLabelVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            vendedor_menu_form vendedor_menu = new vendedor_menu_form();
            vendedor_menu.Show();
        }
    }
}
