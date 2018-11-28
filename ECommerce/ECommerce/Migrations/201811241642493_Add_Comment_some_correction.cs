namespace ECommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Comment_some_correction : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Comments", "DateTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Comments", "DateTime", c => c.DateTime(nullable: false));
        }
    }
}
