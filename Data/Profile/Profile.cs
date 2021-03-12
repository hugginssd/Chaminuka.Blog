using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;
using WebApplication3.Models.Profile;
using WebApplication3.ViewModels;

namespace WebApplication3.Data.Profile
{
    public class Profile : IProfile
    {
        public AppDbContext _ctx;

        public UserManager<ApplicationUsers> _userManager;

        public Profile(AppDbContext ctx, UserManager<ApplicationUsers> userManager)
        {
            _ctx = ctx;
            _userManager = userManager;
        }

        public void AddProfile(Profiles profile)
        {
            _ctx.Profiles.Add(profile);
        }

        public ProfileViewModel GetMyPosts()
        {
            //return _ctx.Posts
            //           .Where(un => un.UserId == _userManager.Users.First().Id)
            //           .ToList();
            return new ProfileViewModel
            {
                Posts = _ctx.Posts
                       .Where(un => un.UserId == _userManager.Users.First().Id)
                       .ToList()
        };
        }

        public Profiles GetProfile(string userName)
        {
            //var context = from c in _ctx.Users
            //              join p in _ctx.Profiles
            //              on c.Id equals p.UserId
            //              select new ProfileViewModel
            //              {
            //                  Bio = p.Bio,
            //                  BadgeName = p.BadgeName,
            //                  BadgeUrl  = p.BadgeUrl,
            //                  User      = p.User
            //              };

            return _ctx.Profiles.Select();
        }

        public void UpdateProfile(Profiles profiles)
        {
            _ctx.Profiles.Update(profiles);
        }

        public async Task<bool> SaveChangesAsync()
        {
            if (await _ctx.SaveChangesAsync() > 0)
            { 
                return true;
            }
            return false;
        }
    }
}
