using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models.Likes
{
    public class Likes
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public DateTime Created { get; set; }
        public string UserId { get; set; }
        public ApplicationUsers User { get; set; }
        public int MainCommentId { get; set; }
        public int SubCommentId { get; set; }
        public int PostId { get; set; } 
    }
}
