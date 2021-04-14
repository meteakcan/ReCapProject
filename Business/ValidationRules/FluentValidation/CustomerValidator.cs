using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.CompanyName).MinimumLength(2).WithMessage("En az 3 karakter giriniz.");
            RuleFor(c => c.CompanyName).MaximumLength(30).WithMessage("30 karakterden büyük olamaz.");
        }
    }
}
