using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdenWorks.Application.Extensions
{
    public class PictureFileValidation:ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            IFormFile file = value as IFormFile;
            if (file != null)
            {
                var extension = Path.GetExtension(file.FileName).ToLower();
                string[] extensions = { "jpg", "jpeg", "png" };

                bool result = extension.Any(x => extension.EndsWith(x));

                if (!result)
                {
                    return new ValidationResult("File format is not valid, please choose jpog, jpeg or png");
                }
            }
            return ValidationResult.Success;
        }
    }
}
