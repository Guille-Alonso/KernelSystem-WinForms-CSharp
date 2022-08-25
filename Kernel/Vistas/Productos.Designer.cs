namespace Kernel.Vistas
{
    partial class Productos
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
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.tboxBuscarProductoDescripcion = new System.Windows.Forms.TextBox();
            this.lblBuscarProducto = new System.Windows.Forms.Label();
            this.GrillaProductos = new System.Windows.Forms.DataGridView();
            this.bindingSourceProductos = new System.Windows.Forms.BindingSource(this.components);
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.margenDeGananciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.margenDeGananciaPorcentajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProducto.Location = new System.Drawing.Point(12, 12);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(146, 64);
            this.btnNuevoProducto.TabIndex = 0;
            this.btnNuevoProducto.Text = "Nuevo Producto";
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProducto.Location = new System.Drawing.Point(540, 12);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(135, 64);
            this.btnModificarProducto.TabIndex = 1;
            this.btnModificarProducto.Text = "Modificar Producto";
            this.btnModificarProducto.UseVisualStyleBackColor = true;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProducto.Location = new System.Drawing.Point(751, 12);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(117, 64);
            this.btnEliminarProducto.TabIndex = 2;
            this.btnEliminarProducto.Text = "Eliminar Producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // tboxBuscarProductoDescripcion
            // 
            this.tboxBuscarProductoDescripcion.Location = new System.Drawing.Point(360, 129);
            this.tboxBuscarProductoDescripcion.Name = "tboxBuscarProductoDescripcion";
            this.tboxBuscarProductoDescripcion.Size = new System.Drawing.Size(355, 22);
            this.tboxBuscarProductoDescripcion.TabIndex = 3;
            this.tboxBuscarProductoDescripcion.TextChanged += new System.EventHandler(this.tboxBuscarProductoDescripcion_TextChanged);
            // 
            // lblBuscarProducto
            // 
            this.lblBuscarProducto.AutoSize = true;
            this.lblBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarProducto.Location = new System.Drawing.Point(89, 129);
            this.lblBuscarProducto.Name = "lblBuscarProducto";
            this.lblBuscarProducto.Size = new System.Drawing.Size(250, 20);
            this.lblBuscarProducto.TabIndex = 4;
            this.lblBuscarProducto.Text = "BUSCAR POR DESCRIPCION :";
            // 
            // GrillaProductos
            // 
            this.GrillaProductos.AllowUserToOrderColumns = true;
            this.GrillaProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrillaProductos.AutoGenerateColumns = false;
            this.GrillaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.descripcionDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.costoUnitarioDataGridViewTextBoxColumn,
            this.precioUnitarioDataGridViewTextBoxColumn,
            this.margenDeGananciaDataGridViewTextBoxColumn,
            this.margenDeGananciaPorcentajeDataGridViewTextBoxColumn});
            this.GrillaProductos.DataSource = this.bindingSourceProductos;
            this.GrillaProductos.Location = new System.Drawing.Point(1, 226);
            this.GrillaProductos.Name = "GrillaProductos";
            this.GrillaProductos.RowHeadersWidth = 51;
            this.GrillaProductos.RowTemplate.Height = 24;
            this.GrillaProductos.Size = new System.Drawing.Size(1187, 150);
            this.GrillaProductos.TabIndex = 5;
            // 
            // bindingSourceProductos
            // 
            this.bindingSourceProductos.DataSource = typeof(Kernel.Dominio.Producto);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockDataGridViewTextBoxColumn.Width = 125;
            // 
            // costoUnitarioDataGridViewTextBoxColumn
            // 
            this.costoUnitarioDataGridViewTextBoxColumn.DataPropertyName = "CostoUnitario";
            this.costoUnitarioDataGridViewTextBoxColumn.HeaderText = "Costo Unitario";
            this.costoUnitarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costoUnitarioDataGridViewTextBoxColumn.Name = "costoUnitarioDataGridViewTextBoxColumn";
            this.costoUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.costoUnitarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // precioUnitarioDataGridViewTextBoxColumn
            // 
            this.precioUnitarioDataGridViewTextBoxColumn.DataPropertyName = "PrecioUnitario";
            this.precioUnitarioDataGridViewTextBoxColumn.HeaderText = "Precio Unitario";
            this.precioUnitarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioUnitarioDataGridViewTextBoxColumn.Name = "precioUnitarioDataGridViewTextBoxColumn";
            this.precioUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioUnitarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // margenDeGananciaDataGridViewTextBoxColumn
            // 
            this.margenDeGananciaDataGridViewTextBoxColumn.DataPropertyName = "MargenDeGanancia";
            this.margenDeGananciaDataGridViewTextBoxColumn.HeaderText = "Ganancia";
            this.margenDeGananciaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.margenDeGananciaDataGridViewTextBoxColumn.Name = "margenDeGananciaDataGridViewTextBoxColumn";
            this.margenDeGananciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.margenDeGananciaDataGridViewTextBoxColumn.Width = 125;
            // 
            // margenDeGananciaPorcentajeDataGridViewTextBoxColumn
            // 
            this.margenDeGananciaPorcentajeDataGridViewTextBoxColumn.DataPropertyName = "MargenDeGananciaPorcentaje";
            this.margenDeGananciaPorcentajeDataGridViewTextBoxColumn.HeaderText = "Ganancia %%%%";
            this.margenDeGananciaPorcentajeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.margenDeGananciaPorcentajeDataGridViewTextBoxColumn.Name = "margenDeGananciaPorcentajeDataGridViewTextBoxColumn";
            this.margenDeGananciaPorcentajeDataGridViewTextBoxColumn.ReadOnly = true;
            this.margenDeGananciaPorcentajeDataGridViewTextBoxColumn.Width = 125;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 450);
            this.Controls.Add(this.GrillaProductos);
            this.Controls.Add(this.lblBuscarProducto);
            this.Controls.Add(this.tboxBuscarProductoDescripcion);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnModificarProducto);
            this.Controls.Add(this.btnNuevoProducto);
            this.Name = "Productos";
            this.Text = "GESTION PRODUCTOS";
            ((System.ComponentModel.ISupportInitialize)(this.GrillaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.TextBox tboxBuscarProductoDescripcion;
        private System.Windows.Forms.Label lblBuscarProducto;
        private System.Windows.Forms.DataGridView GrillaProductos;
        private System.Windows.Forms.BindingSource bindingSourceProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn margenDeGananciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn margenDeGananciaPorcentajeDataGridViewTextBoxColumn;
    }
}