using Kernel.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kernel.Datos
{
   public class Contexto: DbContext
    {
        public Contexto() : base("BDkernel")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Conventions
                .Remove<PluralizingTableNameConvention>();

            modelBuilder
                .Conventions
                .Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder
                .Conventions
                .Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder
                .Entity<Venta>()
                .HasKey(sa => sa.nroVenta)
                .ToTable("Ventas");

            modelBuilder
                .Entity<Producto>()
               // .HasKey(sa => sa.Id)
                .ToTable("Productos");

            modelBuilder
             .Entity<LineaDeVenta>()
           //  .HasKey(sa => sa.Id)
             .ToTable("LineaDeVentas");

            modelBuilder
              .Entity<PrecioFecha>()
              //.HasKey(sa => sa.Id)
              .ToTable("PrecioFechas");

            modelBuilder
             .Entity<Cliente>()
          //   .HasKey(sa => sa.Id)
             .ToTable("Clientes");

            //modelBuilder
            //    .Entity<T>()
            //    .Ignore(t => t.Property);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Producto> Productos { get; set; }

        public DbSet<LineaDeVenta> LineaDeVentas { get; set; }
        public DbSet<PrecioFecha> PrecioFechas { get; set; }

        public DbSet<Cliente> Clientes { get; set; }
    }
}

