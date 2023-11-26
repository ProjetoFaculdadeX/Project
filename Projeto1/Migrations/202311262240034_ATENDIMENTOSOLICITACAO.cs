namespace Projeto1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ATENDIMENTOSOLICITACAO : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Estoque", "Unit", c => c.Int(nullable: false));
            AlterColumn("dbo.Solicitacao", "Unit", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Solicitacao", "Unit", c => c.String(nullable: false, maxLength: 100, unicode: false));
            AlterColumn("dbo.Estoque", "Unit", c => c.String(nullable: false, maxLength: 100, unicode: false));
        }
    }
}
