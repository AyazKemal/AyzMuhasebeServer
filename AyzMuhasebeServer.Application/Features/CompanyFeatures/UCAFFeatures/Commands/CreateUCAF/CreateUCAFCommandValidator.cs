using FluentValidation;

namespace AyzMuhasebeServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;

public sealed class CreateUCAFCommandValidator : AbstractValidator<CreateUCAFCommand>
{
    public CreateUCAFCommandValidator()
    {
        RuleFor(p => p.Code).NotEmpty().WithMessage("Hesap Planı Kodu Boş Olamaz");
        RuleFor(p => p.Code).NotNull().WithMessage("Hesap Planı Kodu Boş Olamaz");
        //RuleFor(p => p.Code).MinimumLength(4).WithMessage("Hesap Planı Kodu Enaz 4 karakter olmalıdır");
        RuleFor(p => p.Name).NotEmpty().WithMessage("Hesap Planı Adı boş olamaz");
        RuleFor(p => p.Name).NotNull().WithMessage("Hesap Planı Adı boş olamaz");
        RuleFor(p => p.CompanyId).NotEmpty().WithMessage("Şirket bilgisi boş olamaz");
        RuleFor(p => p.CompanyId).NotNull().WithMessage("Şirket bilgisi boş olamaz");
        RuleFor(p => p.Type).NotEmpty().WithMessage("Hesap Planı tipi boş olamaz");
        RuleFor(p => p.Type).NotNull().WithMessage("Hesap Planı tipi boş olamaz");
        RuleFor(p => p.Code).MaximumLength(1).WithMessage("Hesap Planı Tipi Enaz 1 karakter olmalıdır");
    }
}
