namespace CoffeeCorner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renameReviewContentField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.reviews", "ReviewContent", c => c.String());
            DropColumn("dbo.reviews", "Review");
        }
        
        public override void Down()
        {
            AddColumn("dbo.reviews", "Review", c => c.String());
            DropColumn("dbo.reviews", "ReviewContent");
        }
    }
}
