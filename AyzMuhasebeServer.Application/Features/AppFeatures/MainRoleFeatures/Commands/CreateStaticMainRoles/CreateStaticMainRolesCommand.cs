using AyzMuhasebeServer.Application.Messaging;
using AyzMuhasebeServer.Domain.AppEntities;

namespace AyzMuhasebeServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateStaticMainRoles;
public sealed record CreateStaticMainRolesCommand(
    List<MainRole> MainRoles) : ICommand<CreateStaticMainRolesCommandResponse>;
