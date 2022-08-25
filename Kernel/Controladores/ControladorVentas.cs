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
    public class ControladorVentas
    {
        private Ventas _vista;
        private Venta _venta;
        private Venta _ventaModificar;
        private Venta _ventaFantasma;

        private int _b;
        private ConsultarVentas _vistaConsultar;
        private Repositorio<Venta> _repoVentas;
        private ControladorImpresion _ci;
        public ControladorVentas(Ventas vista)
        {
            _vista = vista;
            _repoVentas = new Repositorio<Venta>();
            _venta = new Venta(_repoVentas.GetAll().ToList().Count + 1);
            _ventaFantasma = new Venta();

        }

        public ControladorVentas()
        {

        }
        public ControladorVentas(ConsultarVentas vista) // filtrar ventas y listar ventas
        {
            _vistaConsultar = vista;
            _repoVentas = new Repositorio<Venta>();
        }

        public ControladorVentas(int nroVenta, ConsultarVentas vistaConsultar) // eliminar venta
        {
           
            Repositorio<Producto> repoPro = new Repositorio<Producto>();
            _repoVentas = new Repositorio<Venta>();
          
                _repoVentas.DevolverStock(_repoVentas.GetAll().ToList().Single(p => p.nroVenta.Equals(nroVenta)), repoPro.GetAll().ToList());
            _repoVentas.Eliminar(_repoVentas.GetAll().ToList().Single(p => p.nroVenta.Equals(nroVenta)));
                
                vistaConsultar.ActualizarGrillaVentas(_repoVentas.GetAll().ToList());
                repoPro.GuardarCambios();
                repoPro.Dispose();
          
        }
       
        public Producto BuscarProducto(int id)
        {
            var producto = default(Producto);
            
                 using (var Repo = new Repositorio<Producto>())
                {
                     producto = Repo.GetAll().ToList().Single(p => p.Id.Equals(id) && p.Bandera != false);
                  
                        return producto;
                  
                }
           
        }

        public void CrearYAgregarLineaVenta(int cod, int cant, int desc, bool bandera)
        {
            if (bandera == false)
            {
                int b = 0;
                var pro = default(Producto);
                try
                {
                     pro = BuscarProducto(cod);
                }
                catch (Exception)
                {
                    _vista.MostrarMensaje("El producto ingresado no existe");
                }

                if (pro != null)
                {
                   
                    LineaDeVenta lvFantasma = new LineaDeVenta() { Cantidad = cant, Descuento = desc };
                    lvFantasma.Producto = pro;

                    LineaDeVenta lv = new LineaDeVenta() {Cantidad = cant, Descuento = desc };

                    lv.ProductoID = pro.Id;
                    //usar objetos venta y lv que solo sean para impacto visual.. los verdaderos seran almacenados

                    if (_ventaFantasma.LineaDeVentas.Count() != 0)
                    {
                        foreach (LineaDeVenta aux in  _ventaFantasma.LineaDeVentas)
                        {
                            if (aux.Producto.Id == lvFantasma.Producto.Id)
                            {
                                _vista.MostrarMensaje("El producto ya fue ingresado a la venta");
                                b = 1;
                                break;

                            }
                        }
                        if (b == 0)
                        {
                            

                            //BBDD
                            lv.nroVenta = _venta.nroVenta;
                            _venta.LineaDeVentas.Add(lv);

                            //fantasma
                            lvFantasma.nroVenta = _ventaFantasma.nroVenta;
                            _ventaFantasma.LineaDeVentas.Add(lvFantasma);
                        }

                    }
                    else
                    {
                        _venta.LineaDeVentas.Add(lv);
                        _ventaFantasma.LineaDeVentas.Add(lvFantasma);
                    }


                     _vista.ActualizarGrillaVentas(_ventaFantasma.LineaDeVentas.ToList());
                    _vista.ActualizarTotalVenta(_ventaFantasma);
                }
               
            }
            else
            {
                int b = 0;
                var pro = default(Producto);
                try
                {
                    pro = BuscarProducto(cod);
                }
                catch (Exception)
                {
                    _vista.MostrarMensaje("El producto ingresado no existe");
                }

                if (pro != null)
                {
                    LineaDeVenta lvFantasma = new LineaDeVenta() { Cantidad = cant, Descuento = desc };
                    lvFantasma.Producto = pro;

                    LineaDeVenta lv = new LineaDeVenta() { Cantidad = cant, Descuento = desc };

                    lv.ProductoID = pro.Id;


                    if (_ventaFantasma.LineaDeVentas.Count() != 0)
                    {
                        foreach (LineaDeVenta aux in  _ventaFantasma.LineaDeVentas)
                        {
                            if (aux.Producto.Id == lvFantasma.Producto.Id)
                            {
                                _vista.MostrarMensaje("El producto ya fue ingresado a la venta");
                                b = 1;
                                break;

                            }
                        }
                        if (b == 0)
                        {
                            

                            //BBDD
                            lv.nroVenta = _ventaModificar.nroVenta;
                            _ventaModificar.LineaDeVentas.Add(lv);

                            //fantasma
                            lvFantasma.nroVenta = _ventaFantasma.nroVenta;
                            _ventaFantasma.LineaDeVentas.Add(lvFantasma);
                        }

                    }
                    else 
                    {
                        _ventaModificar.LineaDeVentas.Add(lv);
                        _ventaFantasma.LineaDeVentas.Add(lvFantasma);
                    }


                    _vista.ActualizarGrillaVentas(_ventaFantasma.LineaDeVentas.ToList());
                    _vista.ActualizarTotalVenta(_ventaFantasma);
                }
               
            }
          

        }

        public void QuitarLineaVenta(int id, bool bandera)
        {
            if (bandera == false)
            {
                List<LineaDeVenta> llvAux = new List<LineaDeVenta>();

                foreach (LineaDeVenta lv in _ventaFantasma.LineaDeVentas)
                {
                    if (lv.Producto.Id != id)
                    {
                        llvAux.Add(lv);

                    }
                    else
                    {
                        
                        _venta.LineaDeVentas.Remove(lv);
                        _venta.LineaDeVentas = null;
                       
                    }

                }

                _vista.ActualizarGrillaVentas(llvAux.ToList());

                _venta.LineaDeVentas = llvAux.ToList(); //BBDD
                _ventaFantasma.LineaDeVentas = llvAux.ToList();

                _vista.ActualizarTotalVenta(_ventaFantasma);
            }
            else
            {
                List<LineaDeVenta> llvAux = new List<LineaDeVenta>();

                foreach (LineaDeVenta lv in _ventaFantasma.LineaDeVentas)
                {
                    if (lv.Producto.Id != id)
                    {
                        llvAux.Add(lv);
                       
                    }
                    else
                    {

                        _ventaModificar.LineaDeVentas.Remove(lv);
                        _ventaModificar.LineaDeVentas = null;
                    }

                }
              //  _vista.ActualizarGrillaVentas(llvAux.ToList());
           
                _ventaModificar.LineaDeVentas = llvAux.ToList(); //BBDD
                _ventaFantasma.LineaDeVentas = llvAux.ToList();

                _vista.ActualizarGrillaVentas(_ci.ObtenerLineasDeVenta(_ventaFantasma).ToList());
                _vista.ActualizarTotalVenta(_ventaFantasma);
            }
        }

        public void RegistrarVenta(DateTime fecha, bool bandera) 
        {
         
            if (bandera == false)
            {
                if (_venta.LineaDeVentas.Count() != 0 && _venta.ClienteId != null)
                {
                   
                    string mensaje = _repoVentas.VerificarStock(_ventaFantasma);
                   
                    if (mensaje == null)
                    {
                        _venta.Fecha = fecha;
                        Repositorio<Producto> repoProd = new Repositorio<Producto>();

                        
                        _repoVentas.ReducirStock(_ventaFantasma.LineaDeVentas.ToList(), repoProd.GetAll().ToList());
                            _repoVentas.Add(_venta);
                        
                        _vista.MostrarMensaje("Venta Registrada");
                        _vista.LimpiarGrillaVentas();
                        _vista.LimpiarContenedorCliente();
                       
                        _venta = new Venta();
                        _ventaFantasma = new Venta();
                        _vista.ActualizarTotalVenta(_venta);

                        repoProd.GuardarCambios();
                        repoProd.Dispose();
                       // _repoVentas.Dispose();

                       // _vista = new Ventas();
                    } else _vista.MostrarMensaje("no hay stock de" + mensaje);
                } else _vista.MostrarMensaje("Olvido cargar productos o un Cliente");
            }
            else
            {
               
                if (_ventaModificar.LineaDeVentas.Count() != 0 && _ventaModificar.ClienteId != null)
                {
                    if (_b == 0)
                    {
                        using (var repoP = new Repositorio<Producto>())
                        {
                            _repoVentas.DevolverStock(_venta, repoP.GetAll().ToList());
                            repoP.GuardarCambios();
                        }
                        
                    }
                    string mensaje;
                    using (var repoP2 = new Repositorio<Producto>())
                    {
                         mensaje = _repoVentas.VerificarStock(_ventaFantasma, repoP2.GetAll().ToList());
                    }
                   

                    if (mensaje == null)
                    {
                        _ventaModificar.Fecha = fecha;

                        Repositorio<Producto> repoProd = new Repositorio<Producto>();

                      
                        _repoVentas.ReducirStock(_ventaFantasma.LineaDeVentas.ToList(), repoProd.GetAll().ToList());
                   
                        _repoVentas.ActualizarVenta(_ventaModificar, _repoVentas);

                        _vista.MostrarMensaje("Venta Modificada");
                        _vista.LimpiarGrillaVentas();
                        _vista.LimpiarContenedorCliente();

                        _ventaModificar = new Venta();
                        _venta = new Venta(); 
                        _ventaFantasma = new Venta();

                        _vista.ActualizarTotalVenta(_ventaModificar);
                        _vista._bandera = false;
                       

                        repoProd.GuardarCambios();
                        repoProd.Dispose();
                       // _repoVentas.Dispose();
                      //  _vista = new Ventas();
                    }
                    else
                    {
                        _vista.MostrarMensaje("no hay stock de" + mensaje);
                        _b = 1;
                    }
                    
                }
                else _vista.MostrarMensaje("Olvido cargar productos o un Cliente");
            }
        }

        public void CargarClienteVenta(int? id, bool bandera)
        {
            if (bandera == false)
            {
                var cliente = default(Cliente);
                try
                {
                    using (var repo = new Repositorio<Cliente>())
                    {
                        cliente = repo.GetAll().ToList().Single(p => p.Id.Equals(id) && p.Bandera != false);
                    }
                }
                catch (Exception)
                {
                    _vista.MostrarMensaje("El cliente ingresado no existe");
                }
                   
                if (cliente != null)
                {
                  
                    _venta.ClienteId = cliente.Id;

                    _vista.MostrarCliente(cliente);
                }
                else
                {
                   
                    _venta.ClienteId = null;
                    _vista.LimpiarContenedorCliente();
                }
            }
            else
            {
                var cliente = default(Cliente);
                try
                {
                    using (var repo = new Repositorio<Cliente>())
                    {
                        cliente = repo.GetAll().ToList().Single(p => p.Id.Equals(id) && p.Bandera != false);
                    }
                }
                catch (Exception)
                {
                    _vista.MostrarMensaje("El cliente ingresado no existe");
                }
                if (cliente != null)
                {
                   
                    _ventaModificar.ClienteId = cliente.Id;

                    _vista.MostrarCliente(cliente);
                }
                else
                {
                   
                    _ventaModificar.ClienteId = null;
                    _vista.LimpiarContenedorCliente();
                }
            }
        }

        public void FiltrarVentas(string id)
        {
            _repoVentas = new Repositorio<Venta>();
            IEnumerable<Venta> lista = _repoVentas.GetFiltered(v => v.Cliente.Id.ToString().StartsWith(id));
            _vistaConsultar.FiltrarVentas(lista);
        }
        public void FiltrarVentasPorFecha(DateTime fecha)
        {
            _repoVentas = new Repositorio<Venta>();
          
            IEnumerable <Venta> lista = _repoVentas.GetFiltered(v => v.Fecha.Month == fecha.Month && v.Fecha.Year == fecha.Year);

            _vistaConsultar.FiltrarVentas(lista);
        }

        public List<Venta> ListarVentas()
        {
           
          return _repoVentas.GetAll().ToList();
            
        }
        public void Dispose()
        {
            _repoVentas.Dispose();
        }

        public void CargarVentaAModificar(Ventas vista, int nroVenta, ConsultarVentas vistaConsultar, ControladorImpresion ci)
        {
            _vista = vista;
            _b = 0;
            _ci = ci;
            
            _venta = _repoVentas.GetAll().ToList().Single(p => p.nroVenta.Equals(nroVenta));
            
            _ventaModificar = new Venta(_venta.nroVenta) { ClienteId = _venta.ClienteId,  Fecha = _venta.Fecha, LineaDeVentas = _venta.LineaDeVentas.ToList() };

            _ventaFantasma = new Venta(_venta.nroVenta) {Cliente = _venta.Cliente, ClienteId = _venta.ClienteId, Fecha = _venta.Fecha, LineaDeVentas = _venta.LineaDeVentas.ToList() };

            ConsultarVentas formulario = vistaConsultar;
            formulario.Close();
            _vista.CargarVentaAModificar(_ventaFantasma, this, _ci.ObtenerLineasDeVenta(_ventaFantasma));
        }

        public Venta ObtenerVenta(int nroVenta)
        {
            return _repoVentas.GetAll().ToList().Single(p => p.nroVenta.Equals(nroVenta));
        }
    }
}
