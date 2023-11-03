namespace Projeto1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PassworderrorUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Table_User", "Passworderror", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Table_User", "Passworderror");
        }
    }
}
