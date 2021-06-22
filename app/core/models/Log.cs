using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerManagement.app.core.models
{
    [Table("log")]
    public class Log : BaseEntity
    {
        public long Id { get; set; }
        public string Method { get; set; }
        public string IpAddress { get; set; }
        public string Query { get; set; }
    }
}