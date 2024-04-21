namespace TP_CAI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vendedor_menu_form));
            pictureBox1 = new PictureBox();
            LinkLabelCerrarSesion = new LinkLabel();
            btnVenta = new ePOSOne.btnProduct.Button_WOC();
            btnReporteVentas = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-6, -38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(630, 474);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LinkLabelCerrarSesion
            // 
            LinkLabelCerrarSesion.ActiveLinkColor = Color.Black;
            LinkLabelCerrarSesion.AutoSize = true;
            LinkLabelCerrarSesion.BackColor = Color.FromArgb(224, 224, 224);
            LinkLabelCerrarSesion.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LinkLabelCerrarSesion.LinkColor = Color.Black;
            LinkLabelCerrarSesion.Location = new Point(12, 9);
            LinkLabelCerrarSesion.Name = "LinkLabelCerrarSesion";
            LinkLabelCerrarSesion.Size = new Size(81, 15);
            LinkLabelCerrarSesion.TabIndex = 50;
            LinkLabelCerrarSesion.TabStop = true;
            LinkLabelCerrarSesion.Text = "Cerrar sesión";
            // 
            // btnVenta
            // 
            btnVenta.BackColor = Color.FromArgb(224, 224, 224);
            btnVenta.BorderColor = Color.Transparent;
            btnVenta.ButtonColor = Color.White;
            btnVenta.FlatAppearance.BorderSize = 0;
            btnVenta.FlatStyle = FlatStyle.Flat;
            btnVenta.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVenta.Location = new Point(104, 98);
            btnVenta.Name = "btnVenta";
            btnVenta.OnHoverBorderColor = Color.Transparent;
            btnVenta.OnHoverButtonColor = Color.FromArgb(255, 192, 192);
            btnVenta.OnHoverTextColor = Color.Transparent;
            btnVenta.Size = new Size(355, 53);
            btnVenta.TabIndex = 51;
            btnVenta.Text = "VENTA";
            btnVenta.TextColor = Color.Gray;
            btnVenta.UseVisualStyleBackColor = false;
            // 
            // btnReporteVentas
            // 
            btnReporteVentas.BackColor = Color.FromArgb(224, 224, 224);
            btnReporteVentas.BorderColor = Color.Transparent;
            btnReporteVentas.ButtonColor = Color.White;
            btnReporteVentas.FlatAppearance.BorderSize = 0;
            btnReporteVentas.FlatStyle = FlatStyle.Flat;
            btnReporteVentas.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnReporteVentas.Location = new Point(104, 173);
            btnReporteVentas.Name = "btnReporteVentas";
            btnReporteVentas.OnHoverBorderColor = Color.Transparent;
            btnReporteVentas.OnHoverButtonColor = Color.FromArgb(255, 192, 192);
            btnReporteVentas.OnHoverTextColor = Color.Transparent;
            btnReporteVentas.Size = new Size(355, 53);
            btnReporteVentas.TabIndex = 52;
            btnReporteVentas.Text = "REPORTE DE VENTAS POR VENDEDOR";
            btnReporteVentas.TextColor = Color.Gray;
            btnReporteVentas.UseVisualStyleBackColor = false;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 415);
            Controls.Add(btnReporteVentas);
            Controls.Add(btnVenta);
            Controls.Add(LinkLabelCerrarSesion);
            Controls.Add(pictureBox1);
            Name = "Form8";
            Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private LinkLabel LinkLabelCerrarSesion;
        private ePOSOne.btnProduct.Button_WOC btnVenta;
        private ePOSOne.btnProduct.Button_WOC btnReporteVentas;
    }
}