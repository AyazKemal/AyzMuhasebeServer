using AyzMuhasebeServer.Domain.CompanyEntities;
using AyzMuhasebeServer.Domain.Repositories.UCAFRepositories;

namespace AyzMuhasebeServer.Persistance.Repositories.UCAFRepositories
{
    public sealed class UCAFCommandRepository : CommandRepository<UniformChartOfAccount>, IUCAFCommandRepository
    {
    }
}
