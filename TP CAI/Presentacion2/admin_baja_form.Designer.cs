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
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblErrorDNI = new System.Windows.Forms.Label();
            this.listBoxUsuario = new System.Windows.Forms.ListBox();
            this.lblErrorEliminar = new System.Windows.Forms.Label();
            this.btnEliminarUsuario = new ePOSOne.btnProduct.Button_WOC();
            this.btnBuscarUsuario = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
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
            this.linkLabelVolver.TabIndex = 4;
            this.linkLabelVolver.TabStop = true;
            this.linkLabelVolver.Text = "Volver";
            this.linkLabelVolver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelVolver_LinkClicked_1);
            // 
            // lblGestionUsuariosTitulo
            // 
            this.lblGestionUsuariosTitulo.AutoSize = true;
            this.lblGestionUsuariosTitulo.Font = new System.Drawing.Font("Inter", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionUsuariosTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblGestionUsuariosTitulo.Location = new System.Drawing.Point(216, 27);
            this.lblGestionUsuariosTitulo.Name = "lblGestionUsuariosTitulo";
            this.lblGestionUsuariosTitulo.Size = new System.Drawing.Size(212, 33);
            this.lblGestionUsuariosTitulo.TabIndex = 5;
            this.lblGestionUsuariosTitulo.Text = "BAJA USUARIO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingrese el Id Usuario del usuario que desea eliminar";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(169, 143);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(302, 20);
            this.txtDNI.TabIndex = 7;
            // 
            // lblErrorDNI
            // 
            this.lblErrorDNI.AutoSize = true;
            this.lblErrorDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDNI.Location = new System.Drawing.Point(169, 168);
            this.lblErrorDNI.Name = "lblErrorDNI";
            this.lblErrorDNI.Size = new System.Drawing.Size(0, 15);
            this.lblErrorDNI.TabIndex = 8;
            // 
            // listBoxUsuario
            // 
            this.listBoxUsuario.FormattingEnabled = true;
            this.listBoxUsuario.Location = new System.Drawing.Point(170, 239);
            this.listBoxUsuario.Name = "listBoxUsuario";
            this.listBoxUsuario.Size = new System.Drawing.Size(302, 95);
            this.listBoxUsuario.TabIndex = 34;
            // 
            // lblErrorEliminar
            // 
            this.lblErrorEliminar.AutoSize = true;
            this.lblErrorEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorEliminar.Location = new System.Drawing.Point(170, 336);
            this.lblErrorEliminar.Name = "lblErrorEliminar";
            this.lblErrorEliminar.Size = new System.Drawing.Size(0, 15);
            this.lblErrorEliminar.TabIndex = 35;
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.BorderColor = System.Drawing.Color.Transparent;
            this.btnEliminarUsuario.ButtonColor = System.Drawing.Color.Salmon;
            this.btnEliminarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEliminarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.ForeColor = System.Drawing.Color.Transparent;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(169, 363);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.OnHoverBorderColor = System.Drawing.Color.Salmon;
            this.btnEliminarUsuario.OnHoverButtonColor = System.Drawing.Color.Salmon;
            this.btnEliminarUsuario.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnEliminarUsuario.Size = new System.Drawing.Size(302, 38);
            this.btnEliminarUsuario.TabIndex = 36;
            this.btnEliminarUsuario.Text = "Eliminar Usuario";
            this.btnEliminarUsuario.TextColor = System.Drawing.Color.White;
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click_1);
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.BorderColor = System.Drawing.Color.Transparent;
            this.btnBuscarUsuario.ButtonColor = System.Drawing.Color.Salmon;
            this.btnBuscarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBuscarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBuscarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarUsuario.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarUsuario.ForeColor = System.Drawing.Color.Transparent;
            this.btnBuscarUsuario.Location = new System.Drawing.Point(169, 198);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.OnHoverBorderColor = System.Drawing.Color.Salmon;
            this.btnBuscarUsuario.OnHoverButtonColor = System.Drawing.Color.Salmon;
            this.btnBuscarUsuario.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnBuscarUsuario.Size = new System.Drawing.Size(302, 38);
            this.btnBuscarUsuario.TabIndex = 33;
            this.btnBuscarUsuario.Text = "Buscar Usuario";
            this.btnBuscarUsuario.TextColor = System.Drawing.Color.White;
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click_1);
            // 
            // admin_baja_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 450);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.lblErrorEliminar);
            this.Controls.Add(this.listBoxUsuario);
            this.Controls.Add(this.btnBuscarUsuario);
            this.Controls.Add(this.lblErrorDNI);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGestionUsuariosTitulo);
            this.Controls.Add(this.linkLabelVolver);
            this.Name = "admin_baja_form";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.LinkLabel linkLabelVolver;
        private System.Windows.Forms.Label lblGestionUsuariosTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblErrorDNI;
        private ePOSOne.btnProduct.Button_WOC btnBuscarUsuario;
        private System.Windows.Forms.ListBox listBoxUsuario;
        private System.Windows.Forms.Label lblErrorEliminar;
        private ePOSOne.btnProduct.Button_WOC btnEliminarUsuario;
    }
}