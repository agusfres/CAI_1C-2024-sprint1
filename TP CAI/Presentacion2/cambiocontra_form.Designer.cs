﻿namespace Presentacion2
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
            this.lblCambiaTuContraseñaTitulo = new System.Windows.Forms.Label();
            this.linkLabelVolver = new System.Windows.Forms.LinkLabel();
            this.txtContraseñaActual = new System.Windows.Forms.TextBox();
            this.txtContraseñaNueva = new System.Windows.Forms.TextBox();
            this.btnCambiar = new ePOSOne.btnProduct.Button_WOC();
            this.lblErrorContraseñaVieja = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCambioContraseñaExitosa = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCambiaTuContraseñaTitulo
            // 
            this.lblCambiaTuContraseñaTitulo.AutoSize = true;
            this.lblCambiaTuContraseñaTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCambiaTuContraseñaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambiaTuContraseñaTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblCambiaTuContraseñaTitulo.Location = new System.Drawing.Point(53, 30);
            this.lblCambiaTuContraseñaTitulo.Name = "lblCambiaTuContraseñaTitulo";
            this.lblCambiaTuContraseñaTitulo.Size = new System.Drawing.Size(478, 31);
            this.lblCambiaTuContraseñaTitulo.TabIndex = 1;
            this.lblCambiaTuContraseñaTitulo.Text = "DEBES CAMBIAR TU CONTRASEÑA";
            // 
            // linkLabelVolver
            // 
            this.linkLabelVolver.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabelVolver.AutoSize = true;
            this.linkLabelVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkLabelVolver.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.linkLabelVolver.ForeColor = System.Drawing.Color.Red;
            this.linkLabelVolver.LinkColor = System.Drawing.Color.Black;
            this.linkLabelVolver.Location = new System.Drawing.Point(12, 9);
            this.linkLabelVolver.Name = "linkLabelVolver";
            this.linkLabelVolver.Size = new System.Drawing.Size(37, 13);
            this.linkLabelVolver.TabIndex = 2;
            this.linkLabelVolver.TabStop = true;
            this.linkLabelVolver.Text = "Volver";
            this.linkLabelVolver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelVolver_LinkClicked_1);
            // 
            // txtContraseñaActual
            // 
            this.txtContraseñaActual.BackColor = System.Drawing.Color.White;
            this.txtContraseñaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaActual.ForeColor = System.Drawing.Color.Gray;
            this.txtContraseñaActual.Location = new System.Drawing.Point(162, 184);
            this.txtContraseñaActual.Name = "txtContraseñaActual";
            this.txtContraseñaActual.Size = new System.Drawing.Size(253, 21);
            this.txtContraseñaActual.TabIndex = 3;
            // 
            // txtContraseñaNueva
            // 
            this.txtContraseñaNueva.BackColor = System.Drawing.Color.White;
            this.txtContraseñaNueva.Enabled = false;
            this.txtContraseñaNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaNueva.ForeColor = System.Drawing.Color.Gray;
            this.txtContraseñaNueva.Location = new System.Drawing.Point(162, 265);
            this.txtContraseñaNueva.Name = "txtContraseñaNueva";
            this.txtContraseñaNueva.ReadOnly = true;
            this.txtContraseñaNueva.Size = new System.Drawing.Size(253, 21);
            this.txtContraseñaNueva.TabIndex = 4;
            this.txtContraseñaNueva.Text = "CAI20232";
            // 
            // btnCambiar
            // 
            this.btnCambiar.BackColor = System.Drawing.Color.White;
            this.btnCambiar.BorderColor = System.Drawing.Color.Transparent;
            this.btnCambiar.ButtonColor = System.Drawing.Color.Salmon;
            this.btnCambiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCambiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiar.ForeColor = System.Drawing.Color.Transparent;
            this.btnCambiar.Location = new System.Drawing.Point(162, 330);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.OnHoverBorderColor = System.Drawing.Color.Salmon;
            this.btnCambiar.OnHoverButtonColor = System.Drawing.Color.Salmon;
            this.btnCambiar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnCambiar.Size = new System.Drawing.Size(226, 41);
            this.btnCambiar.TabIndex = 34;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.TextColor = System.Drawing.Color.White;
            this.btnCambiar.UseVisualStyleBackColor = false;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // lblErrorContraseñaVieja
            // 
            this.lblErrorContraseñaVieja.AutoSize = true;
            this.lblErrorContraseñaVieja.BackColor = System.Drawing.Color.White;
            this.lblErrorContraseñaVieja.ForeColor = System.Drawing.Color.Red;
            this.lblErrorContraseñaVieja.Location = new System.Drawing.Point(162, 209);
            this.lblErrorContraseñaVieja.Name = "lblErrorContraseñaVieja";
            this.lblErrorContraseñaVieja.Size = new System.Drawing.Size(0, 13);
            this.lblErrorContraseñaVieja.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(162, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ingrese su contraseña actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(162, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Su nueva contraseña será:";
            // 
            // lblCambioContraseñaExitosa
            // 
            this.lblCambioContraseñaExitosa.AutoSize = true;
            this.lblCambioContraseñaExitosa.BackColor = System.Drawing.Color.White;
            this.lblCambioContraseñaExitosa.ForeColor = System.Drawing.Color.Black;
            this.lblCambioContraseñaExitosa.Location = new System.Drawing.Point(162, 314);
            this.lblCambioContraseñaExitosa.Name = "lblCambioContraseñaExitosa";
            this.lblCambioContraseñaExitosa.Size = new System.Drawing.Size(0, 13);
            this.lblCambioContraseñaExitosa.TabIndex = 38;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion2.Properties.Resources.New_Project__2___1_;
            this.pictureBox1.Location = new System.Drawing.Point(-26, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(602, 423);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // cambiocontra_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 415);
            this.Controls.Add(this.lblCambioContraseñaExitosa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblErrorContraseñaVieja);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.txtContraseñaNueva);
            this.Controls.Add(this.txtContraseñaActual);
            this.Controls.Add(this.linkLabelVolver);
            this.Controls.Add(this.lblCambiaTuContraseñaTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "cambiocontra_form";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCambiaTuContraseñaTitulo;
        private System.Windows.Forms.LinkLabel linkLabelVolver;
        private System.Windows.Forms.TextBox txtContraseñaActual;
        private System.Windows.Forms.TextBox txtContraseñaNueva;
        private ePOSOne.btnProduct.Button_WOC btnCambiar;
        private System.Windows.Forms.Label lblErrorContraseñaVieja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCambioContraseñaExitosa;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}