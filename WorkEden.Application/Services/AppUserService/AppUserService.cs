using AutoMapper;
using EdenWorks.Application.Models.DTOs.EntryDTO;
using EdenWorks.Application.Models.VMs;
using EdenWorks.Domain.Entites;
using EdenWorks.Domain.Enums;
using EdenWorks.Domain.Repositories;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdenWorks.Application.Services.AppUserService
{
    public class AppUserService: IAppUserService
    {
        private readonly IMapper _mapper;
        private readonly IAppUserRepo _appUserRepo;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AppUserService(IMapper mapper,
                              IAppUserRepo appUserRepo,       
                              UserManager<AppUser> userManager,
                              SignInManager<AppUser> signInManager)
        {
            _mapper = mapper;
            _appUserRepo = appUserRepo;
            _userManager = userManager;
            _signInManager = signInManager;

        }

        public async Task<UpdateProfileDTO> GetbyId(int id)
        {
            var user = await _appUserRepo.GetFilteredFirstOrDefault(
                select: x => new AppUserVM
                {
                    Id = x.Id,
                    UserName = x.UserName,
                    Email = x.Email,

                },
                where: x => x.Id == id && x.Status != Status.Passive
                );
            var model = _mapper.Map<UpdateProfileDTO>(user);
            return model;
        }

        public async Task<SignInResult> Login(LoginDTO model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, false);
            return result;
        }

        public async Task LogOut()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<IdentityResult> Register(RegisterDTO model)
        {
            var user = _mapper.Map<AppUser>(model);

            var result = await _userManager.CreateAsync(user, model.Password);
            //if (result.Succeeded)
            //{
            //    await _signInManager.SignInAsync(user, isPersistent: false);
            //}
            return result;
        }

        public async Task UpdateUser(UpdateProfileDTO model)
        {
            var user = await _appUserRepo.GetDefault(x => x.Id == model.Id);
            
            if (user != null)
            {
                if (model.UserName != null)
                {
                    await _userManager.SetUserNameAsync(user, model.UserName);
                    await _signInManager.SignInAsync(user, false);
                }
                if (model.Email!=null)
                {
                    await _userManager.SetEmailAsync(user, model.Email);
                }
                if (model.Password != null)
                {
                    user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, model.Password);
                    await _userManager.UpdateAsync(user);
                }
            }
        }
    }
}
