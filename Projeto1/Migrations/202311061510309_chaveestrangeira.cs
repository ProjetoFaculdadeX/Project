namespace Projeto1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chaveestrangeira : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Estoque", "IdDepartment", c => c.Int(nullable: false));
            CreateIndex("dbo.Estoque", "IdDepartment");
            AddForeignKey("dbo.Estoque", "IdDepartment", "dbo.Department", "IdDepartment");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Estoque", "IdDepartment", "dbo.Department");
            DropIndex("dbo.Estoque", new[] { "IdDepartment" });
            AlterColumn("dbo.Estoque", "IdDepartment", c => c.String(nullable: false, maxLength: 100, unicode: false));
        }
    }
}
