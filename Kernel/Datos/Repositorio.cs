using Kernel.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kernel.Datos
{
    public class Repositorio<TEntity> : IDisposable
        where TEntity : class
    {
        private readonly Contexto _context;

        public Repositorio()
        {
            if (_context == null)
            {
                _context = new Contexto();
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>();
        }


        public IEnumerable<TEntity> GetFiltered(Expression<Func<TEntity, bool>> filter)
        {
            return _context.Set<TEntity>().Where(filter);
        }

        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();

        }
        
        //public void BorrarProductosDuplicados(Repositorio<Producto> rep)
        //{
        //    foreach (Producto p in rep.GetAll().ToList())
        //    {
        //        if (p.PrecioFechas.Count == 0)
        //        {
        //            QuitarProducto(p);
        //        }
        //    }
        //    _context.SaveChanges();

        //}

      
        public void GuardarCambios()
        {
            _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
        public bool BuscarCliente(Cliente cl, List<Cliente> clientes)
        {
            bool bandera = false;
          
            foreach (Cliente c in clientes)
            {
                if (c.Nombre == cl.Nombre && c.Id != cl.Id && c.Bandera == true)
                {
                    bandera = true;
                    return bandera;
                }
            }
            return bandera;
        }

        public bool BuscarProducto(Producto prod, List<Producto> productos)
        {
            bool bandera = false;

            foreach (Producto p in /*clientes*/ productos)
            {
                if (p.Descripcion == prod.Descripcion && p.Id != prod.Id && p.Bandera == true)
                {
                    bandera = true;
                    return bandera;
                }
            }
            return bandera;
        }
        public void DevolverStock(Venta venta, List<Producto> productos)
        {
            foreach (LineaDeVenta l in venta.LineaDeVentas)
            {
                int cant = l.Cantidad;
                Producto pro = l.Producto;
                Devolver(cant, pro, productos);
            }
           
        }

        private void Devolver(int cantidad, Producto pro, List<Producto> productos)
        {
            foreach (Producto p in productos)
            {
                if (p.Id == pro.Id)
                {
                    p.Stock = p.Stock + cantidad;
                    break;
                }
            }
        }

        public void Eliminar(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
        }

        public  void ReducirStock(List<LineaDeVenta> lv, List<Producto> productos)
        {
            foreach (LineaDeVenta l in lv)
            {
                int cant = l.Cantidad;
                Producto pro = l.Producto;
                Reducir(cant, pro, productos);
            }
        }

        private  void Reducir(int cant, Producto pro, List<Producto> productos)
        {
            foreach (Producto p in productos)
            {
                if (p.Id == pro.Id)
                {
                    p.Stock = p.Stock - cant;
                    break;
                }
            }
        }

        public  string VerificarStock(Venta venta, List<Producto> lista)
        {
            string aux = null;
            foreach (LineaDeVenta lv in venta.LineaDeVentas)
            {
                foreach (Producto p in lista)
                {
                    if (lv.Producto.Id == p.Id)
                    {
                        if (lv.Cantidad > p.Stock)
                        {
                            aux = aux + "-" + lv.Producto.Descripcion;
                        }
                    }
                    
                }
                
            }
            return aux;
        }

        public string VerificarStock(Venta venta)
        {
            string aux = null;
            foreach (LineaDeVenta lv in venta.LineaDeVentas)
            {
                        if (lv.Cantidad > lv.Producto.Stock)
                        {
                            aux = aux + "-" + lv.Producto.Descripcion;
                        }
                    
            }
            return aux;
        }

        public void ActualizarVenta(Venta venta, Repositorio<Venta> repo)
        {
            foreach (Venta v in repo.GetAll().ToList())
            {
                if (v.nroVenta == venta.nroVenta)
                {
                    repo.Eliminar(v);
                    repo.Add(venta);
                    repo.GuardarCambios();
                    break;
                }
            }
        }
    }

}
