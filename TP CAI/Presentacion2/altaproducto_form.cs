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
    public partial class altaproducto_form : Form
    {
        public altaproducto_form()
        {
            InitializeComponent();
        }

        private void linkLabelVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            gestionproductos gestionproductos = new gestionproductos();
            gestionproductos.Hide();

        }

        private void altaproducto_form_Load(object sender, EventArgs e)
        {

        }
    }
}
