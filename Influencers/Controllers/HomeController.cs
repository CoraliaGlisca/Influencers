using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Influencers.Models;
using Influencers.BusinessLogic;
using Influencers.BusinessLogic.Services;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;

namespace Influencers.Controllers
{
    public class HomeController : Controller
    {
        ArticleService _articleService;
        AuthorService _authorService;
        TagsService _tagsService;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ArticleService articleService, AuthorService authorService, TagsService tagsService)
        {
            _logger = logger;
            _articleService = articleService;
            _authorService = authorService;
            _tagsService = tagsService;
        }

        [HttpGet]
        public IActionResult Index(string searchString, int? pageNumber, string currentFilter, string sortOrder)
        {
            ViewData["CurrentSort"] = sortOrder;

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;

            //List<Article> articleList = _articleService.getAllArticles();
            IEnumerable<ArticleViewModel> viewModel = _articleService.GetAllArticles().Select(s => new ArticleViewModel
            {
                Title = $"{s.Title}",
                Content = s.Content,
                Date = s.Date,
                NickName = _authorService.GetNicknameById(s.AuthorId),
                Image = s.Image,
                ArticleId = s.Id,
                TagName = _tagsService.GetAllTags(s.Id)
        }).ToList();
            var modelSorted = viewModel.OrderByDescending(s => s.Date).ToList();
            if (!String.IsNullOrEmpty(searchString))
            {
                modelSorted = viewModel.Where(s => s.TagName.Contains(searchString)).ToList();
            }

            return View(modelSorted);
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
    }
}
