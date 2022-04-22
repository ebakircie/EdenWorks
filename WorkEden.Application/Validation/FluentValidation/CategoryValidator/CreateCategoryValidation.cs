using FluentValidation;
using WorkEden.Application.Models.DTOs.CategoryDTO;

namespace WorkEden.Application.Validation.FluentValidation.CategoryValidator
{
    public class CreateCategoryValidation : AbstractValidator<CreateCategoryDTO>
    {
        public CreateCategoryValidation()
        {
            RuleFor(x => x.CategoryName).NotEmpty()
                                       .WithMessage("Category name cannot be blank!")
                                       .MinimumLength(5)
                                       .MaximumLength(50);
        }
    }
   

}
