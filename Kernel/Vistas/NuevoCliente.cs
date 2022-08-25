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
    public partial class NuevoCliente : Form
    {
        private ControladorCliente _cc;
        private Clientes _vista;
        public NuevoCliente(Clientes vista)
        {
            InitializeComponent();
            _cc = new ControladorCliente(this);
            _vista = vista;
        }
       
        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            _cc.GuardarCliente();
           // _vista.ActualizarGrillaClientes();
        }

        public void CargarCliente(Cliente c)
        {
            bindingSourceNuevoCliente.DataSource = c;
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
    }
}
