using CustomerManagement.app.core.models;

namespace CustomerManagement.app.core.repositories.Implementations
{
    public class LogRepository : AbstractRepository<Log>, ILogRepository
    {
        public LogRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}