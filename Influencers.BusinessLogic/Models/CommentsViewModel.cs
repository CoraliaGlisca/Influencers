using Influencers.Models.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Influencers.BusinessLogic.Models
{
    public class CommentsViewModel
    {
        public int CommentsId { get; set; }
        public string Content { get; set; }

        public List<string> commentsContentList { get; set; }
        public int ArticleId { get; set; }
    }
}
