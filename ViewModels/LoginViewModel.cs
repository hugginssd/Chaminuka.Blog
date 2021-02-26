using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Profile name")]
        public string  UserName { get; set; }
        public string Email { get; set; }
        [Required]
        public string  Password { get; set; }
        [Display(Name="Remember me")]
        public bool RememberMe { get; set; }
    }   
}
