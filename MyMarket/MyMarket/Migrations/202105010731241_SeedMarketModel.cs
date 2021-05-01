namespace MyMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedMarketModel : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Markets ON Insert into Markets(TransactionID, Barcode, QuantitySold, DateTimeSold, TotalPrice) values(1, '1', 2, '3-3-2000', '1001')");
            Sql("SET IDENTITY_INSERT Markets ON Insert into Markets(TransactionID, Barcode, QuantitySold, DateTimeSold, TotalPrice) values(2, '2', 3, '3-5-2000', '30.5')");
        }
        
        public override void Down()
        {
        }
    }
}
