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
            this.btnmenu = new ePOSOne.btnProduct.Button_WOC();
            this.btnventa = new ePOSOne.btnProduct.Button_WOC();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Nombre de la empresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(32, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Fecha de la operación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(32, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
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
            this.dataGridView1.Location = new System.Drawing.Point(32, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 100);
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
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(32, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Promociones:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(32, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Nombre promoción:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(418, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "Total a pagar:";
            // 
            // lblNombreEmp
            // 
            this.lblNombreEmp.AutoSize = true;
            this.lblNombreEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblNombreEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNombreEmp.Location = new System.Drawing.Point(351, 22);
            this.lblNombreEmp.Name = "lblNombreEmp";
            this.lblNombreEmp.Size = new System.Drawing.Size(97, 15);
            this.lblNombreEmp.TabIndex = 43;
            this.lblNombreEmp.Text = "ElectroHogar SA";
            // 
            // lblFechaOp
            // 
            this.lblFechaOp.AutoSize = true;
            this.lblFechaOp.Location = new System.Drawing.Point(351, 58);
            this.lblFechaOp.Name = "lblFechaOp";
            this.lblFechaOp.Size = new System.Drawing.Size(0, 13);
            this.lblFechaOp.TabIndex = 44;
            // 
            // lblDatosCliente
            // 
            this.lblDatosCliente.AutoSize = true;
            this.lblDatosCliente.Location = new System.Drawing.Point(351, 92);
            this.lblDatosCliente.Name = "lblDatosCliente";
            this.lblDatosCliente.Size = new System.Drawing.Size(0, 13);
            this.lblDatosCliente.TabIndex = 45;
            // 
            // lblPromociones
            // 
            this.lblPromociones.AutoSize = true;
            this.lblPromociones.Location = new System.Drawing.Point(351, 247);
            this.lblPromociones.Name = "lblPromociones";
            this.lblPromociones.Size = new System.Drawing.Size(0, 13);
            this.lblPromociones.TabIndex = 46;
            // 
            // lblNombrePromo
            // 
            this.lblNombrePromo.AutoSize = true;
            this.lblNombrePromo.Location = new System.Drawing.Point(351, 289);
            this.lblNombrePromo.Name = "lblNombrePromo";
            this.lblNombrePromo.Size = new System.Drawing.Size(0, 13);
            this.lblNombrePromo.TabIndex = 47;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(529, 327);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 48;
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
            this.btnmenu.Location = new System.Drawing.Point(416, 374);
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
            this.btnventa.Location = new System.Drawing.Point(188, 374);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion2.Properties.Resources.New_Project__4_;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(805, 455);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
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
            this.Controls.Add(this.pictureBox1);
            this.Name = "remito_form";
            this.Text = "remito_form";
            this.Load += new System.EventHandler(this.remito_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}