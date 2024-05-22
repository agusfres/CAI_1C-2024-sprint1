namespace Presentacion2
{
    partial class remito_form
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
            this.btnventa = new ePOSOne.btnProduct.Button_WOC();
            this.btnmenu = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // btnventa
            // 
            this.btnventa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnventa.BorderColor = System.Drawing.Color.Transparent;
            this.btnventa.ButtonColor = System.Drawing.Color.Salmon;
            this.btnventa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnventa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnventa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnventa.Location = new System.Drawing.Point(321, 341);
            this.btnventa.Name = "btnventa";
            this.btnventa.OnHoverBorderColor = System.Drawing.Color.Salmon;
            this.btnventa.OnHoverButtonColor = System.Drawing.Color.Salmon;
            this.btnventa.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnventa.Size = new System.Drawing.Size(163, 31);
            this.btnventa.TabIndex = 34;
            this.btnventa.Text = "Agregar otra venta";
            this.btnventa.TextColor = System.Drawing.Color.White;
            this.btnventa.UseVisualStyleBackColor = false;
            this.btnventa.Click += new System.EventHandler(this.btnventa_Click);
            // 
            // btnmenu
            // 
            this.btnmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnmenu.BorderColor = System.Drawing.Color.Transparent;
            this.btnmenu.ButtonColor = System.Drawing.Color.Salmon;
            this.btnmenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnmenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnmenu.Location = new System.Drawing.Point(321, 387);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.OnHoverBorderColor = System.Drawing.Color.Salmon;
            this.btnmenu.OnHoverButtonColor = System.Drawing.Color.Salmon;
            this.btnmenu.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnmenu.Size = new System.Drawing.Size(163, 31);
            this.btnmenu.TabIndex = 35;
            this.btnmenu.Text = "Volver al Menú";
            this.btnmenu.TextColor = System.Drawing.Color.White;
            this.btnmenu.UseVisualStyleBackColor = false;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // remito_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnmenu);
            this.Controls.Add(this.btnventa);
            this.Name = "remito_form";
            this.Text = "remito_form";
            this.ResumeLayout(false);

        }

        #endregion

        private ePOSOne.btnProduct.Button_WOC btnventa;
        private ePOSOne.btnProduct.Button_WOC btnmenu;
    }
}