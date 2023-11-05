namespace Projeto1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserInt : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Table_User", "IdDeparment", c => c.Int(nullable: false));
            DropColumn("dbo.Table_User", "Department");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Table_User", "Department", c => c.String(nullable: false, maxLength: 150, unicode: false));
            DropColumn("dbo.Table_User", "IdDeparment");
        }
    }
}
