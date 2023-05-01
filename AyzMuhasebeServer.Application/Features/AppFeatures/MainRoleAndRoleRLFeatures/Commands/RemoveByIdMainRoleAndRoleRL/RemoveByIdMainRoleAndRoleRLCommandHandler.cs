using AyzMuhasebeServer.Application.Messaging;
using AyzMuhasebeServer.Application.Services.AppServices;
using AyzMuhasebeServer.Domain.AppEntities;

namespace AyzMuhasebeServer.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Commands.RemoveByIdMainRoleAndRoleRL
{
    public sealed class RemoveByIdMainRoleAndRoleRLCommandHandler : ICommandHandler<RemoveByIdMainRoleAndRoleRLCommand, RemoveByIdMainRoleAndRoleRLCommandResponse>
    {
        private readonly IMainRoleAndRoleRelationshipService _roleRelationshipService;

        public RemoveByIdMainRoleAndRoleRLCommandHandler(IMainRoleAndRoleRelationshipService roleRelationshipService)
        {
            _roleRelationshipService = roleRelationshipService;
        }

        public async Task<RemoveByIdMainRoleAndRoleRLCommandResponse> Handle(RemoveByIdMainRoleAndRoleRLCommand request, CancellationToken cancellationToken)
        {
            MainRoleAndRoleRelationship entity = await _roleRelationshipService.GetByIdAsync(request.Id);

            if (entity == null) throw new Exception("Bu ana role ve role bağlantısı bulunamadı");

            await _roleRelationshipService.RemoveByIdAsync(request.Id);
            return new();
        }
    }
}
