namespace CoffeeCorner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.reviews", "Brand", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.reviews", "Review", c => c.String(nullable: false));
            AlterColumn("dbo.reviews", "ProductName", c => c.String(nullable: false, maxLength: 60));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.reviews", "ProductName", c => c.String());
            AlterColumn("dbo.reviews", "Review", c => c.String());
            AlterColumn("dbo.reviews", "Brand", c => c.String());
        }
    }
}
