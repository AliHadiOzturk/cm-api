using System.Linq;
using System.Threading.Tasks;
using CustomerManagement.app.model;
using Microsoft.EntityFrameworkCore;

namespace CustomerManagement.app.repositories.Implementation
{
    public class CustomerRepository : AbstractRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public DataContext Context()
        {
            return dataContext;
        }

        public async override Task<Customer> FindOneNoTracking(long id)
        {
            return await _entity.AsNoTracking().Where(item => item.Id == id).SingleOrDefaultAsync();
        }
    }
}