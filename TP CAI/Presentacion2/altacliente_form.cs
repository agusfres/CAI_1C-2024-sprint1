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
using Presentacion;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;




namespace Presentacion2
{
    public partial class altacliente_form : Form
    {
        public altacliente_form()
        {
            InitializeComponent();
        }


        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            lblErrorNombre.Text = "";
            lblErrorApellido.Text = ""; ;
            lblErrorEmail.Text = "";
            lblErrorDireccion.Text = "";
            lblErrorFecha.Text = "";
            lblErrorDNI.Text = "";
            lblErrorTelefono.Text = "";

            Validador validadorCampos = new Validador();

            string txNombre = txtNombre.Text;
            string txApellido = txtApellido.Text;
            string txEmail = txtEmail.Text;
            string txDireccion = txtDireccion.Text;
            string txFechaNac = txtFechaNac.Text;
            string txDNI = txtDNI.Text;
            string txTelefono = txtTelefono.Text;

            string errorNombre = validadorCampos.ValidarNombre(txNombre, "Nombre");
            string errorApellido = validadorCampos.ValidarNombre(txApellido, "Apellido");
            string errorDireccion = validadorCampos.ValidarDireccion(txDireccion, "Dirección");
            string errorTelefono = validadorCampos.ValidarTelefono(txTelefono, "Teléfono");
            string errorEmail = validadorCampos.ValidarEmail(txEmail, "Email");
            string errorFecha = validadorCampos.ValidarFecha(txFechaNac, "Fecha");
            string errorDNI = validadorCampos.ValidarDNI(txDNI, "DNI");

            lblErrorNombre.Text = errorNombre;
            lblErrorApellido.Text = errorApellido;
            lblErrorEmail.Text = errorEmail;
            lblErrorDireccion.Text = errorDireccion;
            lblErrorFecha.Text = errorFecha;
            lblErrorDNI.Text = errorDNI;
            lblErrorTelefono.Text = errorTelefono;

            string acumuladorErrores = errorApellido + errorFecha + errorDireccion + errorDNI  + errorTelefono + errorNombre + errorEmail;

            if (string.IsNullOrEmpty(acumuladorErrores))
            {
                Operacion operacion = new Operacion();
                DateTime datetimeTxFechaNac = operacion.TransformarStringDatetime(txFechaNac);
                int intTxDNI = operacion.TransformarStringInt(txDNI);

                NegocioCliente negociocliente = new NegocioCliente();
                try
                {
                    negociocliente.AgregarCliente(txNombre, txApellido, txDireccion, txTelefono, txEmail, datetimeTxFechaNac, intTxDNI);
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
            txtEmail.Clear();
            txtDireccion.Clear();
            txtFechaNac.Clear();
            txtDNI.Clear();
            txtCliente.Clear();
            txtTelefono.Clear();
        }


        private async void Congrats()
        {
            lblMensajeAgregar.Text = "Usuario cargado con éxito";
            await Task.Delay(5000);
            lblMensajeAgregar.Text = "";
        }


        private void linkLabelVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            admin_gestioncliente_form admin_Gestioncliente_Form = new admin_gestioncliente_form();
            admin_Gestioncliente_Form.Show();
        }
    }
}