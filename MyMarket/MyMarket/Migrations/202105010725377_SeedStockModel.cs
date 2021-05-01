namespace MyMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedStockModel : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Stocks ON Insert into Stocks(ItemId, Barcode, Quantity, PricePerUnit) values(1, '1', 3, 500.5)");
            Sql("SET IDENTITY_INSERT Stocks ON Insert into Stocks(ItemId, Barcode, Quantity, PricePerUnit) values(2, '2', 5, 5.5)");
            Sql("SET IDENTITY_INSERT Stocks ON Insert into Stocks(ItemId, Barcode, Quantity, PricePerUnit) values(3, '3', 1, 5.15)");
        }
        
        public override void Down()
        {
        }
    }
}
