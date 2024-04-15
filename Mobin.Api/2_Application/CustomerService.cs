using Mobin.Api._0_shared.Framework;
using Mobin.Api._3_Domain.Customer;
using System.Runtime.CompilerServices;

namespace Mobin.Api._2_Application
{
    public class CustomerService(ICustomerRepository customerRepository,
        IUnitOfWork unitOfWork) : ICustomerService
    {
        public async Task<Customer> CreateAsync(Customer customer)
        {
            customerRepository.Add(customer);
            await unitOfWork.CommitAsync();
            return customer;
        }

        public async Task Remove(int id)
        {
            await customerRepository.RemoveAsync(id);
            await unitOfWork.CommitAsync();
        }
    }
}
