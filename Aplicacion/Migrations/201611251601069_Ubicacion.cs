namespace Aplicacion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ubicacion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ubicacions",
                c => new
                    {
                        Id_Ubicaciones = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false),
                        Direccion = c.String(nullable: false),
                        Edificio = c.String(),
                        Estado = c.String(),
                    })
                .PrimaryKey(t => t.Id_Ubicaciones);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ubicacions");
        }
    }
}
