namespace Projeto1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialpc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Estoque", "Department", c => c.String(nullable: false, maxLength: 100, unicode: false));
            AddColumn("dbo.Estoque", "Date_Created", c => c.DateTime(nullable: false));
            AddColumn("dbo.Estoque", "Lote", c => c.String(nullable: false, maxLength: 30, unicode: false));
            AddColumn("dbo.Estoque", "Date_Updated", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Estoque", "Unit", c => c.String(nullable: false, maxLength: 100, unicode: false));
            AlterColumn("dbo.Table_User", "Password_User", c => c.String(maxLength: 120, unicode: false));
            DropColumn("dbo.Estoque", "IdDepartment");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Estoque", "IdDepartment", c => c.Int(nullable: false));
            AlterColumn("dbo.Table_User", "Password_User", c => c.String(maxLength: 150, unicode: false));
            AlterColumn("dbo.Estoque", "Unit", c => c.Int(nullable: false));
            DropColumn("dbo.Estoque", "Date_Updated");
            DropColumn("dbo.Estoque", "Lote");
            DropColumn("dbo.Estoque", "Date_Created");
            DropColumn("dbo.Estoque", "Department");
        }
    }
}
