using AyzMuhasebeServer.Application.Messaging;

namespace AyzMuhasebeServer.Application.Features.AppFeatures.MainRoleAndUserRLFeatures.Commands.CreateMainRoleAndUserRL;

public sealed record CreateMainRoleAndUserRLCommand(
    string UserId,
    string MainRoleId,
    string CompanyId) : ICommand<CreateMainRoleAndUserRLCommandResponse>;