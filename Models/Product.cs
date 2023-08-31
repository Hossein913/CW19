using System.ComponentModel.DataAnnotations;

namespace Store.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }

        public double Price { get; set; }

        public string? Photo { get; set; }

        public string? Description { get; set; }

        //navigation:
        //each product own many orders

        public List<Order> Orders { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
