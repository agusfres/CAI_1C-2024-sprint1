namespace Presentacion2
{
    partial class Form2
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
            this.btnIngresar = new ePOSOne.btnProduct.Button_WOC();
            this.lblUsuarioError = new System.Windows.Forms.Label();
            this.lblContraseñaError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIniciarSesionTitulo
            // 
            this.lblIniciarSesionTitulo.AutoSize = true;
            this.lblIniciarSesionTitulo.Font = new System.Drawing.Font("Inter", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciarSesionTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblIniciarSesionTitulo.Location = new System.Drawing.Point(152, 9);
            this.lblIniciarSesionTitulo.Name = "lblIniciarSesionTitulo";
            this.lblIniciarSesionTitulo.Size = new System.Drawing.Size(217, 33);
            this.lblIniciarSesionTitulo.TabIndex = 0;
            this.lblIniciarSesionTitulo.Text = "INICIAR SESIÓN";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Gray;
            this.txtUsuario.Location = new System.Drawing.Point(152, 172);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(253, 22);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "Usuario";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.Gray;
            this.txtContraseña.Location = new System.Drawing.Point(152, 222);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(253, 21);
            this.txtContraseña.TabIndex = 2;
            this.txtContraseña.Text = "Contraseña";
            // 
            // LinklabelOlvidasteContraseña
            // 
            this.LinklabelOlvidasteContraseña.AutoSize = true;
            this.LinklabelOlvidasteContraseña.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinklabelOlvidasteContraseña.LinkColor = System.Drawing.Color.Gray;
            this.LinklabelOlvidasteContraseña.Location = new System.Drawing.Point(257, 272);
            this.LinklabelOlvidasteContraseña.Name = "LinklabelOlvidasteContraseña";
            this.LinklabelOlvidasteContraseña.Size = new System.Drawing.Size(141, 14);
            this.LinklabelOlvidasteContraseña.TabIndex = 3;
            this.LinklabelOlvidasteContraseña.TabStop = true;
            this.LinklabelOlvidasteContraseña.Text = "¿Olvidaste tu contraseña?";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BorderColor = System.Drawing.Color.Transparent;
            this.btnIngresar.ButtonColor = System.Drawing.Color.Salmon;
            this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // 
            // lblUsuarioError
            // 
            this.lblUsuarioError.AutoSize = true;
            this.lblUsuarioError.Location = new System.Drawing.Point(152, 197);
            this.lblUsuarioError.Name = "lblUsuarioError";
            this.lblUsuarioError.Size = new System.Drawing.Size(0, 13);
            this.lblUsuarioError.TabIndex = 34;
            // 
            // lblContraseñaError
            // 
            this.lblContraseñaError.AutoSize = true;
            this.lblContraseñaError.Location = new System.Drawing.Point(152, 247);
            this.lblContraseñaError.Name = "lblContraseñaError";
            this.lblContraseñaError.Size = new System.Drawing.Size(0, 13);
            this.lblContraseñaError.TabIndex = 35;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 398);
            this.Controls.Add(this.lblContraseñaError);
            this.Controls.Add(this.lblUsuarioError);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.LinklabelOlvidasteContraseña);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblIniciarSesionTitulo);
            this.Name = "Form2";
            this.Text = "Form2";
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
    }
}