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

namespace Presentacion2
{
    public partial class admin_agregarproveedor_form : Form
    {
        public admin_agregarproveedor_form()
        {
            InitializeComponent();
        }


        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Validador validadorCampos = new Validador();

            string txNombre = txtNombre.Text;
            string txApellido = txtApellido.Text;
            string txCuit = txtCuit.Text;
            string txEmail = txtEmail.Text;
            List<int> seleccionCategoriaProd = new List<int>(ListbxCategorias.CheckedIndices.Cast<int>());


            string errorNombre = validadorCampos.ValidarNombre(txNombre, "Nombre");
            string errorApellido = validadorCampos.ValidarNombre(txApellido, "Apellido");
            string errorCuit = validadorCampos.ValidarCuit(txCuit, "CUIT");
            string errorEmail = validadorCampos.ValidarEmail(txEmail, "Email");
            string errorCategoriaProducto = validadorCampos.ValidarCategoriaProducto1(ListbxCategorias);

            lblErrorNombre.Text = errorNombre;
            lblErrorApellido.Text = errorApellido;
            lblErrorCuit.Text = errorCuit;
            lblErrorEmail.Text = errorEmail;
            lblErrorCategoria.Text = errorCategoriaProducto;


            string acumuladorErrores = errorNombre + errorApellido + errorCuit + errorEmail + errorCategoriaProducto;

            if (string.IsNullOrEmpty(acumuladorErrores))
            {
                NegocioProveedor negocioProveedor = new NegocioProveedor();
                try
                {
                    negocioProveedor.AgregarProveedor(txNombre, txApellido, txCuit, txEmail, seleccionCategoriaProd);

                    LimpiarCampos();
                    Congrats();
                }
                catch (Exception ex)
                {
                    lblMensaje.Text = ex.Message;
                }
            }
        }


        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCuit.Clear();
            txtEmail.Clear();
            for (int i = 0; i < ListbxCategorias.Items.Count; i++)
            {

                ListbxCategorias.SetItemChecked(i, false);
            }


        }


        private async void Congrats()
        {
            lblMensaje.Text = "Proveedor cargado exitosamente";
            await Task.Delay(5000);
            lblMensaje.Text = "";
        }


        private void linkLabelVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            admin_gestionproveedor_form admin_Gestionproveedor_Form = new admin_gestionproveedor_form();
            admin_Gestionproveedor_Form.Show();
        }
    }
}
