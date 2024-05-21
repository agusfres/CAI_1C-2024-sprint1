using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Negocio;
using Persistencia;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;




namespace Presentacion2
{
    public partial class admin_agregar_form : Form
    {
        public admin_agregar_form()
        {
            InitializeComponent();
        }


        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            lblErrorNombre.Text = "";
            lblErrorApellido.Text = ""; ;
            lblErrorEmail.Text = "";
            lblErrorDireccion.Text = "";
            lblErrorContraseña.Text = "";
            lblErrorFecha.Text = "";
            lblErrorDNI.Text = "";
            lblErrorUsuario.Text = "";
            lblErrorTelefono.Text = "";
            lblErrorTipoUsuario.Text = "";

            Validador validadorCampos = new Validador();

            string txNombre = txtNombre.Text;
            string txApellido = txtApellido.Text;
            string txContraseña = txtContraseña.Text;
            string txEmail = txtEmail.Text;
            string txDireccion = txtDireccion.Text;
            string txFechaNac = txtFechaNac.Text;
            string txDNI = txtDNI.Text;
            string txNombreUsuario = txtUsuario.Text;
            string txTelefono = txtTelefono.Text;
            string cmTipoUsuario = cmbTipoUsuario.Text;

            string errorNombre = validadorCampos.ValidarNombre(txNombre, "Nombre");
            string errorApellido = validadorCampos.ValidarNombre(txApellido, "Apellido");
            string errorDireccion = validadorCampos.ValidarDireccion(txDireccion, "Dirección");
            string errorTelefono = validadorCampos.ValidarTelefono(txTelefono, "Teléfono");
            string errorEmail = validadorCampos.ValidarEmail(txEmail, "Email");
            string errorFecha = validadorCampos.ValidarFecha(txFechaNac, "Fecha");
            string errorUsuario = validadorCampos.ValidarDato(txNombreUsuario, txNombre, txApellido, "Usuario");
            string errorTipoUsuario = validadorCampos.ValidarTipoUsuario(cmTipoUsuario, "Tipo de usuario");
            string errorDNI = validadorCampos.ValidarDNI(txDNI, "DNI");
            string errorContraseña = validadorCampos.ValidarContraseña(txContraseña);

            lblErrorNombre.Text = errorNombre;
            lblErrorApellido.Text = errorApellido;
            lblErrorEmail.Text = errorEmail;
            lblErrorDireccion.Text = errorDireccion;
            lblErrorContraseña.Text = errorContraseña;
            lblErrorFecha.Text = errorFecha;
            lblErrorDNI.Text = errorDNI;
            lblErrorUsuario.Text = errorUsuario;
            lblErrorTelefono.Text = errorTelefono;
            lblErrorTipoUsuario.Text = errorTipoUsuario;

            string acumuladorErrores = errorApellido + errorContraseña + errorFecha + errorDireccion + errorDNI + errorUsuario + errorTelefono + errorNombre + errorEmail + errorTipoUsuario;

            if (string.IsNullOrEmpty(acumuladorErrores))
            {
                Operacion operacion = new Operacion();
                DateTime datetimeTxFechaNac = operacion.TransformarStringDatetime(txFechaNac);
                int intCmTipoUsuario = operacion.ObtenerTipoUsuario(cmTipoUsuario);
                int intTxDNI = operacion.TransformarStringInt(txDNI);

                NegocioUsuario negocioUsuario = new NegocioUsuario();
                try
                {
                    negocioUsuario.AgregarUsuario(txNombre, txApellido, txDireccion, txTelefono, txEmail, datetimeTxFechaNac, txNombreUsuario, intCmTipoUsuario, intTxDNI, txContraseña);
                    LimpiarCampos();
                    Congrats();
                }
                catch (Exception ex)
                {
                    lblMensajeAgregar.Text = ex.Message;
                }
            }
        }


        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtContraseña.Clear();
            txtEmail.Clear();
            txtDireccion.Clear();
            txtFechaNac.Clear();
            txtDNI.Clear();
            txtUsuario.Clear();
            txtTelefono.Clear();
            cmbTipoUsuario.SelectedIndex = -1;
        }


        private async void Congrats()
        {
            lblMensajeAgregar.Text = "Usuario cargado con éxito";
            await Task.Delay(5000);
            lblMensajeAgregar.Text = "";
        }


        private void linkLabelVolver_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            admin_gestion_form admin_gestion = new admin_gestion_form();
            admin_gestion.Show();
        }
    }
}