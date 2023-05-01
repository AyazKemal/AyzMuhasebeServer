using AyzMuhasebeServer.Application.Messaging;
using AyzMuhasebeServer.Application.Services.AppServices;
using Microsoft.EntityFrameworkCore;

namespace AyzMuhasebeServer.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Queries
{
    public sealed class GetAllMainRoleAndRoleRLQueryHandler : IQueryHandler<GetAllMainRoleAndRoleRLQuery, GetAllMainRoleAndRoleRLQueryResponse>
    {
        private readonly IMainRoleAndRoleRelationshipService _roleRelationshipService;

        public GetAllMainRoleAndRoleRLQueryHandler(IMainRoleAndRoleRelationshipService roleRelationshipService)
        {
            _roleRelationshipService = roleRelationshipService;
        }

        public async Task<GetAllMainRoleAndRoleRLQueryResponse> Handle(GetAllMainRoleAndRoleRLQuery request, CancellationToken cancellationToken)
        {
            return new(await _roleRelationshipService
                .GetAll()
                .Include("AppRole")
                .Include("MainRole")
                .ToListAsync());
        }
    }
}
