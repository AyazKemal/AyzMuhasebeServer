using AyzMuhasebeServer.Domain.CompanyEntities;
using AyzMuhasebeServer.Domain.Repositories.GenericRepositories.CompanyDbContext;

namespace AyzMuhasebeServer.Domain.Repositories.CompanyDbContext.UCAFRepositories
{
    public interface IUCAFQueryRepository : ICompanyDbQueryRepository<UniformChartOfAccount>
    {
    }
}
