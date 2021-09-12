using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Influencers.BusinessLogic.Models;
using Influencers.BusinessLogic.Services;
using Influencers.Models;
using Influencers.Models.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Influencers.Controllers
{
    public class ArticleController : Controller
    {
        private readonly ArticleService _articleService;
        private readonly AuthorService _authorService;
        private readonly TagsService _tagsService;
        private readonly EmailService emailService;
        private readonly CommentsService commentsService;


        public ArticleController(
            ArticleService articleService, 
            AuthorService authorService, 
            TagsService tagsService, 
            EmailService emailService,
            CommentsService commentsService)
        {
            _articleService = articleService;
            _authorService = authorService;
            _tagsService = tagsService;
            this.emailService = emailService;
            this.commentsService = commentsService;
        }

        [HttpGet]
        public IActionResult ShowArticle(int? id)
        {
            ArticleViewModel viewModel = new ArticleViewModel();
            

            if (id.HasValue)
            {
                Article article = _articleService.GetArticleById(id.Value);                

                viewModel.ArticleId = article.Id;
                viewModel.Title = article.Title;
                viewModel.Content = article.Content;
                viewModel.Date = article.Date;
                viewModel.Image = article.Image;
                viewModel.NickName = _authorService.GetNicknameById(article.AuthorId);                
                viewModel.TagName = _tagsService.GetAllTags(article.Id);              

                HashSet<ArticleViewModel> suggestedList = new HashSet<ArticleViewModel>();

                IEnumerable<Article> articles;

                List<string> tagsList = viewModel.TagName.Split(' ').ToList();


                foreach(var tag in tagsList)
                {
                    if(tag != "")
                    {                        
                        articles = _articleService.GetArticlesByTags(tag.Trim());

                        articles = articles.Where(x => x.Id != id).ToList();

                        List<ArticleViewModel> articleViewModels = new List<ArticleViewModel>();
                        articleViewModels = articles.Select(s => new ArticleViewModel
                        {
                            ArticleId = s.Id,
                            Title = s.Title,
                            Content = s.Content,
                            AuthorId = s.AuthorId,
                            NickName = _authorService.GetNicknameById(s.AuthorId),
                            TagName = _tagsService.GetAllTags(s.Id),
                            Image = s.Image
                        }).ToList();
                        //foreach (var item in articleViewModels)
                        //{
                            //if (viewModel.ArticleId != item.ArticleId)
                            //{
                                suggestedList.UnionWith(articleViewModels);

                            //}
                    }

                }

                viewModel.suggestedList = suggestedList.ToList();


            }
            
            return View(viewModel);
        }
        
        //[HttpPost]
        //public IActionResult AddComments(CommentsViewModel viewModel,int id)
        //{
           
        //    string comments = viewModel.Content;

        //    commentsService.AddComments(comments, id);

        //    return View(viewModel);
        //}

        [HttpGet]
        public IActionResult AddArticle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddArticle(ArticleViewModel viewModel, IFormFile file)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            //bool isNew = !id.HasValue;
            //Article article = isNew ? new Article
            //{
            //} : _articleService.GetArticleById(id.Value);

            int id = viewModel.ArticleId;
            string title = viewModel.Title;
            string content = viewModel.Content;
            string tagName = viewModel.TagName;
            //string image = viewModel.Image;
            List<string> tags = viewModel.TagName.Split(',').ToList();

            int authorId = _authorService.GetAuthorIdByEmail(viewModel.Email);
            
                if (_authorService.CheckIfAuthorExists(viewModel.Email))
                {
                    var art=_articleService.AddArticle(id, title, content, authorId);
                    _articleService.UploadFile(file, art.Id);
                    ViewBag.message = "The article has been added successfully!";
                }
                else
                {
                    ViewBag.message = "The email was not recognized!";
                }

            

            foreach(var tag in tags)
            {
                if (_tagsService.CheckIfTagExists(tag))
                {
                    int tagId = _tagsService.GetTagIdByName(tag);
                    _tagsService.AddArticleTags(tagId, _articleService.GetArticleIdByTitle(title));
                }
                else
                {
                    _tagsService.AddTag(tag);

                    int tagId = _tagsService.GetTagIdByName(tag);
                    _tagsService.AddArticleTags(tagId, _articleService.GetArticleIdByTitle(title));
                }
            }
                                      
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult EditArticle(int? id)
        {
            ArticleViewModel viewModel = new ArticleViewModel();

            if (id.HasValue)
            {
                Article article = _articleService.GetArticleById(id.Value);

                viewModel.ArticleId = article.Id;
                viewModel.Title = article.Title;
                viewModel.Content = article.Content;
                viewModel.Date = article.Date;    
                viewModel.TagName = _tagsService.GetAllTags(id.Value);
                viewModel.Image = article.Image;
                
            }
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult EditArticle(ArticleViewModel viewModel, int id, IFormFile file)
        {

            var article = _articleService.GetArticleById(id);
            article.Title = viewModel.Title;
            article.Content = viewModel.Content;
            int authorID = _authorService.GetAuthorIdByArticleId(id);
            string email = _authorService.GetAuthorEmailbyAuthorId(authorID);
            string image = viewModel.Image;
            //List<string> tags = viewModel.TagName.Split(' ').ToList();

            //var authorIdViewModel = _authorService.GetAuthorIdByEmail(email);
            //var authorId = _authorService.GetAuthorIdByArticleId(id);
            //var articleId = _articleService.GetArticleIdByAuthorId(authorId);

            //if (_authorService.CheckIfAuthorExists(viewModel.Email))
            //{
            //      if(authorIdViewModel == authorId)
            //    {
            //        _articleService.UpdateArticle(article);
            //        ViewBag.message = "The article has been updated successfully!";
            //    }
            //    else
            //    {
            //        ViewBag.message = "You are trying to edit someone else's article!";
            //    }
            //}
            //else
            //{
            //    ViewBag.message = "The email was not recognized!";
            //}
            

            _articleService.UpdateArticle(article);
            _articleService.UploadFile(file, id);
            ViewBag.message = "The article has been updated successfully!";


            //foreach (var tag in tags)
            //{
            //    if(tag != "")
            //    {
            //        if (_tagsService.CheckIfTagExists(tag))
            //        {
            //            int tagId = _tagsService.GetTagIdByName(tag);
            //            ArticleTags articleTags = _tagsService.GetArticleTagsByTagId(tagId);
            //            //_tagsService.AddArticleTags(tagId, _articleService.GetArticleIdByTitle(article.Title));
            //            _tagsService.UpdateArticleTags(articleTags);
            //        }
            //        else
            //        {
            //            _tagsService.AddTag(tag);

            //            int tagId = _tagsService.GetTagIdByName(tag);
            //            ArticleTags articleTags = _tagsService.GetArticleTagsByTagId(tagId);
            //            _tagsService.UpdateArticleTags(articleTags);
            //        }
            //    }

            //}



            return View(viewModel);
        }

        //[HttpGet]
        //public IActionResult Suggestions()
        //{
        //    ArticleViewModel viewModel = new ArticleViewModel();

        //    _articleService.GetAllArticles(int id)
        //    return View();
        //}

        [HttpPost]
        public IActionResult GetVotes(ArticleViewModel viewModel, int id)
        {
            var article = _articleService.GetArticleById(id);
            //article.Vote = viewModel.Votes;
            var authorId = _authorService.GetAuthorIdByArticleId(viewModel.ArticleId);            
           
            _authorService.AddVote(authorId, viewModel.Votes);
            _articleService.AddArticleVote(viewModel.ArticleId, viewModel.Votes);
            ViewBag.message = "Your vote has been recorded!";
            return RedirectToAction("ShowArticle");
        }


        [HttpGet]
        public IActionResult VerifyEmail(int id)
        {
            int authorID = _authorService.GetAuthorIdByArticleId(id);
            string email = _authorService.GetAuthorEmailbyAuthorId(authorID);
            emailService.SendEmail(email, id);
            return View();
        }
        [HttpGet]
        public IActionResult Trending()
        {

            IEnumerable<ArticleViewModel> viewModel = _articleService.GetAllArticles().Select(s => new ArticleViewModel
            {
                Title = $"{s.Title}",
                Content = s.Content,
                Date = s.Date,
                NickName = _authorService.GetNicknameById(s.AuthorId),
                Image = s.Image,
                ArticleId = s.Id,
                TagName = _tagsService.GetAllTags(s.Id),
                ArticleVotes = s.Votes
            });
            IEnumerable<ArticleViewModel> modelSorted = viewModel.OrderByDescending(s => s.Votes).Take(4);

            return PartialView("~/Views/Shared/_TrendingPartial.cshtml", modelSorted); ;
        }


    }
}
