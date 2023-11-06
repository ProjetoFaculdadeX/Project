namespace Projeto1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class estoquedepartment12 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Estoque", "IdDepartment", "dbo.Department");
            DropIndex("dbo.Estoque", new[] { "IdDepartment" });
            AlterColumn("dbo.Estoque", "IdDepartment", c => c.String(nullable: false, maxLength: 100, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Estoque", "IdDepartment", c => c.Int(nullable: false));
            CreateIndex("dbo.Estoque", "IdDepartment");
            AddForeignKey("dbo.Estoque", "IdDepartment", "dbo.Department", "IdDepartment");
        }
    }
}
