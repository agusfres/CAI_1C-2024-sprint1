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

        
    }
}
