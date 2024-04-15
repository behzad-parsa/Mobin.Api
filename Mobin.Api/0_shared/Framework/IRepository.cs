namespace Mobin.Api._0_shared.Framework
{
    public interface IRepository<TAggregateRoot, TIdentifier> : IReadOnlyRepository<TAggregateRoot, TIdentifier> 
    {
        void Add(TAggregateRoot domain);

        void Edit(TAggregateRoot domain);

        Task RemoveAsync(TIdentifier identifier);
    }
}