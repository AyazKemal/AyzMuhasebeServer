using AyzMuhasebeServer.Application.Messaging;

namespace AyzMuhasebeServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF
{
    public sealed record CreateUCAFCommand(
        string Code,
        string Name,
        char Type ,
        string CompanyId) : ICommand<CreateUCAFCommandResponse>;
}
