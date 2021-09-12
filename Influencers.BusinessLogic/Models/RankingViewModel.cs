using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Influencers.Models
{
    public class RankingViewModel
    {
        public string NickName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public int? Votes { get; set; }

        public string ArticleTitle { get; set; }

        public string Tags { get; set; }
    }
}
