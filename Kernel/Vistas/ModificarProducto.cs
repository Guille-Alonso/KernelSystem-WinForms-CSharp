using Kernel.Controladores;
using Kernel.Datos;
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
    public partial class ModificarProducto : Form
    {
        private Productos _vista;
        private ControladorProductos _cp;
        private Producto _proViejo;
        public ModificarProducto(int id, Productos vista)
        {
            InitializeComponent();
            _cp = new ControladorProductos(this);
            CargarProductoAModificar(_cp.BuscarProducto(id));
          
            _vista = vista;

          
           Repositorio<Producto> repoProd = new Repositorio<Producto>();

            Producto producto = repoProd.GetAll().ToList().Single(p => p.Id.Equals(id));
          
            bindingSourcePrecioFecha.DataSource = producto.PrecioFechas.ToList();
           
        }
        public void CargarProductoAModificar(Producto pro)
        {
           
            _proViejo = new Producto() { PrecioUnitario = pro.PrecioUnitario, CostoUnitario = pro.CostoUnitario };
            bindingSourceModificarProducto.DataSource = pro;
           
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                var nuevo = bindingSourceModificarProducto.Current as Producto;
              
                _cp.ActualizarProducto(nuevo, _proViejo);
            }
            catch(Exception)
            {
                MessageBox.Show("Olvido completar campos");
            }
            
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
