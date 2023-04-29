using AyzMuhasebeServer.Domain.AppEntities.Abstractions;

namespace AyzMuhasebeServer.Domain.Repositories.GenericRepositories.AppDbContext;

public interface IAppCommandRepository<T> : ICommandGenericRepository<T>, IRepository<T> where T : Entity
{
}
