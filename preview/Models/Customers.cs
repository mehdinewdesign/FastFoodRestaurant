using System.ComponentModel.DataAnnotations;

namespace FastFoodRestaurant.Models
{
    public class Customers
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public byte Points { get; set; }   
    }
}
