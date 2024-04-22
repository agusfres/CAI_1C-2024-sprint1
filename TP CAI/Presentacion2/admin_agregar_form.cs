using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Negocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace Presentacion2
{
    public partial class admin_agregar_form : Form
    {
        public admin_agregar_form()
        {
            InitializeComponent();
        }


        private async void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            DateTime salidaFecha = DateTime.Now;
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

            string errorNombre = "";
            string errorApellido = "";
            string errorEmail = "";
            string errorDireccion = "";
            string errorContraseña = "";
            string errorFecha = "";
            string errorDNI = "";
            string errorUsuario = "";
            string errorTelefono = "";
            string errorTipoUsuario = "";;

            Validador validadorCampos = new Validador();
            validadorCampos.ValidarTextoUno(txNombre, "Nombre", ref errorNombre);
            validadorCampos.ValidarContraseña(txContraseña, "Contraseña", ref errorContraseña);
            validadorCampos.ValidarTextoUno(txApellido, "Apellido", ref errorApellido);
            validadorCampos.ValidarTextoDos(txEmail, "Email", ref errorEmail);
            validadorCampos.ValidarTextoDos(txDireccion, "Dirección", ref errorDireccion);
            validadorCampos.ValidarFecha(txFechaNac, "Fecha", ref errorFecha, ref salidaFecha);
            validadorCampos.ValidarDNI(txDNI, "DNI", ref errorDNI);
            validadorCampos.ValidarNombreUsuario(txNombreUsuario, txNombre, txApellido, "Usuario", ref errorUsuario);
            validadorCampos.ValidarTelefono(txTelefono, "Teléfono", ref errorTelefono);
            validadorCampos.ValidarTipoUsuario(cmTipoUsuario, "Tipo de usuario", ref errorTipoUsuario);

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

                int intCmTipoUsuario = operacion.ObtenerTipoUsuario(cmTipoUsuario);

                DateTime datetimeTxFechaNac = operacion.TransformarStringDatetime(txFechaNac);
                int intTxDNI = operacion.TransformarStringInt(txDNI);

                NegocioUsuario negocioUsuario = new NegocioUsuario();

                //negocioUsuario.AgregarUsuario(txNombre, txApellido, txDireccion, txTelefono, txEmail, datetimeTxFechaNac, txNombreUsuario, '1', intTxDNI, txContraseña);
                negocioUsuario.AgregarUsuario(txNombre, txApellido, txDireccion, txTelefono, txEmail, datetimeTxFechaNac, txNombreUsuario, intCmTipoUsuario, intTxDNI, txContraseña);

                LimpiarCampos();

                lblconfirma.Text = "Usuario cargado con éxito";
                await Task.Delay(5000);
                lblconfirma.Text = "";
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


        private void linkLabelVolver_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            admin_gestion_form admin_gestion = new admin_gestion_form();
            admin_gestion.Show();
        }
    }
}

