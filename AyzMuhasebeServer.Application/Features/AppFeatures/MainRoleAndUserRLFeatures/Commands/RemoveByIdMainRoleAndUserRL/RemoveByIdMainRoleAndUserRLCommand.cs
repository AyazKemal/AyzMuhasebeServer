using AyzMuhasebeServer.Application.Messaging;

namespace AyzMuhasebeServer.Application.Features.AppFeatures.MainRoleAndUserRLFeatures.Commands.RemoveByIdMainRoleAndUserRL;

public sealed record RemoveByIdMainRoleAndUserRLCommand(
    string Id) : ICommand<RemoveByIdMainRoleAndUserRLCommandResponse>;
