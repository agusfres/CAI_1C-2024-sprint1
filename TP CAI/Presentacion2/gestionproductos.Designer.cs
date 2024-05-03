namespace Presentacion2
{
    partial class gestionproductos
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
            this.btnGestionarProductos = new ePOSOne.btnProduct.Button_WOC();
            this.linkLabelCerrarSesion = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblGestionUsuariosTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGestionarProductos
            // 
            this.btnGestionarProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGestionarProductos.BorderColor = System.Drawing.Color.Transparent;
            this.btnGestionarProductos.ButtonColor = System.Drawing.Color.White;
            this.btnGestionarProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGestionarProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGestionarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGestionarProductos.Location = new System.Drawing.Point(97, 177);
            this.btnGestionarProductos.Name = "btnGestionarProductos";
            this.btnGestionarProductos.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnGestionarProductos.OnHoverButtonColor = System.Drawing.Color.White;
            this.btnGestionarProductos.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnGestionarProductos.Size = new System.Drawing.Size(323, 41);
            this.btnGestionarProductos.TabIndex = 41;
            this.btnGestionarProductos.Text = "REGISTRAR PRODUCTOS";
            this.btnGestionarProductos.TextColor = System.Drawing.Color.Gray;
            this.btnGestionarProductos.UseVisualStyleBackColor = false;
            // 
            // linkLabelCerrarSesion
            // 
            this.linkLabelCerrarSesion.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabelCerrarSesion.AutoSize = true;
            this.linkLabelCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkLabelCerrarSesion.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.linkLabelCerrarSesion.ForeColor = System.Drawing.Color.Red;
            this.linkLabelCerrarSesion.LinkColor = System.Drawing.Color.Black;
            this.linkLabelCerrarSesion.Location = new System.Drawing.Point(26, 28);
            this.linkLabelCerrarSesion.Name = "linkLabelCerrarSesion";
            this.linkLabelCerrarSesion.Size = new System.Drawing.Size(37, 13);
            this.linkLabelCerrarSesion.TabIndex = 40;
            this.linkLabelCerrarSesion.TabStop = true;
            this.linkLabelCerrarSesion.Text = "Volver";
            this.linkLabelCerrarSesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCerrarSesion_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion2.Properties.Resources.New_Project__4___1_;
            this.pictureBox1.Location = new System.Drawing.Point(1, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(549, 386);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // lblGestionUsuariosTitulo
            // 
            this.lblGestionUsuariosTitulo.AutoSize = true;
            this.lblGestionUsuariosTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblGestionUsuariosTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionUsuariosTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblGestionUsuariosTitulo.Location = new System.Drawing.Point(91, 53);
            this.lblGestionUsuariosTitulo.Name = "lblGestionUsuariosTitulo";
            this.lblGestionUsuariosTitulo.Size = new System.Drawing.Size(364, 31);
            this.lblGestionUsuariosTitulo.TabIndex = 43;
            this.lblGestionUsuariosTitulo.Text = "GESTIÓN DE PRODUCTOS";
            // 
            // gestionproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 378);
            this.Controls.Add(this.lblGestionUsuariosTitulo);
            this.Controls.Add(this.btnGestionarProductos);
            this.Controls.Add(this.linkLabelCerrarSesion);
            this.Controls.Add(this.pictureBox1);
            this.Name = "gestionproductos";
            this.Text = "gestionproductos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ePOSOne.btnProduct.Button_WOC btnGestionarProductos;
        private System.Windows.Forms.LinkLabel linkLabelCerrarSesion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblGestionUsuariosTitulo;
    }
}