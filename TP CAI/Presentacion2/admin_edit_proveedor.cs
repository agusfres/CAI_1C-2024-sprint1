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
    public partial class admin_edit_proveedor : Form
    {
        public admin_edit_proveedor()
        {
            InitializeComponent();
        }


        private void linkLabelVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            admin_gestionproveedor_form admin_Gestionproveedor_Form = new admin_gestionproveedor_form();
            admin_Gestionproveedor_Form.Show();
        }
    }
}
