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
    public partial class vendedor_registarventa_form : Form
    {
        public vendedor_registarventa_form()
        {
            InitializeComponent();
        }

        private void linkLabelVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            vendedor_menu_form vendedor_Menu_Form = new vendedor_menu_form();
            vendedor_Menu_Form.Show();    
        }
    }
}
