using AyzMuhasebeServer.Application.Messaging;

namespace AyzMuhasebeServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.RemoveByIdMainRole;
public sealed record RemoveByIdMainRoleCommand(string Id) : ICommand<RemoveByIdMainRoleCommandResponse>;