namespace Presentacion2
{
    partial class supervisor_devolucion_venta
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
            this.btnDevolver = new ePOSOne.btnProduct.Button_WOC();
            this.lblErrorEliminar = new System.Windows.Forms.Label();
            this.txtIdventa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGestionUsuariosTitulo = new System.Windows.Forms.Label();
            this.linkLabelVolver = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMensajeEliminar
            // 
            this.lblMensajeEliminar.AutoSize = true;
            this.lblMensajeEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblMensajeEliminar.Location = new System.Drawing.Point(166, 247);
            this.lblMensajeEliminar.Name = "lblMensajeEliminar";
            this.lblMensajeEliminar.Size = new System.Drawing.Size(0, 13);
            this.lblMensajeEliminar.TabIndex = 44;
            // 
            // btnDevolver
            // 
            this.btnDevolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDevolver.BorderColor = System.Drawing.Color.Transparent;
            this.btnDevolver.ButtonColor = System.Drawing.Color.Salmon;
            this.btnDevolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDevolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDevolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDevolver.Location = new System.Drawing.Point(120, 192);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.OnHoverBorderColor = System.Drawing.Color.Salmon;
            this.btnDevolver.OnHoverButtonColor = System.Drawing.Color.Salmon;
            this.btnDevolver.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnDevolver.Size = new System.Drawing.Size(302, 38);
            this.btnDevolver.TabIndex = 43;
            this.btnDevolver.Text = "Devolver Venta";
            this.btnDevolver.TextColor = System.Drawing.Color.White;
            this.btnDevolver.UseVisualStyleBackColor = false;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // lblErrorEliminar
            // 
            this.lblErrorEliminar.AutoSize = true;
            this.lblErrorEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblErrorEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorEliminar.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEliminar.Location = new System.Drawing.Point(120, 164);
            this.lblErrorEliminar.Name = "lblErrorEliminar";
            this.lblErrorEliminar.Size = new System.Drawing.Size(0, 15);
            this.lblErrorEliminar.TabIndex = 42;
            // 
            // txtIdventa
            // 
            this.txtIdventa.Location = new System.Drawing.Point(120, 139);
            this.txtIdventa.Name = "txtIdventa";
            this.txtIdventa.Size = new System.Drawing.Size(302, 20);
            this.txtIdventa.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 15);
            this.label1.TabIndex = 40;
            this.label1.Text = "Ingrese el Id de la venta que desea devolver";
            // 
            // lblGestionUsuariosTitulo
            // 
            this.lblGestionUsuariosTitulo.AutoSize = true;
            this.lblGestionUsuariosTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblGestionUsuariosTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionUsuariosTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblGestionUsuariosTitulo.Location = new System.Drawing.Point(152, 41);
            this.lblGestionUsuariosTitulo.Name = "lblGestionUsuariosTitulo";
            this.lblGestionUsuariosTitulo.Size = new System.Drawing.Size(260, 31);
            this.lblGestionUsuariosTitulo.TabIndex = 39;
            this.lblGestionUsuariosTitulo.Text = "DEVOLVER VENTA";
            // 
            // linkLabelVolver
            // 
            this.linkLabelVolver.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabelVolver.AutoSize = true;
            this.linkLabelVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkLabelVolver.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.linkLabelVolver.ForeColor = System.Drawing.Color.Red;
            this.linkLabelVolver.LinkColor = System.Drawing.Color.Black;
            this.linkLabelVolver.Location = new System.Drawing.Point(39, 41);
            this.linkLabelVolver.Name = "linkLabelVolver";
            this.linkLabelVolver.Size = new System.Drawing.Size(37, 13);
            this.linkLabelVolver.TabIndex = 38;
            this.linkLabelVolver.TabStop = true;
            this.linkLabelVolver.Text = "Volver";
            this.linkLabelVolver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelVolver_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion2.Properties.Resources.New_Project__3_;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(542, 347);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // supervisor_devolucion_venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 345);
            this.Controls.Add(this.lblMensajeEliminar);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.lblErrorEliminar);
            this.Controls.Add(this.txtIdventa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGestionUsuariosTitulo);
            this.Controls.Add(this.linkLabelVolver);
            this.Controls.Add(this.pictureBox1);
            this.Name = "supervisor_devolucion_venta";
            this.Text = "supervisor_devolucion_venta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensajeEliminar;
        private ePOSOne.btnProduct.Button_WOC btnDevolver;
        private System.Windows.Forms.Label lblErrorEliminar;
        private System.Windows.Forms.TextBox txtIdventa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGestionUsuariosTitulo;
        private System.Windows.Forms.LinkLabel linkLabelVolver;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}