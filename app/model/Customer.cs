using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerManagement.app.model
{
    [Table("customer")]
    public class Customer : BaseEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
    }
}