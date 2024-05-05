namespace Presentacion2
{
    partial class altaproducto_form
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
            this.linkLabelVolver = new System.Windows.Forms.LinkLabel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnConfirmar = new ePOSOne.btnProduct.Button_WOC();
            this.lblErrorContraseña = new System.Windows.Forms.Label();
            this.lblErrorprecio = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblErrorCategoria = new System.Windows.Forms.Label();
            this.lblErrorNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.lblErrorStock = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelVolver
            // 
            this.linkLabelVolver.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabelVolver.AutoSize = true;
            this.linkLabelVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkLabelVolver.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.linkLabelVolver.ForeColor = System.Drawing.Color.Red;
            this.linkLabelVolver.LinkColor = System.Drawing.Color.Black;
            this.linkLabelVolver.Location = new System.Drawing.Point(8, 12);
            this.linkLabelVolver.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelVolver.Name = "linkLabelVolver";
            this.linkLabelVolver.Size = new System.Drawing.Size(46, 16);
            this.linkLabelVolver.TabIndex = 34;
            this.linkLabelVolver.TabStop = true;
            this.linkLabelVolver.Text = "Volver";
            this.linkLabelVolver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelVolver_LinkClicked);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitulo.Location = new System.Drawing.Point(175, 11);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(583, 39);
            this.lblTitulo.TabIndex = 33;
            this.lblTitulo.Text = "AGREGAR UN NUEVO PRODUCTO";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConfirmar.BorderColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.ButtonColor = System.Drawing.Color.Salmon;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConfirmar.Location = new System.Drawing.Point(332, 306);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.OnHoverBorderColor = System.Drawing.Color.Salmon;
            this.btnConfirmar.OnHoverButtonColor = System.Drawing.Color.Salmon;
            this.btnConfirmar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnConfirmar.Size = new System.Drawing.Size(193, 75);
            this.btnConfirmar.TabIndex = 86;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextColor = System.Drawing.Color.White;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.altaProducto_btnConfirmar_Click);
            // 
            // lblErrorContraseña
            // 
            this.lblErrorContraseña.AutoSize = true;
            this.lblErrorContraseña.ForeColor = System.Drawing.Color.Red;
            this.lblErrorContraseña.Location = new System.Drawing.Point(328, 287);
            this.lblErrorContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorContraseña.Name = "lblErrorContraseña";
            this.lblErrorContraseña.Size = new System.Drawing.Size(0, 16);
            this.lblErrorContraseña.TabIndex = 83;
            // 
            // lblErrorprecio
            // 
            this.lblErrorprecio.AutoSize = true;
            this.lblErrorprecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblErrorprecio.ForeColor = System.Drawing.Color.Red;
            this.lblErrorprecio.Location = new System.Drawing.Point(49, 222);
            this.lblErrorprecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorprecio.Name = "lblErrorprecio";
            this.lblErrorprecio.Size = new System.Drawing.Size(0, 16);
            this.lblErrorprecio.TabIndex = 65;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(51, 190);
            this.txtprecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(336, 22);
            this.txtprecio.TabIndex = 64;
            // 
            // lblPrecio
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.ForeColor = System.Drawing.Color.DimGray;
            this.lblDNI.Location = new System.Drawing.Point(51, 162);
            this.lblDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNI.Name = "lblPrecio";
            this.lblDNI.Size = new System.Drawing.Size(64, 24);
            this.lblDNI.TabIndex = 63;
            this.lblDNI.Text = "Precio";
            // 
            // lblErrorCategoria
            // 
            this.lblErrorCategoria.AutoSize = true;
            this.lblErrorCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblErrorCategoria.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCategoria.Location = new System.Drawing.Point(504, 130);
            this.lblErrorCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorCategoria.Name = "lblErrorCategoria";
            this.lblErrorCategoria.Size = new System.Drawing.Size(0, 16);
            this.lblErrorCategoria.TabIndex = 62;
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.AutoSize = true;
            this.lblErrorNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNombre.Location = new System.Drawing.Point(51, 130);
            this.lblErrorNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorNombre.Name = "lblErrorNombre";
            this.lblErrorNombre.Size = new System.Drawing.Size(0, 16);
            this.lblErrorNombre.TabIndex = 59;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(51, 98);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(336, 22);
            this.txtNombre.TabIndex = 58;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.DimGray;
            this.lblNombre.Location = new System.Drawing.Point(51, 71);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 24);
            this.lblNombre.TabIndex = 57;
            this.lblNombre.Text = "Nombre";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1. Audio ",
            "2. Celulares ",
            "3. Electro Hogar ",
            "4. Informática ",
            "5. Smart TV "});
            this.comboBox1.Location = new System.Drawing.Point(504, 97);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(336, 24);
            this.comboBox1.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(500, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 87;
            this.label1.Text = "ID Categoría";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.DimGray;
            this.lblStock.Location = new System.Drawing.Point(504, 162);
            this.lblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(148, 24);
            this.lblStock.TabIndex = 66;
            this.lblStock.Text = "Stock disponible";
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(504, 190);
            this.txtstock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(336, 22);
            this.txtstock.TabIndex = 67;
            // 
            // lblErrorStock
            // 
            this.lblErrorStock.AutoSize = true;
            this.lblErrorStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblErrorStock.ForeColor = System.Drawing.Color.Red;
            this.lblErrorStock.Location = new System.Drawing.Point(503, 222);
            this.lblErrorStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorStock.Name = "lblErrorStock";
            this.lblErrorStock.Size = new System.Drawing.Size(0, 16);
            this.lblErrorStock.TabIndex = 68;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion2.Properties.Resources.New_Project__4___1_;
            this.pictureBox1.Location = new System.Drawing.Point(-7, -55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(905, 506);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // altaproducto_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 444);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblErrorContraseña);
            this.Controls.Add(this.lblErrorStock);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblErrorprecio);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblErrorCategoria);
            this.Controls.Add(this.lblErrorNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.linkLabelVolver);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "altaproducto_form";
            this.Text = "altaproducto_form";
            this.Load += new System.EventHandler(this.altaproducto_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabelVolver;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ePOSOne.btnProduct.Button_WOC btnConfirmar;
        private System.Windows.Forms.Label lblErrorContraseña;
        private System.Windows.Forms.Label lblErrorprecio;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblErrorCategoria;
        private System.Windows.Forms.Label lblErrorNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Label lblErrorStock;
    }
}