using AyzMuhasebeServer.Domain.AppEntities;
using AyzMuhasebeServer.Persistance.Repositories.GenericRepositories.AppDbContext;
using AyzMuhasebeServer.Domain.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories;

namespace AyzMuhasebeServer.Persistance.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories;

public class UserAndCompanyRelationshipCommandRepository : AppCommandRepository<UserAndCompanyRelationship>, IUserAndCompanyRelationshipCommandRepository
{
    public UserAndCompanyRelationshipCommandRepository(Persistance.Context.AppDbContext context) : base(context){ }
}
