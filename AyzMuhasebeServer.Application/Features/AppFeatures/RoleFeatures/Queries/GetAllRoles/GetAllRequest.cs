using AyzMuhasebeServer.Domain.AppEntities.Identity;
using MediatR;

namespace AyzMuhasebeServer.Application.Features.AppFeatures.RoleFeatures.Queries.GetAllRoles
{
    public sealed class GetAllRequest : IRequest<GetAllResponse>
    {
    }
}
