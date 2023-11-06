namespace Projeto1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Department",
                c => new
                    {
                        IdDepartment = c.Int(nullable: false, identity: true),
                        Name_Deparment = c.String(maxLength: 100, unicode: false),
                        Access = c.String(maxLength: 255, unicode: false),
                        nivel = c.String(maxLength: 2, unicode: false),
                    })
                .PrimaryKey(t => t.IdDepartment);
            
            CreateTable(
                "dbo.Estoque",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 100, unicode: false),
                        Unit = c.String(nullable: false, maxLength: 100, unicode: false),
                        IdDepartment = c.Int(nullable: false),
                        Date_Created = c.DateTime(nullable: false),
                        Lote = c.String(nullable: false, maxLength: 30, unicode: false),
                        Date_Updated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Department", t => t.IdDepartment)
                .Index(t => t.IdDepartment);
            
            CreateTable(
                "dbo.Table_User",
                c => new
                    {
                        IdUser = c.Int(nullable: false, identity: true),
                        Name_User = c.String(nullable: false, maxLength: 100, unicode: false),
                        Email_User = c.String(nullable: false, maxLength: 150, unicode: false),
                        Password_User = c.String(nullable: false, maxLength: 120, unicode: false),
                        IdDepartment = c.Int(nullable: false),
                        Data_Created = c.DateTime(nullable: false),
                        Data_Modified = c.DateTime(nullable: false),
                        Status = c.String(nullable: false, maxLength: 7, fixedLength: true, unicode: false),
                        Passworderror = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdUser)
                .ForeignKey("dbo.Department", t => t.IdDepartment)
                .Index(t => t.IdDepartment);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Table_User", "IdDepartment", "dbo.Department");
            DropForeignKey("dbo.Estoque", "IdDepartment", "dbo.Department");
            DropIndex("dbo.Table_User", new[] { "IdDepartment" });
            DropIndex("dbo.Estoque", new[] { "IdDepartment" });
            DropTable("dbo.Table_User");
            DropTable("dbo.Estoque");
            DropTable("dbo.Department");
        }
    }
}
