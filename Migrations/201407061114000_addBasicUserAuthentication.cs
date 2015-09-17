namespace CoffeeCorner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addBasicUserAuthentication : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        RememberMe = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        email = c.String(nullable: false, maxLength: 128),
                        password = c.String(nullable: false, maxLength: 128),
                        deleted = c.Boolean(nullable: false),
                        lastLogin = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.users");
            DropTable("dbo.Logins");
        }
    }
}
