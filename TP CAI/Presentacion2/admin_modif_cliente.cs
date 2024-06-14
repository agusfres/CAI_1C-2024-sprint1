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
        NegocioCliente negociocliente = new NegocioCliente();
        Validador validador = new Validador();
        Operacion operacion = new Operacion();


        public admin_modif_cliente()
        {
            InitializeComponent();
        }


        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            lblErrorDNI.ForeColor = Color.Red;


            string txDNI = txtDNI.Text;

            string errorDNI = validador.ValidarDNIExistente(txDNI, "DNI");

            lblErrorDNI.Text = errorDNI;

            if (string.IsNullOrEmpty(errorDNI))
            {
                int dni = operacion.TransformarStringInt(txDNI);

                Cliente cliente = negociocliente.BuscarCliente(dni);
                Cliente clienteLocal = negociocliente.BuscarClienteBaseLocal(txDNI);

                txtDireccion.Text = cliente.Direccion;
                txtEmail.Text = cliente.Email;
                txtTelefono.Text = cliente.Telefono;
                txtEstado.Text = "";

                if (clienteLocal != null)
                {
                    txtEstado.Text = clienteLocal.Estado;
                }
            }
        }


        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            lblErrorTelefono.ForeColor = Color.Red;
            lblErrorDireccion.ForeColor = Color.Red;
            lblErrorEstado.ForeColor = Color.Red;
            lblErrorEmail.ForeColor = Color.Red;
            lblMensaje.ForeColor = Color.Red;

            string txDNI = this.txtDNI.Text;
            int DNI = operacion.TransformarStringInt(txDNI);
            Cliente cliente = negociocliente.BuscarCliente(DNI);

            string txTelefono = txtTelefono.Text;
            string txDireccion = txtDireccion.Text;
            string txEstado = txtEstado.Text;
            string txEmail = txtEmail.Text;

            string errorTelefono = validador.ValidarTelefono(txTelefono, "Teléfono");
            string errorDireccion = validador.ValidarDireccion(txDireccion, "Dirección");
            string errorEstado = validador.ValidarEstado(txEstado, "Estado");
            string errorEmail = validador.ValidarEmail(txEmail, "Email");

            lblErrorTelefono.Text = errorTelefono;
            lblErrorDireccion.Text = errorDireccion;
            lblErrorEstado.Text = errorEstado;
            lblErrorEmail.Text = errorEmail;

            string acumuladorErrores = errorTelefono + errorDireccion + errorEstado + errorEmail;

            if (string.IsNullOrEmpty(acumuladorErrores))
            {
                try
                {
                     negociocliente.ModificarCliente(cliente.Id, txTelefono, txDireccion, txEstado, txEmail);
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
            txtDNI.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtEstado.Clear();
            txtEmail.Clear();
        }


        private async void Congrats()
        {
            lblMensaje.ForeColor = Color.Green;
            lblMensaje.Text = "Cliente modificado exitosamente";
            await Task.Delay(5000);
            lblMensaje.Text = "";
        }


        private void linkLabelVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            admin_gestioncliente_form admin_Gestioncliente_Form = new admin_gestioncliente_form();
            admin_Gestioncliente_Form.Show();
        }
    }
}
