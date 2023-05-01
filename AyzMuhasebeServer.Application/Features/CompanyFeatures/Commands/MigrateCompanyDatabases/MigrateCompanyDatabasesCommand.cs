using AyzMuhasebeServer.Application.Messaging;

namespace AyzMuhasebeServer.Application.Features.CompanyFeatures.Commands.MigrateCompanyDatabases
{
    public sealed record MigrateCompanyDatabasesCommand() : ICommand<MigrateCompanyDatabasesCommandResponse>;
}
