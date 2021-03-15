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
            return new ProfileViewModel
            {
                Posts = _ctx.Posts
                       .Where(un => un.UserId == _userManager.Users.First().Id)
                       .ToList()
        };
        }

        public Profiles GetProfile(string userId)
        {
            var profile = (from p in _ctx.Profiles
                    join u in _ctx.Users
                    on p.UserId equals u.Id
                    where p.UserId == userId    
                    select new Profiles
                    { 
                      Bio = p.Bio,
                       Company = p.Company,
                        Industry = p.Industry,
                         PrimaryRole = p.PrimaryRole,
                          Location = p.Location,
                           Type = p.Type,
                            User = (ApplicationUsers)u
                            
                    }).FirstOrDefault();


            return profile;
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

        public string GetUserId(string userName)
        {
            return _ctx.Users.Where(un => un.UserName == userName).FirstOrDefault().Id;
        }
    }
}
