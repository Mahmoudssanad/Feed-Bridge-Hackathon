using System.ComponentModel.DataAnnotations.Schema;

namespace FeedBridge.Models.Entities
{
    public class Report
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }

        // Admin اللي أنشأ التقرير
        [ForeignKey("CreatedBy")]
        public string CreatedById { get; set; }
        public ApplicationUser CreatedBy { get; set; }

        // اليوزر اللي التقرير متوجه ليه
        [ForeignKey("TargetUser")]
        public string TargetUserId { get; set; }
        public ApplicationUser TargetUser { get; set; }
    }
}
