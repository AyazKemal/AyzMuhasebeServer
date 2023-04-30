using AyzMuhasebeServer.Domain.AppEntities;
using AyzMuhasebeServer.Domain.Repositories.AppDbContext.MainRoleRepositories;
using AyzMuhasebeServer.Persistance.Repositories.GenericRepositories.AppDbContext;

namespace AyzMuhasebeServer.Persistance.Repositories.AppDbContext.MainRoleRepositories;
public class MainRoleQueryRepository : AppQueryRepository<MainRole>, IMainRoleQueryRepository
{
    public MainRoleQueryRepository(Context.AppDbContext context) : base(context)
    {
    }
}
