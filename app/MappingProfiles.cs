using AutoMapper;
using CustomerManagement.app.core.models;
using CustomerManagement.app.core.services.models;
using CustomerManagement.app.model;
using CustomerManagement.app.services.models;

namespace CustomerManagement.app
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Customer, CustomerDTO>().ReverseMap();
            CreateMap<AppException, AppExceptionDTO>().ReverseMap();
            CreateMap<Log, LogDTO>().ReverseMap();
        }
    }
}