using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FastFoodRestaurant.Models
{
    public class Customers
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public byte Points { get; set; }
    }
}
