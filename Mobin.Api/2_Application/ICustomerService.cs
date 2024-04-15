using Mobin.Api._3_Domain.Customer;

namespace Mobin.Api._2_Application
{
    public interface ICustomerService
    {
        Task<Customer> CreateAsync(Customer customer);
        Task Remove(int id);
    }
}
