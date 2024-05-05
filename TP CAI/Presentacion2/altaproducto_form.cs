using Negocio;
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
            lblErrorStock.Text = ""; ;
            lblErrorprecio.Text = "";



            Validador validadorCampos = new Validador();

            string txNombre = txtNombre.Text;
            string cmCategoria = comboBox1.Text;
            string txPrecio = txtprecio.Text;
            string txStock = txtstock.Text;
            string errorNombre = validadorCampos.ValidarNombreProducto(txNombre, "Nombre");
            string errorPrecio = validadorCampos.ValidarStockPrecio(txPrecio, "Precio");
            string errorStock = validadorCampos.ValidarStockPrecio(txStock, "Stock");
            // Buscar forma para que no haya que crear dos validaciones de un mismo atributo (Modificar a ListBox?)
            string errorCategoria = validadorCampos.ValidarCategoriaProducto2(cmCategoria, "Categoria");

            lblErrorNombre.Text = errorNombre;
            lblErrorStock.Text = errorStock;
            lblErrorprecio.Text = errorPrecio;
            lblErrorCategoria.Text = errorCategoria;

            string acumuladorErrores = errorNombre + errorStock + errorPrecio + errorCategoria;

            if (string.IsNullOrEmpty(acumuladorErrores))
            {
                Operacion operacion = new Operacion();
                double doubleTxPrecio = operacion.TransformarStringDouble(txPrecio);
                int intTxStock = operacion.TransformarStringInt(txStock);
                int intCmCategoria = operacion.ObtenerTipoCategoria(cmCategoria);
               // NegocioProducto negocioProducto = new NegocioProducto();

                try
                {
                    //negocioProducto.AgregarProducto(txNombre, intCmCategoria, idUsuario, idProveedor,doubleTxPrecio,intTxStock);
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    //lblMensajeAgregar.Text = ex.Message;
                }

            }
        }
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtprecio.Clear();
            txtstock.Clear();
            comboBox1.SelectedIndex = -1;
        }

    }
}
