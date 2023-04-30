using AyzMuhasebeServer.Domain.AppEntities;
using AyzMuhasebeServer.Domain.Repositories.AppDbContext.MainRoleRepositories;
using AyzMuhasebeServer.Domain.Repositories.GenericRepositories;
using AyzMuhasebeServer.Persistance.Repositories.GenericRepositories.AppDbContext;

namespace AyzMuhasebeServer.Persistance.Repositories.AppDbContext.MainRoleRepositories;
public class MainRoleCommandRepository : AppCommandRepository<MainRole>, IMainRoleCommandRepository
{
    public MainRoleCommandRepository(Context.AppDbContext context) : base(context)
    {
    }
}
