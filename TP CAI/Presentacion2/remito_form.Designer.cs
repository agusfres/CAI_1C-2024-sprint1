﻿namespace Presentacion2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNombreEmp = new System.Windows.Forms.Label();
            this.lblFechaOp = new System.Windows.Forms.Label();
            this.lblDatosCliente = new System.Windows.Forms.Label();
            this.lblPromociones = new System.Windows.Forms.Label();
            this.lblNombrePromo = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 19);
            this.label1.TabIndex = 36;
            this.label1.Text = "Nombre de la empresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "Fecha de la operación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 19);
            this.label3.TabIndex = 38;
            this.label3.Text = "Datos del cliente:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_producto,
            this.Descripción,
            this.Cantidad,
            this.Monto_unitario,
            this.Monto_total});
            this.dataGridView1.Location = new System.Drawing.Point(32, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 57);
            this.dataGridView1.TabIndex = 39;
            // 
            // Id_producto
            // 
            this.Id_producto.HeaderText = "Detalle";
            this.Id_producto.Name = "Id_producto";
            // 
            // Descripción
            // 
            this.Descripción.HeaderText = "";
            this.Descripción.Name = "Descripción";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "";
            this.Cantidad.Name = "Cantidad";
            // 
            // Monto_unitario
            // 
            this.Monto_unitario.HeaderText = "";
            this.Monto_unitario.Name = "Monto_unitario";
            // 
            // Monto_total
            // 
            this.Monto_total.HeaderText = "";
            this.Monto_total.Name = "Monto_total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 19);
            this.label4.TabIndex = 40;
            this.label4.Text = "Promociones:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 19);
            this.label5.TabIndex = 41;
            this.label5.Text = "Nombre promoción:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(418, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 19);
            this.label6.TabIndex = 42;
            this.label6.Text = "Total a pagar:";
            // 
            // lblNombreEmp
            // 
            this.lblNombreEmp.AutoSize = true;
            this.lblNombreEmp.Location = new System.Drawing.Point(220, 25);
            this.lblNombreEmp.Name = "lblNombreEmp";
            this.lblNombreEmp.Size = new System.Drawing.Size(0, 13);
            this.lblNombreEmp.TabIndex = 43;
            // 
            // lblFechaOp
            // 
            this.lblFechaOp.AutoSize = true;
            this.lblFechaOp.Location = new System.Drawing.Point(214, 60);
            this.lblFechaOp.Name = "lblFechaOp";
            this.lblFechaOp.Size = new System.Drawing.Size(0, 13);
            this.lblFechaOp.TabIndex = 44;
            // 
            // lblDatosCliente
            // 
            this.lblDatosCliente.AutoSize = true;
            this.lblDatosCliente.Location = new System.Drawing.Point(175, 94);
            this.lblDatosCliente.Name = "lblDatosCliente";
            this.lblDatosCliente.Size = new System.Drawing.Size(0, 13);
            this.lblDatosCliente.TabIndex = 45;
            // 
            // lblPromociones
            // 
            this.lblPromociones.AutoSize = true;
            this.lblPromociones.Location = new System.Drawing.Point(140, 221);
            this.lblPromociones.Name = "lblPromociones";
            this.lblPromociones.Size = new System.Drawing.Size(0, 13);
            this.lblPromociones.TabIndex = 46;
            // 
            // lblNombrePromo
            // 
            this.lblNombrePromo.AutoSize = true;
            this.lblNombrePromo.Location = new System.Drawing.Point(185, 263);
            this.lblNombrePromo.Name = "lblNombrePromo";
            this.lblNombrePromo.Size = new System.Drawing.Size(0, 13);
            this.lblNombrePromo.TabIndex = 47;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(529, 302);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 48;
            // 
            // remito_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblNombrePromo);
            this.Controls.Add(this.lblPromociones);
            this.Controls.Add(this.lblDatosCliente);
            this.Controls.Add(this.lblFechaOp);
            this.Controls.Add(this.lblNombreEmp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnmenu);
            this.Controls.Add(this.btnventa);
            this.Name = "remito_form";
            this.Text = "remito_form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ePOSOne.btnProduct.Button_WOC btnventa;
        private ePOSOne.btnProduct.Button_WOC btnmenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNombreEmp;
        private System.Windows.Forms.Label lblFechaOp;
        private System.Windows.Forms.Label lblDatosCliente;
        private System.Windows.Forms.Label lblPromociones;
        private System.Windows.Forms.Label lblNombrePromo;
        private System.Windows.Forms.Label lblTotal;
    }
}