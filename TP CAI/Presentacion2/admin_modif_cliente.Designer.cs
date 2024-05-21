namespace Presentacion2
{
    partial class admin_modif_cliente
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
            this.lblErrorEmail = new System.Windows.Forms.Label();
            this.lblErrorDNI = new System.Windows.Forms.Label();
            this.lblErrorNombre = new System.Windows.Forms.Label();
            this.btnConfirmar = new ePOSOne.btnProduct.Button_WOC();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblErrorApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new ePOSOne.btnProduct.Button_WOC();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIngresoCliente = new System.Windows.Forms.TextBox();
            this.lblIngresaCliente = new System.Windows.Forms.Label();
            this.lblGestionClienteTitulo = new System.Windows.Forms.Label();
            this.linkLabelVolver = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblErrorEmail
            // 
            this.lblErrorEmail.AutoSize = true;
            this.lblErrorEmail.Location = new System.Drawing.Point(431, 265);
            this.lblErrorEmail.Name = "lblErrorEmail";
            this.lblErrorEmail.Size = new System.Drawing.Size(0, 13);
            this.lblErrorEmail.TabIndex = 100;
            // 
            // lblErrorDNI
            // 
            this.lblErrorDNI.AutoSize = true;
            this.lblErrorDNI.Location = new System.Drawing.Point(92, 265);
            this.lblErrorDNI.Name = "lblErrorDNI";
            this.lblErrorDNI.Size = new System.Drawing.Size(0, 13);
            this.lblErrorDNI.TabIndex = 99;
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.AutoSize = true;
            this.lblErrorNombre.Location = new System.Drawing.Point(92, 191);
            this.lblErrorNombre.Name = "lblErrorNombre";
            this.lblErrorNombre.Size = new System.Drawing.Size(0, 13);
            this.lblErrorNombre.TabIndex = 98;
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
            this.btnConfirmar.Location = new System.Drawing.Point(322, 338);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.OnHoverBorderColor = System.Drawing.Color.Salmon;
            this.btnConfirmar.OnHoverButtonColor = System.Drawing.Color.Salmon;
            this.btnConfirmar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnConfirmar.Size = new System.Drawing.Size(145, 61);
            this.btnConfirmar.TabIndex = 96;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextColor = System.Drawing.Color.White;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(431, 242);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(253, 20);
            this.txtEmail.TabIndex = 83;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.DimGray;
            this.lblEmail.Location = new System.Drawing.Point(431, 220);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 18);
            this.lblEmail.TabIndex = 82;
            this.lblEmail.Text = "Email";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(92, 242);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(253, 20);
            this.txtDNI.TabIndex = 78;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.ForeColor = System.Drawing.Color.DimGray;
            this.lblDNI.Location = new System.Drawing.Point(92, 220);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDNI.Size = new System.Drawing.Size(33, 18);
            this.lblDNI.TabIndex = 77;
            this.lblDNI.Text = "DNI";
            // 
            // lblErrorApellido
            // 
            this.lblErrorApellido.AutoSize = true;
            this.lblErrorApellido.Location = new System.Drawing.Point(431, 194);
            this.lblErrorApellido.Name = "lblErrorApellido";
            this.lblErrorApellido.Size = new System.Drawing.Size(0, 13);
            this.lblErrorApellido.TabIndex = 76;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(431, 168);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(253, 20);
            this.txtApellido.TabIndex = 75;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.DimGray;
            this.lblApellido.Location = new System.Drawing.Point(431, 146);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(59, 18);
            this.lblApellido.TabIndex = 74;
            this.lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(92, 168);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(253, 20);
            this.txtNombre.TabIndex = 73;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.DimGray;
            this.lblNombre.Location = new System.Drawing.Point(92, 146);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 18);
            this.lblNombre.TabIndex = 72;
            this.lblNombre.Text = "Nombre";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BorderColor = System.Drawing.Color.Transparent;
            this.btnBuscarCliente.ButtonColor = System.Drawing.Color.Salmon;
            this.btnBuscarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBuscarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.Transparent;
            this.btnBuscarCliente.Location = new System.Drawing.Point(560, 84);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.OnHoverBorderColor = System.Drawing.Color.Salmon;
            this.btnBuscarCliente.OnHoverButtonColor = System.Drawing.Color.Salmon;
            this.btnBuscarCliente.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnBuscarCliente.Size = new System.Drawing.Size(138, 38);
            this.btnBuscarCliente.TabIndex = 71;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.TextColor = System.Drawing.Color.White;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 70;
            // 
            // txtIngresoCliente
            // 
            this.txtIngresoCliente.Location = new System.Drawing.Point(92, 106);
            this.txtIngresoCliente.Name = "txtIngresoCliente";
            this.txtIngresoCliente.Size = new System.Drawing.Size(377, 20);
            this.txtIngresoCliente.TabIndex = 69;
            // 
            // lblIngresaCliente
            // 
            this.lblIngresaCliente.AutoSize = true;
            this.lblIngresaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresaCliente.ForeColor = System.Drawing.Color.DimGray;
            this.lblIngresaCliente.Location = new System.Drawing.Point(92, 84);
            this.lblIngresaCliente.Name = "lblIngresaCliente";
            this.lblIngresaCliente.Size = new System.Drawing.Size(340, 18);
            this.lblIngresaCliente.TabIndex = 68;
            this.lblIngresaCliente.Text = "Ingrese el nombre de Cliente que debería modificar";
            // 
            // lblGestionClienteTitulo
            // 
            this.lblGestionClienteTitulo.AutoSize = true;
            this.lblGestionClienteTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionClienteTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblGestionClienteTitulo.Location = new System.Drawing.Point(255, 27);
            this.lblGestionClienteTitulo.Name = "lblGestionClienteTitulo";
            this.lblGestionClienteTitulo.Size = new System.Drawing.Size(238, 31);
            this.lblGestionClienteTitulo.TabIndex = 67;
            this.lblGestionClienteTitulo.Text = "EDITAR CLIENTE";
            // 
            // linkLabelVolver
            // 
            this.linkLabelVolver.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabelVolver.AutoSize = true;
            this.linkLabelVolver.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.linkLabelVolver.ForeColor = System.Drawing.Color.Red;
            this.linkLabelVolver.LinkColor = System.Drawing.Color.Black;
            this.linkLabelVolver.Location = new System.Drawing.Point(58, 16);
            this.linkLabelVolver.Name = "linkLabelVolver";
            this.linkLabelVolver.Size = new System.Drawing.Size(37, 13);
            this.linkLabelVolver.TabIndex = 66;
            this.linkLabelVolver.TabStop = true;
            this.linkLabelVolver.Text = "Volver";
            this.linkLabelVolver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelVolver_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(473, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 101;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(222, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(355, 18);
            this.label3.TabIndex = 102;
            this.label3.Text = "Modifique los campos que quiera y toque \"confirmar\"";
            // 
            // admin_modif_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblErrorEmail);
            this.Controls.Add(this.lblErrorDNI);
            this.Controls.Add(this.lblErrorNombre);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblErrorApellido);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIngresoCliente);
            this.Controls.Add(this.lblIngresaCliente);
            this.Controls.Add(this.lblGestionClienteTitulo);
            this.Controls.Add(this.linkLabelVolver);
            this.Name = "admin_modif_cliente";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblErrorEmail;
        private System.Windows.Forms.Label lblErrorDNI;
        private System.Windows.Forms.Label lblErrorNombre;
        private ePOSOne.btnProduct.Button_WOC btnConfirmar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblErrorApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private ePOSOne.btnProduct.Button_WOC btnBuscarCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIngresoCliente;
        private System.Windows.Forms.Label lblIngresaCliente;
        private System.Windows.Forms.Label lblGestionClienteTitulo;
        private System.Windows.Forms.LinkLabel linkLabelVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}