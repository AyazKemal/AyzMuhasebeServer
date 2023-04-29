using AyzMuhasebeServer.Domain.AppEntities;
using AyzMuhasebeServer.Domain.Repositories.AppDbContext.CompanyRepositories;
using AyzMuhasebeServer.Persistance.Repositories.GenericRepositories.AppDbContext;

namespace AyzMuhasebeServer.Persistance.Repositories.AppDbContext.CompanyRepositories;
public sealed class CompanyQueryRepository : AppQueryRepository<Company>, ICompanyQueryRepository
{
    public CompanyQueryRepository(Context.AppDbContext context) : base(context)
    {
    }
}
