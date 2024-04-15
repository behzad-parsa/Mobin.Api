using System.Linq.Expressions;

namespace Mobin.Api._0_shared.Framework
{
    public interface IReadOnlyRepository<TAggregateRoot, TIdentifier>
    {
        IQueryable<TAggregateRoot> Query { get; }

        Task<int> CountAsync(IQueryable<TAggregateRoot> query, Expression<Func<TAggregateRoot, bool>> expression);

        Task<TAggregateRoot?> GetByIdAsync(TIdentifier identifier);

        Task<List<TAggregateRoot>> GetListAsync(IQueryable<TAggregateRoot> query, Expression<Func<TAggregateRoot, bool>> expression);
    }
}