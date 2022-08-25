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
    public class ControladorCliente
    {
        private NuevoCliente _vista;
        private Cliente _cliente;
        private ModificarCliente _vistaModifica;
        private Clientes _vistaClientes;
        private Repositorio<Cliente> _repo;
        public ControladorCliente()
        {

        }

        public ControladorCliente(Clientes vista)
        {
            _vistaClientes = vista;
            _repo = new Repositorio<Cliente>();

        }

        public ControladorCliente(int id, Clientes vista)
        {
            List<Cliente> lc = new List<Cliente>();
            _repo = new Repositorio<Cliente>();

            foreach (Cliente c in _repo.GetAll().ToList())
            {
                if (c.Id != id)
                {
                    lc.Add(c);
                }
                else
                {
                    c.Bandera = false;
                    lc.Add(c);
                }

            }
            _repo.GuardarCambios(); 
          
            vista.ActualizarGrillaClientes();
            _repo.Dispose(); 
           
        }
        public ControladorCliente(ModificarCliente vista)
        {
            _vistaModifica = vista;
            _repo = new Repositorio<Cliente>();
        }
        public ControladorCliente(NuevoCliente vista)
        {
            _repo = new Repositorio<Cliente>();
            _vista = vista;
            using (var repo = new Repositorio<Cliente>())
            {
                _cliente = new Cliente(repo.GetAll().ToList().Count + 1);
            }
           
            _vista.CargarCliente(_cliente);
        }

        public void GuardarCliente()
        {
            if (_cliente.Nombre != null && !_repo.BuscarCliente(_cliente, _repo.GetAll().ToList()) && _cliente.Nombre != "")
            {
                using (var repo = new Repositorio<Cliente>())
                {
                    repo.Add(_cliente);
                }
             
                _vista.ActualizarGrillaClientes();
                _repo.Dispose();
            }
            else if (_cliente.Nombre == null || _cliente.Nombre == "")
            {
                _vista.MostrarMensaje("Debe ingresar un nombre");
            }
            else _vista.MostrarMensaje("Ya existe un cliente con ese nombre");
        }

        public List<Cliente> ListarClientes()
        {
            using (var repoCliente = new Repositorio<Cliente>())
            {
                List<Cliente> laux = new List<Cliente>();
                foreach (Cliente c in repoCliente.GetAll().ToList())
                {
                    if (c.Bandera == true)
                    {
                        laux.Add(c);
                    }
                }
                return laux;
            }
           
        }

        public void ActualizarCliente(Cliente nuevo)
        {
            
            if (nuevo.Nombre != "" && nuevo.Direccion != "" && ! _repo.BuscarCliente(nuevo, _repo.GetAll().ToList()) && nuevo.Nombre != null)
            {      
                _repo.GuardarCambios();
                _vistaModifica.ActualizarGrillaClientes();
                _repo.Dispose();
            }
            else if (nuevo.Nombre == ""  || nuevo.Direccion == "")
            {
                _vistaModifica.MostrarMensaje("Olvido completar campos");
            }
            else _vistaModifica.MostrarMensaje("Ya existe un cliente con esa descripcion");
        }

        public Cliente BuscarCliente(int id)
        {
           
            return _repo.GetAll().ToList().Single(p => p.Id.Equals(id));
        }

        public void FiltrarClientes(string nombre)
        {
            
                IEnumerable<Cliente> lista = _repo.GetFiltered(p => p.Nombre.StartsWith(nombre) && p.Bandera != false);
            
            _vistaClientes.FiltrarClientes(lista);
        }

        public void Dispose()
        {
            _repo.Dispose();
        }
    }
}
