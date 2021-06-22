using CustomerManagement.app.model;

namespace CustomerManagement.app.repositories
{
    public interface ICustomerRepository : IBaseRepository<Customer>
    {
        DataContext Context();
    }
}