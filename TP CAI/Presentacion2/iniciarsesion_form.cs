using System;
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
using Negocio;


namespace Presentacion2
{
    public partial class iniciarsesion_form : Form
    {
        int erroresRestantes = 3;


        public iniciarsesion_form()
        {
            InitializeComponent();
        }

        
        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombreUsuarioActual = txtUsuario.Text;
            string contraseñaActual = txtContraseña.Text;
            Validador validador = new Validador();
            lblUsuarioError.Text = "";
            lblContraseñaError.Text = "";


            if ((validador.ValidarVacio(nombreUsuarioActual, "Usuario") != "") || (validador.ValidarVacio(contraseñaActual, "Contraseña") != ""))
            {
                // QUEDA PENDIENTE RESOLVER LOS 3 INTENTOS RESTANTES
                //intentosRestantes -= 1;
                //lblIntentosRestantes.Text = "Te quedan " + intentosRestantes + " intentos antes que se inactive tu usuario";

                if (validador.ValidarVacio(nombreUsuarioActual, "Usuario") != "")
                {
                    lblUsuarioError.Text = "Debe ingresar un nombre de usuario";
                }
                if (validador.ValidarVacio(contraseñaActual, "Contraseña") != "")
                {
                    lblContraseñaError.Text = "Debe ingresar una contraseña";
                }
            }
            if (lblUsuarioError.Text == "" && lblContraseñaError.Text == "")
            {
                Login login = new Login(nombreUsuarioActual, contraseñaActual);
                try
                {
                    string idUsuario = UsuarioService.Login(login);

                    
                    if (idUsuario.GetType() == typeof(string))
                    {
                        this.Hide();
                        admin_menu_form admin_Menu_form = new admin_menu_form();
                        admin_Menu_form.Show();
                    }
                }
                catch (Exception ex)
                {
                    erroresRestantes -= 1;

                    if (erroresRestantes == 0)
                    {
                        lblMensajeInicioSesion.ForeColor = Color.Red;
                        lblMensajeInicioSesion.Text = "Se inactivará el usuario";
                        lblErroresRestantes.ForeColor = Color.Red;
                        lblErroresRestantes.Text = "Agotaste los 3 intentos";
                        // Queda pendiente inactivar el usuario
                        await Task.Delay(3000);
                        LimpiarCampos();
                    }
                    else
                    {
                        lblMensajeInicioSesion.Text = ex.Message;
                        lblErroresRestantes.Text = "Te quedan " + erroresRestantes + " intentos restantes";
                    }
                } 
            }
        }
        

        private void LinklabelOlvidasteContraseña_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            cambiocontra_form cambiocontra_Form = new cambiocontra_form(null, null);
            cambiocontra_Form.Show();
        }

        private void iniciarsesion_form_Activated(object sender, EventArgs e)
        {
            List<Usuario> listaUsuariosLocal = new List<Usuario>();
            Usuario usuarioInicio = new Usuario(Guid.Parse("70b37dc1-8fde-4840-be47-9ababd0ee7e5"), "Grupo 5", "Grupo 5", "Grupo 5", "55555555", "grupo@5.com", DateTime.Now, DateTime.Parse("01/01/2000"), null, null, "grupo5", 3, 55555555, "grupo5", 5, "ACTIVO");
            listaUsuariosLocal.Add(usuarioInicio);
        }


        private void LimpiarCampos()
        {
            lblMensajeInicioSesion.ForeColor = Color.Black;
            lblErroresRestantes.ForeColor = Color.Black;
            lblUsuarioError.Text = "";
            lblContraseñaError.Text = "";
            lblMensajeInicioSesion.Text = "";
            lblErroresRestantes.Text = "";
            txtContraseña.Clear();
            txtUsuario.Clear();
            txtContraseña.Clear();
            erroresRestantes = 3;
        }
    }
}