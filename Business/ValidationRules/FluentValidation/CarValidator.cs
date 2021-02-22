using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.Description).NotEmpty().WithMessage("Araba ismi bos birakilamaz!");
            RuleFor(r => r.DailyPrice).NotEmpty().WithMessage("Günlük fiyat bos birakilamaz");
            RuleFor(r => r.DailyPrice).GreaterThan(0).WithMessage("Günlük fiyat 0 dan buyuk olmali");
        }
    }
}
