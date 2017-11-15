using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewsBlog.Models;
using NewsBlog.Models.Abstract;
using NewsBlog.Models.Entities;
using NewsBlog.Models.Concrete;

namespace NewsBlog.Controllers
{
    public class HomeController : Controller
    {
        public IArticleRepository articleRepository { get; set; }
        public HomeController(IArticleRepository articleRepository)
        {
            this.articleRepository = articleRepository;
        }
        public IActionResult Index()
        {
            IEnumerable<Article> res = articleRepository.GetAll();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
