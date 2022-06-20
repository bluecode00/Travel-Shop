using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TravelShop.Business.Abstract;
using TravelShop.WebUI.Identity;
using TravelShop.WebUI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelShop.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, ICartService cartService)
        {
            _userManager = userManager;
            _signInManager = signInManager;

        }

        public IActionResult AccessDenied()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login( string returnUrl)
        {
            return View(new LoginModel()
            {
                ReturnUrl=returnUrl   
            });
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.FindByNameAsync(model.UserName);
            if (user == null)
            {
                ModelState.AddModelError("", "Böyle bir kullanıcı bulunamadı!");
                return View(model);
            }

             
            var result = await _signInManager.PasswordSignInAsync(user, model.Password, true, true);
            if (result.Succeeded)
            {
                return Redirect(model.ReturnUrl ?? "~/");
            }
            return View(model);
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {

            var user = new User()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.UserName,
                Email = model.Email
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                
                return RedirectToAction("Login", "Account");
            }
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Redirect("~/");
        }
    }
}
