using AyzMuhasebeServer.Domain.AppEntities.Identity;

namespace AyzMuhasebeServer.Application.Features.AppFeatures.RoleFeatures.Queries.GetAllRoles
{
    public sealed class GetAllResponse
    {
        public IList<AppRole> Roles { get; set; }
    }
}
