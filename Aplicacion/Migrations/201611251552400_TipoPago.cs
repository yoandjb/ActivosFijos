namespace Aplicacion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TipoPago : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TipoPagoes",
                c => new
                    {
                        Id_Pagos = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false),
                        Estado = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id_Pagos);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TipoPagoes");
        }
    }
}
