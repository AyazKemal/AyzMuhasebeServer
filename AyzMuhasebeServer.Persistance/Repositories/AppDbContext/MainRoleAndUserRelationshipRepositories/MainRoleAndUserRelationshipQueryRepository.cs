using AyzMuhasebeServer.Domain.AppEntities;
using AyzMuhasebeServer.Persistance.Repositories.GenericRepositories.AppDbContext;
using AyzMuhasebeServer.Domain.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories;

namespace AyzMuhasebeServer.Persistance.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories;

public class MainRoleAndUserRelationshipQueryRepository : AppQueryRepository<MainRoleAndUserRelationship>, IMainRoleAndUserRelationshipQueryRepository
{
    public MainRoleAndUserRelationshipQueryRepository(Persistance.Context.AppDbContext context) : base(context){ }
}
