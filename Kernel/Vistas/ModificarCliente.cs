using Kernel.Controladores;
using Kernel.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kernel.Vistas
{
    public partial class ModificarCliente : Form
    {
        private Clientes _vista;
        private ControladorCliente _cc;
        public ModificarCliente(int id, Clientes vista)
        {
            InitializeComponent();
            _cc = new ControladorCliente(this);
            _vista = vista;

            CargarClienteAModificar(_cc.BuscarCliente(id));

            _vista = vista;
            
        }
        public void CargarClienteAModificar(Cliente c)
        {
           
            bindingSourceModificaCliente.DataSource = c;
        }

        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        public void ActualizarGrillaClientes()
        {
            _vista.ActualizarGrillaClientes();
            Close();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            
            var nuevo = bindingSourceModificaCliente.Current as Cliente;
            _cc.ActualizarCliente(nuevo);
            
        }
    }
}

