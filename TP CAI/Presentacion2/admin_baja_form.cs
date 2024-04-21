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
        List<Usuario> usuarios = new List<Usuario>();
        public admin_baja_form()
        {
            InitializeComponent();
        }

        private void btnBuscarUsuario_Click_1(object sender, EventArgs e)
        {
            
            string txDNI = txtDNI.Text;
            string msg = "";

            if (string.IsNullOrEmpty(txDNI))
            {
                lblErrorDNI.Text = "Ingrese un DNI";
            }
            else if (int.TryParse(txDNI, out int dni))
            {
                NegocioUsuario negocio = new NegocioUsuario();
                msg = negocio.BuscarDni(dni, usuarios);

                if (msg == "ERROR")
                {
                    lblErrorDNI.Text = "Ingrese un DNI existente.";
                }
                else
                {
                    listBoxUsuario.Text = msg;
                }

            }
            else
            {
                lblErrorDNI.Text = "Ingrese un dato válido";
            }
            
        }

        private void btnEliminarUsuario_Click_1(object sender, EventArgs e)
        {
            // Cambiar txDNI por txIdUsuario, ya que se necesita el Guid del id usuario para eliminar o borrar
            string txDNI = txtDNI.Text;
            NegocioUsuario negocioUsuario = new NegocioUsuario();
            Operacion operacion = new Operacion();

            if (Guid.TryParse(txDNI, out Guid idUsuario))
            {
                negocioUsuario.BorrarUsuario(idUsuario);
            }
            else
            {
                lblErrorEliminar.Text = "Debes indicar el id / Guid del usuario a eliminar";
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
