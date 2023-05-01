using AyzMuhasebeServer.Application.Messaging;

namespace AyzMuhasebeServer.Application.Features.CompanyFeatures.Commands.CreateCompany
{
    public sealed record CreateCompanyCommand(
        string Name,
        string ServerName,
        string DatabaseName,
        string UserId,
        string Password) : ICommand<CreateCompanyCommandResponse>;
}
