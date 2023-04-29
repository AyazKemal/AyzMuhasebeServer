using AyzMuhasebeServer.Application.Messaging;

namespace AyzMuhasebeServer.Application.Features.AppFeatures.AppUserFeatures.Commands.Login
{
    public sealed record LoginCommand(string EmailOrUserName, string Password) : ICommand<LoginCommandResponse>;

}
