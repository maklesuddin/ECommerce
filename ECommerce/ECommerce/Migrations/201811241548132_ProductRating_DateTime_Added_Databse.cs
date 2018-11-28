namespace ECommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductRating_DateTime_Added_Databse : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProductRatings", "DateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProductRatings", "DateTime", c => c.Time(nullable: false, precision: 7));
        }
    }
}
