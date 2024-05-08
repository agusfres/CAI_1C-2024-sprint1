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
    public partial class admin_bajaproveedor_form : Form
    {
        NegocioProveedor negocioProveedor = new NegocioProveedor();


        public admin_bajaproveedor_form()
        {
            InitializeComponent();
        }


        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            lblErrorId.Text = "";
            string txId = txtId.Text;
           

            if (Guid.TryParse(txId, out Guid id))
            {
                try
                {
                    negocioProveedor.BajaProveedor(id);

                    LimpiarCampos();
                    Congrats();
                }
                catch (Exception ex)
                {
                    lblMensajeEliminar.Text = ex.Message;
                }
            }
            else
            {
                lblErrorId.Text = "Debes indicar el ID/Guid válido del usuario a eliminar";
            }
        }


        private void LimpiarCampos()
        {
            txtId.Clear();
        }


        private async void Congrats()
        {
            lblMensajeEliminar.Text = "Proveedor eliminado exitosamente";
            await Task.Delay(5000);
            lblMensajeEliminar.Text = "";
        }


        private void linkLabelVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            admin_gestionproveedor_form admin_Gestionproveedor_Form = new admin_gestionproveedor_form();
            admin_Gestionproveedor_Form.Show();
        }
    }
}
