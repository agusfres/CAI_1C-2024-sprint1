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
    public partial class admin_gestioncliente_form : Form
    {
        public admin_gestioncliente_form()
        {
            InitializeComponent();
        }


        private void btnAgregarCrearUsuario_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            admin_agregar_form form1 = new admin_agregar_form();
            form1.Show();
        }



        private void btnBajaUsuario_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            admin_baja_form form6 = new admin_baja_form();
            form6.Show();
        }


        private void linkLabelVolver_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            admin_menu_form form4 = new admin_menu_form();
            form4.Show();
        }
    }
}