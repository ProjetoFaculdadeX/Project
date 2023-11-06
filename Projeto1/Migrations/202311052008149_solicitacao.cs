namespace Projeto1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class solicitacao : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Solicitacao",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 100, unicode: false),
                        Unit = c.String(nullable: false, maxLength: 100, unicode: false),
                        IdDepartment = c.Int(nullable: false),
                        Date_Created = c.DateTime(nullable: false),
                        Lote = c.String(nullable: false, maxLength: 30, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Solicitacao");
        }
    }
}
