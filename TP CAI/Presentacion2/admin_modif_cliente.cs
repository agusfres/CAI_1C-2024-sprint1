using Datos;
using Negocio;
using Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Presentacion2
{
    public partial class admin_modif_cliente : Form
    {
        public admin_modif_cliente()
        {
            InitializeComponent();
        }

        private void linkLabelVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            admin_gestioncliente_form admin_Gestioncliente_Form = new admin_gestioncliente_form();
            admin_Gestioncliente_Form.Show();
        }


        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string txtDNI = txtIngresoDNI.Text;
            Validador validador = new Validador();
            string errorDNI = validador.ValidarDNIExistente(txtDNI, "DNI");
            lblErrorDNI.Text = errorDNI;
            if (errorDNI.Length == 0)
            {
                Operacion operacion = new Operacion();
                int DNI = operacion.TransformarStringInt(txtDNI);

                NegocioCliente negociocliente = new NegocioCliente();
                Cliente cliente = negociocliente.BuscarCliente(DNI);
                Cliente clienteLocal = negociocliente.BuscarClienteBaseLocal(txtDNI);
                txtDireccion.Text = cliente.Direccion;
                txtEmail.Text = cliente.Email;
                txtTelefono.Text = cliente.Telefono;
                txtEstado.Text = clienteLocal.Estado;
            }
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
          
            Validador validadorCampos = new Validador();
            string txtDNI = txtIngresoDNI.Text;
            Operacion operacion = new Operacion();
            int DNI = operacion.TransformarStringInt(txtDNI);
            NegocioCliente negociocliente = new NegocioCliente();
            Cliente cliente = negociocliente.BuscarCliente(DNI);

            //string txUsuario = string.Empty;
            string txTelefono = txtTelefono.Text;
            string txDireccion = txtDireccion.Text;
            string txEmail = txtEmail.Text;
            string txEstado = txtEstado.Text;
            string estado = cliente.Estado;

            string errorDireccion = validadorCampos.ValidarDireccion(txDireccion, "Dirección");
            string errorTelefono = validadorCampos.ValidarTelefono(txTelefono, "Teléfono");
            string errorEmail = validadorCampos.ValidarEmail(txEmail, "Email");
            string errorEstado = validadorCampos.ValidarEstado(estado, txEstado, "Estado");

            lblErrorTelefono.Text = errorTelefono;
            lblErrorDireccion.Text = errorDireccion;
            lblErrorEmail.Text = errorEmail;
            lblErrorEstado.Text = errorEstado;

            string acumuladorErrores = errorTelefono + errorDireccion + errorEmail + errorEstado;

            if (string.IsNullOrEmpty(acumuladorErrores))
            {
                try
                {
                     negociocliente.ModificarCliente(cliente.IdCliente,txDireccion ,txTelefono , txEmail,txEstado);
                     LimpiarCampos();
                     Congrats();
                }
                catch(Exception ex)
                {
                    lblMensaje.Text = ex.Message;
                }

            }
        }
        private void LimpiarCampos()
        {
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtEmail.Clear();
            txtEstado.Clear();
            txtIngresoDNI.Clear();

        }

        private async void Congrats()
        {
            lblMensaje.Text = "Proveedor cargado exitosamente";
            await Task.Delay(5000);
            lblMensaje.Text = "";
        }

    }
}
