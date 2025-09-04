using System.ComponentModel.DataAnnotations.Schema;

namespace FeedBridge.Models.Entities
{
    public class Partner
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string PageLink { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
