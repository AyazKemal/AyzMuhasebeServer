using AyzMuhasebeServer.Domain.AppEntities;

namespace AyzMuhasebeServer.Application.Features.AppFeatures.MainRoleFeatures.Queries.GetAllMainRole;
public sealed record GetAllMainRoleQueryResponse(IList<MainRole> MainRoles);
