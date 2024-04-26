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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Text.RegularExpressions;


namespace Presentacion2
{
    public partial class iniciarsesion_form : Form
    {
        Validador validador = new Validador();
        NegocioUsuario negocioUsuario = new NegocioUsuario();
        int erroresRestantes = 3;


        public iniciarsesion_form()
        {
            InitializeComponent();
        }

        
        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombreUsuarioActual = txtUsuario.Text;
            string contraseñaActual = txtContraseña.Text;
            List<Usuario> listaUsuarios;
            lblMensajeInicioSesion.Text = "";
            lblUsuarioError.Text = "";
            lblContraseñaError.Text = "";


            if ((validador.ValidarVacio(nombreUsuarioActual, "Usuario") != "") || (validador.ValidarVacio(contraseñaActual, "Contraseña") != ""))
            {
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
                try
                {
                    Login login = new Login(nombreUsuarioActual, contraseñaActual);

                    listaUsuarios = negocioUsuario.TraerUsuariosActivos();

                    UsuarioService.Login(login);

                    Usuario usuario = negocioUsuario.BuscarUsuario(nombreUsuarioActual);

                    int tipoUsuario = usuario.TipoUsuario;
                    this.Hide();
                    if (tipoUsuario == 3)
                    {
                        admin_menu_form admin_menu = new admin_menu_form();
                        admin_menu.Show();
                    }
                    else if (tipoUsuario == 2)
                    {
                        this.Hide();
                        supervisor_menu_form supervisor_menu = new supervisor_menu_form();
                        supervisor_menu.Show();
                    }
                    else // El web service los guarda como 0 a todos
                    {
                        vendedor_menu_form vendedor_menu = new vendedor_menu_form();
                        vendedor_menu.Show();
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

            Usuario usuario = negocioUsuario.BuscarUsuario(txtUsuario.Text);
            if (usuario == null)
            {
                lblMensajeInicioSesion.Text = "Debe ingresar un nombre de usuario existente";
            }
            else
            {
                this.Hide();
                cambiocontra_form cambiocontra_Form = new cambiocontra_form(usuario.NombreUsuario);
                cambiocontra_Form.Show();
            }
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