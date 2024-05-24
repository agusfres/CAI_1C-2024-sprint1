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
            this.Hide();
            admin_menu_form form4 = new admin_menu_form();
            form4.Show();
        }

        private void btnRepVentasVendedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_agregarproveedor_form admin_Agregarproveedor_Form = new admin_agregarproveedor_form  ();
            admin_Agregarproveedor_Form.Show();
        }

        private void btnRepMasVendidos_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_edit_proveedor admin_Edit_Proveedor = new admin_edit_proveedor ();
            admin_Edit_Proveedor.Show();
        }

        private void btnRepStockCritico_Click(object sender, EventArgs e)
        {
            this.Hide ();
            admin_bajaproveedor_form admin_Bajaproveedor_Form = new admin_bajaproveedor_form();
            admin_Bajaproveedor_Form.Show();

        }
    }
}
