namespace CoffeeCorner.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CoffeeCorner.Models.CoffeeDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CoffeeCorner.Models.CoffeeDBContext context)
        {
            context.Reviews.AddOrUpdate(i => i.ProductName,
                new CoffeeCorner.Models.review
                {
                    Brand = "Caffe Roma",
                    ProductName = "Classic Gold Filter Coffee",
                    ReviewDate = DateTime.Parse("2014-1-11"),
                    Price = 7,
                    ReviewContent = "A rich full bodied flavour, very a lingering bitter after taste."
                },

                new CoffeeCorner.Models.review
                {
                    Brand = "Lavazza",
                    ProductName = "Decaffeinated Ground Coffee",
                    ReviewDate = DateTime.Parse("2014-1-17"),
                    Price = 5,
                    ReviewContent = "Watery and weak flavour, not at all enjoyable."
                },

                new CoffeeCorner.Models.review
                {
                    Brand = "Douwe Egberts",
                    ProductName = "Traditional Filter Coffee",
                    ReviewDate = DateTime.Parse("2013-10-18"),
                    Price = 6,
                    ReviewContent = "Mild soft flavour with little after taste, very refreshing."
                },

                new CoffeeCorner.Models.review
                {
                    Brand = "Lyons",
                    ProductName = "Coffee Bags - Gourmet Italian",
                    ReviewDate = DateTime.Parse("2014-2-1"),
                    Price = 11,
                    ReviewContent = "Very watery almost artificial tasting coffee, not disimilar to cheap vedning machine coffee."
                }
           );
        }
    }
}
