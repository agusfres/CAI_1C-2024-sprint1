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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cambiocontra_form));
            pictureBox1 = new PictureBox();
            lblContraseñaTitulo = new Label();
            txtContraseñaVieja = new TextBox();
            txtContraseñaNueva = new TextBox();
            txtConfirmacionNueva = new TextBox();
            btnCambiarContraseña = new ePOSOne.btnProduct.Button_WOC();
            lblErrorVieja = new Label();
            lblErrorNueva = new Label();
            lblErrorConfirmacion = new Label();
            linkLabelVolver = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-8, -16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(572, 437);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            // btnCambiarContraseña
            // 
            btnCambiarContraseña.BackColor = Color.White;
            btnCambiarContraseña.BorderColor = Color.Transparent;
            btnCambiarContraseña.ButtonColor = Color.Tomato;
            btnCambiarContraseña.FlatAppearance.BorderSize = 0;
            btnCambiarContraseña.FlatStyle = FlatStyle.Flat;
            btnCambiarContraseña.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCambiarContraseña.Location = new Point(193, 329);
            btnCambiarContraseña.Name = "btnCambiarContraseña";
            btnCambiarContraseña.OnHoverBorderColor = Color.Transparent;
            btnCambiarContraseña.OnHoverButtonColor = Color.FromArgb(255, 192, 192);
            btnCambiarContraseña.OnHoverTextColor = Color.Transparent;
            btnCambiarContraseña.Size = new Size(158, 38);
            btnCambiarContraseña.TabIndex = 47;
            btnCambiarContraseña.Text = "Cambiar contraseña";
            btnCambiarContraseña.TextColor = Color.White;
            btnCambiarContraseña.UseVisualStyleBackColor = false;
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
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 415);
            Controls.Add(linkLabelVolver);
            Controls.Add(lblErrorConfirmacion);
            Controls.Add(lblErrorNueva);
            Controls.Add(lblErrorVieja);
            Controls.Add(btnCambiarContraseña);
            Controls.Add(txtConfirmacionNueva);
            Controls.Add(txtContraseñaNueva);
            Controls.Add(txtContraseñaVieja);
            Controls.Add(lblContraseñaTitulo);
            Controls.Add(pictureBox1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
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