using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Negocio;
using Datos;


namespace TP_CAI
{
    public partial class admin_agregar_form : Form
    {
        List<Usuario> usuarios = new List<Usuario>();

        public admin_agregar_form()
        {
            InitializeComponent();
        }


        private async void btnConfirmar_Click(object sender, EventArgs e)
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
            string errorTipoUsuario = "";
            string acumuladorErrores = "";

            Validador validadorCampos = new Validador();
            validadorCampos.validarTextoUno(txNombre, "Nombre", ref errorNombre);
            validadorCampos.validarContraseña(txContraseña, "Contraseña", ref errorContraseña);
            validadorCampos.validarTextoUno(txApellido, "Apellido", ref errorApellido);
            validadorCampos.validarTextoDos(txEmail, "Email", ref errorEmail);
            validadorCampos.validarTextoDos(txDireccion, "Dirección", ref errorDireccion);
            validadorCampos.validarFecha(txFechaNac, "Fecha", ref errorFecha, ref salidaFecha);
            validadorCampos.validarDNI(txDNI, "DNI", ref errorDNI);
            validadorCampos.validarNombreUsuario(txNombreUsuario, txNombre, txApellido, "Usuario", ref errorUsuario);
            validadorCampos.validarTelefono(txTelefono, "Teléfono", ref errorTelefono);
            validadorCampos.validarTipoUsuario(cmTipoUsuario, "Tipo de usuario", ref errorTipoUsuario);

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

            acumuladorErrores = errorApellido + errorContraseña + errorFecha + errorDireccion + errorDNI + errorUsuario + errorTelefono + errorNombre + errorEmail + errorTipoUsuario;

            if (string.IsNullOrEmpty(acumuladorErrores))
            {

                Operacion operacion = new Operacion();
                int id = operacion.asignarId(usuarios);
                string host = "grupo 5";
                int intCmTipoUsuario = operacion.transformarStringInt(cmTipoUsuario);
                DateTime datetimeTxFechaNac = operacion.transformarStringDatetime(txFechaNac);
                int intTxDNI = operacion.transformarStringInt(txDNI);

                NegocioUsuario negocio = new NegocioUsuario();
                negocio.Alta(id, txNombre, txApellido, txDireccion, txTelefono, txEmail, DateTime.Now, datetimeTxFechaNac, DateTime.Now, DateTime.Now, txNombreUsuario, intCmTipoUsuario, intTxDNI, txContraseña, host,usuarios);

                LimpiarCampos();

                lblconfirma.Text = "Usuario cargado con éxito ";
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

        private void linkLabelVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            admin_gestion_form form5 = new admin_gestion_form();
            form5.Show();
            
        }
    }
}
