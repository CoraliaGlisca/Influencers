using Influencers.Models.Model;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Influencers.Models
{
    public class ArticleViewModel
    {
        public int ArticleId { get; set; }
        public int AuthorId { get; set; }
        public int ArticleTagsId { get; set; }

        [Required]
        [MaxLength(150)]
        [Display(Name = "Enter title: ")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Enter Content: ")]
        public string Content { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime Date { get; set; }

        //public virtual Author Author { get; set; }

        public string NickName { get; set; }

        public int TagsId { get; set; }
      
      
        [Display(Name ="Enter tags: ")]
        public string TagName { get; set; }

        [Required]
        [Display(Name = "Enter Email: ")]
        public string Email { get; set; }
        
        public int Votes { get; set; }
        public string Image { get; set; }

        public List<ArticleViewModel> suggestedList = new List<ArticleViewModel>();

        [Display(Name ="Enter a comment:")]
        public string Comments { get; set; }
        public List<Comments> CommentsList { get; set; }

        public int? ArticleVotes { get; set; }
        
    }
}
