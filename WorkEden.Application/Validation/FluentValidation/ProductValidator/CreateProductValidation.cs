using EdenWorks.Application.Models.DTOs.ProductDTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdenWorks.Application.Validation.FluentValidation.ProductValidator
{
    public class CreateProductValidation:AbstractValidator<CreateProductDTO>
    {
        public CreateProductValidation()
        {
            RuleFor(x => x.Name).NotEmpty().MinimumLength(2).MaximumLength(50);
            RuleFor(x => x.Price).NotEmpty();
            RuleFor(x=> x.CategoryId).NotEmpty();
            
        }
    }
}
