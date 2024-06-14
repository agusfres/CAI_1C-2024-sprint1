using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Presentacion;


namespace Presentacion2
{
    public partial class supervisor_devolucion_venta : Form
    {
        public supervisor_devolucion_venta()
        {
            InitializeComponent();
        }


        private void btnDevolver_Click(object sender, EventArgs e)
        {
            lblErrorEliminar.ForeColor = Color.Red;

            string id = txtIdventa.Text;
            Validador validador = new Validador();
            lblErrorEliminar.Text = validador.ValidarIdVenta(id, "ID Venta");
           
            if (lblErrorEliminar.Text == "")
            {
                NegocioVenta negocioVenta = new NegocioVenta();
                negocioVenta.DevolucionCompra(id);

                LimpiarCampos();
                Congrats();
            }
        }


        private void LimpiarCampos()
        {
            lblErrorEliminar.Text = "";
            txtIdventa.Clear();
        }

        private async void Congrats()
        {
            lblMensajeEliminar.ForeColor = Color.Green;
            lblMensajeEliminar.Text = "La venta fue devuelta exitosamente";
            await Task.Delay(5000);
            lblMensajeEliminar.Text = "";
        }


        private void linkLabelVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            supervisor_menu_form supervisor_Menu_Form = new supervisor_menu_form();
            supervisor_Menu_Form.Show();
        }
    }
}
