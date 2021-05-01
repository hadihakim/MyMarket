namespace MyMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedRefFood : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into RefFoods(FoodTypeId, FoodTypeName) values(1,'Spaghetti')");
            
            Sql("Insert into RefFoods (FoodTypeId, FoodTypeName) values(2,'pizza')");
            Sql("Insert into RefFoods(FoodTypeId, FoodTypeName) values(3,'Carrot')");
            Sql("Insert into RefFoods(FoodTypeId, FoodTypeName) values(4,'Milk')");
            /*Sql("SET IDENTITY_INSERT RefFood ON Insert into RefFood(FoodTypeId, FoodTypeName) values(1,'Spaghetti')");
            Sql("SET IDENTITY_INSERT RefFood ON Insert into RefFood(FoodTypeId, FoodTypeName) values(2,'pizza')");
            Sql("SET IDENTITY_INSERT RefFood ON Insert into RefFood(FoodTypeId, FoodTypeName) values(3,'Carrot')");
            Sql("SET IDENTITY_INSERT RefFood ON Insert into RefFood(FoodTypeId, FoodTypeName) values(4,'Milk')");*/
        }
        
        public override void Down()
        {
        }
    }
}
