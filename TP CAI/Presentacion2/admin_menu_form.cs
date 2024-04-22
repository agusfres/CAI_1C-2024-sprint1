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
            this.Hide();
            iniciarsesion_form form2 = new iniciarsesion_form();
            form2.Show();
        }
    }
}
