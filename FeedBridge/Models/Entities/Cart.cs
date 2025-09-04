using System.ComponentModel.DataAnnotations.Schema;

namespace FeedBridge.Models.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public decimal Quantity { get; set; }

        public List<Order> Orders { get; set; } = new List<Order>();

        public List<Product> Products { get; set; } = new List<Product>();

        [ForeignKey("User")]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
