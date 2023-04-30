using AyzMuhasebeServer.Application.Messaging;

namespace AyzMuhasebeServer.Application.Features.MainRoleFeatures.Commands.UpdateMainRole;
public sealed record UpdateMainRoleCommand(
   string Id,
    string Title) : ICommand<UpdateMainRoleCommandResponse>;
