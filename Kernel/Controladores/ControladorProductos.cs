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
    public class ControladorProductos
    {
        private Producto _producto;
        private NuevoProducto _vista;
        private ModificarProducto _vistaModificar;
        private Productos _vistaProductos;
        private Repositorio<Producto> _repo;
        public ControladorProductos(ModificarProducto vista)
        {
            _vistaModificar = vista;
            _repo = new Repositorio<Producto>();
        }
        public ControladorProductos()
        {
            //_repo = new Repositorio<Producto>();
        }

        public ControladorProductos(Productos vista)
        {
            _vistaProductos = vista;
            _repo = new Repositorio<Producto>();

        }
        public ControladorProductos(int id, Productos vista)
        {
            List<Producto> lp = new List<Producto>();
            _repo = new Repositorio<Producto>();

            foreach (Producto p in _repo.GetAll().ToList())
            {
                if (p.Id != id)
                {
                    lp.Add(p);
                }
                else
                {
                    p.Bandera = false;
                    lp.Add(p);
                }
            }

          
            _repo.GuardarCambios();
            vista.ActualizarGrilla();
            _repo.Dispose();
        }
        public ControladorProductos(NuevoProducto vista)
        {
            _repo = new Repositorio<Producto>();

            using (var repoProducto = new Repositorio<Producto>())
            {
                _producto = new Producto(repoProducto.GetAll().ToList().Count + 1);
            }
          
            _vista = vista;
            _vista.CargarProducto(_producto);
        }

        public void GuardarProducto()
        {
            PrecioFecha pf = new PrecioFecha();
            pf.CostoUnitario = _producto.CostoUnitario;
            pf.PrecioUnitario = _producto.PrecioUnitario;
           

            if (_producto.Descripcion != null && ! _repo.BuscarProducto(_producto, _repo.GetAll().ToList()) && _producto.Descripcion != "")
            {
              
                    pf.ProductoID = _producto.Id;
                    _producto.PrecioFechas.Add(pf);

                    _repo.Add(_producto);
               
                _vista.ActualizarGrillaProductos();
                _repo.Dispose();

            }
            else if (_producto.Descripcion == null || _producto.Descripcion == "")
            {
                _vista.MostrarMensaje("Debe ingresar una descripcion");
            }
            else _vista.MostrarMensaje("Ya existe un producto con esa descripcion");
          
        }

        public List<Producto> ListarProductos()
        {
            using (var repoProductos = new Repositorio<Producto>())
            {
                List<Producto> laux = new List<Producto>();

                foreach (Producto p in repoProductos.GetAll().ToList())
                {
                    if (p.Bandera == true)
                    {
                        laux.Add(p);
                    }
                }


                return laux;
            }

        }

        public Producto BuscarProducto(int id)
        {
            return _repo.GetAll().ToList().Single(p => p.Id.Equals(id));
        }

        public void ActualizarProducto(Producto pro, Producto proViejo)
        {
            PrecioFecha pf = new PrecioFecha();
            if (pro.PrecioUnitario != proViejo.PrecioUnitario || pro.CostoUnitario != proViejo.CostoUnitario)
            {
                if(pro.Descripcion != "" && !_repo.BuscarProducto(pro, _repo.GetAll().ToList()))
                {
                    pf.PrecioUnitario = pro.PrecioUnitario;
                    pf.CostoUnitario = pro.CostoUnitario;

                    pf.ProductoID = pro.Id;
                    pro.PrecioFechas.Add(pf);

                    _repo.GuardarCambios();

                    _vistaModificar.ActualizarGrillaProductos();
                    _repo.Dispose();
                }
               
            }else if (pro.Descripcion != "" && !_repo.BuscarProducto(pro, _repo.GetAll().ToList()))
            {
                _repo.GuardarCambios();

                _vistaModificar.ActualizarGrillaProductos();
                _repo.Dispose();
            }
            else if (pro.Descripcion == "")
            {
                _vistaModificar.MostrarMensaje("Debe ingresar una descripcion");
            }
            else _vistaModificar.MostrarMensaje("Ya existe un producto con esa descripcion");

        }

        public void FiltrarProductos(string cadena)
        {
            
            IEnumerable<Producto> lista = _repo.GetFiltered(p => p.Descripcion.StartsWith(cadena) && p.Bandera != false);

            _vistaProductos.FiltrarProductos(lista);
        }

        public void Dispose()
        {
            _repo.Dispose();
        }
    }
}
