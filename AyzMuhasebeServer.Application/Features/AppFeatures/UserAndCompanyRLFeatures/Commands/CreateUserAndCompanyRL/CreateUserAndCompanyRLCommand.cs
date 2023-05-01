using AyzMuhasebeServer.Application.Messaging;

namespace AyzMuhasebeServer.Application.Features.AppFeatures.UserAndCompanyRLFeatures.Commands.CreateUserAndCompanyRL;

public sealed record CreateUserAndCompanyRLCommand (string AppUserId,
    string CompanyId) : ICommand<CreateUserAndCompanyRLCommandResponse>;
