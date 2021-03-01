using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;
using WebApplication3.Models.Comments;
using WebApplication3.Models.Likes;
using WebApplication3.ViewModels;

namespace WebApplication3.Data.Repository
{
    public interface IRepository
    {
        Post GetPost(int id);
        List<Post> GetAllPosts();
        IndexViewModel GetAllPosts(int pageNumber);
        List<Post> GetAllPosts(string Category);
        void AddPost(Post post);
        void UpdatePost(Post post);
        void RemovePost(int id);
        void AddSubComment(SubComment comment);
        void AddLikes(Likes likes);
        void UpdateLikes(Likes likes);
        void RemoveLikes(Likes likes);
        Task<bool> SaveChangesAsync();
    }
}
