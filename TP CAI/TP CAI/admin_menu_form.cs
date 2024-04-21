using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_CAI
{
    public partial class admin_menu_form : Form
    {
        public admin_menu_form()
        {
            InitializeComponent();
        }

        private void lblCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            iniciarsesion_form form2 = new iniciarsesion_form();
            form2.Show();
        }

        private void btnGestionarUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_gestion_form form5 = new admin_gestion_form();
            form5.Show();
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
