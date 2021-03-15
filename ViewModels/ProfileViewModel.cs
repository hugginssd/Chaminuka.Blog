using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.ViewModels
{
    public class ProfileViewModel   
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Bio { get; set; } = "";
        public string BadgeName { get; set; } = "";
        public string BadgeUrl { get; set; } = "";
        public string UserId { get; set; }
        public ApplicationUsers User { get; set; }
        public DateTime BirthDate { get; set; } = DateTime.Now.AddYears(-18);
        public string Company { get; set; } = "";
        public string Location { get; set; } = "";
        public string Type { get; set; } = "";
        public string PrimaryRole { get; set; } = "";
        public string Industry { get; set; } = "";
        public IEnumerable<Post> Posts { get; set; }

    }
}
