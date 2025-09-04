namespace FeedBridge.Models.Entities
{
    public class StaticPage
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; } // id بدل استخدم url هو اسم بسيط مقروء بالنسبه للمستخدم بضعه في ال 
        public string Content { get; set; }
        public DateTime LastUpdat { get; set; }

        // لو عاوز اعرف مين عدل علي الصفحه 
        public string? LastModifiedById { get; set; }
        public ApplicationUser? LastModifiedBy { get; set; }
    }
}
