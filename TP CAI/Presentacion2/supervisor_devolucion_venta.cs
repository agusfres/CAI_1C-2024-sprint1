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

        private void linkLabelVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            supervisor_menu_form supervisor_Menu_Form = new supervisor_menu_form();
            supervisor_Menu_Form.Show();
        }
    }
}
