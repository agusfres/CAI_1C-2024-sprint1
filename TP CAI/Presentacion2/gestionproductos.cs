using Datos;
using Negocio;
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
    public partial class gestionproductos : Form
    {
        private int tipousuario;
        public gestionproductos(int tipousuario)
        {
            InitializeComponent();
            this.tipousuario = tipousuario;
        }
        public gestionproductos()
        {
            InitializeComponent();
        }

        public void linkLabelCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (tipousuario == 3)
            {
                this.Hide();
                admin_menu_form form4 = new admin_menu_form();
                form4.Show();
            }
            else if (tipousuario == 2)
            {
                this.Hide();
                supervisor_menu_form form5 = new supervisor_menu_form();
                form5.Show();
            }
        }

        private void btnGestionarProductos_Click(object sender, EventArgs e)
        {
            this.Hide();
            altaproducto_form form4 = new altaproducto_form();
            form4.Show();
        }
    }
}
