using AyzMuhasebeServer.Domain.AppEntities;
using AyzMuhasebeServer.Domain.Repositories.GenericRepositories.AppDbContext;

namespace AyzMuhasebeServer.Domain.Repositories.AppDbContext.CompanyRepositories;
public interface ICompanyCommandRepository:IAppCommandRepository<Company>
{
}
