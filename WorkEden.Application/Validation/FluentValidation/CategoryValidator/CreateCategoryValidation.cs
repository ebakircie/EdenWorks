using FluentValidation;
using EdenWorks.Application.Models.DTOs.CategoryDTO;

namespace EdenWorks.Application.Validation.FluentValidation.CategoryValidator
{
    public class CreateCategoryValidation : AbstractValidator<CreateCategoryDTO>
    {
        public CreateCategoryValidation()
        {
            RuleFor(x => x.CategoryName).NotEmpty()
                                       .MinimumLength(2)
                                       .MaximumLength(50);
        }
    }
   

}
