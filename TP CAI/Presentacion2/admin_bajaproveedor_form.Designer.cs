namespace Presentacion2
{
    partial class admin_bajaproveedor_form
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
            this.lblMensajeEliminar = new System.Windows.Forms.Label();
            this.btnEliminarProveedor = new ePOSOne.btnProduct.Button_WOC();
            this.lblErrorId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGestionUsuariosTitulo = new System.Windows.Forms.Label();
            this.linkLabelVolver = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblMensajeEliminar
            // 
            this.lblMensajeEliminar.AutoSize = true;
            this.lblMensajeEliminar.Location = new System.Drawing.Point(422, 417);
            this.lblMensajeEliminar.Name = "lblMensajeEliminar";
            this.lblMensajeEliminar.Size = new System.Drawing.Size(0, 13);
            this.lblMensajeEliminar.TabIndex = 44;
            // 
            // btnEliminarProveedor
            // 
            this.btnEliminarProveedor.BorderColor = System.Drawing.Color.Transparent;
            this.btnEliminarProveedor.ButtonColor = System.Drawing.Color.Salmon;
            this.btnEliminarProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEliminarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEliminarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProveedor.ForeColor = System.Drawing.Color.Transparent;
            this.btnEliminarProveedor.Location = new System.Drawing.Point(196, 366);
            this.btnEliminarProveedor.Name = "btnEliminarProveedor";
            this.btnEliminarProveedor.OnHoverBorderColor = System.Drawing.Color.Salmon;
            this.btnEliminarProveedor.OnHoverButtonColor = System.Drawing.Color.Salmon;
            this.btnEliminarProveedor.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnEliminarProveedor.Size = new System.Drawing.Size(302, 38);
            this.btnEliminarProveedor.TabIndex = 43;
            this.btnEliminarProveedor.Text = "Eliminar Proveedor";
            this.btnEliminarProveedor.TextColor = System.Drawing.Color.White;
            this.btnEliminarProveedor.UseVisualStyleBackColor = true;
            this.btnEliminarProveedor.Click += new System.EventHandler(this.btnEliminarProveedor_Click);
            // 
            // lblErrorId
            // 
            this.lblErrorId.AutoSize = true;
            this.lblErrorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorId.Location = new System.Drawing.Point(196, 281);
            this.lblErrorId.Name = "lblErrorId";
            this.lblErrorId.Size = new System.Drawing.Size(0, 15);
            this.lblErrorId.TabIndex = 42;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(196, 256);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(302, 20);
            this.txtId.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 15);
            this.label1.TabIndex = 40;
            this.label1.Text = "Ingrese el Id Proveedor del usuario que desea eliminar";
            // 
            // lblGestionUsuariosTitulo
            // 
            this.lblGestionUsuariosTitulo.AutoSize = true;
            this.lblGestionUsuariosTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionUsuariosTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblGestionUsuariosTitulo.Location = new System.Drawing.Point(219, 34);
            this.lblGestionUsuariosTitulo.Name = "lblGestionUsuariosTitulo";
            this.lblGestionUsuariosTitulo.Size = new System.Drawing.Size(263, 31);
            this.lblGestionUsuariosTitulo.TabIndex = 39;
            this.lblGestionUsuariosTitulo.Text = "BAJA PROVEEDOR";
            // 
            // linkLabelVolver
            // 
            this.linkLabelVolver.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabelVolver.AutoSize = true;
            this.linkLabelVolver.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.linkLabelVolver.ForeColor = System.Drawing.Color.Red;
            this.linkLabelVolver.LinkColor = System.Drawing.Color.Black;
            this.linkLabelVolver.Location = new System.Drawing.Point(39, 12);
            this.linkLabelVolver.Name = "linkLabelVolver";
            this.linkLabelVolver.Size = new System.Drawing.Size(37, 13);
            this.linkLabelVolver.TabIndex = 38;
            this.linkLabelVolver.TabStop = true;
            this.linkLabelVolver.Text = "Volver";
            this.linkLabelVolver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelVolver_LinkClicked);
            // 
            // admin_bajaproveedor_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.lblMensajeEliminar);
            this.Controls.Add(this.btnEliminarProveedor);
            this.Controls.Add(this.lblErrorId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGestionUsuariosTitulo);
            this.Controls.Add(this.linkLabelVolver);
            this.Name = "admin_bajaproveedor_form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensajeEliminar;
        private ePOSOne.btnProduct.Button_WOC btnEliminarProveedor;
        private System.Windows.Forms.Label lblErrorId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGestionUsuariosTitulo;
        private System.Windows.Forms.LinkLabel linkLabelVolver;
    }
}