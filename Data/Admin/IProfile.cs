using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Data.Admin
{
    public interface IProfile
    {
        void GetProfile(int id);
        void UpdateProfile(ApplicationUsers applicationUsers);
    }
}
