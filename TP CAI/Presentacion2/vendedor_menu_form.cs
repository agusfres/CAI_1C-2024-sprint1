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
    public partial class vendedor_menu_form : Form
    {
        
        public vendedor_menu_form()
        {
            InitializeComponent();
        }

        private void linkLabelVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            iniciarsesion_form iniciarsesion_Form = new iniciarsesion_form();
            iniciarsesion_Form.Show();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            agregarventa_form agregarventa = new agregarventa_form();
            agregarventa.Show();
        }

        private void btnReporteVentas_Click(object sender, EventArgs e)
        {
            this.Hide();
            reporte_ventasxvendedor reporteventas = new reporte_ventasxvendedor(1);
            reporteventas.Show();
        }
    }
}
