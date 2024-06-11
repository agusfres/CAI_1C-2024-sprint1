using Datos;
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
    public partial class reporte_stock : Form
    {
        private int tipousuario;
        public reporte_stock(int tipousuario)
        {
            InitializeComponent();
            this.tipousuario = tipousuario;
        }

        private void linkLabelVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            admin_gestionreportes_form admin_gestionreportes_form = new admin_gestionreportes_form(tipousuario);
            admin_gestionreportes_form.Show();
        }

        private void reporte_stock_Load(object sender, EventArgs e)
        {
            NegocioReporte negocioReporte = new NegocioReporte();

            dataGridView1.DataSource = negocioReporte.ReporteProductosBajoStock();
            dataGridView1.Refresh();

        }
    }
}
