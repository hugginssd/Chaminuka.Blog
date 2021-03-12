using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models.Profile
{
    public class Profiles   
    {   
        public int Id { get; set; }
        public string Bio { get; set; } 
        public string BadgeName { get; set; }   
        public string BadgeUrl { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
        public string PrimaryRole { get; set; }
        public string Industry { get; set; }
        public string UserId { get; set; }
        public ApplicationUsers User { get; set; }
    }
}
