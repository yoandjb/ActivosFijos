namespace Aplicacion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Empleado : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Empleadoes",
                c => new
                    {
                        Id_Empleado = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false),
                        cedula = c.String(maxLength: 12),
                        Departamento = c.String(nullable: false),
                        Tipodepersona = c.String(),
                        Fechadeingreso = c.DateTime(nullable: false),
                        Estado = c.String(),
                    })
                .PrimaryKey(t => t.Id_Empleado);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Empleadoes");
        }
    }
}
