namespace Kernel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Direccion = c.String(),
                        Bandera = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        nroVenta = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        ClienteId = c.Int(),
                    })
                .PrimaryKey(t => t.nroVenta)
                .ForeignKey("dbo.Clientes", t => t.ClienteId)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.LineaDeVentas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        nroVenta = c.Int(),
                        Cantidad = c.Int(nullable: false),
                        Descuento = c.Double(nullable: false),
                        ProductoID = c.Int(),
                        descripcionProducto = c.String(),
                        Venta_nroVenta = c.Int(),
                        Venta_nroVenta1 = c.Int(),
                        Venta_nroVenta2 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Productos", t => t.ProductoID)
                .ForeignKey("dbo.Ventas", t => t.Venta_nroVenta)
                .ForeignKey("dbo.Ventas", t => t.Venta_nroVenta1)
                .ForeignKey("dbo.Ventas", t => t.Venta_nroVenta2)
                .Index(t => t.ProductoID)
                .Index(t => t.Venta_nroVenta)
                .Index(t => t.Venta_nroVenta1)
                .Index(t => t.Venta_nroVenta2);
            
            CreateTable(
                "dbo.Productos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.Int(nullable: false),
                        Descripcion = c.String(),
                        Bandera = c.Boolean(nullable: false),
                        Stock = c.Int(nullable: false),
                        CostoUnitario = c.Double(nullable: false),
                        PrecioUnitario = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PrecioFechas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductoID = c.Int(),
                        Fecha = c.DateTime(nullable: false),
                        CostoUnitario = c.Double(nullable: false),
                        PrecioUnitario = c.Double(nullable: false),
                        Producto_Id = c.Int(),
                        Producto_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Productos", t => t.ProductoID)
                .ForeignKey("dbo.Productos", t => t.Producto_Id)
                .ForeignKey("dbo.Productos", t => t.Producto_Id1)
                .Index(t => t.ProductoID)
                .Index(t => t.Producto_Id)
                .Index(t => t.Producto_Id1);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LineaDeVentas", "Venta_nroVenta2", "dbo.Ventas");
            DropForeignKey("dbo.LineaDeVentas", "Venta_nroVenta1", "dbo.Ventas");
            DropForeignKey("dbo.LineaDeVentas", "Venta_nroVenta", "dbo.Ventas");
            DropForeignKey("dbo.PrecioFechas", "Producto_Id1", "dbo.Productos");
            DropForeignKey("dbo.PrecioFechas", "Producto_Id", "dbo.Productos");
            DropForeignKey("dbo.PrecioFechas", "ProductoID", "dbo.Productos");
            DropForeignKey("dbo.LineaDeVentas", "ProductoID", "dbo.Productos");
            DropForeignKey("dbo.Ventas", "ClienteId", "dbo.Clientes");
            DropIndex("dbo.PrecioFechas", new[] { "Producto_Id1" });
            DropIndex("dbo.PrecioFechas", new[] { "Producto_Id" });
            DropIndex("dbo.PrecioFechas", new[] { "ProductoID" });
            DropIndex("dbo.LineaDeVentas", new[] { "Venta_nroVenta2" });
            DropIndex("dbo.LineaDeVentas", new[] { "Venta_nroVenta1" });
            DropIndex("dbo.LineaDeVentas", new[] { "Venta_nroVenta" });
            DropIndex("dbo.LineaDeVentas", new[] { "ProductoID" });
            DropIndex("dbo.Ventas", new[] { "ClienteId" });
            DropTable("dbo.PrecioFechas");
            DropTable("dbo.Productos");
            DropTable("dbo.LineaDeVentas");
            DropTable("dbo.Ventas");
            DropTable("dbo.Clientes");
        }
    }
}
