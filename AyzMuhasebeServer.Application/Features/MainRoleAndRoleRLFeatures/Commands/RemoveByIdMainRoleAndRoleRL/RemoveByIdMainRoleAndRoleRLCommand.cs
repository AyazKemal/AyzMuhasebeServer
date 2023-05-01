using AyzMuhasebeServer.Application.Messaging;

namespace AyzMuhasebeServer.Application.Features.MainRoleAndRoleRLFeatures.Commands.RemoveByIdMainRoleAndRoleRL
{
    public sealed record RemoveByIdMainRoleAndRoleRLCommand(
        string Id):ICommand<RemoveByIdMainRoleAndRoleRLCommandResponse>;
}
