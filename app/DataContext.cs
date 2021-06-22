using CustomerManagement.app.core.models;
using CustomerManagement.app.model;
using Microsoft.EntityFrameworkCore;

namespace CustomerManagement.app
{
    public class DataContext : DbContext
    {
        DbSet<Customer> Customers { get; set; }
        DbSet<Log> Log { get; set; }
        DbSet<AppException> AppExceptions { get; set; }
        public DataContext(DbContextOptions options) : base(options)
        {
        }



    }
}