using System.ComponentModel.DataAnnotations;

namespace FastFoodRestaurant.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public byte Points { get; set; }
    }
}
