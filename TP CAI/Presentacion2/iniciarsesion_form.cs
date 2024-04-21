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
    public partial class iniciarsesion_form : Form
    {
        public iniciarsesion_form()
        {
            InitializeComponent();
        }
        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            admin_menu_form admin_Menu_form = new admin_menu_form();
            admin_Menu_form.Show();
        }

        private void LinklabelOlvidasteContraseña_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Hide();
            cambiocontra_form cambiocontra_Form = new cambiocontra_form();
            cambiocontra_Form.Show();
           
        }
    }
}
