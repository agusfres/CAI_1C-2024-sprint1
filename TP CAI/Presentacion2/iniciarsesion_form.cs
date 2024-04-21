using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Persistencia;

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
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            Validador validador = new Validador();
            lblUsuarioError.Text = "";
            lblContraseñaError.Text = "";

            if (validador.validarVacio(usuario, "Usuario") != "")
            {
                lblUsuarioError.Text = "Debe ingresar un nombre de usuario";
            }
            if (validador.validarVacio(contraseña, "Contraseña") != "")
            {
                lblContraseñaError.Text = "Debe ingresar una contraseña";
            }
            if (lblUsuarioError.Text == "" && lblContraseñaError.Text == "") 
            {
                List<Usuario> listaUsuarios = new List<Usuario>();
                UsuarioService usuarioservice = new UsuarioService();
                listaUsuarios = usuarioservice.TraerUsuariosActivos(Guid.Parse("70b37dc1-8fde-4840-be47-9ababd0ee7e5"));
                if (validador.validarContraseñaDefinitivaLogin(contraseña) == "")
                {
                    this.Hide();
                    admin_menu_form admin_Menu_form = new admin_menu_form();
                    admin_Menu_form.Show();
                }
                else
                {
                    this.Hide();
                    cambiocontra_form cambiocontra_Form = new cambiocontra_form();
                    cambiocontra_Form.Show();
                }
            }
        }


        private void LinklabelOlvidasteContraseña_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Hide();
            cambiocontra_form cambiocontra_Form = new cambiocontra_form();
            cambiocontra_Form.Show();
           
        }



    }
}
