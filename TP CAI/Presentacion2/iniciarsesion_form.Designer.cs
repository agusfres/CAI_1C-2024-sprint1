namespace Presentacion2
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
            this.lblIniciarSesionTitulo = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.LinklabelOlvidasteContraseña = new System.Windows.Forms.LinkLabel();
            this.lblUsuarioError = new System.Windows.Forms.Label();
            this.lblContraseñaError = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblMensajeInicioSesion = new System.Windows.Forms.Label();
            this.lblErroresRestantes = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIngresar = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIniciarSesionTitulo
            // 
            this.lblIniciarSesionTitulo.AutoSize = true;
            this.lblIniciarSesionTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblIniciarSesionTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciarSesionTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblIniciarSesionTitulo.Location = new System.Drawing.Point(152, 9);
            this.lblIniciarSesionTitulo.Name = "lblIniciarSesionTitulo";
            this.lblIniciarSesionTitulo.Size = new System.Drawing.Size(226, 31);
            this.lblIniciarSesionTitulo.TabIndex = 0;
            this.lblIniciarSesionTitulo.Text = "INICIAR SESIÓN";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Gray;
            this.txtUsuario.Location = new System.Drawing.Point(152, 149);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(253, 21);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.Gray;
            this.txtContraseña.Location = new System.Drawing.Point(152, 229);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(253, 21);
            this.txtContraseña.TabIndex = 2;
            // 
            // LinklabelOlvidasteContraseña
            // 
            this.LinklabelOlvidasteContraseña.AutoSize = true;
            this.LinklabelOlvidasteContraseña.BackColor = System.Drawing.Color.White;
            this.LinklabelOlvidasteContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinklabelOlvidasteContraseña.LinkColor = System.Drawing.Color.Gray;
            this.LinklabelOlvidasteContraseña.Location = new System.Drawing.Point(360, 296);
            this.LinklabelOlvidasteContraseña.Name = "LinklabelOlvidasteContraseña";
            this.LinklabelOlvidasteContraseña.Size = new System.Drawing.Size(110, 13);
            this.LinklabelOlvidasteContraseña.TabIndex = 3;
            this.LinklabelOlvidasteContraseña.TabStop = true;
            this.LinklabelOlvidasteContraseña.Text = "Cambia tu contraseña";
            this.LinklabelOlvidasteContraseña.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinklabelOlvidasteContraseña_LinkClicked_1);
            // 
            // lblUsuarioError
            // 
            this.lblUsuarioError.AutoSize = true;
            this.lblUsuarioError.BackColor = System.Drawing.Color.White;
            this.lblUsuarioError.ForeColor = System.Drawing.Color.Red;
            this.lblUsuarioError.Location = new System.Drawing.Point(152, 177);
            this.lblUsuarioError.Name = "lblUsuarioError";
            this.lblUsuarioError.Size = new System.Drawing.Size(0, 13);
            this.lblUsuarioError.TabIndex = 34;
            // 
            // lblContraseñaError
            // 
            this.lblContraseñaError.AutoSize = true;
            this.lblContraseñaError.BackColor = System.Drawing.Color.White;
            this.lblContraseñaError.ForeColor = System.Drawing.Color.Red;
            this.lblContraseñaError.Location = new System.Drawing.Point(152, 256);
            this.lblContraseñaError.Name = "lblContraseñaError";
            this.lblContraseñaError.Size = new System.Drawing.Size(0, 13);
            this.lblContraseñaError.TabIndex = 35;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.White;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(152, 133);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 36;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.White;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(152, 212);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(61, 13);
            this.lblContraseña.TabIndex = 37;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblMensajeInicioSesion
            // 
            this.lblMensajeInicioSesion.AutoSize = true;
            this.lblMensajeInicioSesion.BackColor = System.Drawing.Color.White;
            this.lblMensajeInicioSesion.ForeColor = System.Drawing.Color.Red;
            this.lblMensajeInicioSesion.Location = new System.Drawing.Point(173, 280);
            this.lblMensajeInicioSesion.Name = "lblMensajeInicioSesion";
            this.lblMensajeInicioSesion.Size = new System.Drawing.Size(0, 13);
            this.lblMensajeInicioSesion.TabIndex = 38;
            // 
            // lblErroresRestantes
            // 
            this.lblErroresRestantes.AutoSize = true;
            this.lblErroresRestantes.BackColor = System.Drawing.Color.White;
            this.lblErroresRestantes.ForeColor = System.Drawing.Color.Red;
            this.lblErroresRestantes.Location = new System.Drawing.Point(173, 296);
            this.lblErroresRestantes.Name = "lblErroresRestantes";
            this.lblErroresRestantes.Size = new System.Drawing.Size(0, 13);
            this.lblErroresRestantes.TabIndex = 39;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion2.Properties.Resources.New_Project__2___1_;
            this.pictureBox1.Location = new System.Drawing.Point(3, -75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(555, 487);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.White;
            this.btnIngresar.BorderColor = System.Drawing.Color.Transparent;
            this.btnIngresar.ButtonColor = System.Drawing.Color.Salmon;
            this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.Transparent;
            this.btnIngresar.Location = new System.Drawing.Point(158, 318);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.OnHoverBorderColor = System.Drawing.Color.Salmon;
            this.btnIngresar.OnHoverButtonColor = System.Drawing.Color.Salmon;
            this.btnIngresar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnIngresar.Size = new System.Drawing.Size(226, 41);
            this.btnIngresar.TabIndex = 33;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextColor = System.Drawing.Color.White;
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // iniciarsesion_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 398);
            this.Controls.Add(this.lblErroresRestantes);
            this.Controls.Add(this.lblMensajeInicioSesion);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblContraseñaError);
            this.Controls.Add(this.lblUsuarioError);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.LinklabelOlvidasteContraseña);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblIniciarSesionTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "iniciarsesion_form";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIniciarSesionTitulo;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.LinkLabel LinklabelOlvidasteContraseña;
        private ePOSOne.btnProduct.Button_WOC btnIngresar;
        private System.Windows.Forms.Label lblUsuarioError;
        private System.Windows.Forms.Label lblContraseñaError;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblMensajeInicioSesion;
        private System.Windows.Forms.Label lblErroresRestantes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}