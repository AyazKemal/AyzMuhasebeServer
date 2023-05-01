using AyzMuhasebeServer.Application.Messaging;

namespace AyzMuhasebeServer.Application.Features.MainRoleAndRoleRLFeatures.Commands.CreateMainRoleAndRoleRL
{
    public sealed record CreateMainRoleAndRoleRLCommand(
        string RoleId, 
        string MainRoleId):ICommand<CreateMainRoleAndRoleRLCommandResponse>;
}
