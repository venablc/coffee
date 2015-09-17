namespace CoffeeCorner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dataAnnotations1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.reviews", "Brand", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.reviews", "ReviewContent", c => c.String(nullable: false));
            AlterColumn("dbo.reviews", "ProductName", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.reviews", "ProductName", c => c.String());
            AlterColumn("dbo.reviews", "ReviewContent", c => c.String());
            AlterColumn("dbo.reviews", "Brand", c => c.String());
        }
    }
}
