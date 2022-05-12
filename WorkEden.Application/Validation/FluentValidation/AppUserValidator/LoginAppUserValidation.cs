using EdenWorks.Application.Models.DTOs.EntryDTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdenWorks.Application.Validation.FluentValidation.AppUserValidator
{
    public class LoginAppUserValidation:AbstractValidator<LoginDTO>
    {
        public LoginAppUserValidation()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("The Username field is required.");
            RuleFor(x=> x.Password).NotEmpty();
        }
        
    }
}
