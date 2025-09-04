namespace FeedBridge.Models
{
    // ErrorViewModel => (Error.cshtml) ����� ��� ����� �������� ���� ������� ������ �� ���� ����� 
    public class ErrorViewModel
    {
        // �� ����� Logs ���� �� ��� ��� ���� ����� ����� �� �� �� request ��� unique value ����� asp.net 
        public string? RequestId { get; set; }

        // ����� �� ��� ���� ����� ��� RequestId �� ���� ����� ��� �� �� ��� RequestId ������ ��� ����� ��� ���� �� 
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
