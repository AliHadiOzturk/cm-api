using CustomerManagement.app.core.models;

namespace CustomerManagement.app.core.repositories.Implementations
{
    public class AppExceptionRepository : AbstractRepository<AppException>, IAppExceptionRepository
    {
        public AppExceptionRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public DataContext Context()
        {
            return dataContext;
        }
    }
}