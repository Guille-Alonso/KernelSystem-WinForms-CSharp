namespace Kernel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class incremento : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "Cuit", c => c.String());
            AddColumn("dbo.Clientes", "Telefono", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "Telefono");
            DropColumn("dbo.Clientes", "Cuit");
        }
    }
}
