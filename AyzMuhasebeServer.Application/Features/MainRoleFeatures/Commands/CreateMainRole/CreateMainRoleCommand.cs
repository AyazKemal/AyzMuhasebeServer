using AyzMuhasebeServer.Application.Features.MainRoleFeatures.Commands.CreateMainRole;
using AyzMuhasebeServer.Application.Messaging;

namespace AyzMuhasebeServer.Application.Features.MainRoleFeatures.Commands.CreateRole;
public sealed record CreateMainRoleCommand(
    string Title,
    string CompanyId=null) : ICommand<CreateMainRoleCommandResponse>;
