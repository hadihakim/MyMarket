namespace MyMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStockModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        ItemId = c.Int(nullable: false, identity: true),
                        Barcode = c.String(nullable: false, maxLength: 15),
                        Quantity = c.Int(nullable: false),
                        PricePerUnit = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.ItemId)
                .ForeignKey("dbo.Foods", t => t.Barcode, cascadeDelete: true)
                .Index(t => t.Barcode);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stocks", "Barcode", "dbo.Foods");
            DropIndex("dbo.Stocks", new[] { "Barcode" });
            DropTable("dbo.Stocks");
        }
    }
}
