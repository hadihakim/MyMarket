namespace MyMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRefFoodModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RefFoods",
                c => new
                    {
                        FoodTypeId = c.Byte(nullable: false),
                        FoodTypeName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.FoodTypeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RefFoods");
        }
    }
}
