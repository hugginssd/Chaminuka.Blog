﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;
using WebApplication3.Models.Comments;
using WebApplication3.Models.Likes;
using WebApplication3.Models.Profile;

namespace WebApplication3.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<MainComment> MainComments { get; set; }
        public DbSet<SubComment> SubComments { get; set; }
        public DbSet<MailRequest> MailRequests { get; set; }
        public DbSet<Likes> Likes { get; set; }
        public DbSet<Profiles> Profiles { get; set; }    
    }
}
    