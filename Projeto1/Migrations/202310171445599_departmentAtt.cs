namespace Projeto1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class departmentAtt : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Department", "Access", c => c.String(maxLength: 255, unicode: false));
            AddColumn("dbo.Department", "nivel", c => c.String(maxLength: 2, unicode: false));
            AlterColumn("dbo.Table_User", "Name_User", c => c.String(nullable: false, maxLength: 100, unicode: false));
            AlterColumn("dbo.Table_User", "Email_User", c => c.String(nullable: false, maxLength: 150, unicode: false));
            AlterColumn("dbo.Table_User", "Password_User", c => c.String(nullable: false, maxLength: 120, unicode: false));
            AlterColumn("dbo.Table_User", "Department", c => c.String(nullable: false, maxLength: 150, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Table_User", "Department", c => c.String(maxLength: 150, unicode: false));
            AlterColumn("dbo.Table_User", "Password_User", c => c.String(maxLength: 120, unicode: false));
            AlterColumn("dbo.Table_User", "Email_User", c => c.String(maxLength: 150, unicode: false));
            AlterColumn("dbo.Table_User", "Name_User", c => c.String(maxLength: 100, unicode: false));
            DropColumn("dbo.Department", "nivel");
            DropColumn("dbo.Department", "Access");
        }
    }
}
