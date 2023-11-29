namespace Projeto1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class departmentnivelretirado : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Department", "Access");
            DropColumn("dbo.Department", "nivel");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Department", "nivel", c => c.String(maxLength: 2, unicode: false));
            AddColumn("dbo.Department", "Access", c => c.String(maxLength: 255, unicode: false));
        }
    }
}
