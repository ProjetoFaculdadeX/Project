namespace Projeto1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EstoqueDepartmentInt : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Estoque", "Department", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Estoque", "Department", c => c.String(nullable: false, maxLength: 100, unicode: false));
        }
    }
}
