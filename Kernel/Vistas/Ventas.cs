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
    public partial class Ventas : Form 
    {
        private ControladorVentas _cv;
        public bool _bandera = false; 
        public Ventas()
        {
            InitializeComponent();
            GrillaLineasDeVenta.DataSource = null;
            _cv = new ControladorVentas(this);
        }
       
        private void btnIngresarProductoVentas_Click_1(object sender, EventArgs e)
        {
            try
            {
                int cod = int.Parse(tboxCodigoProductoVentas.Text);
                int cant = int.Parse(tboxCantidadProductoVentas.Text);
                int desc = int.Parse(tboxDescuentoProductoVentas.Text);

                _cv.CrearYAgregarLineaVenta(cod, cant, desc,_bandera);
                LimpiarContenedorProducto();
                tboxCodigoProductoVentas.Select();
            }
            catch (Exception)
            {
                MostrarMensaje("Debe completar los campos correctamente");
                tboxCodigoProductoVentas.Select();
            }

        }
        
        public void LimpiarContenedorProducto()
        {
            tboxCantidadProductoVentas.Clear();
            tboxCodigoProductoVentas.Clear();
            tboxDescuentoProductoVentas.Clear();
        }
        public void LimpiarContenedorCliente()
        {
            tboxNombreClienteVentas.Clear();
            tboxDomicilioClienteVentas.Clear();
            tboxCodigoClienteVentas.Clear();

        }
        public void LimpiarGrillaVentas()
        {
            GrillaLineasDeVenta.DataSource = "";
            
        }
        public void ActualizarGrillaVentas(List<LineaDeVenta> llv)
        {
            GrillaLineasDeVenta.DataSource = "";
            GrillaLineasDeVenta.DataSource = llv.ToList();
            
        }

        public void ActualizarGrillaVentas(List<LineaFactura> llvAux)
        {
            GrillaLineasDeVenta.DataSource = "";
            GrillaLineasDeVenta.DataSource = llvAux.ToList();
        }
        public void ActualizarTotalVenta(Venta venta)
        {
            lblTotalVenta.Text = venta.CalcularTotalParcial().ToString();
        }
        private void btnQuitarProductosVentas_Click(object sender, EventArgs e)
        {
            try
            {
                var codigoProducto = GrillaLineasDeVenta.Rows[GrillaLineasDeVenta.CurrentRow.Index].Cells[0].Value.ToString();
                _cv.QuitarLineaVenta(int.Parse(codigoProducto),_bandera); 
                
            }
            catch (Exception)
            {
                MostrarMensaje("Olvido seleccionar un producto");
            }
          
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            
            DateTime fechahora = CalendarTime.Value;
            _cv.RegistrarVenta(fechahora, _bandera);
        }

        private void btnConsultarVentas_Click(object sender, EventArgs e)
        {
            new ConsultarVentas(this).ShowDialog();
        }

        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void btnIngresarClienteVentas_Click(object sender, EventArgs e)
        {
            try
            {
                _cv.CargarClienteVenta(int.Parse(tboxCodigoClienteVentas.Text), _bandera);
            }
            catch (Exception)
            {
                MostrarMensaje("debe ingresar un cliente");
                LimpiarContenedorCliente();
                tboxCodigoClienteVentas.Select();
            }
        }
        public void MostrarCliente(Cliente c)
        {
            tboxNombreClienteVentas.Text = c.Nombre;
            tboxDomicilioClienteVentas.Text = c.Direccion;
            tboxCodigoClienteVentas.Text = c.Id.ToString();
        }

        //public void CargarVentaAModificar(Venta v, ControladorVentas cv)
        //{
        //    _cv = cv;

        //    GrillaLineasDeVenta.DataSource = v.LineaDeVentas.ToList();

        //    CalendarTime.Value = v.Fecha;

        //    lblTotalVenta.Text = v.Total.ToString();
        //    _bandera = true;
        //    _cv.CargarClienteVenta(v.ClienteId, _bandera);
        //}

        public void CargarVentaAModificar(Venta v, ControladorVentas cv, List<LineaFactura> lista)
        {
            _cv = cv;

            GrillaLineasDeVenta.DataSource = lista;

            CalendarTime.Value = v.Fecha;

            lblTotalVenta.Text = v.Total.ToString();
            _bandera = true;
            _cv.CargarClienteVenta(v.ClienteId, _bandera);
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            new NuevoCliente(new Clientes()).ShowDialog();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            tboxCodigoClienteVentas.Select();
        }
    }
}
