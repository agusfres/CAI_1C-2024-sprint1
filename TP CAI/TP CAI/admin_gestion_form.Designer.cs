namespace TP_CAI
{
    partial class admin_gestion_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_gestion_form));
            pictureBox2 = new PictureBox();
            linkLabelVolver = new LinkLabel();
            lblGestionUsuariosTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-7, -22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(572, 437);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 49;
            pictureBox2.TabStop = false;
            // 
            // linkLabelVolver
            // 
            linkLabelVolver.ActiveLinkColor = Color.Black;
            linkLabelVolver.AutoSize = true;
            linkLabelVolver.BackColor = Color.FromArgb(224, 224, 224);
            linkLabelVolver.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabelVolver.LinkColor = Color.Black;
            linkLabelVolver.Location = new Point(12, 9);
            linkLabelVolver.Name = "linkLabelVolver";
            linkLabelVolver.Size = new Size(40, 15);
            linkLabelVolver.TabIndex = 52;
            linkLabelVolver.TabStop = true;
            linkLabelVolver.Text = "Volver";
            linkLabelVolver.LinkClicked += linkLabelVolver_LinkClicked;
            // 
            // lblGestionUsuariosTitulo
            // 
            lblGestionUsuariosTitulo.AutoSize = true;
            lblGestionUsuariosTitulo.BackColor = Color.FromArgb(224, 224, 224);
            lblGestionUsuariosTitulo.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblGestionUsuariosTitulo.ForeColor = Color.DimGray;
            lblGestionUsuariosTitulo.Location = new Point(12, 9);
            lblGestionUsuariosTitulo.Name = "lblGestionUsuariosTitulo";
            lblGestionUsuariosTitulo.Size = new Size(332, 31);
            lblGestionUsuariosTitulo.TabIndex = 53;
            lblGestionUsuariosTitulo.Text = "GESTIÓN DE USUARIOS";
            // 
            // admin_gestion_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 415);
            Controls.Add(lblGestionUsuariosTitulo);
            Controls.Add(linkLabelVolver);
            Controls.Add(pictureBox2);
            Name = "admin_gestion_form";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private LinkLabel linkLabelVolver;
        private Label lblGestionUsuariosTitulo;
        private ePOSOne.btnProduct.Button_WOC btnAgregarCrearUsuario;
        private ePOSOne.btnProduct.Button_WOC btnModificarUsuario;
        private ePOSOne.btnProduct.Button_WOC btnBajaUsuario;
    }
}