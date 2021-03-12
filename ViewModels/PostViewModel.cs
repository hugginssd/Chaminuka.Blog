using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.ViewModels
{
    public class PostViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = "";
        public string Body { get; set; } = "";
        [Required]
        public string Description { get; set; } = "";
        public string Tags { get; set; } = "";
        [Required]
        public string Category { get; set; } = "";
        public string UserId { get; set; }
        public ApplicationUsers User { get; set; }
        public string CurrentImage { get; set; } = "";
        public IFormFile Image { get; set; } = null ;     
    }
}
