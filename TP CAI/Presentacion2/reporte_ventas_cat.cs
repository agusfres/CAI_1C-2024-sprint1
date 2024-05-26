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
    
    public partial class reporte_ventas_cat : Form
    {
        public reporte_ventas_cat()
        {
            InitializeComponent();
        }


        private void linkLabelVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            admin_gestionreportes_form admin_gestionreportes_form = new admin_gestionreportes_form();
            admin_gestionreportes_form.Show();
        }


        public void reporte_ventas_cat_Load(object sender, EventArgs e)
        {
            NegocioReporte negocioReporte = new NegocioReporte();

            List<string> listaMasVendidosPorCat = negocioReporte.ReporteMasVendidoPorCategoria();

            lblProducto1.Text = listaMasVendidosPorCat[0];
            lblProducto2.Text = listaMasVendidosPorCat[1];
            lblProducto3.Text = listaMasVendidosPorCat[2];
            lblProducto4.Text = listaMasVendidosPorCat[3];
            lblProducto5.Text = listaMasVendidosPorCat[4];
        }
    }
}
