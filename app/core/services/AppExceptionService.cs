using System;
using System.Threading.Tasks;
using AutoMapper;
using CustomerManagement.app.core.models;
using CustomerManagement.app.core.repositories;
using CustomerManagement.app.core.services.models;

namespace CustomerManagement.app.core.services
{
    public class AppExceptionService
    {
        private readonly IAppExceptionRepository appExceptionRepository;
        private readonly IMapper mapper;

        public AppExceptionService(IAppExceptionRepository appExceptionRepository, IMapper mapper)
        {
            this.mapper = mapper;
            this.appExceptionRepository = appExceptionRepository;
        }

        public async Task Save(AppExceptionDTO request)
        {
            appExceptionRepository.Context().ChangeTracker.Clear();
            var exp = mapper.Map<AppException>(request);

            exp.CreateDate = DateTime.Now;

            await appExceptionRepository.Save(exp);
            await appExceptionRepository.SaveChangesAsync();

        }
    }
}