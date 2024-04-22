﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Persistencia;


namespace Presentacion2
{
    public partial class iniciarsesion_form : Form
    {
        List<Usuario> listaUsuarios = new List<Usuario>();


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


            if ((validador.ValidarVacio(usuario, "Usuario") != "") || (validador.ValidarVacio(contraseña, "Contraseña") != ""))
            {
                // QUEDA PENDIENTE RESOLVER LOS 3 INTENTOS RESTANTES
                //intentosRestantes -= 1;
                //lblIntentosRestantes.Text = "Te quedan " + intentosRestantes + " intentos antes que se inactive tu usuario";

                if (validador.ValidarVacio(usuario, "Usuario") != "")
                {
                    lblUsuarioError.Text = "Debe ingresar un nombre de usuario";
                }
                if (validador.ValidarVacio(contraseña, "Contraseña") != "")
                {
                    lblContraseñaError.Text = "Debe ingresar una contraseña";
                }
            }
            if (lblUsuarioError.Text == "" && lblContraseñaError.Text == "")
            {
                UsuarioService usuarioservice = new UsuarioService();
                listaUsuarios = usuarioservice.TraerUsuariosActivos(Guid.Parse("70b37dc1-8fde-4840-be47-9ababd0ee7e5"));
                if (validador.ValidarContraseñaDefinitivaLogin(contraseña) == "")
                {
                    this.Hide();
                    admin_menu_form admin_Menu_form = new admin_menu_form();
                    admin_Menu_form.Show();
                }
                else
                {
                    this.Hide();
                    cambiocontra_form cambiocontra_Form = new cambiocontra_form(usuario);
                    cambiocontra_Form.Show();
                }
            }
        }


        private void LinklabelOlvidasteContraseña_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            cambiocontra_form cambiocontra_Form = new cambiocontra_form(null);
            cambiocontra_Form.Show();
        }
    }
}
