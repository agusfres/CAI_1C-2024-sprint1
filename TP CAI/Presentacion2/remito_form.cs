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
    public partial class remito_form : Form
    {
        public remito_form()
        {
            InitializeComponent();
        }

        private void btnventa_Click(object sender, EventArgs e)
        {
            this.Hide();
            agregarventa_form agregarventa_Form = new agregarventa_form();
            agregarventa_Form.Show();
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            vendedor_menu_form vendedor_Menu_Form = new vendedor_menu_form();
           vendedor_Menu_Form.Show();
        }
    }
}
