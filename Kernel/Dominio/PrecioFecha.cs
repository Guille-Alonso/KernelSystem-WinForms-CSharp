using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kernel.Dominio
{
    public class PrecioFecha
    {
        public virtual Producto Producto { get; set; }
        public Nullable<int> ProductoID { get; set; } //

        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public double CostoUnitario { get; set; }
        public double PrecioUnitario { get; set; }
        public double MargenDeGanancia
        {
            get
            {
                return Math.Truncate(PrecioUnitario - CostoUnitario);
            }
        }
        public double MargenDeGananciaPorcentaje
        {
            get
            {
                return ((PrecioUnitario - CostoUnitario) - 1) * 100;
            }
        }
        public PrecioFecha()
        {
            Fecha = DateTime.Now;
        }

    }
}
