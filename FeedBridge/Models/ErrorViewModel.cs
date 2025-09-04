namespace FeedBridge.Models
{
    // ErrorViewModel => (Error.cshtml) ÝßÑÊå Çäå ÈíãËá ÇáÈíÇäÇÊ Çááí ãÍÊÇÌíä äÚÑÖåÇ Ýí ÕÝÍå ÇáÎØÃ 
    public class ErrorViewModel
    {
        // Úä ØÑíÞå Logs ÚÔÇä áæ ÍÕá ÎØÃ ÇÞÏÑ ÇÊÊÈÚ ÇáÎØÃ ÏÇ Ýí Çá request áßá unique value ÈíæáÏ asp.net 
        public string? RequestId { get; set; }

        // åíÑÌÚ ÕÍ æáæ ãÝíÔ åíÑÌå ÎØÃ RequestId Ýí ÕÝÍå ÇáÎØÃ æáÇ áÇ áæ Ýíå RequestId æÙíÝÊå Çäå ÈíÞæá åáí äÚÑÖ Çá 
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
