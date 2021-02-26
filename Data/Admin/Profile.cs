using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Data.Admin
{
    public class Profile : IProfile
    {
        public AppDbContext _ctx;
        public Profile(AppDbContext ctx)
        {
            _ctx = ctx;
        }

        public void GetProfile(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProfile(ApplicationUsers applicationUsers)
        {
            throw new NotImplementedException();
        }
    }
}
