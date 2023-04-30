using AyzMuhasebeServer.Application.Features.MainRoleFeatures.Commands.CreateRole;
using AyzMuhasebeServer.Application.Messaging;
using AyzMuhasebeServer.Application.Service.AppServices;
using AyzMuhasebeServer.Domain.AppEntities;

namespace AyzMuhasebeServer.Application.Features.MainRoleFeatures.Commands.CreateMainRole;
public sealed class CreateMainRoleCommandHandler : ICommandHandler<CreateMainRoleCommand, CreateMainRoleCommandResponse>
{
    private readonly IMainRoleService _mainRoleService;

    public CreateMainRoleCommandHandler(IMainRoleService mainRoleService)
    {
        _mainRoleService = mainRoleService;
    }

    public async Task<CreateMainRoleCommandResponse> Handle(CreateMainRoleCommand request, CancellationToken cancellationToken)
    {
        MainRole checkMainRoleTitle = await _mainRoleService.GetByTitleAndCompanyId(request.Title, request.CompanyId, cancellationToken);
        if (checkMainRoleTitle != null) throw new Exception("Bu rol daha önce kaydedilmiş");

        MainRole mainRole = new(
            Guid.NewGuid().ToString(),
            request.Title,
            request.CompanyId != null ? false : true,
            request.CompanyId);
        await _mainRoleService.CreateAsync(mainRole,cancellationToken);

        return new();
    }
}
