using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EdenWorks.Application.Models.DTOs.CategoryDTO;

namespace EdenWorks.Application.Validation.FluentValidation.CategoryValidator
{
    public class UpdateCategoryValidation : AbstractValidator<UpdateCategoryDTO>
    {
        public UpdateCategoryValidation()
        {
            RuleFor(x => x.CategoryName).NotEmpty()
                                      .WithMessage("Category name cannot be blank!")
                                      .MinimumLength(2)
                                      .MaximumLength(50)
                                      .WithMessage("Minimum 2 and Maximum 50 characters allowed!");
        }
    }
}
