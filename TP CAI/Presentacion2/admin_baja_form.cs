using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Negocio;


namespace Presentacion2
{
    public partial class admin_baja_form : Form
    {
        public admin_baja_form()
        {
            InitializeComponent();
        }


        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            string txIdUsuario = txtIdUsuario.Text;
            NegocioUsuario negocioUsuario = new NegocioUsuario();

            if (Guid.TryParse(txIdUsuario, out Guid idUsuario))
            {
                try
                {
                    negocioUsuario.BorrarUsuario(idUsuario);

                    lblUsuarioEliminadoExitosamente.Text = "Usuario eliminado exitosamente";
                }
                catch (Exception ex)
                {
                    lblErrorEliminar.Text = ex.Message;
                }
            }
            else
            {
                lblErrorEliminar.Text = "Debes indicar el ID/Guid válido del usuario a eliminar";
            }
        }


        private void linkLabelVolver_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            admin_gestion_form form5 = new admin_gestion_form();
            form5.Show();
        }
    }
}