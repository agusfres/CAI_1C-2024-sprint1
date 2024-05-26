using Datos;
using Persistencia;
using Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion2
{
    
    public partial class reporte_ventas_cat : Form
    {
        ProductoService productoService = new ProductoService();
        public reporte_ventas_cat()
        {
            InitializeComponent();
        }

        private void linkLabelVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            admin_gestionreportes_form admin_gestionreportes_form = new admin_gestionreportes_form();
            admin_gestionreportes_form.Show();
        }

        public void reporte_ventas_cat_Load(object sender, EventArgs e)
        {
            int categoria= 1;

            //Aca deberia buscar en el de ventas 

            List <Producto> listaproductos = productoService.TraerProductosPorCategoria(categoria);
           
            foreach (Producto producto in listaproductos)
            {
                
            }

            //lblProducto1.Text=al producto con mas ventas

            //repetir por cada categoria
        }


    }
}
