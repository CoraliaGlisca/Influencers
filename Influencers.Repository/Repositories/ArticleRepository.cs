using Influencers.Models.Model;
using Influencers.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Influencers.Repository.Repositories
{
    public class ArticleRepository : BaseRepository<Article>, IArticleRepository
    {
        public ArticleRepository(InfluencersDbContext dbContext) : base(dbContext)
        {

        }

        public List<Article> GetAllArticles()
        {
            return dbContext.Article.ToList();
        }

        public List<Article> GetAllArticlesById(int id)
        {
            return dbContext.Article.Where(s => s.Id == id).ToList();
        }

        public Article GetArticleById(int id)
        {
            return dbContext.Article.FirstOrDefault(s => s.Id == id);
        }

        public int GetArticleIdByAuthorId(int id)
        {
            return dbContext.Article.SingleOrDefault(x => x.AuthorId == id).Id;
        }

        public int GetArticleIdByTitle(string title)
        {
            return dbContext.Article.FirstOrDefault( s => s.Title == title).Id;
        }

        public Article UploadArticleFile(int id)
        {
            return dbContext.Article.FirstOrDefault(x => x.Id == id);
        }
    }
}
