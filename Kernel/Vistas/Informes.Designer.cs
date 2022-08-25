namespace Kernel.Vistas
{
    partial class Informes
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
            this.GrillaInforme = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tboxDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIngresarProducto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CalendarDesde = new System.Windows.Forms.MonthCalendar();
            this.CalendarHasta = new System.Windows.Forms.MonthCalendar();
            this.btnGenerarInforme = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.unidadesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.margenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceInforme = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaInforme)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInforme)).BeginInit();
            this.SuspendLayout();
            // 
            // GrillaInforme
            // 
            this.GrillaInforme.AllowUserToOrderColumns = true;
            this.GrillaInforme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GrillaInforme.AutoGenerateColumns = false;
            this.GrillaInforme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaInforme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.unidadesDataGridViewTextBoxColumn,
            this.costoDataGridViewTextBoxColumn,
            this.ventasDataGridViewTextBoxColumn,
            this.margenDataGridViewTextBoxColumn});
            this.GrillaInforme.DataSource = this.bindingSourceInforme;
            this.GrillaInforme.Location = new System.Drawing.Point(12, 346);
            this.GrillaInforme.Name = "GrillaInforme";
            this.GrillaInforme.RowHeadersWidth = 51;
            this.GrillaInforme.RowTemplate.Height = 24;
            this.GrillaInforme.Size = new System.Drawing.Size(729, 171);
            this.GrillaInforme.TabIndex = 93;
            this.GrillaInforme.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tboxDescripcion);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tboxCodigo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnIngresarProducto);
            this.panel1.Location = new System.Drawing.Point(34, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 237);
            this.panel1.TabIndex = 6;
            // 
            // tboxDescripcion
            // 
            this.tboxDescripcion.Location = new System.Drawing.Point(3, 105);
            this.tboxDescripcion.Name = "tboxDescripcion";
            this.tboxDescripcion.ReadOnly = true;
            this.tboxDescripcion.Size = new System.Drawing.Size(382, 22);
            this.tboxDescripcion.TabIndex = 6;
            this.tboxDescripcion.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Descripcion";
            // 
            // tboxCodigo
            // 
            this.tboxCodigo.Location = new System.Drawing.Point(154, 28);
            this.tboxCodigo.Name = "tboxCodigo";
            this.tboxCodigo.Size = new System.Drawing.Size(100, 22);
            this.tboxCodigo.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Codigo";
            // 
            // btnIngresarProducto
            // 
            this.btnIngresarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarProducto.Location = new System.Drawing.Point(175, 169);
            this.btnIngresarProducto.Name = "btnIngresarProducto";
            this.btnIngresarProducto.Size = new System.Drawing.Size(116, 61);
            this.btnIngresarProducto.TabIndex = 1;
            this.btnIngresarProducto.Text = "Ingresar Producto";
            this.btnIngresarProducto.UseVisualStyleBackColor = true;
            this.btnIngresarProducto.Click += new System.EventHandler(this.btnIngresarProducto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(520, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 90;
            this.label1.Text = "DESDE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(892, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 92;
            this.label2.Text = "HASTA";
            // 
            // CalendarDesde
            // 
            this.CalendarDesde.Location = new System.Drawing.Point(438, 69);
            this.CalendarDesde.Name = "CalendarDesde";
            this.CalendarDesde.TabIndex = 2;
            // 
            // CalendarHasta
            // 
            this.CalendarHasta.Location = new System.Drawing.Point(796, 69);
            this.CalendarHasta.Name = "CalendarHasta";
            this.CalendarHasta.TabIndex = 3;
            // 
            // btnGenerarInforme
            // 
            this.btnGenerarInforme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGenerarInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarInforme.Location = new System.Drawing.Point(807, 346);
            this.btnGenerarInforme.Name = "btnGenerarInforme";
            this.btnGenerarInforme.Size = new System.Drawing.Size(183, 81);
            this.btnGenerarInforme.TabIndex = 4;
            this.btnGenerarInforme.Text = "Generar Informe";
            this.btnGenerarInforme.UseVisualStyleBackColor = true;
            this.btnGenerarInforme.Click += new System.EventHandler(this.btnGenerarInforme_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(681, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 91;
            this.label5.Text = "( 00 : 00 : 00 hs )";
            // 
            // unidadesDataGridViewTextBoxColumn
            // 
            this.unidadesDataGridViewTextBoxColumn.DataPropertyName = "Unidades";
            this.unidadesDataGridViewTextBoxColumn.HeaderText = "Unidades";
            this.unidadesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unidadesDataGridViewTextBoxColumn.Name = "unidadesDataGridViewTextBoxColumn";
            this.unidadesDataGridViewTextBoxColumn.Width = 125;
            // 
            // costoDataGridViewTextBoxColumn
            // 
            this.costoDataGridViewTextBoxColumn.DataPropertyName = "Costo";
            this.costoDataGridViewTextBoxColumn.HeaderText = "Costo";
            this.costoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costoDataGridViewTextBoxColumn.Name = "costoDataGridViewTextBoxColumn";
            this.costoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ventasDataGridViewTextBoxColumn
            // 
            this.ventasDataGridViewTextBoxColumn.DataPropertyName = "Ventas";
            this.ventasDataGridViewTextBoxColumn.HeaderText = "Ventas";
            this.ventasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ventasDataGridViewTextBoxColumn.Name = "ventasDataGridViewTextBoxColumn";
            this.ventasDataGridViewTextBoxColumn.Width = 125;
            // 
            // margenDataGridViewTextBoxColumn
            // 
            this.margenDataGridViewTextBoxColumn.DataPropertyName = "Margen";
            this.margenDataGridViewTextBoxColumn.HeaderText = "Margen";
            this.margenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.margenDataGridViewTextBoxColumn.Name = "margenDataGridViewTextBoxColumn";
            this.margenDataGridViewTextBoxColumn.ReadOnly = true;
            this.margenDataGridViewTextBoxColumn.Width = 125;
            // 
            // bindingSourceInforme
            // 
            this.bindingSourceInforme.DataSource = typeof(Kernel.Dominio.Informe);
            // 
            // Informes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 548);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGenerarInforme);
            this.Controls.Add(this.CalendarHasta);
            this.Controls.Add(this.CalendarDesde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GrillaInforme);
            this.Name = "Informes";
            this.Text = "INFORMES";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Informes_FormClosing);
            this.Load += new System.EventHandler(this.Informes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaInforme)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInforme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrillaInforme;
        private System.Windows.Forms.BindingSource bindingSourceInforme;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn margenDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tboxDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIngresarProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar CalendarDesde;
        private System.Windows.Forms.MonthCalendar CalendarHasta;
        private System.Windows.Forms.Button btnGenerarInforme;
        private System.Windows.Forms.Label label5;
    }
}