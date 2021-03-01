using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.ViewModels
{
    public class LikesViewModel
    {
        public int Count { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public string UserId { get; set; }
        public ApplicationUsers User { get; set; }
        public int MainCommentId { get; set; }
        public int SubCommentId { get; set; }
        public int PostId { get; set; } 
    }
}
