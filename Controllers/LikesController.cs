using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Data.Repository;
using WebApplication3.Models;
using WebApplication3.Models.Comments;
using WebApplication3.Models.Likes;
using WebApplication3.ViewModels;

namespace WebApplication3.Controllers
{
    public class LikesController : Controller
    {
        public IRepository _repo;

        public UserManager<ApplicationUsers> _userManager;

        public LikesController(IRepository repository, UserManager<ApplicationUsers> userManager)
        {
            _repo = repository;
            _userManager = userManager;
        }

       public async Task<IActionResult> Like(LikesViewModel lvm)    
        {   
            var user = await _userManager.GetUserAsync(HttpContext.User);
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Post", new { Id = lvm.PostId });
            }
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Auth");
            }

            if (lvm.PostId != 0)
            {
                var likes = new Likes
                {
                    Count = +1,
                    Created = DateTime.Now,
                    User = user,
                    PostId  = lvm.PostId
                };

                _repo.AddLikes(likes);

                return RedirectToAction("Post", new {Id = lvm.PostId });
            }
            return RedirectToAction("Home", "Post");
        }
    }
}
