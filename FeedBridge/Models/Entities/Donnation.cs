using System.ComponentModel.DataAnnotations.Schema;

namespace FeedBridge.Models.Entities
{
    public class Donnation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string? ImgURL { get; set; }
        public DateOnly ExpirDate { get; set; }
        public decimal Quantity { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
    }
}
