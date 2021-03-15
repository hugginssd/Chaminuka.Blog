using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Data;
using WebApplication3.Data.Profile;
using WebApplication3.Models;
using WebApplication3.Models.Profile;
using WebApplication3.ViewModels;

namespace WebApplication3.Controllers
{
    public class ProfileController : Controller
    {
        public IProfile _profile;

        public AppDbContext _ctx;
        public UserManager<ApplicationUsers> _userManager;

        public ProfileController(AppDbContext ctx, IProfile profile, UserManager<ApplicationUsers> userManager)
        {
            _profile = profile;
            _ctx = ctx;
            _userManager = userManager;
        }


        public IActionResult Profile()
        {
            return View();
        }
        public IActionResult MyProfile()
        {
            var myPosts = _profile.GetMyPosts();
            return View(myPosts);
        }

        [HttpGet]
        public IActionResult Update(string userName)
        {
            Console.WriteLine("\n"+_profile.GetUserId(userName)+"\n");
                
            var cp = _profile.GetProfile(_profile.GetUserId(userName));
            return View(new ProfileViewModel
            {
                FirstName = cp.User.FirstName,
                LastName = cp.User.LastName,
                Bio = cp.Bio,
                User = cp.User,
                Company = cp.Company,
                Location = cp.Location,
                Type = cp.Type,
                PrimaryRole = cp.PrimaryRole,
                Industry = cp.Industry

            });

        }
        [HttpPost]
        public async Task<IActionResult> Update(ProfileViewModel pvm)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var profile = new Profiles
            {
                Bio  = pvm.Bio,
                User = pvm.User,
                Company = pvm.Company,
                Location = pvm.Location,
                Type     = pvm.Type,
                PrimaryRole = pvm.PrimaryRole,
                Industry = pvm.Industry

            };

            _profile.AddProfile(profile);
            if (await _profile.SaveChangesAsync())
            {
                return RedirectToAction("MyProfile", "Profile");
            }
            return View(profile);
        }
        [HttpGet]
        public IActionResult GetActivity()
        {
            var myPosts = _profile.GetMyPosts();
            return View(myPosts);
        }
    }
}
