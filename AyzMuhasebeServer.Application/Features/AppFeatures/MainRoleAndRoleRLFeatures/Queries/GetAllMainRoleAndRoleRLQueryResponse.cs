using AyzMuhasebeServer.Domain.AppEntities;

namespace AyzMuhasebeServer.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Queries
{
    public sealed record GetAllMainRoleAndRoleRLQueryResponse(
        List<MainRoleAndRoleRelationship> mainRoleAndRoleRelationships);
}
