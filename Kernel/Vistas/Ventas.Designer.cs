namespace Kernel.Vistas
{
    partial class Ventas
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
            this.components = new System.ComponentModel.Container();
            this.GrillaLineasDeVenta = new System.Windows.Forms.DataGridView();
            this.ProductoCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitarioProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceLineaVenta = new System.Windows.Forms.BindingSource(this.components);
            this.btnConsultarVentas = new System.Windows.Forms.Button();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tboxDomicilioClienteVentas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxNombreClienteVentas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIngresarClienteVentas = new System.Windows.Forms.Button();
            this.tboxCodigoClienteVentas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CalendarTime = new System.Windows.Forms.DateTimePicker();
            this.tboxDescuentoProductoVentas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxCantidadProductoVentas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxCodigoProductoVentas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnQuitarProductosVentas = new System.Windows.Forms.Button();
            this.btnIngresarProductoVentas = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalVenta = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaLineasDeVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLineaVenta)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrillaLineasDeVenta
            // 
            this.GrillaLineasDeVenta.AllowUserToOrderColumns = true;
            this.GrillaLineasDeVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrillaLineasDeVenta.AutoGenerateColumns = false;
            this.GrillaLineasDeVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaLineasDeVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductoCodigo,
            this.descripcionProductoDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioUnitarioProductoDataGridViewTextBoxColumn,
            this.Descuento,
            this.Total});
            this.GrillaLineasDeVenta.DataSource = this.bindingSourceLineaVenta;
            this.GrillaLineasDeVenta.Location = new System.Drawing.Point(3, 329);
            this.GrillaLineasDeVenta.Name = "GrillaLineasDeVenta";
            this.GrillaLineasDeVenta.RowHeadersWidth = 51;
            this.GrillaLineasDeVenta.RowTemplate.Height = 24;
            this.GrillaLineasDeVenta.Size = new System.Drawing.Size(1144, 208);
            this.GrillaLineasDeVenta.TabIndex = 9;
            this.GrillaLineasDeVenta.TabStop = false;
            // 
            // ProductoCodigo
            // 
            this.ProductoCodigo.DataPropertyName = "ProductoCodigo";
            this.ProductoCodigo.HeaderText = "Codigo";
            this.ProductoCodigo.MinimumWidth = 6;
            this.ProductoCodigo.Name = "ProductoCodigo";
            this.ProductoCodigo.ReadOnly = true;
            this.ProductoCodigo.Width = 125;
            // 
            // descripcionProductoDataGridViewTextBoxColumn
            // 
            this.descripcionProductoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcionProductoDataGridViewTextBoxColumn.DataPropertyName = "descripcionProducto";
            this.descripcionProductoDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionProductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descripcionProductoDataGridViewTextBoxColumn.Name = "descripcionProductoDataGridViewTextBoxColumn";
            this.descripcionProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.Width = 125;
            // 
            // precioUnitarioProductoDataGridViewTextBoxColumn
            // 
            this.precioUnitarioProductoDataGridViewTextBoxColumn.DataPropertyName = "precioUnitarioProducto";
            this.precioUnitarioProductoDataGridViewTextBoxColumn.HeaderText = "Precio Unitario";
            this.precioUnitarioProductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioUnitarioProductoDataGridViewTextBoxColumn.Name = "precioUnitarioProductoDataGridViewTextBoxColumn";
            this.precioUnitarioProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioUnitarioProductoDataGridViewTextBoxColumn.Width = 125;
            // 
            // Descuento
            // 
            this.Descuento.DataPropertyName = "Descuento";
            this.Descuento.HeaderText = "Descuento %";
            this.Descuento.MinimumWidth = 6;
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            this.Descuento.Width = 125;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 125;
            // 
            // bindingSourceLineaVenta
            // 
            this.bindingSourceLineaVenta.DataSource = typeof(Kernel.Dominio.LineaDeVenta);
            // 
            // btnConsultarVentas
            // 
            this.btnConsultarVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConsultarVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarVentas.Location = new System.Drawing.Point(191, 571);
            this.btnConsultarVentas.Name = "btnConsultarVentas";
            this.btnConsultarVentas.Size = new System.Drawing.Size(190, 53);
            this.btnConsultarVentas.TabIndex = 19;
            this.btnConsultarVentas.TabStop = false;
            this.btnConsultarVentas.Text = "Consultar Ventas";
            this.btnConsultarVentas.UseVisualStyleBackColor = true;
            this.btnConsultarVentas.Click += new System.EventHandler(this.btnConsultarVentas_Click);
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarVenta.Location = new System.Drawing.Point(669, 572);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(190, 50);
            this.btnRegistrarVenta.TabIndex = 7;
            this.btnRegistrarVenta.Text = "Registrar Venta";
            this.btnRegistrarVenta.UseVisualStyleBackColor = true;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tboxDomicilioClienteVentas);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tboxNombreClienteVentas);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnIngresarClienteVentas);
            this.panel1.Controls.Add(this.tboxCodigoClienteVentas);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnNuevoCliente);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 293);
            this.panel1.TabIndex = 21;
            // 
            // tboxDomicilioClienteVentas
            // 
            this.tboxDomicilioClienteVentas.Location = new System.Drawing.Point(186, 228);
            this.tboxDomicilioClienteVentas.Name = "tboxDomicilioClienteVentas";
            this.tboxDomicilioClienteVentas.ReadOnly = true;
            this.tboxDomicilioClienteVentas.Size = new System.Drawing.Size(263, 22);
            this.tboxDomicilioClienteVentas.TabIndex = 16;
            this.tboxDomicilioClienteVentas.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "DOMICILIO :";
            // 
            // tboxNombreClienteVentas
            // 
            this.tboxNombreClienteVentas.Location = new System.Drawing.Point(186, 185);
            this.tboxNombreClienteVentas.Name = "tboxNombreClienteVentas";
            this.tboxNombreClienteVentas.ReadOnly = true;
            this.tboxNombreClienteVentas.Size = new System.Drawing.Size(263, 22);
            this.tboxNombreClienteVentas.TabIndex = 14;
            this.tboxNombreClienteVentas.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "CLIENTE :";
            // 
            // btnIngresarClienteVentas
            // 
            this.btnIngresarClienteVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarClienteVentas.Location = new System.Drawing.Point(339, 90);
            this.btnIngresarClienteVentas.Name = "btnIngresarClienteVentas";
            this.btnIngresarClienteVentas.Size = new System.Drawing.Size(149, 66);
            this.btnIngresarClienteVentas.TabIndex = 1;
            this.btnIngresarClienteVentas.Text = "Ingresar Cliente";
            this.btnIngresarClienteVentas.UseVisualStyleBackColor = true;
            this.btnIngresarClienteVentas.Click += new System.EventHandler(this.btnIngresarClienteVentas_Click);
            // 
            // tboxCodigoClienteVentas
            // 
            this.tboxCodigoClienteVentas.Location = new System.Drawing.Point(186, 134);
            this.tboxCodigoClienteVentas.Name = "tboxCodigoClienteVentas";
            this.tboxCodigoClienteVentas.Size = new System.Drawing.Size(119, 22);
            this.tboxCodigoClienteVentas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID CLIENTE :";
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCliente.Location = new System.Drawing.Point(13, 20);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(133, 55);
            this.btnNuevoCliente.TabIndex = 9;
            this.btnNuevoCliente.TabStop = false;
            this.btnNuevoCliente.Text = "Nuevo Cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.CalendarTime);
            this.panel2.Controls.Add(this.tboxDescuentoProductoVentas);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tboxCantidadProductoVentas);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tboxCodigoProductoVentas);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnQuitarProductosVentas);
            this.panel2.Controls.Add(this.btnIngresarProductoVentas);
            this.panel2.Location = new System.Drawing.Point(553, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 293);
            this.panel2.TabIndex = 22;
            // 
            // CalendarTime
            // 
            this.CalendarTime.Location = new System.Drawing.Point(271, 20);
            this.CalendarTime.Name = "CalendarTime";
            this.CalendarTime.Size = new System.Drawing.Size(280, 22);
            this.CalendarTime.TabIndex = 6;
            // 
            // tboxDescuentoProductoVentas
            // 
            this.tboxDescuentoProductoVentas.Location = new System.Drawing.Point(132, 115);
            this.tboxDescuentoProductoVentas.Name = "tboxDescuentoProductoVentas";
            this.tboxDescuentoProductoVentas.Size = new System.Drawing.Size(100, 22);
            this.tboxDescuentoProductoVentas.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "DESCUENTO %";
            // 
            // tboxCantidadProductoVentas
            // 
            this.tboxCantidadProductoVentas.Location = new System.Drawing.Point(132, 76);
            this.tboxCantidadProductoVentas.Name = "tboxCantidadProductoVentas";
            this.tboxCantidadProductoVentas.Size = new System.Drawing.Size(100, 22);
            this.tboxCantidadProductoVentas.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "CANTIDAD :";
            // 
            // tboxCodigoProductoVentas
            // 
            this.tboxCodigoProductoVentas.Location = new System.Drawing.Point(132, 37);
            this.tboxCodigoProductoVentas.Name = "tboxCodigoProductoVentas";
            this.tboxCodigoProductoVentas.Size = new System.Drawing.Size(100, 22);
            this.tboxCodigoProductoVentas.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "CODIGO :";
            // 
            // btnQuitarProductosVentas
            // 
            this.btnQuitarProductosVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarProductosVentas.Location = new System.Drawing.Point(257, 226);
            this.btnQuitarProductosVentas.Name = "btnQuitarProductosVentas";
            this.btnQuitarProductosVentas.Size = new System.Drawing.Size(159, 60);
            this.btnQuitarProductosVentas.TabIndex = 9;
            this.btnQuitarProductosVentas.TabStop = false;
            this.btnQuitarProductosVentas.Text = "Quitar Producto";
            this.btnQuitarProductosVentas.UseVisualStyleBackColor = true;
            this.btnQuitarProductosVentas.Click += new System.EventHandler(this.btnQuitarProductosVentas_Click);
            // 
            // btnIngresarProductoVentas
            // 
            this.btnIngresarProductoVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarProductoVentas.Location = new System.Drawing.Point(73, 226);
            this.btnIngresarProductoVentas.Name = "btnIngresarProductoVentas";
            this.btnIngresarProductoVentas.Size = new System.Drawing.Size(159, 60);
            this.btnIngresarProductoVentas.TabIndex = 5;
            this.btnIngresarProductoVentas.Text = "Ingresar Producto";
            this.btnIngresarProductoVentas.UseVisualStyleBackColor = true;
            this.btnIngresarProductoVentas.Click += new System.EventHandler(this.btnIngresarProductoVentas_Click_1);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 24);
            this.label7.TabIndex = 23;
            this.label7.Text = "TOTAL ( $ ) :";
            // 
            // lblTotalVenta
            // 
            this.lblTotalVenta.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTotalVenta.AutoSize = true;
            this.lblTotalVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVenta.Location = new System.Drawing.Point(144, 34);
            this.lblTotalVenta.Name = "lblTotalVenta";
            this.lblTotalVenta.Size = new System.Drawing.Size(50, 25);
            this.lblTotalVenta.TabIndex = 24;
            this.lblTotalVenta.Text = "0.00";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lblTotalVenta);
            this.panel3.Location = new System.Drawing.Point(402, 543);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 81);
            this.panel3.TabIndex = 25;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 633);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegistrarVenta);
            this.Controls.Add(this.btnConsultarVentas);
            this.Controls.Add(this.GrillaLineasDeVenta);
            this.Name = "Ventas";
            this.Text = "VENTAS";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaLineasDeVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLineaVenta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView GrillaLineasDeVenta;
        private System.Windows.Forms.BindingSource bindingSourceLineaVenta;
        private System.Windows.Forms.Button btnConsultarVentas;
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tboxDomicilioClienteVentas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxNombreClienteVentas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIngresarClienteVentas;
        private System.Windows.Forms.TextBox tboxCodigoClienteVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tboxDescuentoProductoVentas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboxCantidadProductoVentas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxCodigoProductoVentas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnQuitarProductosVentas;
        private System.Windows.Forms.Button btnIngresarProductoVentas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalVenta;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker CalendarTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitarioProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}