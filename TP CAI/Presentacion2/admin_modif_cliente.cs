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
            string errorDNI = validadorCampos.ValidarDNI(txDNI, "DNI");


            string acumuladorErrores = errorNombre + errorApellido + errorEmail + errorDNI;

            if (string.IsNullOrEmpty(acumuladorErrores))
            {
                Operacion operacion = new Operacion();
                int intTxDNI = operacion.TransformarStringInt(txDNI);
            }
            // FALTA VALIDACIÓN DE BUSCAR Y MODIFICAR CLIENTE EN LA API
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
