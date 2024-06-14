namespace Presentacion2
{
    partial class agregarventa_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblagregarproductos = new System.Windows.Forms.Label();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblTotalTexto = new System.Windows.Forms.Label();
            this.lblDescuentosTexto = new System.Windows.Forms.Label();
            this.lblTotalFinalTexto = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDescuentos = new System.Windows.Forms.Label();
            this.lblTotalFinal = new System.Windows.Forms.Label();
            this.lblErrorProducto = new System.Windows.Forms.Label();
            this.lblErrorCantidad = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabelVolver = new System.Windows.Forms.LinkLabel();
            this.lblErrorDNI = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.lblPromociones = new System.Windows.Forms.Label();
            this.lblPromocionesTexto = new System.Windows.Forms.Label();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.button1 = new ePOSOne.btnProduct.Button_WOC();
            this.lblErrorFinalizar = new System.Windows.Forms.Label();
            this.lblErrorCarrito = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Cantidad,
            this.Precio});
            this.dataGridView1.Location = new System.Drawing.Point(302, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(364, 139);
            this.dataGridView1.TabIndex = 0;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 125;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 125;
            // 
            // lblagregarproductos
            // 
            this.lblagregarproductos.AutoSize = true;
            this.lblagregarproductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblagregarproductos.Location = new System.Drawing.Point(35, 135);
            this.lblagregarproductos.Name = "lblagregarproductos";
            this.lblagregarproductos.Size = new System.Drawing.Size(102, 13);
            this.lblagregarproductos.TabIndex = 2;
            this.lblagregarproductos.Text = "Indique un producto";
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblcantidad.Location = new System.Drawing.Point(37, 212);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(100, 13);
            this.lblcantidad.TabIndex = 3;
            this.lblcantidad.Text = "Indique su cantidad";
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(38, 160);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(121, 21);
            this.cmbProducto.TabIndex = 5;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(37, 237);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 6;
            // 
            // lblTotalTexto
            // 
            this.lblTotalTexto.AutoSize = true;
            this.lblTotalTexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTotalTexto.Location = new System.Drawing.Point(299, 223);
            this.lblTotalTexto.Name = "lblTotalTexto";
            this.lblTotalTexto.Size = new System.Drawing.Size(34, 13);
            this.lblTotalTexto.TabIndex = 7;
            this.lblTotalTexto.Text = "Total:";
            // 
            // lblDescuentosTexto
            // 
            this.lblDescuentosTexto.AutoSize = true;
            this.lblDescuentosTexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblDescuentosTexto.Location = new System.Drawing.Point(299, 252);
            this.lblDescuentosTexto.Name = "lblDescuentosTexto";
            this.lblDescuentosTexto.Size = new System.Drawing.Size(67, 13);
            this.lblDescuentosTexto.TabIndex = 10;
            this.lblDescuentosTexto.Text = "Descuentos:";
            // 
            // lblTotalFinalTexto
            // 
            this.lblTotalFinalTexto.AutoSize = true;
            this.lblTotalFinalTexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTotalFinalTexto.Location = new System.Drawing.Point(299, 305);
            this.lblTotalFinalTexto.Name = "lblTotalFinalTexto";
            this.lblTotalFinalTexto.Size = new System.Drawing.Size(56, 13);
            this.lblTotalFinalTexto.TabIndex = 11;
            this.lblTotalFinalTexto.Text = "Total final:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(384, 223);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 12;
            // 
            // lblDescuentos
            // 
            this.lblDescuentos.AutoSize = true;
            this.lblDescuentos.Location = new System.Drawing.Point(384, 252);
            this.lblDescuentos.Name = "lblDescuentos";
            this.lblDescuentos.Size = new System.Drawing.Size(0, 13);
            this.lblDescuentos.TabIndex = 13;
            // 
            // lblTotalFinal
            // 
            this.lblTotalFinal.AutoSize = true;
            this.lblTotalFinal.Location = new System.Drawing.Point(384, 305);
            this.lblTotalFinal.Name = "lblTotalFinal";
            this.lblTotalFinal.Size = new System.Drawing.Size(0, 13);
            this.lblTotalFinal.TabIndex = 14;
            // 
            // lblErrorProducto
            // 
            this.lblErrorProducto.AutoSize = true;
            this.lblErrorProducto.Location = new System.Drawing.Point(37, 184);
            this.lblErrorProducto.Name = "lblErrorProducto";
            this.lblErrorProducto.Size = new System.Drawing.Size(0, 13);
            this.lblErrorProducto.TabIndex = 15;
            // 
            // lblErrorCantidad
            // 
            this.lblErrorCantidad.AutoSize = true;
            this.lblErrorCantidad.Location = new System.Drawing.Point(37, 261);
            this.lblErrorCantidad.Name = "lblErrorCantidad";
            this.lblErrorCantidad.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCantidad.TabIndex = 16;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitulo.Location = new System.Drawing.Point(189, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(272, 31);
            this.lblTitulo.TabIndex = 35;
            this.lblTitulo.Text = "REGISTRAR VENTA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion2.Properties.Resources.New_Project__4_;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(686, 375);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabelVolver
            // 
            this.linkLabelVolver.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabelVolver.AutoSize = true;
            this.linkLabelVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkLabelVolver.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.linkLabelVolver.ForeColor = System.Drawing.Color.Red;
            this.linkLabelVolver.LinkColor = System.Drawing.Color.Black;
            this.linkLabelVolver.Location = new System.Drawing.Point(12, 9);
            this.linkLabelVolver.Name = "linkLabelVolver";
            this.linkLabelVolver.Size = new System.Drawing.Size(37, 13);
            this.linkLabelVolver.TabIndex = 41;
            this.linkLabelVolver.TabStop = true;
            this.linkLabelVolver.Text = "Volver";
            this.linkLabelVolver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelVolver_LinkClicked);
            // 
            // lblErrorDNI
            // 
            this.lblErrorDNI.AutoSize = true;
            this.lblErrorDNI.Location = new System.Drawing.Point(37, 107);
            this.lblErrorDNI.Name = "lblErrorDNI";
            this.lblErrorDNI.Size = new System.Drawing.Size(0, 13);
            this.lblErrorDNI.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(35, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Ingrese el DNI del cliente";
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(38, 84);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(100, 20);
            this.txtdni.TabIndex = 45;
            // 
            // lblPromociones
            // 
            this.lblPromociones.AutoSize = true;
            this.lblPromociones.Location = new System.Drawing.Point(384, 277);
            this.lblPromociones.Name = "lblPromociones";
            this.lblPromociones.Size = new System.Drawing.Size(0, 13);
            this.lblPromociones.TabIndex = 47;
            // 
            // lblPromocionesTexto
            // 
            this.lblPromocionesTexto.AutoSize = true;
            this.lblPromocionesTexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblPromocionesTexto.Location = new System.Drawing.Point(299, 277);
            this.lblPromocionesTexto.Name = "lblPromocionesTexto";
            this.lblPromocionesTexto.Size = new System.Drawing.Size(71, 13);
            this.lblPromocionesTexto.TabIndex = 46;
            this.lblPromocionesTexto.Text = "Promociones:";
            // 
            // button_WOC1
            // 
            this.button_WOC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_WOC1.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC1.ButtonColor = System.Drawing.Color.Salmon;
            this.button_WOC1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_WOC1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_WOC1.Location = new System.Drawing.Point(503, 223);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Salmon;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.Salmon;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOC1.Size = new System.Drawing.Size(163, 31);
            this.button_WOC1.TabIndex = 34;
            this.button_WOC1.Text = "Finalizar venta";
            this.button_WOC1.TextColor = System.Drawing.Color.White;
            this.button_WOC1.UseVisualStyleBackColor = false;
            this.button_WOC1.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.BorderColor = System.Drawing.Color.Transparent;
            this.button1.ButtonColor = System.Drawing.Color.Salmon;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(28, 286);
            this.button1.Name = "button1";
            this.button1.OnHoverBorderColor = System.Drawing.Color.Salmon;
            this.button1.OnHoverButtonColor = System.Drawing.Color.Salmon;
            this.button1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button1.Size = new System.Drawing.Size(163, 31);
            this.button1.TabIndex = 33;
            this.button1.Text = "Agregar al carrito";
            this.button1.TextColor = System.Drawing.Color.White;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblErrorFinalizar
            // 
            this.lblErrorFinalizar.AutoSize = true;
            this.lblErrorFinalizar.Location = new System.Drawing.Point(513, 276);
            this.lblErrorFinalizar.Name = "lblErrorFinalizar";
            this.lblErrorFinalizar.Size = new System.Drawing.Size(0, 13);
            this.lblErrorFinalizar.TabIndex = 48;
            // 
            // lblErrorCarrito
            // 
            this.lblErrorCarrito.AutoSize = true;
            this.lblErrorCarrito.Location = new System.Drawing.Point(513, 257);
            this.lblErrorCarrito.Name = "lblErrorCarrito";
            this.lblErrorCarrito.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCarrito.TabIndex = 49;
            // 
            // agregarventa_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 350);
            this.Controls.Add(this.lblErrorCarrito);
            this.Controls.Add(this.lblErrorFinalizar);
            this.Controls.Add(this.lblPromociones);
            this.Controls.Add(this.lblPromocionesTexto);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.lblErrorDNI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkLabelVolver);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.button_WOC1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblErrorCantidad);
            this.Controls.Add(this.lblErrorProducto);
            this.Controls.Add(this.lblTotalFinal);
            this.Controls.Add(this.lblDescuentos);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalFinalTexto);
            this.Controls.Add(this.lblDescuentosTexto);
            this.Controls.Add(this.lblTotalTexto);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.lblcantidad);
            this.Controls.Add(this.lblagregarproductos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "agregarventa_form";
            this.Text = "agregarventa_form";
            this.Load += new System.EventHandler(this.agregarventa_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblagregarproductos;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblTotalTexto;
        private System.Windows.Forms.Label lblDescuentosTexto;
        private System.Windows.Forms.Label lblTotalFinalTexto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDescuentos;
        private System.Windows.Forms.Label lblTotalFinal;
        private System.Windows.Forms.Label lblErrorProducto;
        private System.Windows.Forms.Label lblErrorCantidad;
        private ePOSOne.btnProduct.Button_WOC button1;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabelVolver;
        private System.Windows.Forms.Label lblErrorDNI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.Label lblPromociones;
        private System.Windows.Forms.Label lblPromocionesTexto;
        private System.Windows.Forms.Label lblErrorFinalizar;
        private System.Windows.Forms.Label lblErrorCarrito;
    }
}