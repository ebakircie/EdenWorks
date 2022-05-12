using EdenWorks.Application.Extensions;
using EdenWorks.Application.Models.DTOs.EntryDTO;
using EdenWorks.Application.Services.AppUserService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EdenWorks.Presentation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly IAppUserService _appUserService;
        public AccountController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
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
                    return RedirectToAction("Index");

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

        //private IActionResult RedirectToLocal(string returnUrl)
        //{
        //    if (Url.IsLocalUrl(returnUrl))
        //    {
        //        return Redirect(returnUrl);
        //    }
        //    else
        //    {
        //        return RedirectToAction("AdminMain", "Home");
        //    }
        //}

        public async Task<IActionResult> Logout()
        {
            await _appUserService.LogOut();

            return RedirectToAction("LogIn", "Account");
        }

        [NeedAuthentication]
        public async Task<IActionResult> Edit(string userName)
        {
            if (userName == User.Identity.Name)
            {
                var user = await _appUserService.GetbyId(Convert.ToInt32(User.GetUserId()));

                if (user == null)
                    return NotFound();

                return View(user);
            }
            else
            {
                RedirectToAction("Index", "Home");
                return View();
            }
        }

        [NeedAuthentication]
        public async Task<IActionResult> Edit(UpdateProfileDTO model)
        {
            if (ModelState.IsValid)
            {
                await _appUserService.UpdateUser(model);
                TempData["Success"] = "Profile successfully edited.";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["Error"] = "Profile hasn't been edited!";
                return RedirectToAction("Edit");
            }
        }

    }
}
