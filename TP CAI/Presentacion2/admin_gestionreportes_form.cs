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
    public partial class admin_gestionreportes_form : Form
    {
        public admin_gestionreportes_form()
        {
            InitializeComponent();
        }

        private void linkLabelVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //depende el usuario
        }

        private void btnRepVentasVendedor_Click(object sender, EventArgs e)
        {
          
        }

        private void btnRepMasVendidos_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRepStockCritico_Click(object sender, EventArgs e)
        {
            this.Hide ();
            ReporteStock reporteStock = new ReporteStock();
            reporteStock.Show();

        }
    }
}
