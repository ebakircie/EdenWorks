using EdenWorks.Application.Models.DTOs.EntryDTO;
using FluentValidation;


namespace EdenWorks.Application.Validation.FluentValidation.AppUserValidator
{
    public class EditAppUserValidation:AbstractValidator<UpdateProfileDTO>
    {
        public EditAppUserValidation()
        {
            RuleFor(x => x.UserName).NotEmpty().MinimumLength(6);
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x=> x.Password).NotEmpty().MinimumLength(6);
            RuleFor(x => x.ConfirmPassword).NotEmpty().Equal(x => x.Password).WithMessage("Password doesnt match!");
        }
    }
}
