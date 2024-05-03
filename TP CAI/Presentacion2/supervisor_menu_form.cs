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
    public partial class supervisor_menu_form : Form
    {
        public supervisor_menu_form()
        {
            InitializeComponent();
        }

        private void btnGestionarProductos_Click(object sender, EventArgs e)
        {
            this.Hide();
            altaproducto_form altaproducto = new altaproducto_form();
            altaproducto.Show();
        }

        private void linkLabelVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            iniciarsesion_form iniciarsesion_Form = new iniciarsesion_form();
            iniciarsesion_Form.Show();
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            this.Hide();
            supervisor_devolucion_venta supervisor_Devolucion_Venta = new supervisor_devolucion_venta();
            supervisor_Devolucion_Venta.Show();
        }
    }
}
