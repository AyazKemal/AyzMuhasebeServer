using AyzMuhasebeServer.Application.Service.AppServices;
using AyzMuhasebeServer.Domain.AppEntities.Identity;
using MediatR;

namespace AyzMuhasebeServer.Application.Features.AppFeatures.RoleFeatures.Queries.GetAllRoles
{
    public sealed class GetAllHandler : IRequestHandler<GetAllRequest, GetAllResponse>
    {
        private readonly IRoleService _roleService;

        public GetAllHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<GetAllResponse> Handle(GetAllRequest request, CancellationToken cancellationToken)
        {
            IList<AppRole> roles = await _roleService.GetAllRolesAsync();
            return new GetAllResponse { Roles = roles };
        }
    }
}
