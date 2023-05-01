using AyzMuhasebeServer.Application.Messaging;

namespace AyzMuhasebeServer.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Commands.CreateMainRoleAndRoleRL
{
    public sealed record CreateMainRoleAndRoleRLCommand(
        string RoleId,
        string MainRoleId) : ICommand<CreateMainRoleAndRoleRLCommandResponse>;
}
