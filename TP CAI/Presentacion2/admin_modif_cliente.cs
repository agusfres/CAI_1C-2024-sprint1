using Datos;
using Negocio;
using Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
          
            Validador validadorCampos = new Validador();

            string txNombre = txtTelefono.Text;
            string txApellido = txtDireccion.Text;
            string txEmail = txtEmail.Text;
            string txDNI = txtEstado.Text;

            string errorNombre = validadorCampos.ValidarNombre(txNombre, "Nombre");
            string errorApellido = validadorCampos.ValidarNombre(txApellido, "Apellido");
            string errorEmail = validadorCampos.ValidarEmail(txEmail, "Email");
            string errorEstado = validadorCampos.ValidarDNI(txDNI, "DNI");


            string acumuladorErrores = errorNombre + errorApellido + errorEmail + errorEstado;

            if (string.IsNullOrEmpty(acumuladorErrores))
            {
                Operacion operacion = new Operacion();
                int intTxDNI = operacion.TransformarStringInt(txDNI);
            }
            // FALTA VALIDACIÓN DE BUSCAR Y MODIFICAR CLIENTE EN LA API

            NegocioCliente negociocliente = new NegocioCliente();
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
                txtDireccion.Text = cliente.Direccion;
                txtEmail.Text = cliente.Email;
                txtTelefono.Text = cliente.Telefono;    
            }
        }
    }
}
