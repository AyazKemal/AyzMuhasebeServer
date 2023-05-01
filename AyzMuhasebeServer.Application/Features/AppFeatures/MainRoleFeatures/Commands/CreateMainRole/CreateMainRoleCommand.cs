using AyzMuhasebeServer.Application.Messaging;

namespace AyzMuhasebeServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateMainRole;
public sealed record CreateMainRoleCommand(
    string Title,
    string CompanyId = null) : ICommand<CreateMainRoleCommandResponse>;
