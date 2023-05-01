using AyzMuhasebeServer.Domain.AppEntities;
using AyzMuhasebeServer.Persistance.Repositories.GenericRepositories.AppDbContext;
using AyzMuhasebeServer.Domain.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories;

namespace AyzMuhasebeServer.Persistance.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories;

public class MainRoleAndRoleRelationshipQueryRepository : AppQueryRepository<MainRoleAndRoleRelationship>, IMainRoleAndRoleRelationshipQueryRepository
{
    public MainRoleAndRoleRelationshipQueryRepository(Persistance.Context.AppDbContext context) : base(context){ }
}
