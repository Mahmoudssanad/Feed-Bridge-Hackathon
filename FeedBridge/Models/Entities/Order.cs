using FeedBridge.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace FeedBridge.Models.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public decimal Quantity { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }


        [ForeignKey("Cart")]
        public int CartId { get; set; }
        public Cart Cart { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();
    }
}
