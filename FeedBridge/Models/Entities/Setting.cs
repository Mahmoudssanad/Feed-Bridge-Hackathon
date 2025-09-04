namespace FeedBridge.Models.Entities
{
    // ...بيبقا فيه الحاجات العامه للمشروع زي اللوجو ورقم التواصل وايميل التواصل والعنوان وهكذا
    public class Setting
    {
        public int Id { get; set; }
        public string Key { get; set; }      // مثال: "SiteName"
        public string Value { get; set; }    // مثال: "FeedBridge"
    }
}
