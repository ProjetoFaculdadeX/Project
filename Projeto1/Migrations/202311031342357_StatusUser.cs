namespace Projeto1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StatusUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Table_User", "Status", c => c.String(nullable: false, maxLength: 7, fixedLength: true, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Table_User", "Status");
        }
    }
}
