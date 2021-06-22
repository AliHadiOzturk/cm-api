using System.Collections.Generic;
using System.Threading.Tasks;

namespace CustomerManagement.app
{
    public interface IBaseRepository<T>
    {
        Task<T> FindOne(long id);
        Task<T> FindOneNoTracking(long id);
        Task<List<T>> FindAll();

        Task Save(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task SaveChangesAsync();
    }
}