using EdenWorks.Application.Models.DTOs.EntryDTO;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdenWorks.Application.Services.AppUserService
{
    public interface IAppUserService
    {
        Task<IdentityResult> Register(RegisterDTO model);
        Task<SignInResult> Login(LoginDTO model);
        Task LogOut();

        Task UpdateUser(UpdateProfileDTO model);
        Task<UpdateProfileDTO> GetbyId(int id);
    }
}
