using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidator:AbstractValidator<Brand>
    {
        public BrandValidator()
        {

            RuleFor(b => b.BrandName).MinimumLength(2).WithMessage("En az 3 karakter giriniz.");
            RuleFor(b => b.BrandName).MaximumLength(20).WithMessage("20 karakterden büyük olamaz.");

        }
    }
}
