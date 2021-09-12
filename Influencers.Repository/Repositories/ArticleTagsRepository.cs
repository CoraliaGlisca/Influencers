using Influencers.Models.Model;
using Influencers.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Influencers.Repository.Repositories
{
    public class ArticleTagsRepository : BaseRepository<ArticleTags>, IArticleTags                                                                                             
    {
        public ArticleTagsRepository(InfluencersDbContext dbContext) : base(dbContext)
        {

        }

        public List<ArticleTags> GetArticleIdByTagId(int id)
        {
            return dbContext.ArticleTags.Where(x => x.TagsId == id).ToList();
        }

        public List<ArticleTags> GetAllTagsByArticleId(int id)
        {
            return dbContext.ArticleTags.Where(x => x.ArticleId == id).ToList();
        }

        public ArticleTags GetArticleTagsById(int id)
        {
            return dbContext.ArticleTags.Where(x => x.TagsId == id).FirstOrDefault();
        }
    }
}
