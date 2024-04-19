namespace TP_CAI
{
    partial class admin_baja_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_baja_form));
            lblBajaUsuarioTitulo = new Label();
            linkLabelVolver = new LinkLabel();
            txtDNI = new TextBox();
            lblDNI = new Label();
            listBoxUsuario = new ListBox();
            lblErrorDNI = new Label();
            lblErrorSeleccionUsuario = new Label();
            btnEliminarUsuario = new Button();
            btnBuscarUsuario = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblBajaUsuarioTitulo
            // 
            lblBajaUsuarioTitulo.AutoSize = true;
            lblBajaUsuarioTitulo.BackColor = Color.FromArgb(224, 224, 224);
            lblBajaUsuarioTitulo.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblBajaUsuarioTitulo.ForeColor = Color.DimGray;
            lblBajaUsuarioTitulo.Location = new Point(216, 27);
            lblBajaUsuarioTitulo.Name = "lblBajaUsuarioTitulo";
            lblBajaUsuarioTitulo.Size = new Size(214, 31);
            lblBajaUsuarioTitulo.TabIndex = 54;
            lblBajaUsuarioTitulo.Text = "BAJA USUARIO";
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
            linkLabelVolver.TabIndex = 55;
            linkLabelVolver.TabStop = true;
            linkLabelVolver.Text = "Volver";
            linkLabelVolver.LinkClicked += linkLabelVolver_LinkClicked;
            // 
            // txtDNI
            // 
            txtDNI.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDNI.ForeColor = Color.Black;
            txtDNI.Location = new Point(169, 143);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(302, 21);
            txtDNI.TabIndex = 57;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.BackColor = Color.FromArgb(224, 224, 224);
            lblDNI.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDNI.Location = new Point(170, 115);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(245, 15);
            lblDNI.TabIndex = 58;
            lblDNI.Text = "Ingrese DNI del usuario que desea eliminar";
            // 
            // listBoxUsuario
            // 
            listBoxUsuario.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxUsuario.FormattingEnabled = true;
            listBoxUsuario.ItemHeight = 15;
            listBoxUsuario.Location = new Point(170, 239);
            listBoxUsuario.Name = "listBoxUsuario";
            listBoxUsuario.Size = new Size(302, 94);
            listBoxUsuario.TabIndex = 59;
            // 
            // lblErrorDNI
            // 
            lblErrorDNI.AutoSize = true;
            lblErrorDNI.BackColor = Color.FromArgb(224, 224, 224);
            lblErrorDNI.Location = new Point(169, 168);
            lblErrorDNI.Name = "lblErrorDNI";
            lblErrorDNI.Size = new Size(0, 15);
            lblErrorDNI.TabIndex = 60;
            // 
            // lblErrorSeleccionUsuario
            // 
            lblErrorSeleccionUsuario.AutoSize = true;
            lblErrorSeleccionUsuario.BackColor = Color.FromArgb(224, 224, 224);
            lblErrorSeleccionUsuario.Location = new Point(170, 336);
            lblErrorSeleccionUsuario.Name = "lblErrorSeleccionUsuario";
            lblErrorSeleccionUsuario.Size = new Size(0, 15);
            lblErrorSeleccionUsuario.TabIndex = 61;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.Location = new Point(169, 373);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(302, 23);
            btnEliminarUsuario.TabIndex = 62;
            btnEliminarUsuario.Text = "Eliminar Usuario";
            btnEliminarUsuario.UseVisualStyleBackColor = true;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
            // 
            // btnBuscarUsuario
            // 
            btnBuscarUsuario.Location = new Point(169, 198);
            btnBuscarUsuario.Name = "btnBuscarUsuario";
            btnBuscarUsuario.Size = new Size(302, 23);
            btnBuscarUsuario.TabIndex = 63;
            btnBuscarUsuario.Text = "Buscar Usuario";
            btnBuscarUsuario.UseVisualStyleBackColor = true;
            btnBuscarUsuario.Click += btnBuscarUsuario_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-1, -5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(652, 452);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 64;
            pictureBox2.TabStop = false;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 450);
            Controls.Add(btnBuscarUsuario);
            Controls.Add(btnEliminarUsuario);
            Controls.Add(lblErrorSeleccionUsuario);
            Controls.Add(lblErrorDNI);
            Controls.Add(listBoxUsuario);
            Controls.Add(lblDNI);
            Controls.Add(txtDNI);
            Controls.Add(linkLabelVolver);
            Controls.Add(lblBajaUsuarioTitulo);
            Controls.Add(pictureBox2);
            Name = "Form6";
            Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblBajaUsuarioTitulo;
        private LinkLabel linkLabelVolver;
        private TextBox txtDNI;
        private Label lblDNI;
        private ListBox listBoxUsuario;
        private Label lblErrorDNI;
        private Label lblErrorSeleccionUsuario;
        private Button btnEliminarUsuario;
        private Button btnBuscarUsuario;
        private PictureBox pictureBox2;
    }
}