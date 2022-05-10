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
                                      .MinimumLength(2)
                                      .MaximumLength(50);
        }
    }
}
