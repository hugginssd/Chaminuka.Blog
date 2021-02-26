using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication3.Data;
using WebApplication3.Data.FileManager;
using WebApplication3.Data.Repository;
using WebApplication3.Models;
using WebApplication3.Models.Comments;
using WebApplication3.ViewModels;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private IRepository _repo;

        public IFileManager _fileManager;

        public UserManager<ApplicationUsers> _userManager;

        public HomeController(IRepository repo, IFileManager fileManager, UserManager<ApplicationUsers> userManager)
        {
            _repo = repo;
            _fileManager = fileManager;
            _userManager = userManager;
        }

        public IActionResult Index(int pageNumber,string category)
        {
            if (pageNumber < 1)
            {
                return RedirectToAction("Index", new { pageNumber = 1, category });
            }


            //var vm = new IndexViewModel
            //{
            //    PageNumber = pageNumber,
            //    Posts = string.IsNullOrEmpty(category)? _repo.GetAllPosts(pageNumber) : _repo.GetAllPosts(category)
            //};

            var vm = _repo.GetAllPosts(pageNumber);
            //var posts 
            //
            return View(vm);

        }

        public IActionResult Post(int id)
        {
            var post = _repo.GetPost(id);
            return View(post);

        }

        [HttpGet("/Image/{image}")] //can also use [HttpGet("{controller}/Image/{image}")]
        [ResponseCache(CacheProfileName ="Monthly")]
        public IActionResult Image(string image)
        {
            var mime = image.Substring(image.LastIndexOf('.') + 1);
            return new FileStreamResult(_fileManager.ImageStream(image), $"image/{mime}");
        }

        [HttpPost]
        public async Task<IActionResult> Comment(CommentViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Post", new { Id = vm.PostId });
            }

            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Auth");
            }


            var post = _repo.GetPost(vm.PostId);
            if (vm.MainCommentId == 0)
            {
                post.MainComments = post.MainComments ?? new List<MainComment>(); //if main comments are null then list
                var user = await _userManager.GetUserAsync(HttpContext.User);
                post.MainComments.Add(new MainComment
                {
                    Message = vm.Message,
                    Created = DateTime.Now,
                    User = user
                });

                _repo.UpdatePost(post);
            }
            else
            {
                var user = await _userManager.GetUserAsync(HttpContext.User);
                var comment = new SubComment
                {
                    MainCommentId = vm.MainCommentId,
                    Message = vm.Message,
                    Created = DateTime.Now,
                    User = user
                };
                _repo.AddSubComment(comment);
            }
            await _repo.SaveChangesAsync();


            return RedirectToAction("Post", new { Id = vm.PostId });
            //return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        //public IActionResult Contact(MailRequestViewModel cvm)
        //{
        //    return View(cvm);
        //}

        public IActionResult About()
        {   
            return View();
        }

        //[HttpGet]
        //public IActionResult Edit(int? id)
        //{
        //    if(id == null)
        //    return View(new Post());
        //    else
        //    {
        //        var post = _repo.GetPost((int)id);
        //        return View(post);
        //    }
        //}

        //[HttpPost]
        //public async Task<IActionResult> Edit(Post post)
        //{
        //    if (post.Id >0) 
        //    {
        //        _repo.UpdatePost(post);
        //    }
        //    else
        //    {
        //        _repo.AddPost(post);
        //    }

        //    if (await _repo.SaveChangesAsync())
        //    {
        //        return RedirectToAction("Index");
        //    }
        //    return View(post);

        //}

        //[HttpGet]
        //public async Task<IActionResult> Remove(int id)
        //{
        //    _repo.RemovePost(id);
        //    await _repo.SaveChangesAsync();
        //    return RedirectToAction("Index");
        //}
    }
}
