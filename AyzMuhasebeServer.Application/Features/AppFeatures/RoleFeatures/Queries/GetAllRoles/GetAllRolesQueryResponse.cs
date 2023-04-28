using AyzMuhasebeServer.Domain.AppEntities.Identity;

namespace AyzMuhasebeServer.Application.Features.AppFeatures.RoleFeatures.Queries.GetAllRoles
{
    public sealed record GetAllRolesQueryResponse(IList<AppRole> Roles);
}
