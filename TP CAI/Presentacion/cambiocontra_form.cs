using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_CAI
{
    public partial class cambiocontra_form : Form
    {
        public cambiocontra_form()
        {
            InitializeComponent();
        }

        private void linkLabelVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            iniciarsesion_form form2 = new iniciarsesion_form();
            form2.Show();
        }
    }
}
