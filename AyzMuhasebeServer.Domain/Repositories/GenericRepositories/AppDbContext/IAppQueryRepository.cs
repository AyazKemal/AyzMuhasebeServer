using AyzMuhasebeServer.Domain.AppEntities.Abstractions;

namespace AyzMuhasebeServer.Domain.Repositories.GenericRepositories.AppDbContext;

public interface IAppQueryRepository<T> : IQueryGenericRepository<T>, IRepository<T> where T : Entity
{
}
