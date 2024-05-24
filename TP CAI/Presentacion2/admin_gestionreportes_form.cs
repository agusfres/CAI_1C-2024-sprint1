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
        private int tipousuario;


        public admin_gestionreportes_form(int tipousuario)
        {
            InitializeComponent();
            this.tipousuario = tipousuario;

        }

        private void linkLabelVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(tipousuario == 3)
            {
                this.Hide();
                admin_menu_form form4 = new admin_menu_form();
                form4.Show();
            }
            else if (tipousuario == 2)
            {
                this.Hide();
                supervisor_menu_form form5 = new supervisor_menu_form();
                form5.Show();
            }
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
