using EdenWorks.Application.Extensions;
using EdenWorks.Application.Models.DTOs.EntryDTO;
using EdenWorks.Application.Services.AppUserService;
using EdenWorks.Domain.Entites;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EdenWorks.Presentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly UserManager<AppUser> _userManager;
        public AccountController(IAppUserService appUserService, UserManager<AppUser> userManager)
        {
            _appUserService = appUserService;
            _userManager = userManager;
        }

        [NeedAuthentication]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [NeedAuthentication]
        public async Task<IActionResult> Register(RegisterDTO model)
        {
            if (ModelState.IsValid)
            {
                var result = await _appUserService.Register(model);
                if (result.Succeeded)
                {
                    return RedirectToAction("AdminMain", "Home");

                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, item.Description);
                    }
                }
            }
            return View(model);
        }

        [AllowAnonymous]
        public async Task<IActionResult> LogIn(string? returnUrl = "/")

        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("AdminMain", "Home");
            }
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> LogIn(LoginDTO model)
        {
            if (ModelState.IsValid)
            {
                var result = await _appUserService.Login(model);
                if (result.Succeeded)
                {
                    return RedirectToAction("AdminMain", "Home");
                }
                ModelState.AddModelError(string.Empty, "Check Username and Password!");
            }
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await _appUserService.LogOut();

            return RedirectToAction("LogIn", "Account");
        }

        [NeedAuthentication]
        public async Task<IActionResult> Edit()
        {
            var user = await _appUserService.GetbyId(Convert.ToInt32(User.GetUserId())); // static extension class 

            if (user == null)
            {
                return NotFound();
            }
            else
            {
                return View(user);
            }



        }

        [NeedAuthentication]
        [HttpPost]
        public async Task<IActionResult> Edit(UpdateProfileDTO model)
        {
            if (ModelState.IsValid)
            {
                await _appUserService.UpdateUser(model);
                TempData["Success"] = "Profile successfully edited.";
                return RedirectToAction("AdminMain", "Home");
            }
            else
            {
                TempData["Error"] = "Profile hasn't been edited!";
                return RedirectToAction("Edit");
            }
        }

    }
}
