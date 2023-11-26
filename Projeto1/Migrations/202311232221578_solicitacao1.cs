namespace Projeto1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class solicitacao1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Solicitacao", "IdEstoque", c => c.Int(nullable: false));
            CreateIndex("dbo.Solicitacao", "IdEstoque");
            AddForeignKey("dbo.Solicitacao", "IdEstoque", "dbo.Estoque", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Solicitacao", "IdEstoque", "dbo.Estoque");
            DropIndex("dbo.Solicitacao", new[] { "IdEstoque" });
            DropColumn("dbo.Solicitacao", "IdEstoque");
        }
    }
}
