using AyzMuhasebeServer.Application.Messaging;

namespace AyzMuhasebeServer.Application.Features.AppFeatures.UserAndCompanyRLFeatures.Commands.RemoveByIdUserAndCompanyRL;

public sealed record RemoveByIdUserAndCompanyRLCommand(
string Id) : ICommand<RemoveByIdUserAndCompanyRLCommandResponse>;
