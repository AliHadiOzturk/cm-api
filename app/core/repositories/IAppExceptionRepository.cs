using CustomerManagement.app.core.models;

namespace CustomerManagement.app.core.repositories
{
    public interface IAppExceptionRepository : IBaseRepository<AppException>
    {
        DataContext Context();
    }
}