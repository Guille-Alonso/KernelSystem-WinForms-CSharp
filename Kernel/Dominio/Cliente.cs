using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kernel.Dominio
{
    public class Cliente
    {
        public virtual ICollection<Venta> Ventas { get; set; }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public bool Bandera { get; set; }
        public string Cuit { get; set; }
        public int Telefono { get; set; }

        public Cliente(int id)
        {
            Id = id;
            Bandera = true;
        }

        public Cliente()
        {
            this.Ventas = new HashSet<Venta>(); //
            Bandera = true;
        }

    }
}
