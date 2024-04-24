namespace Presentacion2
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
            this.linkLabelVolver = new System.Windows.Forms.LinkLabel();
            this.lblGestionUsuariosTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.lblErrorEliminar = new System.Windows.Forms.Label();
            this.btnEliminarUsuario = new ePOSOne.btnProduct.Button_WOC();
            this.lblMensajeEliminar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelVolver
            // 
            this.linkLabelVolver.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabelVolver.AutoSize = true;
            this.linkLabelVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkLabelVolver.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.linkLabelVolver.ForeColor = System.Drawing.Color.Red;
            this.linkLabelVolver.LinkColor = System.Drawing.Color.Black;
            this.linkLabelVolver.Location = new System.Drawing.Point(48, 45);
            this.linkLabelVolver.Name = "linkLabelVolver";
            this.linkLabelVolver.Size = new System.Drawing.Size(37, 13);
            this.linkLabelVolver.TabIndex = 4;
            this.linkLabelVolver.TabStop = true;
            this.linkLabelVolver.Text = "Volver";
            this.linkLabelVolver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelVolver_LinkClicked_1);
            // 
            // lblGestionUsuariosTitulo
            // 
            this.lblGestionUsuariosTitulo.AutoSize = true;
            this.lblGestionUsuariosTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblGestionUsuariosTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionUsuariosTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblGestionUsuariosTitulo.Location = new System.Drawing.Point(205, 45);
            this.lblGestionUsuariosTitulo.Name = "lblGestionUsuariosTitulo";
            this.lblGestionUsuariosTitulo.Size = new System.Drawing.Size(214, 31);
            this.lblGestionUsuariosTitulo.TabIndex = 5;
            this.lblGestionUsuariosTitulo.Text = "BAJA USUARIO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingrese el Id Usuario del usuario que desea eliminar";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(158, 137);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(302, 20);
            this.txtIdUsuario.TabIndex = 7;
            // 
            // lblErrorEliminar
            // 
            this.lblErrorEliminar.AutoSize = true;
            this.lblErrorEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorEliminar.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEliminar.Location = new System.Drawing.Point(158, 162);
            this.lblErrorEliminar.Name = "lblErrorEliminar";
            this.lblErrorEliminar.Size = new System.Drawing.Size(0, 15);
            this.lblErrorEliminar.TabIndex = 8;
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEliminarUsuario.BorderColor = System.Drawing.Color.Transparent;
            this.btnEliminarUsuario.ButtonColor = System.Drawing.Color.Salmon;
            this.btnEliminarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEliminarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEliminarUsuario.Location = new System.Drawing.Point(158, 223);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.OnHoverBorderColor = System.Drawing.Color.Salmon;
            this.btnEliminarUsuario.OnHoverButtonColor = System.Drawing.Color.Salmon;
            this.btnEliminarUsuario.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnEliminarUsuario.Size = new System.Drawing.Size(302, 38);
            this.btnEliminarUsuario.TabIndex = 36;
            this.btnEliminarUsuario.Text = "Eliminar Usuario";
            this.btnEliminarUsuario.TextColor = System.Drawing.Color.White;
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // lblMensajeEliminar
            // 
            this.lblMensajeEliminar.AutoSize = true;
            this.lblMensajeEliminar.Location = new System.Drawing.Point(159, 197);
            this.lblMensajeEliminar.Name = "lblMensajeEliminar";
            this.lblMensajeEliminar.Size = new System.Drawing.Size(0, 13);
            this.lblMensajeEliminar.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Image = global::Presentacion2.Properties.Resources.New_Project;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(597, 364);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // admin_baja_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 352);
            this.Controls.Add(this.lblMensajeEliminar);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.lblErrorEliminar);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGestionUsuariosTitulo);
            this.Controls.Add(this.linkLabelVolver);
            this.Controls.Add(this.pictureBox1);
            this.Name = "admin_baja_form";
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.LinkLabel linkLabelVolver;
        private System.Windows.Forms.Label lblGestionUsuariosTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Label lblErrorEliminar;
        private ePOSOne.btnProduct.Button_WOC btnEliminarUsuario;
        private System.Windows.Forms.Label lblMensajeEliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}