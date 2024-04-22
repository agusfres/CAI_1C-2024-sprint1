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
            this.btnIngresar = new ePOSOne.btnProduct.Button_WOC();
            this.lblIntentosRestantes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIniciarSesionTitulo
            // 
            this.lblIniciarSesionTitulo.AutoSize = true;
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
            this.txtUsuario.Location = new System.Drawing.Point(152, 153);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(253, 21);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.Gray;
            this.txtContraseña.Location = new System.Drawing.Point(152, 218);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(253, 21);
            this.txtContraseña.TabIndex = 2;
            // 
            // LinklabelOlvidasteContraseña
            // 
            this.LinklabelOlvidasteContraseña.AutoSize = true;
            this.LinklabelOlvidasteContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinklabelOlvidasteContraseña.LinkColor = System.Drawing.Color.Gray;
            this.LinklabelOlvidasteContraseña.Location = new System.Drawing.Point(257, 272);
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
            this.lblUsuarioError.Location = new System.Drawing.Point(149, 177);
            this.lblUsuarioError.Name = "lblUsuarioError";
            this.lblUsuarioError.Size = new System.Drawing.Size(0, 13);
            this.lblUsuarioError.TabIndex = 34;
            // 
            // lblContraseñaError
            // 
            this.lblContraseñaError.AutoSize = true;
            this.lblContraseñaError.Location = new System.Drawing.Point(149, 243);
            this.lblContraseñaError.Name = "lblContraseñaError";
            this.lblContraseñaError.Size = new System.Drawing.Size(0, 13);
            this.lblContraseñaError.TabIndex = 35;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(149, 137);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 36;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(149, 202);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(61, 13);
            this.lblContraseña.TabIndex = 37;
            this.lblContraseña.Text = "Contraseña";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BorderColor = System.Drawing.Color.Transparent;
            this.btnIngresar.ButtonColor = System.Drawing.Color.Salmon;
            this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.Transparent;
            this.btnIngresar.Location = new System.Drawing.Point(158, 312);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.OnHoverBorderColor = System.Drawing.Color.Salmon;
            this.btnIngresar.OnHoverButtonColor = System.Drawing.Color.Salmon;
            this.btnIngresar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnIngresar.Size = new System.Drawing.Size(226, 41);
            this.btnIngresar.TabIndex = 33;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextColor = System.Drawing.Color.White;
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click_1);
            // 
            // lblIntentosRestantes
            // 
            this.lblIntentosRestantes.AutoSize = true;
            this.lblIntentosRestantes.Location = new System.Drawing.Point(260, 360);
            this.lblIntentosRestantes.Name = "lblIntentosRestantes";
            this.lblIntentosRestantes.Size = new System.Drawing.Size(0, 13);
            this.lblIntentosRestantes.TabIndex = 38;
            // 
            // iniciarsesion_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 398);
            this.Controls.Add(this.lblIntentosRestantes);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblContraseñaError);
            this.Controls.Add(this.lblUsuarioError);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.LinklabelOlvidasteContraseña);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblIniciarSesionTitulo);
            this.Name = "iniciarsesion_form";
            this.Text = "Form2";
            this.Activated += new System.EventHandler(this.iniciarsesion_form_Activated);
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
        private System.Windows.Forms.Label lblIntentosRestantes;
    }
}