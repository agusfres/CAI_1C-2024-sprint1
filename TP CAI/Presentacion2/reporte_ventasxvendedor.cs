using Datos;
using Presentacion;
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
    public partial class reporte_ventasxvendedor : Form
    {
        Validador validador = new Validador();
        Operacion operacion = new Operacion();
        NegocioReporte negocioReporte = new NegocioReporte();

        private int tipousuario;
        public reporte_ventasxvendedor(int tipousuario)
        {
            InitializeComponent();
            this.tipousuario = tipousuario;
        }


        private void linkLabelVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (tipousuario == 1)
            {
                this.Hide();
                vendedor_menu_form vendedormenu = new vendedor_menu_form();
                vendedormenu.Show();
            }
            else
            {
                this.Hide();
                admin_gestionreportes_form admin_gestionreportes_form = new admin_gestionreportes_form(tipousuario);
                admin_gestionreportes_form.Show();

            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lblSinResultados.Text = "";
            dataGridView1.Rows.Clear();

            string cmMes = cmbMes.Text;
            
            string errorMes = validador.ValidarMes(cmMes, "Mes");

            lblErrorMes.Text = errorMes;

            if (string.IsNullOrEmpty(errorMes))
            {
                int numeroMes = operacion.ObtenerNumeroMes(cmMes);

                List<ReporteVentasPorVendedor> listaVentasPorVendedor = negocioReporte.ReporteVentasPorVendedor(numeroMes);

                if (listaVentasPorVendedor.Count == 0)
                {
                    lblSinResultados.Text = "No hubo ninguna venta en el periodo seleccionado";
                }
                else
                {
                    foreach (ReporteVentasPorVendedor reporteIndividual in listaVentasPorVendedor)
                    {
                        dataGridView1.Rows.Add(reporteIndividual.Nombre, reporteIndividual.CantidadVentas, reporteIndividual.MontoTotal);
                    }
                }
            }
        }
    }
}
