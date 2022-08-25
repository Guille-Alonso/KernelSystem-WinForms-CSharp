
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kernel.Dominio
{
    public class Venta
    {
        public virtual ICollection<LineaDeVenta> LineaDeVentas { get; set; }


        public int nroVenta { get; set; }

        public DateTime Fecha { get; set; } 
        public double Total 
        {
            get
            {
                return CalcularTotal();
            }
        }

        public virtual Cliente Cliente { get; set; }
        public Nullable<int> ClienteId { get; set; }

        public string NombreCliente
        {
            get
            {
                return Cliente?.Nombre;
            }
        }
        public List<LineaDeVenta> LineasDeVentas { get; set; }
        public Venta(int nro)
        {
            LineasDeVentas = new List<LineaDeVenta>();
            nroVenta = nro;

            this.LineaDeVentas = new HashSet<LineaDeVenta>(); 
        }
        public Venta()
        {
            this.LineaDeVentas = new HashSet<LineaDeVenta>(); 
        }
        public double CalcularTotal()
        {
            
            double aux = 0;
          
            foreach (LineaDeVenta lv in LineaDeVentas)
            {
                DateTime fechaAux = new DateTime(2000, 10, 10, 9, 0, 0);
                PrecioFecha precioFinal = new PrecioFecha();
                precioFinal.Fecha = fechaAux;
                bool bandera = false;
                foreach (PrecioFecha pf in lv.Producto.PrecioFechas)
                {
                    
                    if (DateTime.Compare(pf.Fecha, Fecha) < 0)
                    {
                        bandera = true;
                        if (DateTime.Compare(precioFinal.Fecha , pf.Fecha) < 0)
                        {
                            precioFinal = pf;
                        }
                    }
                    
                }
                if (bandera == false)
                {
                    aux = aux + lv.Total;
                }
                else
                {
                    aux = aux + lv.CalcularTotalLineaVentaConPrecioFecha(precioFinal);
                 //aqui iba lo del precio prod
                }

            }
            return aux;
        }

        public double CalcularTotalParcial()
        {
            double aux = 0;
            foreach (LineaDeVenta lv in LineaDeVentas)
            {
                aux = aux + lv.Total;
            }
            return aux;

        }

    }
}
