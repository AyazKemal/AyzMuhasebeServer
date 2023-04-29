using AyzMuhasebeServer.Domain.AppEntities.Abstractions;

namespace AyzMuhasebeServer.Domain.Repositories
{
    public interface ICommandRepository<T> : IRepository<T> where T : Entity
    {
        Task AddAsync(T entity, CancellationToken cancellationToken);
        Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken);
        void UpdateAysnc(T entity);
        void UpdateRangeAsync(IEnumerable<T> entities);
        Task RemoveById(string id);
        void Remove(T entity);
        void RemoveRangeAsync(IEnumerable<T> entities);
    }
}
