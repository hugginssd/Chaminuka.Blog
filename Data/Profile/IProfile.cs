using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;
using WebApplication3.Models.Profile;
using WebApplication3.ViewModels;

namespace WebApplication3.Data.Profile      
{
    public interface IProfile
    {
        Profiles GetProfile(string userName);
        void AddProfile(Profiles profile);
        void UpdateProfile(Profiles profiles);

        ProfileViewModel GetMyPosts();
        Task<bool> SaveChangesAsync();  
    }
}
