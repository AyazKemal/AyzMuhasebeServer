using AyzMuhasebeServer.Application.Messaging;

namespace AyzMuhasebeServer.Application.Features.AppFeatures.AppUserFeatures.Login
{
    public sealed record LoginCommand(string EmailOrUserName, string Password) : ICommand<LoginCommandResponse>;

}
