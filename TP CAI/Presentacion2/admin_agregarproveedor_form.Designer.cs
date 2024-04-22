namespace Presentacion2
{
    partial class admin_agregarproveedor_form
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
            this.lblconfirma = new System.Windows.Forms.Label();
            this.btnConfirmar = new ePOSOne.btnProduct.Button_WOC();
            this.lblErrorFecha = new System.Windows.Forms.Label();
            this.txtFechaNac = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblErrorDNI = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblErrorApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblErrorNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.linkLabelVolver = new System.Windows.Forms.LinkLabel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblconfirma
            // 
            this.lblconfirma.AutoSize = true;
            this.lblconfirma.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblconfirma.Location = new System.Drawing.Point(276, 305);
            this.lblconfirma.Name = "lblconfirma";
            this.lblconfirma.Size = new System.Drawing.Size(0, 13);
            this.lblconfirma.TabIndex = 67;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BorderColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.ButtonColor = System.Drawing.Color.Salmon;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.Location = new System.Drawing.Point(275, 241);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.OnHoverBorderColor = System.Drawing.Color.Salmon;
            this.btnConfirmar.OnHoverButtonColor = System.Drawing.Color.Salmon;
            this.btnConfirmar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnConfirmar.Size = new System.Drawing.Size(145, 61);
            this.btnConfirmar.TabIndex = 66;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextColor = System.Drawing.Color.White;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // lblErrorFecha
            // 
            this.lblErrorFecha.AutoSize = true;
            this.lblErrorFecha.ForeColor = System.Drawing.Color.Red;
            this.lblErrorFecha.Location = new System.Drawing.Point(423, 198);
            this.lblErrorFecha.Name = "lblErrorFecha";
            this.lblErrorFecha.Size = new System.Drawing.Size(0, 13);
            this.lblErrorFecha.TabIndex = 47;
            // 
            // txtFechaNac
            // 
            this.txtFechaNac.Location = new System.Drawing.Point(424, 172);
            this.txtFechaNac.Name = "txtFechaNac";
            this.txtFechaNac.Size = new System.Drawing.Size(253, 20);
            this.txtFechaNac.TabIndex = 46;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.DimGray;
            this.lblFecha.Location = new System.Drawing.Point(424, 150);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(45, 18);
            this.lblFecha.TabIndex = 45;
            this.lblFecha.Text = "Email";
            this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
            // 
            // lblErrorDNI
            // 
            this.lblErrorDNI.AutoSize = true;
            this.lblErrorDNI.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDNI.Location = new System.Drawing.Point(83, 198);
            this.lblErrorDNI.Name = "lblErrorDNI";
            this.lblErrorDNI.Size = new System.Drawing.Size(0, 13);
            this.lblErrorDNI.TabIndex = 44;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(84, 172);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(253, 20);
            this.txtDNI.TabIndex = 43;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.ForeColor = System.Drawing.Color.DimGray;
            this.lblDNI.Location = new System.Drawing.Point(84, 150);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(42, 18);
            this.lblDNI.TabIndex = 42;
            this.lblDNI.Text = "CUIT";
            // 
            // lblErrorApellido
            // 
            this.lblErrorApellido.AutoSize = true;
            this.lblErrorApellido.ForeColor = System.Drawing.Color.Red;
            this.lblErrorApellido.Location = new System.Drawing.Point(424, 124);
            this.lblErrorApellido.Name = "lblErrorApellido";
            this.lblErrorApellido.Size = new System.Drawing.Size(0, 13);
            this.lblErrorApellido.TabIndex = 41;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(424, 98);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(253, 20);
            this.txtApellido.TabIndex = 40;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.DimGray;
            this.lblApellido.Location = new System.Drawing.Point(424, 76);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(59, 18);
            this.lblApellido.TabIndex = 39;
            this.lblApellido.Text = "Apellido";
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.AutoSize = true;
            this.lblErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNombre.Location = new System.Drawing.Point(84, 124);
            this.lblErrorNombre.Name = "lblErrorNombre";
            this.lblErrorNombre.Size = new System.Drawing.Size(0, 13);
            this.lblErrorNombre.TabIndex = 38;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(84, 98);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(253, 20);
            this.txtNombre.TabIndex = 37;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.DimGray;
            this.lblNombre.Location = new System.Drawing.Point(84, 76);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 18);
            this.lblNombre.TabIndex = 36;
            this.lblNombre.Text = "Nombre";
            // 
            // linkLabelVolver
            // 
            this.linkLabelVolver.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabelVolver.AutoSize = true;
            this.linkLabelVolver.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.linkLabelVolver.ForeColor = System.Drawing.Color.Red;
            this.linkLabelVolver.LinkColor = System.Drawing.Color.Black;
            this.linkLabelVolver.Location = new System.Drawing.Point(46, 24);
            this.linkLabelVolver.Name = "linkLabelVolver";
            this.linkLabelVolver.Size = new System.Drawing.Size(37, 13);
            this.linkLabelVolver.TabIndex = 35;
            this.linkLabelVolver.TabStop = true;
            this.linkLabelVolver.Text = "Volver";
            this.linkLabelVolver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelVolver_LinkClicked);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitulo.Location = new System.Drawing.Point(149, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(482, 31);
            this.lblTitulo.TabIndex = 34;
            this.lblTitulo.Text = "AGREGAR UN NUEVO PROVEEDOR";
            // 
            // admin_agregarproveedor_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 378);
            this.Controls.Add(this.lblconfirma);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblErrorFecha);
            this.Controls.Add(this.txtFechaNac);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblErrorDNI);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblErrorApellido);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblErrorNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.linkLabelVolver);
            this.Controls.Add(this.lblTitulo);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "admin_agregarproveedor_form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblconfirma;
        private ePOSOne.btnProduct.Button_WOC btnConfirmar;
        private System.Windows.Forms.Label lblErrorFecha;
        private System.Windows.Forms.TextBox txtFechaNac;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblErrorDNI;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblErrorApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblErrorNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.LinkLabel linkLabelVolver;
        private System.Windows.Forms.Label lblTitulo;
    }
}