using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ColorValidator:AbstractValidator<Color>
    {
        public ColorValidator()
        {
            RuleFor(c => c.ColorName).MinimumLength(2).WithMessage("En az 3 karakter giriniz.");
            RuleFor(c => c.ColorName).MaximumLength(20).WithMessage("20 karakterden büyük olamaz.");
        }
    }
}
