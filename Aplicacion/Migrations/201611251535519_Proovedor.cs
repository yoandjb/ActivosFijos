namespace Aplicacion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Proovedor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Proovedors",
                c => new
                    {
                        Proveedor = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Cedula = c.String(nullable: false, maxLength: 12),
                        Tipodepersona = c.String(),
                        Fechadeingreso = c.DateTime(nullable: false),
                        Estado = c.String(),
                    })
                .PrimaryKey(t => t.Proveedor);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Proovedors");
        }
    }
}
