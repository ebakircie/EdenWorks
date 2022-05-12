using EdenWorks.Application.Models.DTOs.EntryDTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdenWorks.Application.Validation.FluentValidation.AppUserValidator
{
    public class RegisterAppUserValidation: AbstractValidator<RegisterDTO>
    {
        public RegisterAppUserValidation()
        {
            RuleFor(x => x.UserName).NotEmpty().MinimumLength(6);
            RuleFor(x=> x.Password).NotEmpty().MinimumLength(6);
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.ConfirmPassword).NotEmpty().Equal(x => x.Password).WithMessage("Password doesnt match!");
        }
    }
}
