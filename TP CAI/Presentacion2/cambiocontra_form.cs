using Datos;
using Negocio;
using Presentacion2;
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
    public partial class cambiocontra_form : Form
    {
        string nombreUsuarioActual;


        public cambiocontra_form(string nombreUsuarioActual)
        {
            InitializeComponent();
            this.nombreUsuarioActual = nombreUsuarioActual;
        }


        private void btnCambiar_Click(object sender, EventArgs e)
        {
            Validador validador = new Validador();
            NegocioUsuario negocioUsuario = new NegocioUsuario();

            lblErrorContraseñaVieja.Text = "";
            string contraseñaActual = txtContraseñaActual.Text;

            lblErrorContraseñaVieja.Text = validador.ValidarContraseña(contraseñaActual);

            if (lblErrorContraseñaVieja.Text == "")
            {
                try
                {
                    negocioUsuario.CambiarContraseña(nombreUsuarioActual, contraseñaActual, txtContraseñaNueva.Text);
                    
                    LimpiarCampos();
                    Congrats();

                    Usuario usuario = negocioUsuario.BuscarUsuario(nombreUsuarioActual);
                    
                    this.Hide();
                    int tipoUsuario = usuario.TipoUsuario;
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
                    lblCambioContraseñaExitosa.Text = ex.Message;
                }
            }
        }


        private void LimpiarCampos()
        {
            lblErrorContraseñaVieja.Text = "";
        }


        private async void Congrats()
        {
            lblCambioContraseñaExitosa.Text = "Contraseña modificada exitosamente";
            await Task.Delay(5000);
            lblCambioContraseñaExitosa.Text = "";
        }


        private void linkLabelVolver_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            iniciarsesion_form form2 = new iniciarsesion_form();
            form2.Show();
        }


        private void cambiocontra_form_Load(object sender, EventArgs e)
        {

        }
    }
}