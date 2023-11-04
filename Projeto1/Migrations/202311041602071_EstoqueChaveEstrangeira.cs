namespace Projeto1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EstoqueChaveEstrangeira : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Estoque", "IdDepartment");
            AddForeignKey("dbo.Estoque", "IdDepartment", "dbo.Department", "IdDepartment");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Estoque", "IdDepartment", "dbo.Department");
            DropIndex("dbo.Estoque", new[] { "IdDepartment" });
        }
    }
}
