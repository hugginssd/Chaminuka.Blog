using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Data;
using WebApplication3.Data.Admin;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class ProfileController : Controller
    {
        public AppDbContext _ctx;

        internal IProfile _iprofile;

        public UserManager<ApplicationUsers> _userManager;

        public ProfileController(AppDbContext ctx, IProfile profile, UserManager<ApplicationUsers> userManager)
        {
            _ctx = ctx;
            _iprofile = profile;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
