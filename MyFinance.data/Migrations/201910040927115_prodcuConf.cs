namespace MyFinance.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prodcuConf : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ProviderProducts", newName: "Providings");
            RenameColumn(table: "dbo.Providings", name: "Provider_Id", newName: "Provider");
            RenameColumn(table: "dbo.Providings", name: "Product_ProductID", newName: "Product");
            RenameIndex(table: "dbo.Providings", name: "IX_Product_ProductID", newName: "IX_Product");
            RenameIndex(table: "dbo.Providings", name: "IX_Provider_Id", newName: "IX_Provider");
            DropPrimaryKey("dbo.Providings");
            AddColumn("dbo.Products", "IsBiological", c => c.Int());
            AlterColumn("dbo.Products", "Description", c => c.String(maxLength: 200));
            AddPrimaryKey("dbo.Providings", new[] { "Product", "Provider" });
            DropColumn("dbo.Products", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            DropPrimaryKey("dbo.Providings");
            AlterColumn("dbo.Products", "Description", c => c.String());
            DropColumn("dbo.Products", "IsBiological");
            AddPrimaryKey("dbo.Providings", new[] { "Provider_Id", "Product_ProductID" });
            RenameIndex(table: "dbo.Providings", name: "IX_Provider", newName: "IX_Provider_Id");
            RenameIndex(table: "dbo.Providings", name: "IX_Product", newName: "IX_Product_ProductID");
            RenameColumn(table: "dbo.Providings", name: "Product", newName: "Product_ProductID");
            RenameColumn(table: "dbo.Providings", name: "Provider", newName: "Provider_Id");
            RenameTable(name: "dbo.Providings", newName: "ProviderProducts");
        }
    }
}
