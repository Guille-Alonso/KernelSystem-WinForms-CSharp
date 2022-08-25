using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kernel.Dominio
{
    public class Informe
    {
        public int Unidades { get; set; }
        public double Costo { get; set; }
        public double Ventas { get; set; }
        public double Margen
        {
            get
            {
                return Ventas - Costo;
            }
        }
        public Informe()
        {

        }

    }
}
