namespace CoffeeCorner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.reviews",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Brand = c.String(),
                        ProductName = c.String(),
                        ReviewDate = c.DateTime(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.reviews");
        }
    }
}
