using System;
using System.Collections.Generic;
using System.Text;

namespace FastFoodRestaurant.Models
{
    public class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Products Points { get; set; }
    }
}
