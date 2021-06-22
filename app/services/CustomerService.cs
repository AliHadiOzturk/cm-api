using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using CustomerManagement.app.model;
using CustomerManagement.app.repositories;
using CustomerManagement.app.services.models;
using Microsoft.EntityFrameworkCore;

namespace CustomerManagement.app.services
{
    public class CustomerService
    {
        private readonly ICustomerRepository customerRepository;
        private readonly IMapper mapper;
        public CustomerService(ICustomerRepository customerRepository, IMapper mapper)
        {
            this.mapper = mapper;
            this.customerRepository = customerRepository;
        }
        public async Task<List<CustomerDTO>> GetAll()
        {
            var customers = await customerRepository.FindAll();

            var resp = mapper.Map<List<CustomerDTO>>(customers);

            return resp;
        }

        public async Task Delete(long id)
        {
            var customer = await customerRepository.FindOne(id);

            await customerRepository.Delete(customer);
            await customerRepository.SaveChangesAsync();
        }

        public async Task Save(CustomerDTO request)
        {
            var customer = mapper.Map<Customer>(request);


            await customerRepository.Save(customer);
            await customerRepository.SaveChangesAsync();
        }

        public async Task Update(CustomerDTO request)
        {
            var customer = await customerRepository.FindOneNoTracking(request.Id);
            customer = mapper.Map<Customer>(request);
            customerRepository.Context().Entry<Customer>(customer).State = EntityState.Modified;

            await customerRepository.Update(customer);

            await customerRepository.SaveChangesAsync();
        }
    }
}