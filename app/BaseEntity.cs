using System;

namespace CustomerManagement.app
{
    public abstract class BaseEntity
    {
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool Deleted { get; set; }
    }
}