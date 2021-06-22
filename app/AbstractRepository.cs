using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CustomerManagement.app
{
    public class AbstractRepository<T> where T : class
    {
        protected readonly DataContext dataContext;
        protected DbSet<T> _entity;
        public AbstractRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
            _entity = this.dataContext.Set<T>();

        }
        public async Task Delete(T entity)
        {
            _entity.Remove(entity);
            await Task.CompletedTask;
        }

        public Task<List<T>> FindAll()
        {
            return _entity.ToListAsync();
        }

        public virtual async Task<T> FindOne(long id)
        {
            return await _entity.FindAsync(id);
        }
        public virtual Task<T> FindOneNoTracking(long id)
        {
            throw new System.Exception();
        }

        public async Task Save(T entity)
        {
            await _entity.AddAsync(entity);
        }

        public async Task Update(T entity)
        {
            _entity.Update(entity);
            await Task.CompletedTask;
        }

        public async Task SaveChangesAsync()
        {
            await dataContext.SaveChangesAsync();
        }
    }
}