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
    public partial class Clientes : Form
    {
 
        private ControladorCliente _cc;
        public Clientes()
        {
            InitializeComponent();
           
            _cc = new ControladorCliente();
            ActualizarGrillaClientes();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            new NuevoCliente(this).ShowDialog();
        }

        public void ActualizarGrillaClientes()
        {
            GrillaClientes.DataSource = "";
            GrillaClientes.DataSource = _cc.ListarClientes();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                var valor = GrillaClientes.Rows[GrillaClientes.CurrentRow.Index].Cells[0].Value.ToString();
                new ModificarCliente(int.Parse(valor), this).ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar un Cliente");
            }
           
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (MessageBox.Show("Realmente desea borrar?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    _cc = new ControladorCliente(int.Parse(GrillaClientes.Rows[GrillaClientes.CurrentRow.Index].Cells[0].Value.ToString()), this);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar un Cliente");
            }
        }

        private void tboxBuscarClienteNombre_TextChanged(object sender, EventArgs e)
        {
            ControladorCliente cc = new ControladorCliente(this);
            cc.FiltrarClientes(tboxBuscarClienteNombre.Text);
            cc.Dispose();
        }

        public void FiltrarClientes(IEnumerable<Cliente> lista)
        {
            GrillaClientes.DataSource = "";
            GrillaClientes.DataSource = lista.ToList();
        }
    }
}
