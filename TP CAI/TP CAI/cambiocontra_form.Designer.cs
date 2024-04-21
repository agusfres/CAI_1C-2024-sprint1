namespace TP_CAI
{
    partial class cambiocontra_form
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
            lblContraseñaTitulo = new Label();
            txtContraseñaVieja = new TextBox();
            txtContraseñaNueva = new TextBox();
            txtConfirmacionNueva = new TextBox();
            lblErrorVieja = new Label();
            lblErrorNueva = new Label();
            lblErrorConfirmacion = new Label();
            linkLabelVolver = new LinkLabel();
            SuspendLayout();
            // 
            // lblContraseñaTitulo
            // 
            lblContraseñaTitulo.AutoSize = true;
            lblContraseñaTitulo.BackColor = Color.FromArgb(224, 224, 224);
            lblContraseñaTitulo.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblContraseñaTitulo.ForeColor = Color.DimGray;
            lblContraseñaTitulo.Location = new Point(97, 30);
            lblContraseñaTitulo.Name = "lblContraseñaTitulo";
            lblContraseñaTitulo.Size = new Size(359, 31);
            lblContraseñaTitulo.TabIndex = 8;
            lblContraseñaTitulo.Text = "CAMBIA TU CONTRASEÑA";
            // 
            // txtContraseñaVieja
            // 
            txtContraseñaVieja.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseñaVieja.ForeColor = Color.Gray;
            txtContraseñaVieja.Location = new Point(162, 184);
            txtContraseñaVieja.Name = "txtContraseñaVieja";
            txtContraseñaVieja.Size = new Size(235, 21);
            txtContraseñaVieja.TabIndex = 9;
            txtContraseñaVieja.Text = "Ingrese su contraseña";
            // 
            // txtContraseñaNueva
            // 
            txtContraseñaNueva.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseñaNueva.ForeColor = Color.Gray;
            txtContraseñaNueva.Location = new Point(162, 227);
            txtContraseñaNueva.Name = "txtContraseñaNueva";
            txtContraseñaNueva.Size = new Size(235, 21);
            txtContraseñaNueva.TabIndex = 10;
            txtContraseñaNueva.Text = "Ingrese su nueva contraseña";
            // 
            // txtConfirmacionNueva
            // 
            txtConfirmacionNueva.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmacionNueva.ForeColor = Color.Gray;
            txtConfirmacionNueva.Location = new Point(162, 276);
            txtConfirmacionNueva.Name = "txtConfirmacionNueva";
            txtConfirmacionNueva.Size = new Size(235, 21);
            txtConfirmacionNueva.TabIndex = 11;
            txtConfirmacionNueva.Text = "Confirme su nueva contraseña";
            // 
            // lblErrorVieja
            // 
            lblErrorVieja.AutoSize = true;
            lblErrorVieja.Location = new Point(162, 209);
            lblErrorVieja.Name = "lblErrorVieja";
            lblErrorVieja.Size = new Size(0, 15);
            lblErrorVieja.TabIndex = 48;
            // 
            // lblErrorNueva
            // 
            lblErrorNueva.AutoSize = true;
            lblErrorNueva.Location = new Point(162, 252);
            lblErrorNueva.Name = "lblErrorNueva";
            lblErrorNueva.Size = new Size(0, 15);
            lblErrorNueva.TabIndex = 49;
            // 
            // lblErrorConfirmacion
            // 
            lblErrorConfirmacion.AutoSize = true;
            lblErrorConfirmacion.Location = new Point(162, 301);
            lblErrorConfirmacion.Name = "lblErrorConfirmacion";
            lblErrorConfirmacion.Size = new Size(0, 15);
            lblErrorConfirmacion.TabIndex = 50;
            // 
            // linkLabelVolver
            // 
            linkLabelVolver.ActiveLinkColor = Color.Black;
            linkLabelVolver.AutoSize = true;
            linkLabelVolver.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabelVolver.LinkColor = Color.Black;
            linkLabelVolver.Location = new Point(12, 9);
            linkLabelVolver.Name = "linkLabelVolver";
            linkLabelVolver.Size = new Size(40, 15);
            linkLabelVolver.TabIndex = 51;
            linkLabelVolver.TabStop = true;
            linkLabelVolver.Text = "Volver";
            linkLabelVolver.LinkClicked += linkLabelVolver_LinkClicked;
            // 
            // cambiocontra_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 415);
            Controls.Add(linkLabelVolver);
            Controls.Add(lblErrorConfirmacion);
            Controls.Add(lblErrorNueva);
            Controls.Add(lblErrorVieja);
            Controls.Add(txtConfirmacionNueva);
            Controls.Add(txtContraseñaNueva);
            Controls.Add(txtContraseñaVieja);
            Controls.Add(lblContraseñaTitulo);
            Name = "cambiocontra_form";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblContraseñaTitulo;
        private TextBox txtContraseñaVieja;
        private TextBox txtContraseñaNueva;
        private TextBox txtConfirmacionNueva;
        private ePOSOne.btnProduct.Button_WOC btnCambiarContraseña;
        private Label lblErrorVieja;
        private Label lblErrorNueva;
        private Label lblErrorConfirmacion;
        private LinkLabel linkLabelVolver;
    }
}