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
            //Kurallar buraya yazılır hangi nesne için validation yazıyorsak buraya yazılır DTO larım içinde olabilir
            RuleFor(c => c.Description).NotEmpty();
            RuleFor(c => c.Description).MinimumLength(2);
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(10).When(c => c.BrandId == 1);
            RuleFor(c => c.Description).Must(StartWithA).WithMessage("Arabanın özellikleri A harfi ile başlamalı"); //arabanın özelliği A ile başlamalı 
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
