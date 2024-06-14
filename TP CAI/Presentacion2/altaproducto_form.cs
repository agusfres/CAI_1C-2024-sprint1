using Datos;
using Negocio;
using Persistencia;
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
    public partial class altaproducto_form : Form
    {
        private int tipousuario;


        public altaproducto_form(int tipousuario)
        {
            InitializeComponent();
            this.tipousuario = tipousuario;
        }


        public void altaproducto_form_Load(object sender, EventArgs e)
        {
            NegocioProveedor negocioproveedor = new NegocioProveedor();
            List<Proveedor> listaproveedor = negocioproveedor.TraerProveedoresActivos();
            foreach (Proveedor proveedor in listaproveedor)
            {
                cmbProveedores.Items.Add(proveedor.Cuit);
            }
        }


        private void altaProducto_btnConfirmar_Click(object sender, EventArgs e)
        {
            lblErrorNombre.ForeColor = Color.Red;
            lblErrorCategoria.ForeColor = Color.Red;
            lblErrorprecio.ForeColor = Color.Red;
            lblErrorStock.ForeColor = Color.Red;
            lblErrorIdProveedor.ForeColor = Color.Red;
            lblErrorAgregar.ForeColor = Color.Red;

            lblErrorNombre.Text = "";
            lblErrorCategoria.Text = "";
            lblErrorprecio.Text = "";
            lblErrorStock.Text = "";
            lblErrorIdProveedor.Text = "";


            Validador validadorCampos = new Validador();

            string txNombre = txtNombre.Text;
            string cmCategoria = cmbCategoria.Text;
            string txPrecio = txtPrecio.Text;
            string txStock = txtStock.Text;
            string txIdProveedor = cmbProveedores.Text;

            string errorNombre = validadorCampos.ValidarNombreProducto(txNombre, "Nombre");
            string errorCategoria = validadorCampos.ValidarCategoriaProducto2(cmCategoria, "Categoria");
            string errorPrecio = validadorCampos.ValidarStockPrecio(txPrecio, "Precio");
            string errorStock = validadorCampos.ValidarStockPrecio(txStock, "Stock");
            string errorIdProveedor = validadorCampos.ValidarIdProveedor(txIdProveedor, "ID Proveedor");

            lblErrorNombre.Text = errorNombre;
            lblErrorCategoria.Text = errorCategoria;
            lblErrorprecio.Text = errorPrecio;
            lblErrorStock.Text = errorStock;
            lblErrorIdProveedor.Text = errorIdProveedor;

            string acumuladorErrores = errorNombre + errorCategoria + errorPrecio + errorStock + errorIdProveedor;

            if (string.IsNullOrEmpty(acumuladorErrores))
            {
                Operacion operacion = new Operacion();
                
                int intCmCategoria = operacion.ObtenerTipoCategoria(cmCategoria);
                double doubleTxPrecio = operacion.TransformarStringDouble(txPrecio);
                int intTxStock = operacion.TransformarStringInt(txStock);
                
                NegocioProveedor negocioproveedor = new NegocioProveedor();
                NegocioProducto negocioProducto = new NegocioProducto();
                Proveedor proveedor = negocioproveedor.BuscarProveedor(txIdProveedor);

                try
                {
                    negocioProducto.AgregarProducto(txNombre, intCmCategoria, doubleTxPrecio, intTxStock, proveedor.Id);
                    LimpiarCampos();
                    Congrats();
                }
                catch (Exception ex)
                {
                    lblErrorAgregar.Text = ex.Message;
                }
            }
        }


        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            cmbCategoria.SelectedIndex = -1;
            cmbProveedores.SelectedIndex = -1;
        }


        private async void Congrats()
        {
            lblConfirmar.ForeColor = Color.Green;
            lblConfirmar.Text = "Producto cargado con éxito";
            await Task.Delay(5000);
            lblConfirmar.Text = "";
        }


        private void linkLabelVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            gestionproductos gestionproductos = new gestionproductos(tipousuario);
            gestionproductos.Show();
        }
    }
}
