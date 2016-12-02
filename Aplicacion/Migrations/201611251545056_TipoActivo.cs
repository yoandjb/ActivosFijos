namespace Aplicacion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TipoActivo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TipoActivoes",
                c => new
                    {
                        Activo = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false),
                        Cuentascontablecompra = c.String(),
                        Cuentacontabledepreciacion = c.String(),
                        Estado = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Activo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TipoActivoes");
        }
    }
}
