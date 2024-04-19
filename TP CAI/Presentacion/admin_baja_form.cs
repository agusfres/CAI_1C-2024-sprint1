using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Negocio;

namespace TP_CAI
{
    public partial class admin_baja_form : Form
    {
        List<Usuario> usuarios = new List<Usuario>();
        Usuario usuario = new(1,"Catalina","Alvarez","Salta 2300","11525252","ccc@ffff",DateTime.Now,DateTime.Now, null,null,"cataac",1,43571365,"ABR","WER");

        public admin_baja_form()
        {
            InitializeComponent();
        }

        private void linkLabelVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            admin_gestion_form form5 = new admin_gestion_form();
            form5.Show();
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            usuarios.Add(usuario);
            string txDNI = txtDNI.Text;
            string msg = "";

            if (string.IsNullOrEmpty(txDNI))
            {
                lblErrorDNI.Text = "Ingrese un DNI";
            }
            else
            {
                NegocioUsuario negocio = new NegocioUsuario();

                Operacion operacion = new Operacion();
                int dni = operacion.transformarStringInt(txDNI);

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
        }

        private async void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            string txDNI = txtDNI.Text;
            Operacion operacion = new Operacion();
            int dni = operacion.transformarStringInt(txDNI);

            NegocioUsuario negocio = new NegocioUsuario();
            negocio.Delete(dni,usuarios);
        }
    }
}
