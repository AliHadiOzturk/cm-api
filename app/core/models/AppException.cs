using System.ComponentModel.DataAnnotations.Schema;
using CustomerManagement.app.core.services.models;

namespace CustomerManagement.app.core.models
{
    [Table("appexception")]
    public class AppException : BaseEntity
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