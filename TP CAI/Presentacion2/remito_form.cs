using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion2
{
    public partial class remito_form : Form
    {
        private string clienteDNI;
        private List<CarritoProducto> carritoProductos;
        private double descuentoFinal;
        private double totalFinal;
        private string promosAplicadas;



        public remito_form(string dni, List<CarritoProducto> carritoProductos, double descuentoFinal,double totalFinal, string promosAplicadas)
        {
            InitializeComponent();
            this.clienteDNI = dni;
            this.carritoProductos = carritoProductos;
            this.descuentoFinal = descuentoFinal;
            this.totalFinal = totalFinal;
            this.promosAplicadas = promosAplicadas;
        }

        private void btnventa_Click(object sender, EventArgs e)
        {
            this.Hide();
            agregarventa_form agregarventa_Form = new agregarventa_form();
            agregarventa_Form.Show();
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            vendedor_menu_form vendedor_Menu_Form = new vendedor_menu_form();
           vendedor_Menu_Form.Show();
        }

        private void remito_form_Load(object sender, EventArgs e)
        {

            lblFechaOp.Text = DateTime.Now.ToString();
            lblDatosCliente.Text = this.clienteDNI;

            foreach (CarritoProducto producto in carritoProductos)
            {
                dataGridView1.Rows.Add(producto.Nombre, producto.Cantidad, producto.Precio);
            }

            double totalAntesPromo = totalFinal + descuentoFinal;
            lblTotalAntesPromo.Text = totalAntesPromo.ToString("F2");
            lblPromociones.Text = this.descuentoFinal.ToString("F2");
            lblTotal.Text = this.totalFinal.ToString("F2");
            lblNombrePromo.Text = this.promosAplicadas;

        }
    }
}
