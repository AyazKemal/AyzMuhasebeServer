using FluentValidation;

namespace AyzMuhasebeServer.Application.Features.MainRoleAndRoleRLFeatures.Commands.CreateMainRoleAndRoleRL
{
    public sealed class CreateMainRoleAndRoleRLCommandValidator : AbstractValidator<CreateMainRoleAndRoleRLCommand>
    {
        public CreateMainRoleAndRoleRLCommandValidator()
        {
            RuleFor(p => p.RoleId).NotEmpty().WithMessage("Rol seçilmelidir!");
            RuleFor(p => p.RoleId).NotNull().WithMessage("Rol seçilmelidir!");
            RuleFor(p => p.MainRoleId).NotNull().WithMessage("Ana Rol seçilmelidir!");
            RuleFor(p => p.MainRoleId).NotEmpty().WithMessage("Ana Rol seçilmelidir!");
        }
    }
}
