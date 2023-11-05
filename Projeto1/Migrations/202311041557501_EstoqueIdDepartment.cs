namespace Projeto1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EstoqueIdDepartment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Estoque", "IdDepartment", c => c.Int(nullable: false));
            DropColumn("dbo.Estoque", "Department");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Estoque", "Department", c => c.Int(nullable: false));
            DropColumn("dbo.Estoque", "IdDepartment");
        }
    }
}
