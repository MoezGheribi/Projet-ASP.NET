namespace MyFinance.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testxc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Factures",
                c => new
                    {
                        ClientFk = c.Int(nullable: false),
                        ProductFK = c.Int(nullable: false),
                        DateAchat = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Prix = c.Single(nullable: false),
                    })
                .PrimaryKey(t => new { t.ClientFk, t.ProductFK, t.DateAchat })
                .ForeignKey("dbo.Clients", t => t.ClientFk, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductFK, cascadeDelete: true)
                .Index(t => t.ClientFk)
                .Index(t => t.ProductFK);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Cin = c.Int(nullable: false, identity: true),
                        dateNaissance = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Mail = c.String(),
                        Nom = c.String(),
                        prenom = c.String(),
                    })
                .PrimaryKey(t => t.Cin);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Factures", "ProductFK", "dbo.Products");
            DropForeignKey("dbo.Factures", "ClientFk", "dbo.Clients");
            DropIndex("dbo.Factures", new[] { "ProductFK" });
            DropIndex("dbo.Factures", new[] { "ClientFk" });
            DropTable("dbo.Clients");
            DropTable("dbo.Factures");
        }
    }
}
