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
                    nombreUsuarioActual = FuncionEspecialObtenerNombreUsuario(nombreUsuarioActual);

                    negocioUsuario.CambiarContraseña(nombreUsuarioActual, contraseñaActual, txtContraseñaNueva.Text);
                    
                    lblCambioContraseñaExitosa.Text = "Se cambió la contraseña exitosamente";
                    LimpiarCampos();
                    Congrats();

                    Usuario usuario = negocioUsuario.BuscarUsuario(nombreUsuarioActual);
                    
                    this.Hide();
                    int tipoUsuario = FuncionEspecialObtenerTipoUsuario(nombreUsuarioActual);
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


        private string FuncionEspecialObtenerNombreUsuario(string nombreUsuarioActual)
        {
            // Como el Web Service no guarda Tipo de usuario ni Estado lo agregamos como dígitos en el campo nombreUsuario
            // Primer dígito para el Tipo de usuario, que puede ser 1, 2 o 3 (Vendedor, Supervisor, Administrador)
            // Segundo dígito para el Estado, que puede ser A o I (Activo o Inactivo)

            // Recorremos el listado de usuarios activos, le quitamos los primeros dos dígitos, y si son iguales reemplaza el nombre de usuario

            NegocioUsuario negocioUsuario = new NegocioUsuario();
            List<Usuario> listaUsuarios = negocioUsuario.TraerUsuariosActivos();

            foreach (Usuario usuario in listaUsuarios)
            {
                string nombreUsuarioApi = usuario.NombreUsuario;
                if (nombreUsuarioApi.Substring(2) == nombreUsuarioActual)
                {
                    return nombreUsuarioApi;
                }
            }

            return nombreUsuarioActual;
        }


        private int FuncionEspecialObtenerTipoUsuario(string nombreUsuarioActual)
        {
            // Como el Web Service no guarda Tipo de usuario ni Estado lo agregamos como dígitos en el campo nombreUsuario
            // Primer dígito para el Tipo de usuario, que puede ser 1, 2 o 3 (Vendedor, Supervisor, Administrador)

            // Devolvemos el primer dígito de nombreUsuario si es que es un n
            char auxiliar = nombreUsuarioActual[0];
            try
            {
                return int.Parse(auxiliar.ToString());
            }
            catch
            {
                MessageBox.Show("Este usuario no se puede usar porque corresponde a una versión antigua del programa, elija otro creado por el Grupo 5");
                LimpiarCampos();
                return -1;
            }
        }
    }
}