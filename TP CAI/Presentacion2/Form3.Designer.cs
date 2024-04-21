namespace Presentacion2
{
    partial class Form3
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
            this.lblCambiaTuContraseñaTitulo = new System.Windows.Forms.Label();
            this.linkLabelVolver = new System.Windows.Forms.LinkLabel();
            this.txtContraseñaVieja = new System.Windows.Forms.TextBox();
            this.txtContraseñaNueva = new System.Windows.Forms.TextBox();
            this.txtConfirmacionNueva = new System.Windows.Forms.TextBox();
            this.btnCambiar = new ePOSOne.btnProduct.Button_WOC();
            this.lblErrorVieja = new System.Windows.Forms.Label();
            this.lblErrorNueva = new System.Windows.Forms.Label();
            this.lblErrorConfirmacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCambiaTuContraseñaTitulo
            // 
            this.lblCambiaTuContraseñaTitulo.AutoSize = true;
            this.lblCambiaTuContraseñaTitulo.Font = new System.Drawing.Font("Inter", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambiaTuContraseñaTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblCambiaTuContraseñaTitulo.Location = new System.Drawing.Point(97, 30);
            this.lblCambiaTuContraseñaTitulo.Name = "lblCambiaTuContraseñaTitulo";
            this.lblCambiaTuContraseñaTitulo.Size = new System.Drawing.Size(357, 33);
            this.lblCambiaTuContraseñaTitulo.TabIndex = 1;
            this.lblCambiaTuContraseñaTitulo.Text = "CAMBIA TU CONTRASEÑA";
            // 
            // linkLabelVolver
            // 
            this.linkLabelVolver.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabelVolver.AutoSize = true;
            this.linkLabelVolver.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.linkLabelVolver.ForeColor = System.Drawing.Color.Red;
            this.linkLabelVolver.LinkColor = System.Drawing.Color.Black;
            this.linkLabelVolver.Location = new System.Drawing.Point(12, 9);
            this.linkLabelVolver.Name = "linkLabelVolver";
            this.linkLabelVolver.Size = new System.Drawing.Size(37, 13);
            this.linkLabelVolver.TabIndex = 2;
            this.linkLabelVolver.TabStop = true;
            this.linkLabelVolver.Text = "Volver";
            // 
            // txtContraseñaVieja
            // 
            this.txtContraseñaVieja.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaVieja.ForeColor = System.Drawing.Color.Gray;
            this.txtContraseñaVieja.Location = new System.Drawing.Point(162, 184);
            this.txtContraseñaVieja.Name = "txtContraseñaVieja";
            this.txtContraseñaVieja.Size = new System.Drawing.Size(253, 22);
            this.txtContraseñaVieja.TabIndex = 3;
            this.txtContraseñaVieja.Text = "Ingrese su contraseña";
            // 
            // txtContraseñaNueva
            // 
            this.txtContraseñaNueva.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaNueva.ForeColor = System.Drawing.Color.Gray;
            this.txtContraseñaNueva.Location = new System.Drawing.Point(162, 227);
            this.txtContraseñaNueva.Name = "txtContraseñaNueva";
            this.txtContraseñaNueva.Size = new System.Drawing.Size(253, 22);
            this.txtContraseñaNueva.TabIndex = 4;
            this.txtContraseñaNueva.Text = "Ingrese su nueva contraseña";
            // 
            // txtConfirmacionNueva
            // 
            this.txtConfirmacionNueva.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmacionNueva.ForeColor = System.Drawing.Color.Gray;
            this.txtConfirmacionNueva.Location = new System.Drawing.Point(162, 272);
            this.txtConfirmacionNueva.Name = "txtConfirmacionNueva";
            this.txtConfirmacionNueva.Size = new System.Drawing.Size(253, 22);
            this.txtConfirmacionNueva.TabIndex = 5;
            this.txtConfirmacionNueva.Text = "Confirme su nueva contraseña";
            // 
            // btnCambiar
            // 
            this.btnCambiar.BorderColor = System.Drawing.Color.Transparent;
            this.btnCambiar.ButtonColor = System.Drawing.Color.Salmon;
            this.btnCambiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCambiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiar.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiar.ForeColor = System.Drawing.Color.Transparent;
            this.btnCambiar.Location = new System.Drawing.Point(162, 330);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.OnHoverBorderColor = System.Drawing.Color.Salmon;
            this.btnCambiar.OnHoverButtonColor = System.Drawing.Color.Salmon;
            this.btnCambiar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnCambiar.Size = new System.Drawing.Size(226, 41);
            this.btnCambiar.TabIndex = 34;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.TextColor = System.Drawing.Color.White;
            this.btnCambiar.UseVisualStyleBackColor = true;
            // 
            // lblErrorVieja
            // 
            this.lblErrorVieja.AutoSize = true;
            this.lblErrorVieja.Location = new System.Drawing.Point(162, 209);
            this.lblErrorVieja.Name = "lblErrorVieja";
            this.lblErrorVieja.Size = new System.Drawing.Size(0, 13);
            this.lblErrorVieja.TabIndex = 35;
            // 
            // lblErrorNueva
            // 
            this.lblErrorNueva.AutoSize = true;
            this.lblErrorNueva.Location = new System.Drawing.Point(162, 252);
            this.lblErrorNueva.Name = "lblErrorNueva";
            this.lblErrorNueva.Size = new System.Drawing.Size(0, 13);
            this.lblErrorNueva.TabIndex = 36;
            // 
            // lblErrorConfirmacion
            // 
            this.lblErrorConfirmacion.AutoSize = true;
            this.lblErrorConfirmacion.Location = new System.Drawing.Point(162, 297);
            this.lblErrorConfirmacion.Name = "lblErrorConfirmacion";
            this.lblErrorConfirmacion.Size = new System.Drawing.Size(0, 13);
            this.lblErrorConfirmacion.TabIndex = 37;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 415);
            this.Controls.Add(this.lblErrorConfirmacion);
            this.Controls.Add(this.lblErrorNueva);
            this.Controls.Add(this.lblErrorVieja);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.txtConfirmacionNueva);
            this.Controls.Add(this.txtContraseñaNueva);
            this.Controls.Add(this.txtContraseñaVieja);
            this.Controls.Add(this.linkLabelVolver);
            this.Controls.Add(this.lblCambiaTuContraseñaTitulo);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCambiaTuContraseñaTitulo;
        private System.Windows.Forms.LinkLabel linkLabelVolver;
        private System.Windows.Forms.TextBox txtContraseñaVieja;
        private System.Windows.Forms.TextBox txtContraseñaNueva;
        private System.Windows.Forms.TextBox txtConfirmacionNueva;
        private ePOSOne.btnProduct.Button_WOC btnCambiar;
        private System.Windows.Forms.Label lblErrorVieja;
        private System.Windows.Forms.Label lblErrorNueva;
        private System.Windows.Forms.Label lblErrorConfirmacion;
    }
}