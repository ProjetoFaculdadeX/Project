namespace Projeto1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Estoque", "IdDepartment", "dbo.Department");
            DropForeignKey("dbo.Table_User", "IdDepartment", "dbo.Department");
            AddForeignKey("dbo.Estoque", "IdDepartment", "dbo.Department", "IdDepartment", cascadeDelete: true);
            AddForeignKey("dbo.Table_User", "IdDepartment", "dbo.Department", "IdDepartment", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Table_User", "IdDepartment", "dbo.Department");
            DropForeignKey("dbo.Estoque", "IdDepartment", "dbo.Department");
            AddForeignKey("dbo.Table_User", "IdDepartment", "dbo.Department", "IdDepartment");
            AddForeignKey("dbo.Estoque", "IdDepartment", "dbo.Department", "IdDepartment");
        }
    }
}
