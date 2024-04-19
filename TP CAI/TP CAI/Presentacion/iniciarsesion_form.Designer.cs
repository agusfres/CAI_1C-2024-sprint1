namespace TP_CAI
{
    partial class iniciarsesion_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(iniciarsesion_form));
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            LinklabelOlvidasteContraseña = new LinkLabel();
            lblUsuarioError = new Label();
            lblContraseñaError = new Label();
            lblIniciarSesionTitulo = new Label();
            btnIngresar = new ePOSOne.btnProduct.Button_WOC();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.ForeColor = Color.Gray;
            txtUsuario.Location = new Point(152, 172);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(253, 21);
            txtUsuario.TabIndex = 1;
            txtUsuario.Text = "Usuario";
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.ForeColor = Color.Gray;
            txtContraseña.Location = new Point(152, 222);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(253, 21);
            txtContraseña.TabIndex = 2;
            txtContraseña.Text = "Contraseña";
            // 
            // LinklabelOlvidasteContraseña
            // 
            LinklabelOlvidasteContraseña.AutoSize = true;
            LinklabelOlvidasteContraseña.BackColor = Color.White;
            LinklabelOlvidasteContraseña.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LinklabelOlvidasteContraseña.LinkColor = Color.Gray;
            LinklabelOlvidasteContraseña.Location = new Point(264, 272);
            LinklabelOlvidasteContraseña.Name = "LinklabelOlvidasteContraseña";
            LinklabelOlvidasteContraseña.Size = new Size(118, 15);
            LinklabelOlvidasteContraseña.TabIndex = 4;
            LinklabelOlvidasteContraseña.TabStop = true;
            LinklabelOlvidasteContraseña.Text = "Cambiar contraseña";
            LinklabelOlvidasteContraseña.LinkClicked += LinklabelOlvidasteContraseña_LinkClicked;
            // 
            // lblUsuarioError
            // 
            lblUsuarioError.AutoSize = true;
            lblUsuarioError.Location = new Point(152, 197);
            lblUsuarioError.Name = "lblUsuarioError";
            lblUsuarioError.Size = new Size(0, 15);
            lblUsuarioError.TabIndex = 5;
            // 
            // lblContraseñaError
            // 
            lblContraseñaError.AutoSize = true;
            lblContraseñaError.Location = new Point(152, 247);
            lblContraseñaError.Name = "lblContraseñaError";
            lblContraseñaError.Size = new Size(0, 15);
            lblContraseñaError.TabIndex = 6;
            // 
            // lblIniciarSesionTitulo
            // 
            lblIniciarSesionTitulo.AutoSize = true;
            lblIniciarSesionTitulo.BackColor = Color.FromArgb(224, 224, 224);
            lblIniciarSesionTitulo.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblIniciarSesionTitulo.ForeColor = Color.DimGray;
            lblIniciarSesionTitulo.Location = new Point(152, 9);
            lblIniciarSesionTitulo.Name = "lblIniciarSesionTitulo";
            lblIniciarSesionTitulo.Size = new Size(226, 31);
            lblIniciarSesionTitulo.TabIndex = 7;
            lblIniciarSesionTitulo.Text = "INICIAR SESIÓN";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.White;
            btnIngresar.BorderColor = Color.Transparent;
            btnIngresar.ButtonColor = Color.Tomato;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.Location = new Point(197, 300);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.OnHoverBorderColor = Color.Transparent;
            btnIngresar.OnHoverButtonColor = Color.FromArgb(255, 192, 192);
            btnIngresar.OnHoverTextColor = Color.Transparent;
            btnIngresar.Size = new Size(158, 38);
            btnIngresar.TabIndex = 46;
            btnIngresar.Text = "Ingresar";
            btnIngresar.TextColor = Color.White;
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-6, -32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(573, 435);
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(556, 398);
            Controls.Add(btnIngresar);
            Controls.Add(lblIniciarSesionTitulo);
            Controls.Add(lblContraseñaError);
            Controls.Add(lblUsuarioError);
            Controls.Add(LinklabelOlvidasteContraseña);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private LinkLabel LinklabelOlvidasteContraseña;
        private Label lblUsuarioError;
        private Label lblContraseñaError;
        private Label lblIniciarSesionTitulo;
        private ePOSOne.btnProduct.Button_WOC btnIngresar;
        private PictureBox pictureBox1;
    }
}