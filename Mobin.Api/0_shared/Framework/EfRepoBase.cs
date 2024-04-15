using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Threading;

namespace Mobin.Api._0_shared.Framework
{
    public class EfRepoBase<TAggregateRoot, TIdentifier> : IRepository<TAggregateRoot, TIdentifier>, IReadOnlyRepository<TAggregateRoot, TIdentifier> where TAggregateRoot : class
        //Or TAggregateRoot : EntityBase<>
    {
        protected readonly DbContext dbContext;
        public IQueryable<TAggregateRoot> Query => dbContext.Set<TAggregateRoot>().AsNoTracking();

        public EfRepoBase(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public virtual void Add(TAggregateRoot domain)
        {
            dbContext.Set<TAggregateRoot>().Add(domain);
        }

        public virtual Task<int> CountAsync(IQueryable<TAggregateRoot> query, Expression<Func<TAggregateRoot, bool>> expression)
        {
            return query.CountAsync(expression);
        }

        public virtual void Edit(TAggregateRoot domain)
        {
            dbContext.Attach(domain);
            dbContext.Entry(domain).State = EntityState.Modified;
        }

        public async virtual Task<TAggregateRoot?> GetByIdAsync(TIdentifier identifier)
        {
            return await dbContext.Set<TAggregateRoot>().FindAsync(new object[1] { identifier });
        }

        public virtual Task<List<TAggregateRoot>> GetListAsync(IQueryable<TAggregateRoot> query, Expression<Func<TAggregateRoot, bool>> expression)
        {
            return query.ToListAsync();
        }

        public async virtual Task RemoveAsync(TIdentifier identifier)
        {
            TAggregateRoot entity = await dbContext.Set<TAggregateRoot>().FindAsync(identifier);

            dbContext.Set<TAggregateRoot>().Remove(entity);
        }
    }


}
