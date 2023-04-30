using AyzMuhasebeServer.Domain.AppEntities;

namespace AyzMuhasebeServer.Application.Features.MainRoleFeatures.Queries.GetAllMainRole;
public sealed record GetAllMainRoleQueryResponse(IList<MainRole> MainRoles);
