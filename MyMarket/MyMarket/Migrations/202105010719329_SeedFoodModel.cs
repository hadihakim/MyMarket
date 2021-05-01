namespace MyMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedFoodModel : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Foods(Barcode, BrandName, FoodTypeId, ProductionDate, ExpityDate) values('1', 'hola', 1, '2-2-2000', '2-3-2001')");
            Sql("Insert into Foods(Barcode, BrandName, FoodTypeId, ProductionDate, ExpityDate) values('2', 'hola', 1, '2-2-2001', '2-3-2002')");
            Sql("Insert into Foods(Barcode, BrandName, FoodTypeId, ProductionDate, ExpityDate) values('3', 'maio', 2, '2-6-2001', '2-3-2003')");
        }
        
        public override void Down()
        {
        }
    }
}
