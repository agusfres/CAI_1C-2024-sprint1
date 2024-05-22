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
            string combobox = comboBox1.Text;
            string txCantidad = txtCantidad.Text;
            string txdni = txtdni.Text;

            Validador validadorCampos = new Validador();
            Operacion operacion = new Operacion();
            int cantidad = operacion.TransformarStringInt(txCantidad);
            int dni = operacion.TransformarStringInt(txdni);
            string errorCombo = validadorCampos.ValidarComboBox(combobox, "Producto");
            string errorDni = validadorCampos.ValidarDNIVenta(txdni, "DNI");
            ProductoService productoService = new ProductoService();
            List<Producto> listaproductos = productoService.TraerProductos();
            Producto producto = listaproductos.Find(p => p.Nombre == combobox);
            int stock = producto.Stock;
            string errorCantidad = validadorCampos.ValidarCantidadProd(txCantidad, "Cantidad",stock);


            lblErrorCantidad.Text = errorCantidad;
            lblErrorProducto.Text = errorCombo;
            lblerrordni.Text = errorDni;
            string acumulador = errorCantidad + errorCombo + errorDni;
            double totalElectro = 0;
            double totalResto = 0;
 
            if (acumulador == "")
            {
                CarritoProducto cp = new CarritoProducto(combobox, producto.Precio, cantidad,producto.IdCategoria);
                carritoProductos.Add(cp);
                dataGridView1.Rows.Add(combobox, cantidad, producto.Precio);
                foreach(CarritoProducto c in carritoProductos)
                {
                    if(c.idCategoria == 3)
                    {
                        totalElectro += c.Cantidad * c.Precio;
                    }
                    else
                    {
                        totalResto += c.Cantidad * c.Precio;
                    }
                    
                }
                lbltotal.Text = "$   " + (totalResto + totalElectro);
                double descuentoElectro = 0;

                if (totalElectro > 100000)
                {
                    descuentoElectro = totalElectro * 0.05;
                }

                NegocioVenta negocioVenta = new NegocioVenta();
                double descuentoPrimerCompra = negocioVenta.DescuentoPrimerCompra(dni,totalResto,totalElectro);
                double descuentoFinal = descuentoElectro + descuentoPrimerCompra;
                double totalFinal = totalResto + totalElectro - descuentoFinal;
                labeldesc.Text = "$   " + descuentoFinal;
                labeltotal.Text = "$   " + totalFinal;
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
