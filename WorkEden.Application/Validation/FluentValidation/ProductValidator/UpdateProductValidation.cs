using EdenWorks.Application.Models.DTOs.ProductDTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdenWorks.Application.Validation.FluentValidation.ProductValidator
{
    public class UpdateProductValidation:AbstractValidator<UpdateProductDTO>
    {
        public UpdateProductValidation()
        {
            RuleFor(x => x.Name).NotEmpty().MinimumLength(2).MaximumLength(150);
            RuleFor(x => x.Price).NotEmpty();
            RuleFor(x => x.CategoryId).NotEmpty();
        }
    }
}
