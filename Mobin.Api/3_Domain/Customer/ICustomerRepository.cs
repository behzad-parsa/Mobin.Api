using Mobin.Api._0_shared.Framework;

namespace Mobin.Api._3_Domain.Customer
{
    public interface ICustomerRepository : IRepository<Customer, int>
    {
        IQueryable<Customer> GetCustomerByProductId(int productId);
        void UpdateStatus(int status);
    }
}
