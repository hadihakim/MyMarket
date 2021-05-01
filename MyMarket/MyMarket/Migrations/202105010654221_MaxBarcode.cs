namespace MyMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MaxBarcode : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Foods");
            AlterColumn("dbo.Foods", "Barcode", c => c.String(nullable: false, maxLength: 15));
            AddPrimaryKey("dbo.Foods", "Barcode");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Foods");
            AlterColumn("dbo.Foods", "Barcode", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Foods", "Barcode");
        }
    }
}
