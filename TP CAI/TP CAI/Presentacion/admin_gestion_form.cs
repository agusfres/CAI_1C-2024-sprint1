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
    public partial class admin_gestion_form : Form
    {
        public admin_gestion_form()
        {
            InitializeComponent();
        }

        private void btnAgregarCrearUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_agregar_form form1 = new admin_agregar_form();
            form1.Show();
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_edit_form form7 = new admin_edit_form();
            form7.Show();
        }

        private void btnBajaUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_baja_form form6 = new admin_baja_form();
            form6.Show();
        }

        private void linkLabelVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            admin_menu_form form4 = new admin_menu_form();
            form4.Show();
        }
    }
}
