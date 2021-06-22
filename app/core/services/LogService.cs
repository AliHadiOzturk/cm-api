using System;
using System.Threading.Tasks;
using AutoMapper;
using CustomerManagement.app.core.models;
using CustomerManagement.app.core.repositories;
using CustomerManagement.app.core.services.models;

namespace CustomerManagement.app.core.services
{
    public class LogService
    {
        private readonly IMapper mapper;
        private readonly ILogRepository logRepository;
        public LogService(IMapper mapper, ILogRepository logRepository)
        {
            this.logRepository = logRepository;
            this.mapper = mapper;

        }

        public async Task Save(LogDTO request)
        {
            var log = mapper.Map<Log>(request);

            log.CreateDate = DateTime.Now;

            await logRepository.Save(log);
            await logRepository.SaveChangesAsync();
        }
    }
}