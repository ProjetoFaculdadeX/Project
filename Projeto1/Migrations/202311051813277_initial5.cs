namespace Projeto1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Table_User", "IdDepartment", "dbo.Department");
            DropIndex("dbo.Table_User", new[] { "IdDepartment" });
            AlterColumn("dbo.Table_User", "IdDepartment", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Table_User", "IdDepartment", c => c.Int(nullable: false));
            CreateIndex("dbo.Table_User", "IdDepartment");
            AddForeignKey("dbo.Table_User", "IdDepartment", "dbo.Department", "IdDepartment");
        }
    }
}
