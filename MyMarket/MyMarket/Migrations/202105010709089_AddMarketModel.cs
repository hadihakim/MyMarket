namespace MyMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMarketModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Markets",
                c => new
                    {
                        TransactionID = c.Int(nullable: false, identity: true),
                        Barcode = c.String(nullable: false, maxLength: 15),
                        QuantitySold = c.Int(nullable: false),
                        DateTimeSold = c.DateTime(nullable: false),
                        TotalPrice = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.TransactionID)
                .ForeignKey("dbo.Foods", t => t.Barcode, cascadeDelete: true)
                .Index(t => t.Barcode);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Markets", "Barcode", "dbo.Foods");
            DropIndex("dbo.Markets", new[] { "Barcode" });
            DropTable("dbo.Markets");
        }
    }
}
