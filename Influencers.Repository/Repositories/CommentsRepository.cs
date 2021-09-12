using Influencers.Models.Model;
using Influencers.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Influencers.Repository.Repositories
{
    public class CommentsRepository : BaseRepository<Comments>, ICommentsRepository
    {
        public CommentsRepository(InfluencersDbContext dbContext) : base(dbContext)
        {

        }

        public string GetCommentByArticleId(int id)
        {
            return dbContext.Comments.FirstOrDefault(x => x.ArticleId == id).Name;
        }

        public List<Comments> GetCommentsByArticleId(int id)
        {
            return dbContext.Comments.Where(x => x.ArticleId == id).ToList();
        }
    }
}
