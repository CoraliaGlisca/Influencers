using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Influencers.BusinessLogic.Services;
using Influencers.Models;
using Influencers.Models.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Influencers.Controllers
{
    public class AuthorController : Controller
    {
        AuthorService authorService;

        public AuthorController(AuthorService authorService)
        {
            this.authorService = authorService;
        }

        [HttpGet]
        public IActionResult AddAuthor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAuthor(AuthorViewModel viewModel, IFormFile file)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            //int Id = viewModel.Id;
            string Nickname = viewModel.NickName;
            string Email = viewModel.Email;
            string FirstName = viewModel.FirstName;
            string LastName = viewModel.LastName;
            //string Image = viewModel.Image;
            string Description = viewModel.Description;
            int Votes = 0;

            if (!authorService.CheckIfAuthorExists(viewModel.Email))
            {
                var art =  authorService.AddAuthor(Nickname, FirstName, LastName, Email, Votes, Description);
                authorService.UploadFile(file, art.Id);
                ViewBag.message = "The author has been added successfully!";
            }
            else
            {
                ViewBag.message = "This email is already in use!";
            }
            return View(viewModel);
        }                    
               
        [HttpGet]
        public IActionResult Ranking(string searchString, string sortOrder)
        {
            ViewData["CurrentFilter"] = searchString;
            ViewData["SortVotes"] = string.IsNullOrEmpty(sortOrder) ? "votes_desc" : "";
            ViewData["SortNickName"] = sortOrder == "Nickname" ? "name_desc" : "";

            IEnumerable<AuthorViewModel> viewModel = authorService.GetAllAuthors().Select(s => new AuthorViewModel
            {
                Id = s.Id,
                NickName = s.NickName,
                FirstName = s.FirstName,
                LastName = s.LastName,
                Votes = s.Votes,
                Image = s.Image,
                Description = s.Description
            });
            
            
            //switch (sortOrder)
            //{
            //    case "name_desc":
            //        viewModel = viewModel.OrderByDescending(s => s.NickName).ToList();
            //        break;
            //    case "votes_desc":
            //        viewModel = viewModel.OrderBy(s => s.Votes).ToList();
            //        break;
            //    default:
            //        viewModel = viewModel.OrderBy(s => s.Votes).ToList();
            //        break;
            //}
            viewModel = viewModel.OrderByDescending(s => s.Votes).ToList();

            var modelSorted = viewModel.OrderByDescending(s => s.NickName).ToList();
            if (!String.IsNullOrEmpty(searchString))
            {
                viewModel = viewModel.Where(s => s.NickName.Contains(searchString, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult ShowAuthor(int? id)
        {
            AuthorViewModel viewModel = new AuthorViewModel();

            if (id.HasValue)
            {
                Author author = authorService.GetAuthorById(id.Value);

                viewModel.Email = author.Email;
                viewModel.NickName = author.NickName;
                viewModel.FirstName = author.FirstName;
                viewModel.LastName = author.LastName;
                viewModel.Votes = author.Votes;
                viewModel.Image = author.Image;
                viewModel.Description = author.Description;
            }

            return View(viewModel);
        }
    }
}
