namespace Aplicacion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Parametro : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Parametroes",
                c => new
                    {
                        Id_Parametro = c.Int(nullable: false, identity: true),
                        Fecha_Proceso = c.DateTime(nullable: false),
                        Depreciacion = c.String(),
                        Rnc = c.String(maxLength: 9),
                        Metodo_Depreciacion = c.String(),
                    })
                .PrimaryKey(t => t.Id_Parametro);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Parametroes");
        }
    }
}
