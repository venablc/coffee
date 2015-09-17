namespace CoffeeCorner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class makeUserLastLoginNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.users", "lastLogin", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.users", "lastLogin", c => c.DateTime(nullable: false));
        }
    }
}
