using AyzMuhasebeServer.Application.Messaging;
using AyzMuhasebeServer.Application.Services.AppServices;
using AyzMuhasebeServer.Domain.AppEntities;

namespace AyzMuhasebeServer.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Commands.CreateMainRoleAndRoleRL
{
    public sealed class CreateMainRoleAndRoleRLHandler : ICommandHandler<CreateMainRoleAndRoleRLCommand,
                                                         CreateMainRoleAndRoleRLCommandResponse>
    {
        private readonly IMainRoleAndRoleRelationshipService _roleRelationshipService;

        public CreateMainRoleAndRoleRLHandler(IMainRoleAndRoleRelationshipService roleRelationshipService)
        {
            _roleRelationshipService = roleRelationshipService;
        }

        public async Task<CreateMainRoleAndRoleRLCommandResponse> Handle(CreateMainRoleAndRoleRLCommand request,
                                                            CancellationToken cancellationToken)
        {
            MainRoleAndRoleRelationship checkRoleAndRoleIsRelated = await _roleRelationshipService
                                 .GetByRoleIdAndMainRoleId(request.RoleId, request.MainRoleId, cancellationToken);

            if (checkRoleAndRoleIsRelated != null) throw new Exception("Bu rol ilişkisi daha önce kurulmuş");

            MainRoleAndRoleRelationship mainRoleAndRoleRelationship = new(
                Guid.NewGuid().ToString(),
                request.RoleId,
                request.MainRoleId);

            await _roleRelationshipService.CreateAsync(mainRoleAndRoleRelationship, cancellationToken);
            return new();
        }
    }
}
