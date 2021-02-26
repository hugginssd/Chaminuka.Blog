﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;
using WebApplication3.Models.Comments;
using WebApplication3.ViewModels;

namespace WebApplication3.Data.Repository
{
    public class Repository : IRepository
    {
        private AppDbContext _ctx;


        public Repository(AppDbContext ctx)
        {
            _ctx = ctx;
        }

        public void AddPost(Post post)
        {
            _ctx.Posts.Add(post);
           
        }
        public List<Post> GetAllPosts()
        {
            return _ctx.Posts.ToList();
        }

        public IndexViewModel GetAllPosts(int pageNumber)
        {
            int pageSize = 6;
            int skipAmount = pageSize * (pageNumber - 1);
            int postsCount = _ctx.Posts.Count();


            return new IndexViewModel
            {
                PageNumber = pageNumber,
                NextPage = postsCount > skipAmount + pageSize,
                Posts =  _ctx.Posts
                    .Skip(skipAmount)
                    .Take(pageSize)
                    .ToList()
            };
        }


        public List<Post> GetAllPosts(string category)
        {
            Func<Post, bool> InCategory = (post) => { return post.Category.ToLower().Equals(category.ToLower()); };

            return _ctx.Posts
                .Where(post =>InCategory(post))
                .ToList();
        }


        public Post GetPost(int id)
        {
           return _ctx.Posts
                .Include(p => p.MainComments)
                    .ThenInclude(mc => mc.SubComments)
                .FirstOrDefault(p =>p.Id == id);
        }

        public void RemovePost(int id)
        {
            _ctx.Posts.Remove(GetPost(id));
        }

        

        public void UpdatePost(Post post)
        {
            _ctx.Posts.Update(post); 
        }
        
        public async Task<bool> SaveChangesAsync()
        {
            if (await _ctx.SaveChangesAsync()>0)
            {
                return true;
            }
            return false;
        }

        public void AddSubComment(SubComment comment)
        {
            _ctx.SubComments.Add(comment);
        }

        public string GetUserName(string userid)
        {
            return  (_ctx.Users
                        .Where(un =>un.Id == userid)
                        .FirstOrDefault()
                        .UserName);
        }

    }
}
