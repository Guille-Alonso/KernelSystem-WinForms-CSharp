using Kernel.Dominio;
using Kernel.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kernel.Controladores
{
   public class ControladorImpresion
    {
        private ImprimirFactura _vistaFactura;
        private Venta _venta;
        private List<LineaFactura> _lf;
        public ControladorImpresion(ImprimirFactura vista, Venta venta)
        {
            _vistaFactura = vista;
            _venta = venta;
            _lf = new List<LineaFactura>();
            GenerarFactura();
        }
        public ControladorImpresion()
        {
            
        }
        private void GenerarFactura()
        {
            foreach (LineaDeVenta lv in _venta.LineaDeVentas)
            {
                _lf.Add(new LineaFactura() { Cantidad = lv.Cantidad, descripcionProducto = lv.descripcionProducto, Descuento = lv.Descuento, ProductoCodigo = lv.ProductoCodigo, precioUnitarioProducto = lv.Producto.ObtenerPrecioUnitarioDelPrecioFecha(_venta.Fecha)});

            }
            _vistaFactura.CargarVentaEnFactura(_lf);
        }

        public List<LineaFactura> ObtenerLineasDeVenta(Venta ventaFantasma)
        {
            List<LineaFactura> lista = new List<LineaFactura>();
            foreach (LineaDeVenta lv in ventaFantasma.LineaDeVentas)
            {
                lista.Add(new LineaFactura() { Cantidad = lv.Cantidad, descripcionProducto = lv.descripcionProducto, Descuento = lv.Descuento, ProductoCodigo = lv.ProductoCodigo, precioUnitarioProducto = lv.Producto.ObtenerPrecioUnitarioDelPrecioFecha(ventaFantasma.Fecha) });

            }
            return lista;
        }
    }
}
