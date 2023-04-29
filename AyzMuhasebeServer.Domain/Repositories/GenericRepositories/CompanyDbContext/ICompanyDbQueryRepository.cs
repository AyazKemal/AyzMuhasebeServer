using AyzMuhasebeServer.Domain.AppEntities.Abstractions;

namespace AyzMuhasebeServer.Domain.Repositories.GenericRepositories.CompanyDbContext
{
    public interface ICompanyDbQueryRepository<T> : ICompanyDbRepository<T>, IQueryGenericRepository<T> where T : Entity
    {

    }
}
