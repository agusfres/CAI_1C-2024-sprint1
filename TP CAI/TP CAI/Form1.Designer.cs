namespace TP_CAI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDNI = new Label();
            lblFecha = new Label();
            lblEmail = new Label();
            lblTelefono = new Label();
            lblDireccion = new Label();
            lblUsuario = new Label();
            lblContraseña = new Label();
            lblTipoUsuario = new Label();
            linkLabelVolver = new LinkLabel();
            lblErrorNombre = new Label();
            lblErrorApellido = new Label();
            lblErrorDNI = new Label();
            lblErrorFecha = new Label();
            lblErrorEmail = new Label();
            lblErrorTelefono = new Label();
            lblErrorDireccion = new Label();
            lblErrorUsuario = new Label();
            lblErrorContraseña = new Label();
            lblErrorTipoUsuario = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDNI = new TextBox();
            txtFechaNac = new TextBox();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            cmbTipoUsuario = new ComboBox();
            btnConfirmar = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, 491);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(633, 69);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Inter Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.DimGray;
            lblTitulo.Location = new Point(78, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(417, 33);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "AGREGAR UN NUEVO USUARIO";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Inter", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.DimGray;
            lblNombre.Location = new Point(46, 70);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(66, 19);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Inter", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.ForeColor = Color.DimGray;
            lblApellido.Location = new Point(325, 70);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(67, 19);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellido";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Inter", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            lblDNI.ForeColor = Color.DimGray;
            lblDNI.Location = new Point(46, 140);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(35, 19);
            lblDNI.TabIndex = 5;
            lblDNI.Text = "DNI";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Inter", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.ForeColor = Color.DimGray;
            lblFecha.Location = new Point(325, 140);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(155, 19);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "Fecha de nacimiento";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Inter", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.DimGray;
            lblEmail.Location = new Point(46, 211);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(47, 19);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Inter", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelefono.ForeColor = Color.DimGray;
            lblTelefono.Location = new Point(325, 211);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(72, 19);
            lblTelefono.TabIndex = 8;
            lblTelefono.Text = "Teléfono";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Inter", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            lblDireccion.ForeColor = Color.DimGray;
            lblDireccion.Location = new Point(44, 280);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(77, 19);
            lblDireccion.TabIndex = 9;
            lblDireccion.Text = "Dirección";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Inter", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.ForeColor = Color.DimGray;
            lblUsuario.Location = new Point(48, 352);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(64, 19);
            lblUsuario.TabIndex = 10;
            lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Inter", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            lblContraseña.ForeColor = Color.DimGray;
            lblContraseña.Location = new Point(325, 352);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(91, 19);
            lblContraseña.TabIndex = 11;
            lblContraseña.Text = "Contraseña";
            // 
            // lblTipoUsuario
            // 
            lblTipoUsuario.AutoSize = true;
            lblTipoUsuario.Font = new Font("Inter", 11.249999F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoUsuario.ForeColor = Color.DimGray;
            lblTipoUsuario.Location = new Point(44, 422);
            lblTipoUsuario.Name = "lblTipoUsuario";
            lblTipoUsuario.Size = new Size(175, 19);
            lblTipoUsuario.TabIndex = 12;
            lblTipoUsuario.Text = "Tipo de usuario/acceso";
            // 
            // linkLabelVolver
            // 
            linkLabelVolver.AutoSize = true;
            linkLabelVolver.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabelVolver.LinkColor = Color.Black;
            linkLabelVolver.Location = new Point(12, 9);
            linkLabelVolver.Name = "linkLabelVolver";
            linkLabelVolver.Size = new Size(42, 15);
            linkLabelVolver.TabIndex = 13;
            linkLabelVolver.TabStop = true;
            linkLabelVolver.Text = "Volver";
            // 
            // lblErrorNombre
            // 
            lblErrorNombre.AutoSize = true;
            lblErrorNombre.Location = new Point(51, 118);
            lblErrorNombre.Name = "lblErrorNombre";
            lblErrorNombre.Size = new Size(0, 15);
            lblErrorNombre.TabIndex = 25;
            // 
            // lblErrorApellido
            // 
            lblErrorApellido.AutoSize = true;
            lblErrorApellido.Location = new Point(331, 118);
            lblErrorApellido.Name = "lblErrorApellido";
            lblErrorApellido.Size = new Size(0, 15);
            lblErrorApellido.TabIndex = 26;
            // 
            // lblErrorDNI
            // 
            lblErrorDNI.AutoSize = true;
            lblErrorDNI.Location = new Point(51, 188);
            lblErrorDNI.Name = "lblErrorDNI";
            lblErrorDNI.Size = new Size(0, 15);
            lblErrorDNI.TabIndex = 27;
            // 
            // lblErrorFecha
            // 
            lblErrorFecha.AutoSize = true;
            lblErrorFecha.Location = new Point(331, 188);
            lblErrorFecha.Name = "lblErrorFecha";
            lblErrorFecha.Size = new Size(0, 15);
            lblErrorFecha.TabIndex = 28;
            // 
            // lblErrorEmail
            // 
            lblErrorEmail.AutoSize = true;
            lblErrorEmail.Location = new Point(51, 259);
            lblErrorEmail.Name = "lblErrorEmail";
            lblErrorEmail.Size = new Size(0, 15);
            lblErrorEmail.TabIndex = 29;
            // 
            // lblErrorTelefono
            // 
            lblErrorTelefono.AutoSize = true;
            lblErrorTelefono.Location = new Point(332, 259);
            lblErrorTelefono.Name = "lblErrorTelefono";
            lblErrorTelefono.Size = new Size(0, 15);
            lblErrorTelefono.TabIndex = 30;
            // 
            // lblErrorDireccion
            // 
            lblErrorDireccion.AutoSize = true;
            lblErrorDireccion.Location = new Point(53, 328);
            lblErrorDireccion.Name = "lblErrorDireccion";
            lblErrorDireccion.Size = new Size(0, 15);
            lblErrorDireccion.TabIndex = 31;
            // 
            // lblErrorUsuario
            // 
            lblErrorUsuario.AutoSize = true;
            lblErrorUsuario.Location = new Point(54, 400);
            lblErrorUsuario.Name = "lblErrorUsuario";
            lblErrorUsuario.Size = new Size(0, 15);
            lblErrorUsuario.TabIndex = 32;
            // 
            // lblErrorContraseña
            // 
            lblErrorContraseña.AutoSize = true;
            lblErrorContraseña.Location = new Point(330, 400);
            lblErrorContraseña.Name = "lblErrorContraseña";
            lblErrorContraseña.Size = new Size(0, 15);
            lblErrorContraseña.TabIndex = 33;
            // 
            // lblErrorTipoUsuario
            // 
            lblErrorTipoUsuario.AutoSize = true;
            lblErrorTipoUsuario.Location = new Point(50, 468);
            lblErrorTipoUsuario.Name = "lblErrorTipoUsuario";
            lblErrorTipoUsuario.Size = new Size(0, 15);
            lblErrorTipoUsuario.TabIndex = 34;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(46, 92);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(253, 23);
            txtNombre.TabIndex = 35;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(325, 92);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(253, 23);
            txtApellido.TabIndex = 36;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(46, 162);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(253, 23);
            txtDNI.TabIndex = 37;
            // 
            // txtFechaNac
            // 
            txtFechaNac.Location = new Point(325, 162);
            txtFechaNac.Name = "txtFechaNac";
            txtFechaNac.Size = new Size(253, 23);
            txtFechaNac.TabIndex = 38;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(46, 233);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(253, 23);
            txtEmail.TabIndex = 39;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(325, 233);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(253, 23);
            txtTelefono.TabIndex = 40;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(46, 302);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(532, 23);
            txtDireccion.TabIndex = 41;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(46, 374);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(253, 23);
            txtUsuario.TabIndex = 42;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(325, 374);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(253, 23);
            txtContraseña.TabIndex = 43;
            // 
            // cmbTipoUsuario
            // 
            cmbTipoUsuario.FormattingEnabled = true;
            cmbTipoUsuario.Location = new Point(46, 444);
            cmbTipoUsuario.Name = "cmbTipoUsuario";
            cmbTipoUsuario.Size = new Size(253, 23);
            cmbTipoUsuario.TabIndex = 44;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BorderColor = Color.Silver;
            btnConfirmar.ButtonColor = Color.Tomato;
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Inter SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmar.Location = new Point(325, 422);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.OnHoverBorderColor = Color.Gray;
            btnConfirmar.OnHoverButtonColor = Color.FromArgb(255, 192, 192);
            btnConfirmar.OnHoverTextColor = Color.Gray;
            btnConfirmar.Size = new Size(120, 54);
            btnConfirmar.TabIndex = 45;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.TextColor = Color.White;
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(631, 557);
            Controls.Add(btnConfirmar);
            Controls.Add(cmbTipoUsuario);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtEmail);
            Controls.Add(txtFechaNac);
            Controls.Add(txtDNI);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblErrorTipoUsuario);
            Controls.Add(lblErrorContraseña);
            Controls.Add(lblErrorUsuario);
            Controls.Add(lblErrorDireccion);
            Controls.Add(lblErrorTelefono);
            Controls.Add(lblErrorEmail);
            Controls.Add(lblErrorFecha);
            Controls.Add(lblErrorDNI);
            Controls.Add(lblErrorApellido);
            Controls.Add(lblErrorNombre);
            Controls.Add(linkLabelVolver);
            Controls.Add(lblTipoUsuario);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(lblDireccion);
            Controls.Add(lblTelefono);
            Controls.Add(lblEmail);
            Controls.Add(lblFecha);
            Controls.Add(lblDNI);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblTitulo;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDNI;
        private Label lblFecha;
        private Label lblEmail;
        private Label lblTelefono;
        private Label lblDireccion;
        private Label lblUsuario;
        private Label lblContraseña;
        private Label lblTipoUsuario;
        private LinkLabel linkLabelVolver;
        private ePOSOne.btnProduct.Button_WOC button_wocConfirmar;
        private Label lblErrorNombre;
        private Label lblErrorApellido;
        private Label lblErrorDNI;
        private Label lblErrorFecha;
        private Label lblErrorEmail;
        private Label lblErrorTelefono;
        private Label lblErrorDireccion;
        private Label lblErrorUsuario;
        private Label lblErrorContraseña;
        private Label lblErrorTipoUsuario;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDNI;
        private TextBox txtFechaNac;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private ComboBox cmbTipoUsuario;
        private ePOSOne.btnProduct.Button_WOC btnConfirmar;
    }
}