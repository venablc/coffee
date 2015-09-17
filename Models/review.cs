using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace CoffeeCorner.Models
{
    public class review
    {
        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        public string Brand { get; set; }

        [Required]
        public string ReviewContent { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Display(Name = "Review Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReviewDate { get; set; }

        public decimal Price { get; set; }
    }

    public class CoffeeDBContext : DbContext
    {
        public DbSet<review> Reviews { get; set; }
        public DbSet<users> Users { get; set; }

        public System.Data.Entity.DbSet<CoffeeCorner.Models.Login> Logins { get; set; }
    }


}