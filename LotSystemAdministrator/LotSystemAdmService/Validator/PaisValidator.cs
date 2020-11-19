using FluentValidation;
using LotSystemAdmDomain.Entities;
using System;

namespace LotSystemAdmService.Validator
{
    public class PaisValidator : AbstractValidator<Pais>
    {
        public PaisValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x => { throw new ArgumentNullException("Nenhum objeto encontrado"); });
            RuleFor(c => c.NomePais)
                .NotEmpty().WithMessage("Campo Nome Pais em Branco, por favor preencher!")
                .NotNull().WithMessage("Campo Nome Pais não pode ser nulo, por favor preencher!");
        }
    }
}
