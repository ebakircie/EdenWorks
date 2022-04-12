using EdenWorks.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkEden.Application.Models.DTOs.CategoryDTO
{
    public class CreateCategoryDTO
    {
        [Required(ErrorMessage ="Category Name cannot be blank!")]
        [MinLength(2,ErrorMessage ="Minimum length must be 2!")]
        [MaxLength(50,ErrorMessage ="Maximum Length must be 50!")]
        public string CategoryName { get; set; }

        public DateTime CreateDate => DateTime.Now;
        public Status Status => Status.Active;
    }
}
