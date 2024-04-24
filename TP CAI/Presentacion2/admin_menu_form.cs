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
    public partial class admin_menu_form : Form
    {
        public admin_menu_form()
        {
            InitializeComponent();
        }


        private void btnGestionarUsuarios_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            admin_gestion_form form5 = new admin_gestion_form();
            form5.Show();
        }


        private void linkLabelCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnGestionarProveedores_Click(object sender, EventArgs e)
        {
            this.Hide();
           admin_gestionproveedor_form Admin_gestionproveedor_form = new admin_gestionproveedor_form();
            Admin_gestionproveedor_form.Show();
        }
    }
}