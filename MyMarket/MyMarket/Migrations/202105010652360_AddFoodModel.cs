namespace MyMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFoodModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        Barcode = c.String(nullable: false, maxLength: 128),
                        BrandName = c.String(nullable: false),
                        FoodTypeId = c.Byte(nullable: false),
                        ProductionDate = c.DateTime(nullable: false),
                        ExpityDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Barcode)
                .ForeignKey("dbo.RefFoods", t => t.FoodTypeId, cascadeDelete: true)
                .Index(t => t.FoodTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Foods", "FoodTypeId", "dbo.RefFoods");
            DropIndex("dbo.Foods", new[] { "FoodTypeId" });
            DropTable("dbo.Foods");
        }
    }
}
