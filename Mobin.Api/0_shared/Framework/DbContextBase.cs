using Microsoft.EntityFrameworkCore;

namespace Mobin.Api._0_shared.Framework
{
    public class DbContextBase : DbContext, IUnitOfWork
    {
        public Task CommitAsync()
        {
            return SaveChangesAsync();
        }
    }
}
