using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class PaymentValidator:AbstractValidator<Payment>
    {
        public PaymentValidator()
        {
            RuleFor(p => p.CreditNumber).NotNull();
            RuleFor(p => p.CreditNumber).MinimumLength(11).MaximumLength(11);
            RuleFor(p => p.FullName).NotNull();
        }
    }
}
