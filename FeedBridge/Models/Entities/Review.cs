using System.ComponentModel.DataAnnotations.Schema;

namespace FeedBridge.Models.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int StarsNumber { get; set; }
        public DateTime CreatedAt { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
