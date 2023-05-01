using AyzMuhasebeServer.Application.Messaging;

namespace AyzMuhasebeServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.UpdateMainRole;
public sealed record UpdateMainRoleCommand(
   string Id,
    string Title) : ICommand<UpdateMainRoleCommandResponse>;
