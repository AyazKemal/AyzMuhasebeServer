using FluentValidation;

namespace AyzMuhasebeServer.Application.Features.CompanyFeatures.Commands.CreateCompany
{
    public sealed class CreateCompanyValidator : AbstractValidator<CreateCompanyCommand>
    {
        public CreateCompanyValidator()
        {
            RuleFor(p => p.DatabaseName).NotEmpty().WithMessage("DataBase bilgisi yazılmalıdır");
            RuleFor(p => p.DatabaseName).NotNull().WithMessage("DataBase bilgisi yazılmalıdır");
            RuleFor(p => p.ServerName).NotEmpty().WithMessage("Server bilgisi yazılmalıdır");
            RuleFor(p => p.ServerName).NotNull().WithMessage("Server bilgisi yazılmalıdır");
            RuleFor(p => p.Name).NotEmpty().WithMessage("Şirket bilgisi yazılmalıdır");
            RuleFor(p => p.Name).NotNull().WithMessage("Şirket bilgisi yazılmalıdır");
        }
    }
}