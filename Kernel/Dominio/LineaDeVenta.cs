using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kernel.Dominio
{
    public class LineaDeVenta
    {
        public virtual Venta Venta { get; set; }
        public Nullable<int> nroVenta { get; set; }

        public int Cantidad { get; set; }
        public int Id { get; set; }

        public double Descuento { get; set; }

        public double Total
        {
            get
            {
                return (Cantidad * precioUnitarioProducto) - (Cantidad * precioUnitarioProducto * (Descuento / 100));

            }
        }
       

        public virtual Producto Producto { get; set; } //

        public Nullable<int> ProductoID { get; set; }


        public string descripcionProducto
        {
            get
            {
                return Producto?.Descripcion;
            }
            set { }
        }
        public double precioUnitarioProducto
        {
            get
            {
                return Producto.PrecioUnitario;
            }
           
        }
        public int ProductoCodigo
        {
            get
            {
                return Producto.Id;
            }
        }

            
        public LineaDeVenta()
        {

        }

        public double CalcularTotalLineaVentaConPrecioFecha(PrecioFecha pf)
        {
            return (Cantidad * pf.PrecioUnitario) - (Cantidad * pf.PrecioUnitario * (Descuento / 100));
        }

        public double CalcularPrecioUnitarioDescuento(double precio)
        {
            return (precio - (precio * (Descuento / 100))) * Cantidad;
        }
    }
}
