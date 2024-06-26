﻿using Presentacion;
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
    public partial class admin_menu_form : Form
    {
        public admin_menu_form()
        {
            InitializeComponent();
        }


        private void btnGestionarUsuarios_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            admin_gestion_form form5 = new admin_gestion_form();
            form5.Show();
        }


        private void linkLabelCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            iniciarsesion_form iniciarSesion = new iniciarsesion_form();
            iniciarSesion.Show();
        }

        private void btnGestionarProveedores_Click(object sender, EventArgs e)
        {
            this.Hide();
           admin_gestionproveedor_form Admin_gestionproveedor_form = new admin_gestionproveedor_form();
            Admin_gestionproveedor_form.Show();
        }

        private void btnGestionarProductos_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestionproductos gestionproductos = new gestionproductos(3);
            gestionproductos.Show();
        }

        private void btnGestionarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_gestioncliente_form Admin_gestioncliente_form = new admin_gestioncliente_form();
            Admin_gestioncliente_form.Show();
        }
        private void btnReportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_gestionreportes_form Admin_gestionreportes_form = new admin_gestionreportes_form(3);
            Admin_gestionreportes_form.Show();
        }

        private void admin_menu_form_Load(object sender, EventArgs e)
        {
            NegocioReporte negocioReporte = new NegocioReporte();
            int cantidad = negocioReporte.AlertaBajoStock();

            if(cantidad > 0)
            {
                label1.Text = "Hay " + cantidad.ToString() + " productos con stock crítico!!!";
            }
            else
            {
                label1.Text = "";
            }
          
            
        }
    }
}