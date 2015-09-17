using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace CoffeeCorner.Models
{
    public class users
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(128)]
        public string email { get; set; }

        [Required]
        [StringLength(128)]
        public string password { get; set; }

        public bool deleted { get; set; }

        public DateTime? lastLogin { get; set; }

    }
}