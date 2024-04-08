using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TP_CAI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DateTime salidaFecha = DateTime.Now;
            string txNombre = txtNombre.Text;
            string txApellido = txtApellido.Text;
            string txContrase�a = txtContrase�a.Text;
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
            string errorContrase�a = "";
            string errorFecha = "";
            string errorDNI = "";
            string errorUsuario = "";
            string errorTelefono = "";
            string errorTipoUsuario = "";
            string acumuladorErrores = "";

            Validador validadorCampos = new Validador();
            validadorCampos.validarTextoUno(txNombre, "Nombre",ref errorNombre);
            validadorCampos.validarContrase�a(txContrase�a, "Contrase�a", ref errorContrase�a);
            validadorCampos.validarTextoUno(txApellido, "Apellido", ref errorApellido);
            validadorCampos.validarTextoDos(txEmail, "Email", ref errorEmail);
            validadorCampos.validarTextoDos(txDireccion, "Direcci�n", ref errorDireccion);
            validadorCampos.validarFecha(txFechaNac, "Fecha", ref errorFecha, ref salidaFecha);
            validadorCampos.validarDNI(txDNI, "DNI", ref errorDNI);
            validadorCampos.validarNombreUsuario(txNombreUsuario, txNombre, txApellido, "Usuario", ref errorUsuario);
            validadorCampos.validarTextoUno(txTelefono, "Tel�fono", ref errorTelefono);
            validadorCampos.validarTipoUsuario(cmTipoUsuario, "Tipo de usuario", ref errorTipoUsuario);

            lblErrorNombre.Text = errorNombre;
            lblErrorApellido.Text = errorApellido;
            lblErrorEmail.Text = errorEmail;
            lblErrorDireccion.Text = errorDireccion;
            lblErrorContrase�a.Text = errorContrase�a;
            lblErrorFecha.Text = errorFecha;
            lblErrorDNI.Text = errorDNI;
            lblErrorUsuario.Text = errorUsuario;
            lblErrorTelefono.Text = errorTelefono;
            lblErrorTipoUsuario.Text = errorTipoUsuario;

            acumuladorErrores = errorApellido + errorContrase�a + errorFecha + errorDireccion + errorDNI + errorUsuario + errorTelefono + errorNombre + errorEmail + errorTipoUsuario;

            if (string.IsNullOrEmpty(acumuladorErrores))
            {
                Transformador transformador = new Transformador();
                int intCmTipoUsuario = transformador.transformarStringInt(cmTipoUsuario);
                DateTime datetimeTxFechaNac = transformador.transformarStringDatetime(txFechaNac);
                int intTxDNI = transformador.transformarStringInt(txDNI);

                Usuario usuario = new Usuario(1, txNombre, txApellido, txDireccion, txTelefono, txEmail, DateTime.Now, datetimeTxFechaNac, DateTime.Now, DateTime.Now, txNombreUsuario, intCmTipoUsuario, intTxDNI, txContrase�a);
                lblconfirma.Text = "Usuario cargado con �xito ";
                LimpiarCampos();
            }


        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtContrase�a.Clear();
            txtEmail.Clear();
            txtDireccion.Clear();
            txtFechaNac.Clear();
            txtDNI.Clear();
            txtUsuario.Clear();
            txtTelefono.Clear();
            cmbTipoUsuario.SelectedIndex = -1;
        }

    }
}
