using Blookey.Application.Common.Validation;
using Blookey.Application.Features.Auth.Commands;
using FluentValidation;

namespace Blookey.Application.Features.Auth.Validator;

public class RegisterValidator : AbstractValidator<RegisterCommand>
{
    public RegisterValidator()
    {
        RuleFor(r => r.Name)
        .NotEmpty().WithMessage(GenericMessages.CampoObrigatorio("nome"))
        .MinimumLength(5).WithMessage(GenericMessages.TamanhoMinimo("nome", 3))
        .MaximumLength(256).WithMessage(GenericMessages.TamanhoMaximo("nome", 256));

        RuleFor(r => r.Email)
            .NotEmpty().WithMessage(GenericMessages.CampoObrigatorio("email"))
            .MinimumLength(5).WithMessage(GenericMessages.TamanhoMinimo("email", 5))
            .MaximumLength(256).WithMessage(GenericMessages.TamanhoMaximo("email", 256))
            .EmailAddress().WithMessage(GenericMessages.FormatoInvalido("email"));

        RuleFor(r => r.Password)
            .NotEmpty().WithMessage(GenericMessages.CampoObrigatorio("senha"))
            .MinimumLength(6).WithMessage(GenericMessages.TamanhoMinimo("senha", 6))
            .MaximumLength(100).WithMessage(GenericMessages.TamanhoMaximo("senha", 100))
            .Matches(@"[A-Z]").WithMessage(GenericMessages.DeveConter("senha", "letra maiúscula"))
            .Matches(@"[a-z]").WithMessage(GenericMessages.DeveConter("senha", "letra minúscula"))
            .Matches(@"[0-9]").WithMessage(GenericMessages.DeveConter("senha", "número"))
            .Matches(@"[^a-zA-Z0-9]").WithMessage(GenericMessages.DeveConter("senha", "caractere especial"));

        RuleFor(r => r.ConfirmPassword)
            .NotEmpty().WithMessage(GenericMessages.CampoObrigatorio("confirmação de senha"))
            .Equal(r => r.Password).WithMessage(GenericMessages.DeveSerIgual("confirmação de senha", "senha"));
    }
}