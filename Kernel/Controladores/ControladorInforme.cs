using Kernel.Datos;
using Kernel.Dominio;
using Kernel.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kernel.Controladores
{
    public class ControladorInforme
    {
        private Informes _vista;
        private Producto _pro;
        private Repositorio<Producto> _RepoProducto;
        private Repositorio<Venta> _RepoVenta;
        public ControladorInforme(Informes vista)
        {
            _vista = vista;
            _RepoProducto = new Repositorio<Producto>();
            _RepoVenta = new Repositorio<Venta>(); 
        }

        public void CargarProducto(int codigo)
        {
            try
            {
                _pro = _RepoProducto.GetAll().ToList().Single(p => p.Id.Equals(codigo) && p.Bandera == true);
            }
            catch (Exception)
            {
                _vista.MostrarMensaje("Producto no existente");
                _pro = null;
                _vista.LimpiarProducto();
            }
            
            if (_pro != null)
            {
                _vista.CargarProducto(_pro);
                _vista.LimpiarGrilla();
            }
            //else _vista.MostrarMensaje("Producto no existente");
            
        }

        public void GenerarInforme(DateTime desde, DateTime hasta)
        {
            Informe info = new Informe();
            List<Informe> li = new List<Informe>();
            
            if (_pro != null)
            {
              
                foreach (Venta v in _RepoVenta.GetAll().ToList())
                {
                    int comparacion1 = DateTime.Compare(desde, v.Fecha);
                    int comparacion2 = DateTime.Compare(v.Fecha, hasta);
                    if (comparacion1 < 0 && comparacion2 < 0 && SeEncuentraElProducto(v))
                    {
                        foreach (LineaDeVenta lv in v.LineaDeVentas)
                        {
                            if (lv.Producto.Id == _pro.Id)
                            {
                                info.Unidades = info.Unidades + lv.Cantidad;
                                info.Ventas = info.Ventas + lv.Producto.ObtenerPrecioFecha(v.Fecha, lv);
                                info.Costo = info.Costo + lv.Producto.ObtenerCostoFecha(v.Fecha, lv);
                            }
                        }
                    }
                }
            }
            else _vista.MostrarMensaje("Olvido cargar un Producto");
            li.Add(info);
            _vista.CargarInforme(li);
        }

        public bool SeEncuentraElProducto(Venta v)
        {
                foreach (LineaDeVenta lv in v.LineaDeVentas)
                {
                    if (lv.Producto.Id == _pro.Id)
                    {
                        return true;
                    }
                }
           
            return false;
        }

        public void Dipose()
        {
            _RepoProducto.Dispose();
            _RepoVenta.Dispose();
        }
    }
}
