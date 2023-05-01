using AyzMuhasebeServer.Domain.AppEntities;
using AyzMuhasebeServer.Persistance.Repositories.GenericRepositories.AppDbContext;
using AyzMuhasebeServer.Domain.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories;

namespace AyzMuhasebeServer.Persistance.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories;

public class UserAndCompanyRelationshipQueryRepository : AppQueryRepository<UserAndCompanyRelationship>, IUserAndCompanyRelationshipQueryRepository
{
    public UserAndCompanyRelationshipQueryRepository(Persistance.Context.AppDbContext context) : base(context){ }
}
