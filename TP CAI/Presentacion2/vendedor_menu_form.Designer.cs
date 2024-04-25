namespace Presentacion2
{
    partial class vendedor_menu_form
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
            this.btnVenta = new ePOSOne.btnProduct.Button_WOC();
            this.btnReporteVentas = new ePOSOne.btnProduct.Button_WOC();
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
            this.linkLabelVolver.Size = new System.Drawing.Size(68, 13);
            this.linkLabelVolver.TabIndex = 4;
            this.linkLabelVolver.TabStop = true;
            this.linkLabelVolver.Text = "Cerrar sesión";
            this.linkLabelVolver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelVolver_LinkClicked);
            // 
            // btnVenta
            // 
            this.btnVenta.BorderColor = System.Drawing.Color.Transparent;
            this.btnVenta.ButtonColor = System.Drawing.Color.White;
            this.btnVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenta.ForeColor = System.Drawing.Color.White;
            this.btnVenta.Location = new System.Drawing.Point(113, 134);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnVenta.OnHoverButtonColor = System.Drawing.Color.White;
            this.btnVenta.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnVenta.Size = new System.Drawing.Size(323, 41);
            this.btnVenta.TabIndex = 36;
            this.btnVenta.Text = "VENTA";
            this.btnVenta.TextColor = System.Drawing.Color.Gray;
            this.btnVenta.UseVisualStyleBackColor = true;
            // 
            // btnReporteVentas
            // 
            this.btnReporteVentas.BorderColor = System.Drawing.Color.Transparent;
            this.btnReporteVentas.ButtonColor = System.Drawing.Color.White;
            this.btnReporteVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReporteVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReporteVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteVentas.ForeColor = System.Drawing.Color.White;
            this.btnReporteVentas.Location = new System.Drawing.Point(113, 199);
            this.btnReporteVentas.Name = "btnReporteVentas";
            this.btnReporteVentas.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnReporteVentas.OnHoverButtonColor = System.Drawing.Color.White;
            this.btnReporteVentas.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnReporteVentas.Size = new System.Drawing.Size(323, 41);
            this.btnReporteVentas.TabIndex = 37;
            this.btnReporteVentas.Text = "REPORTE VENTAS";
            this.btnReporteVentas.TextColor = System.Drawing.Color.Gray;
            this.btnReporteVentas.UseVisualStyleBackColor = true;
            // 
            // vendedor_menu_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 415);
            this.Controls.Add(this.btnReporteVentas);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.linkLabelVolver);
            this.Name = "vendedor_menu_form";
            this.Text = "Form8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelVolver;
        private ePOSOne.btnProduct.Button_WOC btnVenta;
        private ePOSOne.btnProduct.Button_WOC btnReporteVentas;
    }
}