namespace CoffeeCorner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rating : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.reviews", "Review", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.reviews", "Review");
        }
    }
}
