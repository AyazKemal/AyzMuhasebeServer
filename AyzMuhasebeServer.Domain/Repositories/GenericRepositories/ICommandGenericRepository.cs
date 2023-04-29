using AyzMuhasebeServer.Domain.AppEntities.Abstractions;

namespace AyzMuhasebeServer.Domain.Repositories.GenericRepositories;

public interface ICommandGenericRepository<T> where T : Entity
{
    Task AddAsync(T entity, CancellationToken cancellationToken);
    Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken);
    void UpdateAysnc(T entity);
    void UpdateRangeAsync(IEnumerable<T> entities);
    Task RemoveById(string id);
    void Remove(T entity);
    void RemoveRangeAsync(IEnumerable<T> entities);
}
