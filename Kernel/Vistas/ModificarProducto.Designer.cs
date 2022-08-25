namespace Kernel.Vistas
{
    partial class ModificarProducto
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
            this.tboxPrecioUnitarioProducto = new System.Windows.Forms.TextBox();
            this.bindingSourceModificarProducto = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tboxCostoUnitarioProducto = new System.Windows.Forms.TextBox();
            this.tboxStockProducto = new System.Windows.Forms.TextBox();
            this.tboxDescripcionProducto = new System.Windows.Forms.TextBox();
            this.tboxCodigoProducto = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.margenDeGananciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourcePrecioFecha = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceModificarProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePrecioFecha)).BeginInit();
            this.SuspendLayout();
            // 
            // tboxPrecioUnitarioProducto
            // 
            this.tboxPrecioUnitarioProducto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceModificarProducto, "PrecioUnitario", true));
            this.tboxPrecioUnitarioProducto.Location = new System.Drawing.Point(316, 87);
            this.tboxPrecioUnitarioProducto.Name = "tboxPrecioUnitarioProducto";
            this.tboxPrecioUnitarioProducto.Size = new System.Drawing.Size(100, 22);
            this.tboxPrecioUnitarioProducto.TabIndex = 0;
            // 
            // bindingSourceModificarProducto
            // 
            this.bindingSourceModificarProducto.DataSource = typeof(Kernel.Dominio.Producto);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Precio Unitario";
            // 
            // tboxCostoUnitarioProducto
            // 
            this.tboxCostoUnitarioProducto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceModificarProducto, "CostoUnitario", true));
            this.tboxCostoUnitarioProducto.Location = new System.Drawing.Point(316, 134);
            this.tboxCostoUnitarioProducto.Name = "tboxCostoUnitarioProducto";
            this.tboxCostoUnitarioProducto.Size = new System.Drawing.Size(100, 22);
            this.tboxCostoUnitarioProducto.TabIndex = 1;
            // 
            // tboxStockProducto
            // 
            this.tboxStockProducto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceModificarProducto, "Stock", true));
            this.tboxStockProducto.Location = new System.Drawing.Point(316, 205);
            this.tboxStockProducto.Name = "tboxStockProducto";
            this.tboxStockProducto.Size = new System.Drawing.Size(100, 22);
            this.tboxStockProducto.TabIndex = 2;
            // 
            // tboxDescripcionProducto
            // 
            this.tboxDescripcionProducto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceModificarProducto, "Descripcion", true));
            this.tboxDescripcionProducto.Location = new System.Drawing.Point(316, 256);
            this.tboxDescripcionProducto.Name = "tboxDescripcionProducto";
            this.tboxDescripcionProducto.Size = new System.Drawing.Size(100, 22);
            this.tboxDescripcionProducto.TabIndex = 3;
            // 
            // tboxCodigoProducto
            // 
            this.tboxCodigoProducto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceModificarProducto, "Id", true));
            this.tboxCodigoProducto.Location = new System.Drawing.Point(316, 21);
            this.tboxCodigoProducto.Name = "tboxCodigoProducto";
            this.tboxCodigoProducto.ReadOnly = true;
            this.tboxCodigoProducto.Size = new System.Drawing.Size(100, 22);
            this.tboxCodigoProducto.TabIndex = 5;
            this.tboxCodigoProducto.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.fechaDataGridViewTextBoxColumn,
            this.costoUnitarioDataGridViewTextBoxColumn,
            this.precioUnitarioDataGridViewTextBoxColumn,
            this.margenDeGananciaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSourcePrecioFecha;
            this.dataGridView1.Location = new System.Drawing.Point(60, 338);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(681, 150);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.TabStop = false;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.Width = 125;
            // 
            // costoUnitarioDataGridViewTextBoxColumn
            // 
            this.costoUnitarioDataGridViewTextBoxColumn.DataPropertyName = "CostoUnitario";
            this.costoUnitarioDataGridViewTextBoxColumn.HeaderText = "CostoUnitario";
            this.costoUnitarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costoUnitarioDataGridViewTextBoxColumn.Name = "costoUnitarioDataGridViewTextBoxColumn";
            this.costoUnitarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // precioUnitarioDataGridViewTextBoxColumn
            // 
            this.precioUnitarioDataGridViewTextBoxColumn.DataPropertyName = "PrecioUnitario";
            this.precioUnitarioDataGridViewTextBoxColumn.HeaderText = "PrecioUnitario";
            this.precioUnitarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioUnitarioDataGridViewTextBoxColumn.Name = "precioUnitarioDataGridViewTextBoxColumn";
            this.precioUnitarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // margenDeGananciaDataGridViewTextBoxColumn
            // 
            this.margenDeGananciaDataGridViewTextBoxColumn.DataPropertyName = "MargenDeGanancia";
            this.margenDeGananciaDataGridViewTextBoxColumn.HeaderText = "MargenDeGanancia";
            this.margenDeGananciaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.margenDeGananciaDataGridViewTextBoxColumn.Name = "margenDeGananciaDataGridViewTextBoxColumn";
            this.margenDeGananciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.margenDeGananciaDataGridViewTextBoxColumn.Width = 125;
            // 
            // bindingSourcePrecioFecha
            // 
            this.bindingSourcePrecioFecha.DataSource = typeof(Kernel.Dominio.PrecioFecha);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Costo Unitario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(143, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(189, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Codigo";
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.Location = new System.Drawing.Point(584, 118);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(108, 54);
            this.btnModificarProducto.TabIndex = 4;
            this.btnModificarProducto.Text = "Modificar";
            this.btnModificarProducto.UseVisualStyleBackColor = true;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // ModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 537);
            this.Controls.Add(this.btnModificarProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tboxCodigoProducto);
            this.Controls.Add(this.tboxDescripcionProducto);
            this.Controls.Add(this.tboxStockProducto);
            this.Controls.Add(this.tboxCostoUnitarioProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxPrecioUnitarioProducto);
            this.Name = "ModificarProducto";
            this.Text = "MODIFICAR PRODUCTO";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceModificarProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePrecioFecha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSourceModificarProducto;
        private System.Windows.Forms.TextBox tboxPrecioUnitarioProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxCostoUnitarioProducto;
        private System.Windows.Forms.TextBox tboxStockProducto;
        private System.Windows.Forms.TextBox tboxDescripcionProducto;
        private System.Windows.Forms.TextBox tboxCodigoProducto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSourcePrecioFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn margenDeGananciaDataGridViewTextBoxColumn;
    }
}