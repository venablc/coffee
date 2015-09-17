namespace CoffeeCorner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dataAnnotationsRemoved : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.reviews", "Brand", c => c.String());
            AlterColumn("dbo.reviews", "Review", c => c.String());
            AlterColumn("dbo.reviews", "ProductName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.reviews", "ProductName", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.reviews", "Review", c => c.String(nullable: false));
            AlterColumn("dbo.reviews", "Brand", c => c.String(nullable: false, maxLength: 60));
        }
    }
}
