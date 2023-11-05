namespace Projeto1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserChaveEstrangeiraDepartment : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Table_User", "IdDeparment");
            AddForeignKey("dbo.Table_User", "IdDeparment", "dbo.Department", "IdDepartment");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Table_User", "IdDeparment", "dbo.Department");
            DropIndex("dbo.Table_User", new[] { "IdDeparment" });
        }
    }
}
