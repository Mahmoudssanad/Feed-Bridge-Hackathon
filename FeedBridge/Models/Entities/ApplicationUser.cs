using Microsoft.AspNetCore.Identity;

namespace FeedBridge.Models.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string Address { get; set; }
        public string? ImgUrl { get; set; }

        // التقارير اللي اتبعتت له
        public ICollection<Report> ReportsReceived { get; set; } = new List<Report>();

        // (Admins التقارير اللي أنشأها اليوزر (غالبًا 
        public ICollection<Report> ReportsCreated { get; set; } = new List<Report>();

        public ICollection<Review> CreateReviews { get; set; } = new List<Review>();
        public ICollection<Order> Orders { get; set; } = new List<Order>();
        public ICollection<Notification> Notifications { get; set; } = new List<Notification>();
        public ICollection<Partner> ManagePartner { get; set; } = new List<Partner>();
        public ICollection<Support> Supports { get; set; } = new List<Support>();
        public ICollection<StaticPage> StaticPage { get; set; } = new List<StaticPage>();

        public Cart Cart { get; set; }
    }
}
