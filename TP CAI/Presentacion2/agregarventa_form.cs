using Datos;
using Persistencia;
using Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion2
{
    public partial class agregarventa_form : Form
    {
        List<CarritoProducto> carritoProductos = new List<CarritoProducto>();
        ProductoService productoService = new ProductoService();
        NegocioVenta negocioVenta = new NegocioVenta();
        Validador validadorCampos = new Validador();
        Operacion operacion = new Operacion();


        public agregarventa_form()
        {
            InitializeComponent();
        }


        public void agregarventa_form_Load(object sender, EventArgs e)
        {
            List<Producto> listaproductos = productoService.TraerProductos();
            foreach (Producto producto in listaproductos)
            {
                cmbProducto.Items.Add(producto.Nombre);
            }
        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            double totalElectro = 0;
            double totalResto = 0;
            double descuentoElectro = 0;
            string promocionesAplicadas = "";

            string txDni = txtdni.Text;
            string cmProducto = cmbProducto.Text;
            string txCantidad = txtCantidad.Text;

            int dni = operacion.TransformarStringInt(txDni);
            int cantidad = operacion.TransformarStringInt(txCantidad);

            string errorDni = validadorCampos.ValidarDNIExistente(txDni, "DNI");
            string errorProducto = validadorCampos.ValidarComboBox(cmProducto, "Producto");
            string errorCantidad = validadorCampos.ValidarStockPrecio(txCantidad, "Cantidad");

            lblErrorDNI.Text = errorDni;
            lblErrorProducto.Text = errorProducto;
            lblErrorCantidad.Text = errorCantidad;

            if (string.IsNullOrEmpty(errorCantidad))
            {
                List<Producto> listaproductos = productoService.TraerProductos();
                Producto producto = listaproductos.Find(p => p.Nombre == cmProducto);
                int stock = producto.Stock;
                errorCantidad = validadorCampos.ValidarCantidadProd(txCantidad, "Cantidad", stock, carritoProductos);

                lblErrorCantidad.Text = errorCantidad;

                string acumuladorErrores = errorDni + errorProducto + errorCantidad;

                if (string.IsNullOrEmpty(acumuladorErrores))
                {
                    CarritoProducto cp = new CarritoProducto(cmProducto, producto.Precio, cantidad, producto.IdCategoria, producto.IdProducto);
                    carritoProductos.Add(cp);
                    dataGridView1.Rows.Add(cmProducto, cantidad, producto.Precio);

                    foreach(CarritoProducto c in carritoProductos)
                    {
                        if(c.IdCategoria == 3)
                        {
                            totalElectro += c.Cantidad * c.Precio;
                        }
                        else
                        {
                            totalResto += c.Cantidad * c.Precio;
                        }
                    }

                    if (totalElectro > 100000)
                    {
                        descuentoElectro = totalElectro * 0.05;
                        promocionesAplicadas += "Promo Electro Hogar, ";
                    }

                    double descuentoPrimerCompra = negocioVenta.DescuentoPrimerCompra(dni, totalResto, totalElectro);

                    if (descuentoPrimerCompra > 0)
                    {
                        promocionesAplicadas += "Promo Cliente Nuevo, ";
                    }

                    double total = totalResto + totalElectro;
                    double descuentoFinal = descuentoElectro + descuentoPrimerCompra;
                    double totalFinal = total - descuentoFinal;

                    lblTotal.Text = "$   " + total;
                    lblPromociones.Text = promocionesAplicadas;
                    lblDescuentos.Text = "$   " + descuentoFinal;
                    lblTotalFinal.Text = "$   " + totalFinal;
                }
            }
        }


        private void button_WOC1_Click(object sender, EventArgs e)
        {
            lblErrorCarrito.Text = "";

            if ((dataGridView1.RowCount - 1) > 0)
            {
                negocioVenta.AgregarVenta(txtdni.Text, UsuarioLogueado.usuario.Id, carritoProductos);

                string txDni = txtdni.Text;
                double descuentoFinal = double.Parse(lblDescuentos.Text.Replace("$", "").Trim());
                double totalFinal = double.Parse(lblTotalFinal.Text.Replace("$", "").Trim());
                string promocionesAplicadas = lblPromociones.Text;

                this.Hide();
                remito_form remito_Form = new remito_form(txDni, carritoProductos, descuentoFinal, totalFinal, promocionesAplicadas);
                remito_Form.Show();
            }
            else
            {
                lblErrorCarrito.Text = "El carrito no puede estar vacío";
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
