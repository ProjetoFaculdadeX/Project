namespace Projeto1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class estoquedepartment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Estoque", "Departamento", c => c.String(nullable: false, maxLength: 100, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Estoque", "Departamento");
        }
    }
}
