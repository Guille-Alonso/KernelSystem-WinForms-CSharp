namespace Kernel.Vistas
{
    partial class NuevoCliente
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
            this.label2 = new System.Windows.Forms.Label();
            this.tboxNombreCliente = new System.Windows.Forms.TextBox();
            this.tboxDomicilioCliente = new System.Windows.Forms.TextBox();
            this.btnGuardarCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxIdCliente = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bindingSourceNuevoCliente = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNuevoCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "DOMICILIO :";
            // 
            // tboxNombreCliente
            // 
            this.tboxNombreCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceNuevoCliente, "Nombre", true));
            this.tboxNombreCliente.Location = new System.Drawing.Point(388, 106);
            this.tboxNombreCliente.Name = "tboxNombreCliente";
            this.tboxNombreCliente.Size = new System.Drawing.Size(100, 22);
            this.tboxNombreCliente.TabIndex = 2;
            // 
            // tboxDomicilioCliente
            // 
            this.tboxDomicilioCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceNuevoCliente, "Direccion", true));
            this.tboxDomicilioCliente.Location = new System.Drawing.Point(388, 167);
            this.tboxDomicilioCliente.Name = "tboxDomicilioCliente";
            this.tboxDomicilioCliente.Size = new System.Drawing.Size(100, 22);
            this.tboxDomicilioCliente.TabIndex = 3;
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCliente.Location = new System.Drawing.Point(532, 331);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(154, 69);
            this.btnGuardarCliente.TabIndex = 6;
            this.btnGuardarCliente.Text = "Guardar Cliente";
            this.btnGuardarCliente.UseVisualStyleBackColor = true;
            this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardarCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(306, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID :";
            // 
            // tboxIdCliente
            // 
            this.tboxIdCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceNuevoCliente, "Id", true));
            this.tboxIdCliente.Location = new System.Drawing.Point(388, 46);
            this.tboxIdCliente.Name = "tboxIdCliente";
            this.tboxIdCliente.ReadOnly = true;
            this.tboxIdCliente.Size = new System.Drawing.Size(100, 22);
            this.tboxIdCliente.TabIndex = 6;
            this.tboxIdCliente.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceNuevoCliente, "Cuit", true));
            this.textBox1.Location = new System.Drawing.Point(388, 224);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(240, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "CUIT :";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceNuevoCliente, "Telefono", true));
            this.textBox2.Location = new System.Drawing.Point(388, 279);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(240, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "TELEFONO :";
            // 
            // bindingSourceNuevoCliente
            // 
            this.bindingSourceNuevoCliente.DataSource = typeof(Kernel.Dominio.Cliente);
            // 
            // NuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tboxIdCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGuardarCliente);
            this.Controls.Add(this.tboxDomicilioCliente);
            this.Controls.Add(this.tboxNombreCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NuevoCliente";
            this.Text = "NUEVO CLIENTE";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNuevoCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxNombreCliente;
        private System.Windows.Forms.BindingSource bindingSourceNuevoCliente;
        private System.Windows.Forms.TextBox tboxDomicilioCliente;
        private System.Windows.Forms.Button btnGuardarCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxIdCliente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
    }
}