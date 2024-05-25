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
    public partial class reporte_ventasxvendedor : Form
    {
        public reporte_ventasxvendedor()
        {
            InitializeComponent();
        }

        private void linkLabelVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            vendedor_menu_form vendedormenu = new vendedor_menu_form();
            vendedormenu.Show();
        }
    }
}
