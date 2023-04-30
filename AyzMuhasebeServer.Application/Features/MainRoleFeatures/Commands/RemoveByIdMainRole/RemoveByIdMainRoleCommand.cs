using AyzMuhasebeServer.Application.Messaging;

namespace AyzMuhasebeServer.Application.Features.MainRoleFeatures.Commands.RemoveByIdMainRole;
public sealed record RemoveByIdMainRoleCommand(string Id): ICommand<RemoveByIdMainRoleCommandResponse>;