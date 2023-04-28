using AyzMuhasebeServer.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole;
using AyzMuhasebeServer.Domain.AppEntities.Identity;

namespace AyzMuhasebeServer.Application.Service.AppServices
{
    public interface IRoleService
    {
        Task AddAsync(CreateRoleCommand request);
        Task UpdateAsync(AppRole appRole);
        Task DeleteAsync(AppRole appRole);
        Task<IList<AppRole>> GetAllRolesAsync();
        Task<AppRole> GetById(string id);
        Task<AppRole> GetByCode(string code);
    }
}
