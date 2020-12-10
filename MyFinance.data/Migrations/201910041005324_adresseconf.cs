namespace MyFinance.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adresseconf : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "LabAddress_StreetAddress", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "LabAddress_StreetAddress", c => c.String());
        }
    }
}
