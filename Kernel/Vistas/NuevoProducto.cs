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
    public partial class NuevoProducto : Form
    {
       
        private ControladorProductos _cp;
        private Productos _vista;
        public NuevoProducto(Productos vista)
        {
            InitializeComponent();
            _cp = new ControladorProductos(this);
            _vista = vista;
        }

        public void CargarProducto(Producto pro)
        {
            bindingSourceNuevoProducto.DataSource = pro;
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
                _cp.GuardarProducto();
               
        }
        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        public void ActualizarGrillaProductos()
        {
            _vista.ActualizarGrilla();
            Close();
        }
    }
}
