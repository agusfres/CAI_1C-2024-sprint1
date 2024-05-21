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
    }
}
