namespace Kernel.Vistas
{
    partial class NuevoProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.tboxDescripcionProducto = new System.Windows.Forms.TextBox();
            this.bindingSourceNuevoProducto = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxStockProducto = new System.Windows.Forms.TextBox();
            this.tboxPrecioProducto = new System.Windows.Forms.TextBox();
            this.tboxCostoProducto = new System.Windows.Forms.TextBox();
            this.btnGuardarProducto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxCodigoProducto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNuevoProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DESCRIPCION :";
            // 
            // tboxDescripcionProducto
            // 
            this.tboxDescripcionProducto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceNuevoProducto, "Descripcion", true));
            this.tboxDescripcionProducto.Location = new System.Drawing.Point(405, 96);
            this.tboxDescripcionProducto.Name = "tboxDescripcionProducto";
            this.tboxDescripcionProducto.Size = new System.Drawing.Size(150, 22);
            this.tboxDescripcionProducto.TabIndex = 1;
            // 
            // bindingSourceNuevoProducto
            // 
            this.bindingSourceNuevoProducto.DataSource = typeof(Kernel.Dominio.Producto);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "STOCK :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(244, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "COSTO :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(244, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "PRECIO :";
            // 
            // tboxStockProducto
            // 
            this.tboxStockProducto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceNuevoProducto, "Stock", true));
            this.tboxStockProducto.Location = new System.Drawing.Point(403, 150);
            this.tboxStockProducto.Name = "tboxStockProducto";
            this.tboxStockProducto.Size = new System.Drawing.Size(100, 22);
            this.tboxStockProducto.TabIndex = 5;
            // 
            // tboxPrecioProducto
            // 
            this.tboxPrecioProducto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceNuevoProducto, "PrecioUnitario", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.tboxPrecioProducto.Location = new System.Drawing.Point(404, 204);
            this.tboxPrecioProducto.Name = "tboxPrecioProducto";
            this.tboxPrecioProducto.Size = new System.Drawing.Size(100, 22);
            this.tboxPrecioProducto.TabIndex = 6;
            // 
            // tboxCostoProducto
            // 
            this.tboxCostoProducto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceNuevoProducto, "CostoUnitario", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.tboxCostoProducto.Location = new System.Drawing.Point(404, 250);
            this.tboxCostoProducto.Name = "tboxCostoProducto";
            this.tboxCostoProducto.Size = new System.Drawing.Size(100, 22);
            this.tboxCostoProducto.TabIndex = 7;
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProducto.Location = new System.Drawing.Point(516, 364);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(223, 74);
            this.btnGuardarProducto.TabIndex = 8;
            this.btnGuardarProducto.Text = "Guardar Producto";
            this.btnGuardarProducto.UseVisualStyleBackColor = true;
            this.btnGuardarProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(244, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "CODIGO :";
            // 
            // tboxCodigoProducto
            // 
            this.tboxCodigoProducto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceNuevoProducto, "Id", true));
            this.tboxCodigoProducto.Location = new System.Drawing.Point(405, 49);
            this.tboxCodigoProducto.Name = "tboxCodigoProducto";
            this.tboxCodigoProducto.ReadOnly = true;
            this.tboxCodigoProducto.Size = new System.Drawing.Size(100, 22);
            this.tboxCodigoProducto.TabIndex = 10;
            this.tboxCodigoProducto.TabStop = false;
            // 
            // NuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tboxCodigoProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGuardarProducto);
            this.Controls.Add(this.tboxCostoProducto);
            this.Controls.Add(this.tboxPrecioProducto);
            this.Controls.Add(this.tboxStockProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxDescripcionProducto);
            this.Controls.Add(this.label1);
            this.Name = "NuevoProducto";
            this.Text = "NUEVO PRODUCTO";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNuevoProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxDescripcionProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxStockProducto;
        private System.Windows.Forms.TextBox tboxPrecioProducto;
        private System.Windows.Forms.TextBox tboxCostoProducto;
        private System.Windows.Forms.BindingSource bindingSourceNuevoProducto;
        private System.Windows.Forms.Button btnGuardarProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxCodigoProducto;
    }
}