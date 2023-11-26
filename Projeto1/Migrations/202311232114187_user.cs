namespace Projeto1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class user : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Table_User", "IdDepartment", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Table_User", "IdDepartment", c => c.String(nullable: false));
        }
    }
}
