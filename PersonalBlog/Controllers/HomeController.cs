using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PersonalBlog.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public JsonResult LatestBlogPost()
        {
            var posts = new List<BlogPost>()
            {
                new BlogPost(){ PostId = 1 , Title = "xxx", ShortDescription = "xxx"},
                new BlogPost(){ PostId = 2 , Title = "aaa", ShortDescription = "aaa"},
                new BlogPost(){ PostId = 3 , Title = "bbb", ShortDescription = "bbb"},
                new BlogPost(){ PostId = 4 , Title = "ccc", ShortDescription = "ccc"}
            };

            return Json(posts);

        }
    }
}
