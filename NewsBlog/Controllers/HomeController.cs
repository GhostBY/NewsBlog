using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using NewsBlog.Models;
using NewsBlog.Models.Abstract;
using NewsBlog.Models.ViewModel;
using Microsoft.EntityFrameworkCore;
using NewsBlog.Models.Entities;


namespace NewsBlog.Controllers
{
    public class HomeController : Controller
    {
        public IArticleRepository articleRepository { get; set; }
        public HomeController(IArticleRepository articleRepository)
        {
            this.articleRepository = articleRepository;
        }
        //public IActionResult Index()
        //{
        //    IEnumerable<Article> res = articleRepository.GetAll();
        //    return View();
        //}
        public async Task <IActionResult> Index(int page=1)
        {
            int pageSize = 3;   // количество элементов на странице

            var count = await articleRepository.GetAll().CountAsync();
            var items = await articleRepository.GetAll().Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = pageViewModel,
                Articles= items
            };
            return View(viewModel);
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
