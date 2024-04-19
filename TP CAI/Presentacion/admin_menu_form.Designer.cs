namespace TP_CAI
{
    partial class admin_menu_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_menu_form));
            pictureBox2 = new PictureBox();
            LinkLabelCerrarSesion = new LinkLabel();
            btnGestionarUsuarios = new ePOSOne.btnProduct.Button_WOC();
            btnGestionarProveedores = new ePOSOne.btnProduct.Button_WOC();
            BtnGestionarClientes = new ePOSOne.btnProduct.Button_WOC();
            btnGestionarProductos = new ePOSOne.btnProduct.Button_WOC();
            btnReportes = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-4, -20);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(572, 437);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 48;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // LinkLabelCerrarSesion
            // 
            LinkLabelCerrarSesion.ActiveLinkColor = Color.Black;
            LinkLabelCerrarSesion.AutoSize = true;
            LinkLabelCerrarSesion.BackColor = Color.FromArgb(224, 224, 224);
            LinkLabelCerrarSesion.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LinkLabelCerrarSesion.LinkColor = Color.Black;
            LinkLabelCerrarSesion.Location = new Point(12, 9);
            LinkLabelCerrarSesion.Name = "LinkLabelCerrarSesion";
            LinkLabelCerrarSesion.Size = new Size(80, 15);
            LinkLabelCerrarSesion.TabIndex = 49;
            LinkLabelCerrarSesion.TabStop = true;
            LinkLabelCerrarSesion.Text = "Cerrar sesión";
            LinkLabelCerrarSesion.LinkClicked += lblCerrarSesion_LinkClicked;
            // 
            // btnGestionarUsuarios
            // 
            btnGestionarUsuarios.BackColor = Color.FromArgb(224, 224, 224);
            btnGestionarUsuarios.BorderColor = Color.Transparent;
            btnGestionarUsuarios.ButtonColor = Color.White;
            btnGestionarUsuarios.FlatAppearance.BorderSize = 0;
            btnGestionarUsuarios.FlatStyle = FlatStyle.Flat;
            btnGestionarUsuarios.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGestionarUsuarios.Location = new Point(103, 42);
            btnGestionarUsuarios.Name = "btnGestionarUsuarios";
            btnGestionarUsuarios.OnHoverBorderColor = Color.Transparent;
            btnGestionarUsuarios.OnHoverButtonColor = Color.FromArgb(255, 192, 192);
            btnGestionarUsuarios.OnHoverTextColor = Color.Transparent;
            btnGestionarUsuarios.Size = new Size(355, 53);
            btnGestionarUsuarios.TabIndex = 50;
            btnGestionarUsuarios.Text = "GESTIONAR USUARIOS";
            btnGestionarUsuarios.TextColor = Color.Gray;
            btnGestionarUsuarios.UseVisualStyleBackColor = false;
            btnGestionarUsuarios.Click += btnGestionarUsuarios_Click;
            // 
            // btnGestionarProveedores
            // 
            btnGestionarProveedores.BackColor = Color.FromArgb(224, 224, 224);
            btnGestionarProveedores.BorderColor = Color.Transparent;
            btnGestionarProveedores.ButtonColor = Color.White;
            btnGestionarProveedores.FlatAppearance.BorderSize = 0;
            btnGestionarProveedores.FlatStyle = FlatStyle.Flat;
            btnGestionarProveedores.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGestionarProveedores.Location = new Point(103, 101);
            btnGestionarProveedores.Name = "btnGestionarProveedores";
            btnGestionarProveedores.OnHoverBorderColor = Color.Transparent;
            btnGestionarProveedores.OnHoverButtonColor = Color.FromArgb(255, 192, 192);
            btnGestionarProveedores.OnHoverTextColor = Color.Transparent;
            btnGestionarProveedores.Size = new Size(355, 53);
            btnGestionarProveedores.TabIndex = 51;
            btnGestionarProveedores.Text = "GESTIONAR PROVEEDORES";
            btnGestionarProveedores.TextColor = Color.Gray;
            btnGestionarProveedores.UseVisualStyleBackColor = false;
            // 
            // BtnGestionarClientes
            // 
            BtnGestionarClientes.BackColor = Color.FromArgb(224, 224, 224);
            BtnGestionarClientes.BorderColor = Color.Transparent;
            BtnGestionarClientes.ButtonColor = Color.White;
            BtnGestionarClientes.FlatAppearance.BorderSize = 0;
            BtnGestionarClientes.FlatStyle = FlatStyle.Flat;
            BtnGestionarClientes.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnGestionarClientes.Location = new Point(103, 160);
            BtnGestionarClientes.Name = "BtnGestionarClientes";
            BtnGestionarClientes.OnHoverBorderColor = Color.Transparent;
            BtnGestionarClientes.OnHoverButtonColor = Color.FromArgb(255, 192, 192);
            BtnGestionarClientes.OnHoverTextColor = Color.Transparent;
            BtnGestionarClientes.Size = new Size(355, 53);
            BtnGestionarClientes.TabIndex = 52;
            BtnGestionarClientes.Text = "GESTIONAR CLIENTES";
            BtnGestionarClientes.TextColor = Color.Gray;
            BtnGestionarClientes.UseVisualStyleBackColor = false;
            // 
            // btnGestionarProductos
            // 
            btnGestionarProductos.BackColor = Color.FromArgb(224, 224, 224);
            btnGestionarProductos.BorderColor = Color.Transparent;
            btnGestionarProductos.ButtonColor = Color.White;
            btnGestionarProductos.FlatAppearance.BorderSize = 0;
            btnGestionarProductos.FlatStyle = FlatStyle.Flat;
            btnGestionarProductos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGestionarProductos.Location = new Point(103, 219);
            btnGestionarProductos.Name = "btnGestionarProductos";
            btnGestionarProductos.OnHoverBorderColor = Color.Transparent;
            btnGestionarProductos.OnHoverButtonColor = Color.FromArgb(255, 192, 192);
            btnGestionarProductos.OnHoverTextColor = Color.Transparent;
            btnGestionarProductos.Size = new Size(355, 53);
            btnGestionarProductos.TabIndex = 53;
            btnGestionarProductos.Text = "GESTIONAR PRODUCTOS";
            btnGestionarProductos.TextColor = Color.Gray;
            btnGestionarProductos.UseVisualStyleBackColor = false;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(224, 224, 224);
            btnReportes.BorderColor = Color.Transparent;
            btnReportes.ButtonColor = Color.White;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnReportes.Location = new Point(103, 278);
            btnReportes.Name = "btnReportes";
            btnReportes.OnHoverBorderColor = Color.Transparent;
            btnReportes.OnHoverButtonColor = Color.FromArgb(255, 192, 192);
            btnReportes.OnHoverTextColor = Color.Transparent;
            btnReportes.Size = new Size(355, 53);
            btnReportes.TabIndex = 54;
            btnReportes.Text = "REPORTES";
            btnReportes.TextColor = Color.Gray;
            btnReportes.UseVisualStyleBackColor = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 415);
            Controls.Add(btnReportes);
            Controls.Add(btnGestionarProductos);
            Controls.Add(BtnGestionarClientes);
            Controls.Add(btnGestionarProveedores);
            Controls.Add(btnGestionarUsuarios);
            Controls.Add(LinkLabelCerrarSesion);
            Controls.Add(pictureBox2);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private LinkLabel LinkLabelCerrarSesion;
        private ePOSOne.btnProduct.Button_WOC btnGestionarUsuarios;
        private ePOSOne.btnProduct.Button_WOC btnGestionarProveedores;
        private ePOSOne.btnProduct.Button_WOC BtnGestionarClientes;
        private ePOSOne.btnProduct.Button_WOC btnGestionarProductos;
        private ePOSOne.btnProduct.Button_WOC btnReportes;
    }
}