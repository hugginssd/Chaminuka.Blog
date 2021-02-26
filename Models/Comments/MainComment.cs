﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models.Comments
{
    public class MainComment : Comment
    {   
        public List<SubComment> SubComments { get; set; }
        public string UserId { get; set; }
        public ApplicationUsers User { get; set; }
    }
}
