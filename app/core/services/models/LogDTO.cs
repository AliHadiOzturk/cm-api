namespace CustomerManagement.app.core.services.models
{
    public class LogDTO
    {
        public long Id { get; set; }
        public string Method { get; set; }
        public string IpAddress { get; set; }
        public string Query { get; set; }
    }
}