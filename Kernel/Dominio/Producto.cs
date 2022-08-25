using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kernel.Dominio
{
    public class Producto
    {
        public virtual ICollection<PrecioFecha> PrecioFechas { get; set; }
       public virtual ICollection<LineaDeVenta> LineaDeVentas { get; set; }
      
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public bool Bandera { get; set; }
        public int Stock  { get; set; }
        public List<PrecioFecha> ListaPrecioFecha { get; set; } 
        public double CostoUnitario { get; set; }
         public double PrecioUnitario { get; set; }
        public double MargenDeGanancia
        {
            get
            {
                //return PrecioUnitario - CostoUnitario;
                return Math.Truncate((PrecioUnitario - CostoUnitario) * 100) / 100;
            }
        }
        public double MargenDeGananciaPorcentaje
        {
            get
            {
                return Math.Truncate(((PrecioUnitario / CostoUnitario) - 1) * 100);
            }
        }

        public Producto(int id)
        {
            ListaPrecioFecha = new List<PrecioFecha>();
            Id = id;
            Bandera = true;

            this.PrecioFechas = new HashSet<PrecioFecha>(); 
           this.LineaDeVentas = new HashSet<LineaDeVenta>();
        }

        public Producto()
        {
            
        }
        public double ObtenerPrecioFecha(DateTime fechaVenta, LineaDeVenta lv)
        {
            DateTime fechaAux = new DateTime(2000, 10, 10, 9, 0, 0);
            PrecioFecha precioFinal = new PrecioFecha();
            precioFinal.Fecha = fechaAux;
            bool bandera = false;

            foreach (PrecioFecha pf in PrecioFechas)
            {
                if(DateTime.Compare(pf.Fecha,fechaVenta) < 0)     
                {
                    bandera = true;
                    if (DateTime.Compare(precioFinal.Fecha, pf.Fecha) < 0)
                    {
                        precioFinal = pf;
                    }
                }
            }
            if (bandera == true)
            {
                return lv.CalcularPrecioUnitarioDescuento(precioFinal.PrecioUnitario);
            }
            else return lv.Total;
           
        }

        public double ObtenerCostoFecha(DateTime fechaVenta, LineaDeVenta lv)
        {
            DateTime fechaAux = new DateTime(2000, 10, 10, 9, 0, 0);
            PrecioFecha precioFinal = new PrecioFecha();
            precioFinal.Fecha = fechaAux;
            bool bandera = false;

            foreach (PrecioFecha pf in PrecioFechas)
            {
                if (DateTime.Compare(pf.Fecha, fechaVenta) < 0)
                {
                    bandera = true;
                    if (DateTime.Compare(precioFinal.Fecha, pf.Fecha) < 0)
                    {
                        precioFinal = pf;
                    }
                }
            }
            if (bandera == true)
            {
                return precioFinal.CostoUnitario * lv.Cantidad;
            }else return lv.Producto.CostoUnitario * lv.Cantidad;
            
        }

        public double ObtenerPrecioUnitarioDelPrecioFecha(DateTime fechaVenta)
        {
            DateTime fechaAux = new DateTime(2000, 10, 10, 9, 0, 0);
            PrecioFecha precioFinal = new PrecioFecha();
            precioFinal.Fecha = fechaAux;


            foreach (PrecioFecha pf in PrecioFechas)
            {
                if (DateTime.Compare(pf.Fecha, fechaVenta) < 0)
                {

                    if (DateTime.Compare(precioFinal.Fecha, pf.Fecha) < 0)
                    {
                        precioFinal = pf;
                    }
                }
            }
            return precioFinal.PrecioUnitario;
        }
    }
}
