using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kernel.Dominio
{
   public class LineaFactura
    {
        public double Descuento { get; set; }

        public double Total
        {
            get
            {
                return (Cantidad * precioUnitarioProducto) - (Cantidad * precioUnitarioProducto * (Descuento / 100));

            }
        }

        public int Cantidad { get; set; }
        public string descripcionProducto { get; set; }      
     
        public double precioUnitarioProducto { get; set; }
        
        public int ProductoCodigo { get; set; }
       
        public LineaFactura()
        {

        }
    }
}
