using Datos;
using Negocio;
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
        public altaproducto_form()
        {
            InitializeComponent();
        }

        private void linkLabelVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            gestionproductos gestionproductos = new gestionproductos();
            gestionproductos.Hide();

        }
        private void altaproducto_form_Load(object sender, EventArgs e)
        {


        }

        private void altaProducto_btnConfirmar_Click(object sender, EventArgs e)
        {
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
            string txIdProveedor = txtIdProveedor.Text;

            string errorNombre = validadorCampos.ValidarNombreProducto(txNombre, "Nombre");
            // Buscar forma para que no haya que crear dos validaciones de un mismo atributo (Modificar a ListBox?)
            string errorCategoria = validadorCampos.ValidarCategoriaProducto2(cmCategoria, "Categoria");
            string errorPrecio = validadorCampos.ValidarStockPrecio(txPrecio, "Precio");
            string errorStock = validadorCampos.ValidarStockPrecio(txStock, "Stock");
            string errorIdProveedor = validadorCampos.ValidarId(txIdProveedor, "ID Proveedor");

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
                Guid guidIdProveedor = Guid.Parse(txIdProveedor);

                NegocioProducto negocioProducto = new NegocioProducto();

                try
                {
                    negocioProducto.AgregarProducto(txNombre, intCmCategoria, doubleTxPrecio, intTxStock, guidIdProveedor);
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
            txtIdProveedor.Clear();
        }

        private async void Congrats()
        {
            lblConfirmar.Text = "Usuario cargado con éxito";
            await Task.Delay(5000);
            lblConfirmar.Text = "";
        }
    }
}
