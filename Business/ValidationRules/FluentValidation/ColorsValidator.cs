using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ColorsValidator : AbstractValidator<Colors>
    {
        public ColorsValidator()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("ColorName alani bos birakilamaz");
            RuleFor(c => c.Name).MaximumLength(15).WithMessage("ColorName alani en fazla 15 karakter olabilir");
        }
    }
}
