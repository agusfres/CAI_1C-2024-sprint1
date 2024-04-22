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
    public partial class cambiocontra_form : Form
    {
        string nombreUsuarioActual;


        public cambiocontra_form(string nombreUsuarioActual)
        {
            InitializeComponent();
            this.nombreUsuarioActual = nombreUsuarioActual;
        }


        private void linkLabelVolver_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            iniciarsesion_form form2 = new iniciarsesion_form();
            form2.Show();
        }


        private async void btnCambiar_Click(object sender, EventArgs e)
        {
            ListaUsuario listaUsuario = new ListaUsuario();
            lblErrorContraseñaVieja.Text = "";
            string contraseñaVieja = txtContraseñaVieja.Text;

            if (contraseñaVieja == "")
            {
                lblErrorContraseñaVieja.Text = "Debe indicar la contraseña actual" + System.Environment.NewLine;
            }

            Usuario usuarioEncontrado = listaUsuario.BuscarUsuario(nombreUsuarioActual);
            
            if (usuarioEncontrado != null)
            {
                if (usuarioEncontrado.Contraseña != contraseñaVieja)
                {
                    lblErrorContraseñaVieja.Text = "La contraseña indicada no corresponde a la contraseña actual" + System.Environment.NewLine;
                }
                else
                {
                    listaUsuario.ModificarContraseña(nombreUsuarioActual, txtContraseñaNueva.Text);

                    listaUsuario.ModificarEstado(nombreUsuarioActual, "ACTIVO");

                    lblCambioContraseñaExitosa.Text = "Contraseña modificada con éxito" + System.Environment.NewLine;
                    await Task.Delay(4000);

                    int tipoUsuario = usuarioEncontrado.TipoUsuario;
                    if (tipoUsuario == 1)
                    {
                        this.Hide();
                        vendedor_menu_form vendedor_menu = new vendedor_menu_form();
                        vendedor_menu.Show();
                    }
                    else if (tipoUsuario == 2)
                    {
                        this.Hide();
                        supervisor_menu_form supervisor_menu = new supervisor_menu_form();
                        supervisor_menu.Show();
                    }
                    else
                    {
                        this.Hide();
                        admin_menu_form admin_menu = new admin_menu_form();
                        admin_menu.Show();
                    }
                }
            }
        }
    }
}
