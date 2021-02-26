using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class ApplicationUsers : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
        public string PrimaryRole { get; set; }
        public string Industry { get; set; }
        public string Bio { get; set; } 

    }   
}
