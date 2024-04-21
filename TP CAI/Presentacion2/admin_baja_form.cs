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
        Usuario usuario = new Usuario (1, "Catalina", "Alvarez", "Salta 2300", "11525252", "ccc@ffff", DateTime.Now, DateTime.Now, null, null, "cataac", 1, 43571365, "ABR", "WER");

        public admin_baja_form()
        {
            InitializeComponent();
        }

        private void btnBuscarUsuario_Click_1(object sender, EventArgs e)
        {
            
            usuarios.Add(usuario);
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
            string txDNI = txtDNI.Text;
            NegocioUsuario negocioUsuario = new NegocioUsuario();

            if (int.TryParse(txDNI, out int dni))
            {
                negocioUsuario.Delete(dni, usuarios);
            }
            else
            {
                lblErrorEliminar.Text = "Debes seleccionar el usuario a eliminar";
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
