// Ignore Spelling: Mobin

using Microsoft.EntityFrameworkCore;
using Mobin.Api._0_shared.Framework;

namespace Mobin.Api._4_Infra
{
    public class MobinDbContext():DbContextBase
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
