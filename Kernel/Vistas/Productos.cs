using Kernel.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kernel.Dominio;

namespace Kernel.Vistas
{
    public partial class Productos : Form
    {
        private ControladorProductos _cp;
        public Productos()
        {
            InitializeComponent();
            
            _cp = new ControladorProductos();
            ActualizarGrilla();
        }
      
        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                var valor = GrillaProductos.Rows[GrillaProductos.CurrentRow.Index].Cells[0].Value.ToString();
                new ModificarProducto(int.Parse(valor), this).ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar un Producto");
            }
         
        }

        public void ActualizarGrilla()
        {
            GrillaProductos.DataSource = "";
            GrillaProductos.DataSource = _cp.ListarProductos();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            new NuevoProducto(this).ShowDialog();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Realmente desea borrar?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    _cp = new ControladorProductos(int.Parse(GrillaProductos.Rows[GrillaProductos.CurrentRow.Index].Cells[0].Value.ToString()), this);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar un Producto");
            }
        }

        private void tboxBuscarProductoDescripcion_TextChanged(object sender, EventArgs e)
        {
            ControladorProductos cp = new ControladorProductos(this);
            cp.FiltrarProductos(tboxBuscarProductoDescripcion.Text);
            cp.Dispose();
        }

        public void FiltrarProductos(IEnumerable<Producto> lista)
        {
            GrillaProductos.DataSource = "";
            GrillaProductos.DataSource = lista.ToList();
        }
    }
}
