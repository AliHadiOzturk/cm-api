namespace CustomerManagement.app.core.services.models
{
    public class AppExceptionDTO
    {
        public long Id { get; set; }
        public string StackTrace { get; set; }
        public string Method { get; set; }
        public string Message { get; set; }
        public string InnerException { get; set; }
        public string Source { get; set; }
        public string TargetSite { get; set; }
    }
}