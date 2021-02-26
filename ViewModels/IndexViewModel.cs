using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.ViewModels
{
    public class IndexViewModel
    {   
        public int PageNumber { get; set; }
        public bool NextPage { get; set; }  
        public IEnumerable<Post> Posts { get; set; }    
    }
}
