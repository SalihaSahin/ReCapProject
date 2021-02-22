﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class BrandValidator: AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(b => b.Name).NotEmpty().WithMessage("BrandName alani bos birakilamaz.");
            RuleFor(b => b.Name).Length(2, 10).WithMessage("BrandName en az 2 en cok 10 karakter olmalidir.");
        }
    }
}
