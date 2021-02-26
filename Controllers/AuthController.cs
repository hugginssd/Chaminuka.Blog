using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;
using WebApplication3.ViewModels;

namespace WebApplication3.Controllers
{
    public class AuthController : Controller
    {
        public IMapper _mapper;

        public RoleManager<IdentityRole> _roleManager;

        public SignInManager<ApplicationUsers> _signInManager;

        public UserManager<ApplicationUsers> _userManager;

        public AuthController(RoleManager<IdentityRole> roleManager, SignInManager<ApplicationUsers> signManager, UserManager<ApplicationUsers> userManager)
        {
            _roleManager = roleManager;
            _signInManager = signManager;
            _userManager = userManager;
            
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(vm.UserName, vm.Password, false, false);
                if (result.Succeeded)
                {
                        //If the user is not a forum member show dashboard else go to home page
                        //return RedirectToAction("Index", "Panel");
                    
                    return RedirectToAction("Index", "Home");
                }
            }

            ModelState.AddModelError(string.Empty, "Invalid login attempt");


            return View(vm);
        }


        [HttpGet]
        public async Task<IActionResult> Logout()
        {

            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUsers
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    UserName = model.UserName,
                    Email = model.Email,
                };


                var result = await _userManager.CreateAsync(user, model.Password);


                if (result.Succeeded)
                {
                    if (!await _roleManager.RoleExistsAsync("Member"))
                    {
                        await _roleManager.CreateAsync(new IdentityRole("Member"));
                    }
                    await _userManager.AddToRoleAsync(user,"Member");

                    await _signInManager.SignInAsync(user, isPersistent: false);

                    return RedirectToAction("Index", "Home");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                ModelState.AddModelError(string.Empty, "Invalid login attempt");

            }
            return View(model);
        }

    }
}
