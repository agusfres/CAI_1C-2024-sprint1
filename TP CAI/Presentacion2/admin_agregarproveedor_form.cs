﻿using System;
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
    public partial class admin_agregarproveedor_form : Form
    {
        public admin_agregarproveedor_form()
        {
            InitializeComponent();
        }

        private void linkLabelVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            admin_gestionproveedor_form admin_Gestionproveedor_Form = new admin_gestionproveedor_form();
            this.Show();
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }
    }
}