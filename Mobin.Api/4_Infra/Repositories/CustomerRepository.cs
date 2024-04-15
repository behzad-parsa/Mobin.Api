using Microsoft.EntityFrameworkCore;
using Mobin.Api._0_shared.Framework;
using Mobin.Api._3_Domain.Customer;

namespace Mobin.Api._4_Infra.Repositories
{
    public class CustomerRepository(MobinDbContext mobinDbContext) : EfRepoBase<Customer, int>(mobinDbContext), ICustomerRepository
    {
        public IQueryable<Customer> GetCustomerByProductId(int productId)
        {
            //login and join with any thing for example:

            return dbContext.Set<Customer>()
                .Where(x => x.ProductId == productId);
                //.Include(x => x.Product);  
        }

        //Specialty for ****MARZIEH****
        public void UpdateStatus(int status)
        {
            //logic of update
            return;
        }
    }
}
