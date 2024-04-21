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
    public partial class iniciarsesion_form : Form
    {
        public iniciarsesion_form()
        {
            InitializeComponent();
        }

        private void LinklabelOlvidasteContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            cambiocontra_form form3 = new cambiocontra_form();
            form3.Show();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_menu_form form4 = new admin_menu_form();
            form4.Show();
        }
    }
}
