using AyzMuhasebeServer.Domain.CompanyEntities;
using AyzMuhasebeServer.Domain.Repositories.CompanyDbContext.UCAFRepositories;
using AyzMuhasebeServer.Persistance.Repositories.GenericRepositories.CompanyDbContext;

namespace AyzMuhasebeServer.Persistance.Repositories.CompanyDbContext.UCAFRepositories
{
    public sealed class UCAFCommandRepository : CompanyDbCommandRepository<UniformChartOfAccount>, IUCAFCommandRepository
    {
    }
}
