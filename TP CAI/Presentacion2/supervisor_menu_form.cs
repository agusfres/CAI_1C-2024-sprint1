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


namespace Presentacion2
{
    public partial class supervisor_menu_form : Form
    {
        public supervisor_menu_form()
        {
            InitializeComponent();
        }


        private void btnGestionarProductos_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestionproductos gestionproductos = new gestionproductos(2);
            gestionproductos.Show();
        }


        private void btnReporteVentas_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_gestionreportes_form admin_Gestioncliente_Form = new admin_gestionreportes_form(2);
            admin_Gestioncliente_Form.Show();
        }


        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            this.Hide();
            supervisor_devolucion_venta supervisor_devolucion_venta = new supervisor_devolucion_venta();
            supervisor_devolucion_venta.Show();
        }


        private void linkLabelVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            iniciarsesion_form iniciarsesion_Form = new iniciarsesion_form();
            iniciarsesion_Form.Show();
        }


        private void supervisor_menu_form_Load(object sender, EventArgs e)
        {
            NegocioReporte negocioReporte = new NegocioReporte();
            int cantidad = negocioReporte.AlertaBajoStock();

            if (cantidad > 0)
            {
                label1.Text = "Hay " + cantidad.ToString() + " productos con stock crítico!!!";
            }
            else
            {
                label1.Text = "";
            }
        }
    }
}
