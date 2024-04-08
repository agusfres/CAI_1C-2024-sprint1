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
            string txContrasena = txtContraseña.Text;
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
            string errorContrasena = "";
            string errorFecha = "";
            string errorDNI = "";
            string errorUsuario = "";
            string errorTelefono = "";
            string acumuladorErrores = "";



            Validador validadorCampos = new Validador();
            validadorCampos.validarTextoUno(txNombre, "Nombre",ref errorNombre);
            validadorCampos.validarContrasena(txContrasena, "Contrasena", ref errorContrasena);
            validadorCampos.validarTextoUno(txApellido, "Apellido", ref errorApellido);
            validadorCampos.validarTextoDos(txEmail, "Email", ref errorEmail);
            validadorCampos.validarTextoDos(txDireccion, "Dirección", ref errorDireccion);
            validadorCampos.validarFecha(txFechaNac, "Fecha", ref errorFecha, ref salidaFecha);
            validadorCampos.validarDNI(txDNI, "DNI", ref errorDNI);
            validadorCampos.validarNombreUsuario(txNombreUsuario, txNombre, txApellido, "Usuario", ref errorUsuario);
            validadorCampos.validarTextoUno(txTelefono, "Teléfono", ref errorTelefono);

            lblErrorNombre.Text = errorNombre;
            lblErrorApellido.Text = errorApellido;
            lblErrorEmail.Text = errorEmail;
            lblErrorDireccion.Text = errorDireccion;
            lblErrorContraseña.Text = errorContrasena;
            lblErrorFecha.Text = errorFecha;
            lblErrorDNI.Text = errorDNI;
            lblErrorUsuario.Text = errorUsuario;
            lblErrorTelefono.Text = errorTelefono;

        }



    }
}